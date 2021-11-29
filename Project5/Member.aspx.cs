using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When the button is clicked, it interacts with the service and gets all the songs for a given artist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GetSongsButton_Click(object sender, EventArgs e)
        {
            GetTracks.Service1Client getTracks = new GetTracks.Service1Client();
            string input = GetSongsDrop.Text;
            try
            {
                string[] outputList = getTracks.getAlbumTracks(input);
                string output = "";
                for (int i = 0; i < outputList.Length; i++)
                {
                    output += outputList[i] + ", ";
                }
                output = output.Substring(0, output.Length - 2);
                GetAllSongsLabel.Text = output;
            }
            catch
            {
                GetAllSongsLabel.Text = "Something went wrong, please try again.";
            }

        }


        /// <summary>
        /// When the button is clicked, it interacts with the service to get audio features and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GetAudioFeaturesButton_Click(object sender, EventArgs e)
        {
            string artistName = GetAudioFeaturesList.Text;
            artistName = artistName.ToLower();
            string trackID = "";
            string start = "";
            // Adds information depending on which artist is picked
            if (artistName == "justin bieber")
            {
                trackID = "4iJyoBOLtHqaGxP12qzhQI";
                start = "Justin Bieber's top track is Peaches. These audio features were determined by Spotify and give alternative meaning to music. " +
                    "Here are the audio features of the song: ";
            }
            else if (artistName == "kanye west")
            {
                trackID = "6Hfu9sc7jvv6coyy2LlzBF";
                start = "Kanye West's top track is Hurricane. These audio features were determined by Spotify and give alternative meaning to music. " +
                    "Here are the audio features of the song: ";
            }
            else if (artistName == "shakira")
            {
                trackID = "3ZFTkvIE7kyPt6Nu3PEa7V";
                start = "Shakira's top track is Hips Don't Lie. These audio features were determined by Spotify and give alternative meaning to music. " +
                    "Here are the audio features of the song: ";
            }
            else if (artistName == "beyonce")
            {
                trackID = "5IVuqXILoxVWvWEPm82Jxr";
                start = "Beyonce's top track is Crazy In Love. These audio features were determined by Spotify and give alternative meaning to music. " +
                    "Here are the audio features of the song: ";
            }
            else if (artistName == "lil nas x")
            {
                trackID = "5Z9KJZvQzH6PFmb8SNkxuk";
                start = "Kanye West's top track is Industry Baby. These audio features were determined by Spotify and give alternative meaning to music. " +
                    "Here are the audio features of the song: ";
            }
            else
            {
                GetAudioFeaturesLabel.Text = "Invalid name";
                return;
            }

            GetAudioFeatures.Service1Client audio = new GetAudioFeatures.Service1Client();
            string output = audio.GetTrackAudioFeatures(trackID);
            GetAudioFeaturesLabel.Text = start + output;

        }
    }
}