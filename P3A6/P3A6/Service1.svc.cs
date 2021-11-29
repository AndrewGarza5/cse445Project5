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

namespace P3A6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary>
        /// Starting point for service. Calls for artist albums and returns it
        /// </summary>
        /// <param name="artistID">ID of artist to get albums from</param>
        /// <returns>a string containing albums of artist</returns>
        public string GetArtistAlbums(string artistID)
        {
            string artistAlbums = GetArtistAlbumsHelper(artistID).Result;
            return artistAlbums;
        }

        /// <summary>
        /// Method that carries out the actual work. It gets the artist albums in json and goes through the 
        /// json to pick out the albums
        /// 
        /// I made a seperate one because I wanted to make it asynchronous and it was easier this way. 
        /// </summary>
        /// <param name="artistID">ID of artist to get albums from</param>
        /// <returns>a string containing albums of artist</returns>
        public async Task<string> GetArtistAlbumsHelper(string artistID)
        {
            string json = await MakeAPICall("https://api.spotify.com/v1/artists/" + artistID + "/albums");
            ArtistAlbums artistAlbums = JsonConvert.DeserializeObject<ArtistAlbums>(json);

            List<string> albums = new List<string>();
            string albumsStr = "";

            // picks out album names
            for (int i = 0; i < artistAlbums.items.Count; i++)
            {
                bool alreadyInArray = false;
                for (int j = 0; j < albums.Count; j++)
                {
                    if (artistAlbums.items[i].name == albums[j])
                    {
                        alreadyInArray = true;
                    }
                }
                if (!alreadyInArray)
                {
                    Console.WriteLine(artistAlbums.items[i].name);
                    albums.Add(artistAlbums.items[i].name);
                    albumsStr += artistAlbums.items[i].name + ", ";
                }

            }

            albumsStr = albumsStr.Substring(0, albumsStr.Length - 2);

            return albumsStr;
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
        /// Gets a spotify token to interact with the API
        /// </summary>
        /// <returns>string containing the token</returns>
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
    

        /// <summary>
        /// The ArtistAlbums and Items classes are for deserializing the JSON object
        /// </summary>
        class ArtistAlbums
        {
            public IList<Items> items { get; set; }
        }

        class Items
        {
            public string album_group { get; set; }
            public string album_type { get; set; }
            public string id { get; set; }
            public string name { get; set; }
        }
        class Token
        {
            public string access_token { get; set; }
        }

    }
}
