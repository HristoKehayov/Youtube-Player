using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeSearch;
using System.Media;



namespace Youtube_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // configure this code
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    var embed = "<html><head>" +
        //    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
        //    "</head><body>" +
        //    "<iframe width=\"300\" src=\"{0}\"" +
        //    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
        //    "</body></html>";
        //    var url = "https://www.youtube.com/embed/L6ZgzJKfERM";
        //    this.webBrowser1.DocumentText = string.Format(embed, url);
        //}

        int youtubePageNumber = 1;

        int index_of_youtubeVideos_List = 0;

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            YoutubeInfo video_info = new YoutubeInfo(); // MAIN list of information for only 1 youtube video from page 1

            VideoSearch items = new VideoSearch(); // youtube video search plugin

            List<YoutubeInfo> youtube_Videos_List = new List<YoutubeInfo>(); // a list of the info's for specific video

            foreach (var item in items.SearchQuery(textBox1.Text, youtubePageNumber))
            {
                video_info = new YoutubeInfo(); // separate queries from others queries // make different info holder for each video

                video_info.title = item.Title;
                video_info.Authur = item.Author;
                video_info.url = item.Url.Replace("watch?v=", "embed/");
                byte[] imageByte = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageByte))
                {
                    video_info.thumbnail = Image.FromStream(ms);
                }
                youtube_Videos_List.Add(video_info);
            }
            
            CurrMusic_thumbnail.Image = youtube_Videos_List[0].thumbnail;
            CurrTitle_of_theMusic.Text = youtube_Videos_List[0].title;
            CurrAuthur_of_theMusic.Text = youtube_Videos_List[0].Authur;
            //webBrowser1.Navigate("https://youtube.com/");
            webBrowser1.DocumentText = "<html>"
                                       + "<head><meta http-equiv='X-UA-Compatible' content='IE=11' />"
                                       + "<body>" + "\r\n"
                                       + "<iframe src=\"" + "https://www.youtube.com/embed/1wYNFfgrXTI?ecver=2" + "\" width=\"600\" height=\"500\" frameborder=\"0\" allow = \"autoplay; encrypted - media\" allowfullscreen></iframe>"
                                         + "</body></html>";
            //< div style = "position:relative;height:0;padding-bottom:81.73%" >< iframe src = "https://www.youtube.com/embed/1wYNFfgrXTI?ecver=2" style = "position:absolute;width:100%;height:100%;left:0" width = "440" height = "360" frameborder = "0" allow = "autoplay; encrypted-media" allowfullscreen ></ iframe ></ div >

            //string page =
            //                "<html>"
            //               + "<head><meta http-equiv='X-UA-Compatible' content='IE=11' />"
            //               + "<body>" + "\r\n"
            //               + "<iframe src=\"" + url + "\" width=\"260\" height=\"115\" frameborder=\"0\" allowfullscreen></iframe>"
            //               + "</body></html>";

            //this.webBrowser1.DocumentText = string.Format(page);
        }

        private void PlayRandomMusic_Btn_Click(object sender, EventArgs e)
        {
             //-------------------//
            // play random music //
           //-------------------//

            //Random rnd = new Random();
            //int Get_randVideo = rnd.Next();
        }

        private void Next_Page_Search_Btn_Click(object sender, EventArgs e)
        {
            youtubePageNumber++;
            Search_Btn_Click(null, null);
        }

        void Download_YoutubeVideo (string link)
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video

            // path 1
            string project_path = Application.StartupPath;

            Directory.CreateDirectory(project_path + "/Downloaded Music");

            //path 2
            string Downloaded_Music_Folder_path = "Downloaded Music";


            string path_to_save_To = Path.Combine(project_path, Downloaded_Music_Folder_path);

            File.WriteAllBytes(path_to_save_To + video.FullName, video.GetBytes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index_of_youtubeVideos_List++;
        }
    }
}
