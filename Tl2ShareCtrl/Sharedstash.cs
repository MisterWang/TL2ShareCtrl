using System;
using System.IO;
using System.Collections.Generic;

namespace TN2ShareCtrl
{
    class Sharedstash
    {
        public Config cfg;
        public Sharedstash()
        {
            cfg = new Config();
        }

        public string[] getlist()
        {
            try {
                return Directory.GetFiles("share");
            }
            catch (Exception) { }
            return null;
        }

        public void copyto(string name)
        {
            if (cfg.cursth[cfg.ismod] == "" || cfg.cursth[cfg.ismod] == "user")//备份
                backup();

            File.Delete(cfg.getFullPath()+Config.fileName_v2);
            File.Copy(name, cfg.getFullPath() + stashName(name), true);
            if (name.IndexOf("user") >= 0) cfg.cursth[cfg.ismod] = "user";
            else cfg.cursth[cfg.ismod] = name.Replace("share\\", "");
            Console.WriteLine(cfg.cursth);
            

            cfg.appcfg.AppSettings.Settings["cursth"+cfg.ismod].Value = cfg.cursth[cfg.ismod];
            cfg.appcfg.Save();
        }

        public void backup()
        {
            if (Directory.GetFiles(cfg.getFullPath(),Config.fileName_v2).Length > 0)
            {
                File.Copy(cfg.getFullPath() + Config.fileName_v2, "backup\\" + cfg.ismod+Config.fileName_v2, true);
                File.Copy(cfg.getFullPath() + Config.fileName_v2, "share\\" + "user"+cfg.ismod+"_v2.bin", true);
            }
            else
            {
                File.Copy(cfg.getFullPath() + Config.fileName, "backup\\" + cfg.ismod + Config.fileName, true);
                File.Copy(cfg.getFullPath() + Config.fileName, "share\\" + "user"+cfg.ismod+".bin", true);
            }
            //cfg.cursth = "user";
        }

        private string stashName(string stname)
        {
            if (stname.IndexOf("_v2.bin") > 0)
                return Config.fileName_v2;
            else
                return Config.fileName;
        }
    }
}
