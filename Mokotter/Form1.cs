using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudOfficial
{
    public partial class Form1 : Form
    {
        private OAuth _auth;
        public Form1()
        {
            InitializeComponent();

            var settings = Settings.GetInstance();
            settings.Load();
            _auth = new OAuth(settings);
        }

        private void GetMyTweets()
        {
            if (String.IsNullOrEmpty(_auth.Settings.AccessToken)) return;

            textMyTweets.Clear();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("count", "50");
            var timeLine = (_auth.Get("https://api.twitter.com/1.1/statuses/user_timeline.json", parameters));
            var statuses = DynamicJson.Parse(timeLine);

            foreach (var status in statuses)
            {
                textMyTweets.Text +=
                    status.user.screen_name + " " + FromTwitterFormat(status.created_at).ToString() + " "  + Environment.NewLine +
                    status.text + Environment.NewLine + Environment.NewLine;
            }
        }

        private DateTime FromTwitterFormat(string twitterDate)
        {
            DateTime parsedDate;
            string dateFormatString = "ddd MMM dd HH:mm:ss zzz yyyy";

            if (!DateTime.TryParseExact(twitterDate, dateFormatString, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                throw new FormatException(String.Format("Error parsing twitter date '{0}'", twitterDate));
            }

            return parsedDate;
        }

        private void buttonGetPIN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textConsumerKey.Text) || String.IsNullOrEmpty(textConsumerSecret.Text)) return;
            _auth.GetRequestToken(textConsumerKey.Text, textConsumerSecret.Text);
            textMyTweets.Text += "次のURLにアクセスして暗証番号を取得してください："
                + _auth.GetAuthorizeUrl() + Environment.NewLine;
        }

        private void buttonInputPIN_Click(object sender, EventArgs e)
        {
            _auth.GetAccessToken(textPIN.Text);
            textMyTweets.Text +=
                "AccessToken: " + _auth.Settings.AccessToken + Environment.NewLine +
                "AccessTokenSecret: " + _auth.Settings.AccessTokenSecret + Environment.NewLine +
                "UserId: " + _auth.Settings.UserID + Environment.NewLine +
                "ScreenName: " + _auth.Settings.ScreenName + Environment.NewLine;

            GetMyTweets();
        }

        private void buttonGetTimeline_Click(object sender, EventArgs e)
        {
            GetMyTweets();
            GetPublicTimeline();
        }

        private void GetPublicTimeline()
        {
            if (String.IsNullOrEmpty(_auth.Settings.AccessToken)) return;

            textPublicTimeline.Clear();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("count", "50");
            var timeLine = (_auth.Get("https://api.twitter.com/1.1/statuses/home_timeline.json", parameters));
            var statuses = DynamicJson.Parse(timeLine);

            foreach (var status in statuses)
            {
                textPublicTimeline.Text +=
                    status.user.screen_name + " " + FromTwitterFormat(status.created_at).ToString() + " " + Environment.NewLine +
                    status.text + Environment.NewLine + Environment.NewLine;
            }
        }

        private void buttonTweet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_auth.Settings.AccessToken)) return;

            var status = textTweet.Text;
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Clear();
            parameters.Add("status", _auth.UrlEncode(status));

            try
            {
                _auth.Post("https://api.twitter.com/1.1/statuses/update.json", parameters);
                textTweet.Clear();
                GetMyTweets();
                GetPublicTimeline();
            }
            catch
            {

            }

        }
    }
}
