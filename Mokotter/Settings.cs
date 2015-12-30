using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace PseudOfficial
{
    class URLs
    {
        public const string REQUEST_TOKEN_URL = "https://twitter.com/oauth/request_token";
        public const string ACCESS_TOKEN_URL = "https://twitter.com/oauth/access_token";
        public const string AUTHORIZE_URL = "https://twitter.com/oauth/authorize";
        public const string USER_TIMELINE_SOURCE = "https://api.twitter.com/1.1/statuses/user_timeline.json";
        public const string HOME_TIMELINE_SOURCE = "https://api.twitter.com/1.1/statuses/home_timeline.json";
    }

    public class Settings
    {
        private static Settings settings = new Settings();
        public const string SETTING_FILE_PATH = @"Settings.xml";
        
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string RequestToken { get; set; }
        public string RequestTokenSecret { get; set; }
        public string AccessToken { get; set;  }
        public string AccessTokenSecret { get; set; }
        public string UserID { get; set; }
        public string ScreenName { get; set; }

        private Settings()
        {
            if (!File.Exists(SETTING_FILE_PATH))
            {
                Save();
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            var fs = new FileStream(SETTING_FILE_PATH, FileMode.Open);
            settings = (Settings)serializer.Deserialize(fs);
            fs.Close();
        }

        public static Settings GetInstance()
        {
            return settings;
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            FileStream fs = new FileStream(SETTING_FILE_PATH, FileMode.Create);
            serializer.Serialize(fs, settings);
            fs.Close();
        }
    }
}
