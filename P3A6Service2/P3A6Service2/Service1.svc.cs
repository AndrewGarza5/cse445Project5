using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace P3A6Service2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetTrackAudioFeatures(string id)
        {
            string audioFeatures = GetTrackAudioFeaturesHelper(id);
            return audioFeatures;
        }
        public string GetTrackAudioFeaturesHelper(string trackID)
        {
            string json = MakeAPICall("https://api.spotify.com/v1/audio-features/" + trackID).Result;
            AudioFeatures audioFeatures = JsonConvert.DeserializeObject<AudioFeatures>(json);

            string output = "Danceability: " + audioFeatures.danceability + " - " +
                "Energy: " + audioFeatures.energy + " - " +
                "Instrumentalness: " + audioFeatures.instrumentallness + " - " +
                "Liveness: " + audioFeatures.liveness + " - " +
                "Speechiness: " + audioFeatures.speechiness + " - " +
                "Tempo: " + audioFeatures.tempo + " - " +
                "Valence: " + audioFeatures.valence;

            return output;
        }

        /// <summary>
        /// makes a call to the Spotify API 
        /// </summary>
        /// <param name="URL">The endpoint to call for Spotify</param>
        /// <returns>a whole json response</returns>
        public static async Task<string> MakeAPICall(string URL)
        {
            string TOKEN = GetToken().Result;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);

            HttpResponseMessage response = client.GetAsync(URL).Result;
            string data = "";
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();

            return data;
        }

        /// <summary>
        /// A method to get a fresh token to interact with the spotify API
        /// </summary>
        /// <returns>a token</returns>
        public static async Task<string> GetToken()
        {
            string url = "https://accounts.spotify.com/api/token";
            string postString = string.Format("grant_type=client_credentials");
            byte[] byteArray = Encoding.UTF8.GetBytes(postString);
            WebRequest request = WebRequest.Create(url);
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", "7c572f08304b4746ad43b9d4577b8e99", "84a4be7821ad4ef5bfa85fb4698573e1")));
            request.Headers.Add("Authorization", "Basic " + token);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                using (WebResponse response = await request.GetResponseAsync())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string json = reader.ReadToEnd();
                            Token artistAlbums = JsonConvert.DeserializeObject<Token>(json);
                            return artistAlbums.access_token;

                        }
                    }
                }
            }
        }

        class Token
        {
            public string access_token { get; set; }
        }

        class AudioFeatures
        {
            public float acousticness { get; set; }
            public float danceability { get; set; }
            public float energy { get; set; }
            public float instrumentallness { get; set; }
            public float liveness { get; set; }
            public float loudness { get; set; }
            public float speechiness { get; set; }
            public float valence { get; set; }
            public float tempo { get; set; }
        }

    }
}
