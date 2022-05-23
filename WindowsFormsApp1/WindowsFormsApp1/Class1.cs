using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class Config
    {
        public bool IsNullProp()
        {
            return string.IsNullOrEmpty(TextBoxText);
        }
        
        public static Config GetConfig()
        {
            Config config = null;
            string filename = "C:\\Users\\yurko\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\config.xml";
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Config));
                    config = (Config)xml.Deserialize(fs);
                    fs.Close();
                }
            }
            else config = new Config();

            return config;
        }
        public void Save()
        {
            string filename = "C:\\Users\\yurko\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\config.xml";
            if (File.Exists(filename)) File.Delete(filename);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Config));
                xml.Serialize(fs, this);
                fs.Close();
            }
        }

        public string TextBoxText{get; set;}
        public bool xorUse { get; set; }
        public bool orUse { get; set; }
        public bool iUse { get; set; }
        public bool button17 { get; set; }
        public bool button16 { get; set; }
        public bool button18 { get; set; }
        public bool button19 { get; set; }
        public bool button20 { get; set; }
        public bool button21 { get; set; }
        public bool button22 { get; set; }
        public bool button23 { get; set; }
        public bool button24 { get; set; }
        public bool button25 { get; set; }
        public bool button26 { get; set; }
        public bool button27 { get; set; }
    }
}
