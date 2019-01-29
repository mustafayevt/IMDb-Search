using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using YoutubeSearch;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace IMDb_Search
{
    public partial class IMDb : MetroFramework.Forms.MetroForm
    {
        public IMDb()
        {
            InitializeComponent();
            clearAllSection();
            SearchByTitleTxtbx.Focus();
            //a6154a96
        }
        string imdbID = string.Empty;
        private void clearAllSection()
        {
            imdbLink.Text = "";
            foreach (var item in MInfoPanel.Controls.OfType<Label>())
            {
                item.Text = "";
            }
        }
        dynamic Movies;
        int CurrentDataIndex = 0;
        int MaxDataIndex = 0;
        private void SearchByTitleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                clearAllSection();
                YoutubePlayer.Visible = false;
                PosterPctbx.Image = Properties.Resources._1024px_No_image_available_svg;
                HttpClient http = new HttpClient();
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a6154a96&s={SearchByTitleTxtbx.Text}").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                Movies = JsonConvert.DeserializeObject(str);
                MaxDataIndex = Movies.Search.Count;
                LoadData();
            }
            catch (Exception)
            {
            }
        }

        private void LoadData()
        {
            try
            {
                YoutubePlayer.Visible = false;
                LoadPic.Visible = true;
                dynamic tmp = Movies.Search[CurrentDataIndex];
                HttpClient http = new HttpClient();
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a6154a96&t={tmp.Title}").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic data = JsonConvert.DeserializeObject(str);
                if (data.Poster.ToString() != "N/A")
                    PosterPctbx.Load(data.Poster.ToString());
                else PosterPctbx.Image = Properties.Resources._1024px_No_image_available_svg;
                clearAllSection();

                TitleLbl.Text = data.Title;
                TitleLbl.Text += $" ({data.Year})";

                RatedLbl.Text += String.Format("{0,-15}", "Rated:");
                RatedLbl.Text += string.Format("{0,-15}", data.Rated.ToString());

                RuntimeLbl.Text += String.Format("{0,-15}", "Runtime:");
                RuntimeLbl.Text += string.Format("{0,-15}", data.Runtime.ToString());

                GenreLbl.Text += String.Format("{0,-15}", "Genre:");
                GenreLbl.Text += string.Format("{0,-15}", data.Genre.ToString());

                Director.Text += String.Format("{0,-15}", "Director:");
                Director.Text += string.Format("{0,-15}", data.Director.ToString());

                Writer.Text += String.Format("{0,-15}", "Writer:");
                Writer.Text += string.Format("{0,-15}", data.Writer.ToString());

                Actors.Text += String.Format("{0,-15}", "Actors:");
                Actors.Text += string.Format("{0,-15}", data.Actors.ToString());

                Plot.Text += String.Format("{0,-15}", "Plot:");
                Plot.Text += string.Format("{0,-15}", data.Plot.ToString());

                Language.Text += String.Format("{0,-15}", "Lanuage:");
                Language.Text += string.Format("{0,-15}", data.Language.ToString());

                Country.Text += String.Format("{0,-15}", "Country:");
                Country.Text += string.Format("{0,-15}", data.Country.ToString());

                Awards.Text += String.Format("{0,-15}", "Awards:");
                Awards.Text += string.Format("{0,-15}", data.Awards.ToString());

                imdbRating.Text += String.Format("{0,-15}", "IMDb:");
                imdbRating.Text += string.Format("{0,-15}", data.imdbRating.ToString());

                imdbLink.Text += String.Format("{0,-15}", "IMDb id:");
                imdbLink.Text += string.Format("{0,-15}", data.imdbID.ToString());
                imdbID = data.imdbID.ToString();

                //youtube
                VideoSearch videos = new VideoSearch();
                var tmpUrl = videos.SearchQuery($"{TitleLbl.Text} trailer", 1);
                
                var embed = "<html>" +
                        "<head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head>" +
            "<body>" +
            "<iframe width=330px height=160px src =\"{0}\"frameborder = \"0\" encrypted-media\" allowfullscreen></iframe>" +
            "</body>" +
            "</html>";
                var url = $@"https://www.youtube.com/embed/{tmpUrl[0].Url.ToString().Split('=').Last()}";
                YoutubePlayer.DocumentText = string.Format(embed, url);
                YoutubePlayer.Visible = true;
                
                LoadPic.Visible = false;
            }
            catch (Exception)
            {
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                clearAllSection();
                HttpClient http = new HttpClient();
                var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a6154a96&t={SearchByTitleLbl.Text}").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic tmpData = JsonConvert.DeserializeObject(str);
            }
            catch (Exception)
            {
            }
        }

        private void imdbLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.imdb.com/title/{imdbID}");
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (CurrentDataIndex > 0)
            {
                CurrentDataIndex--;
                LoadData();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (CurrentDataIndex < MaxDataIndex)
            {
                CurrentDataIndex++;
                LoadData();
            }
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (CurrentDataIndex != 0)
                {
                    dynamic tmp = Movies.Search[CurrentDataIndex - 1];
                    HttpClient http = new HttpClient();
                    var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a6154a96&t={tmp.Title}").Result;
                    var str = response.Content.ReadAsStringAsync().Result;
                    dynamic data = JsonConvert.DeserializeObject(str);
                    backTip.SetToolTip(back, $"{data.Title} ({data.Year})");
                }
                else backTip.SetToolTip(back,"Not Found");
            }
            catch (Exception)
            {
                
            }
        }

        private void next_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (CurrentDataIndex != MaxDataIndex)
                {
                    dynamic tmp = Movies.Search[CurrentDataIndex + 1];
                    HttpClient http = new HttpClient();
                    var response = http.GetAsync($@"http://www.omdbapi.com/?apikey=a6154a96&t={tmp.Title}").Result;
                    var str = response.Content.ReadAsStringAsync().Result;
                    dynamic data = JsonConvert.DeserializeObject(str);
                    nextTip.SetToolTip(next, $"{data.Title} ({data.Year})");
                }
                else nextTip.SetToolTip(next, "Not Found");
            }
            catch (Exception)
            {

            }
        }
    }
}
