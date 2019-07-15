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
using System.Text.RegularExpressions;

namespace Youtube_Player
{
    public partial class Form1 : Form
    {
        //string url;
        //public string VideoID
        //{
        //    get
        //    {
        //        var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_yUrl);
        //        return yMatch.Success ? yMatch.Groups[1].Value : string.Empty;
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
        }
        public static string StripTagsRegex(string source)
        {
            return Regex.Replace(source, @"<div id=\'yt-masthead-signin\'>(\w.*)</div>", string.Empty);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //StripTagsRegex(webBrowser1.DocumentText);
            webBrowser1.Navigate(textBox1.Text);
            //string htmlofwebpage = webBrowser1.DocumentText;
            //string pattern = @"<button id=\'appbar-guide-button\'>(\d.*)</button>";
            //string pattern2 = @"(<\w.*)\w +";
            //string g = "(\n.*)";

            //string pattern123 = @"<button class=\'yt - uix - button yt - uix - button - size - default yt - uix - button - text yt - uix - button - empty yt - uix - button - has - icon appbar - guide - toggle appbar - guide - clickable - ancestor\' type=\'button\' onclick=\'; return false;  id=\'appbar - guide - button\' aria-label=\'Guide\' aria-controls=\'appbar - guide - menu\'><span class=\'yt - uix - button - icon - wrapper\'><span class=\'yt - uix - button - icon yt - uix - button - icon - appbar - guide yt - sprite\'></span></span></button>";
            //string part = @"<a id=\'logo - container\' href=\'  title=\'YouTube home\' class=\' spf - link  masthead - logo - renderer yt - uix - sessionlink\' data-sessionlink=""><span class=\'logo masthead-logo - renderer - logo yt - sprite\' title=\'YouTube home\'></span><span class=\'content - region\'>AT</span></a>";

            //htmlofwebpage = Regex.Replace(htmlofwebpage, part, string.Empty);
            //webBrowser1.DocumentText = htmlofwebpage;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection buttons = webBrowser1.Document.GetElementsByTagName("button");
            HtmlElementCollection htmlElements = webBrowser1.Document.GetElementsByTagName("a"); 
            //webBrowser1.Document.Body.Style = "zoom:110%;";
            //foreach (HtmlElement elem in buttons)
            //{
            //    if (elem.OuterHtml.ToString().Contains("Full screen (f)") || elem.GetAttribute("title") == "Full screen (f)")  // keep this
            //    {
            //        elem.InvokeMember("click");
            //    }

            //    if (elem.OuterHtml.ToString().Contains("Theater mode (t)") || elem.GetAttribute("title") == "Cinema mode (t)")  // keep this
            //    {
            //        elem.InvokeMember("click");
            //    }
            //}

        }
        bool clicked = false;
        private void Button2_Click(object sender, EventArgs e)
        {
            clicked = !clicked;
            if (clicked)
            {
                Form1.ActiveForm.Width = 1050;
                button2.Text = "<";
            }
            else
            {
                Form1.ActiveForm.Width = 697;
                button2.Text = ">";
            }
        }
    }
}
