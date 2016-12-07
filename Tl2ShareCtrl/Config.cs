using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace TN2ShareCtrl
{
    class Config
    {
        public Configuration appcfg;

        public uint ismod;
        public uint isbackup;
        public long steamid;
        public string[] cursth= { "",""};//当前存档
        //public string modcursth;

        public string path = "C:\\Users\\"+Environment.UserName+"\\Documents\\my games\\Runic Games\\Torchlight 2\\";
        //private string fullPath;
        public string[] modePath = { "save", "modsave" };

        public const string fileName = "sharedstash.bin";
        public const string fileName_v2 = "sharedstash_v2.bin";

        public Config()
        {
            try
            {
                appcfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                
                ismod = uint.Parse(appcfg.AppSettings.Settings["ismod"].Value);
                isbackup = uint.Parse(appcfg.AppSettings.Settings["isbackup"].Value);
                steamid = long.Parse(appcfg.AppSettings.Settings["steamid"].Value);
                cursth[0] = appcfg.AppSettings.Settings["cursth0"].Value;
                cursth[1] = appcfg.AppSettings.Settings["cursth1"].Value;
                //cursth[1] = appcfg.AppSettings.Settings["modcursth"].Value;

                Console.WriteLine(steamid);
                if (steamid == -1)//steam版 获取steamid ,默认为第一个
                {
                    steamid = 0;
                    string[] dirs=Directory.GetDirectories(getFullPath());
                    //Console.WriteLine(dirs[0]);
                    if (dirs.Length == 1)
                    {
                        string[] path = dirs[0].Split('\\');
                        steamid = long.Parse(path[path.Length-1]);
                    }

                    appcfg.AppSettings.Settings["steamid"].Value = "" + steamid;
                    appcfg.Save();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public string getFullPath()
        {
            return path + modePath[ismod] + "\\" + (steamid==0? "" :steamid+"\\");
        }
    }
}
