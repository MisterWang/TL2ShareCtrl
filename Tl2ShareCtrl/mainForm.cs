using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN2ShareCtrl
{
    public partial class mainForm : Form
    {

        private Sharedstash stash;
        public mainForm()
        {
            InitializeComponent();

            stash = new Sharedstash();
            string[] list=stash.getlist();

            //lsbSharelist.Items.AddRange(new object[] { "测试1", "测试2" });
            if (stash.cfg.ismod == 1) cbIsMod.Checked = true;
            if (stash.cfg.cursth[stash.cfg.ismod] != "") lbCurtext.Text = "当前存档 "+stash.cfg.cursth[stash.cfg.ismod];
            lsbSharelist.Items.AddRange(list);
            lsbSharelist.SetSelected(0,true);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            stash.copyto(lsbSharelist.SelectedItem.ToString());
            lbCurtext.Text = "当前存档 " + stash.cfg.cursth[stash.cfg.ismod];
            MessageBox.Show("已经替换");
        }

        private void lsbSharelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbIsMod_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsMod.Checked)
                stash.cfg.ismod = 1;
            else
                stash.cfg.ismod = 0;

            //Console.WriteLine(stash.cfg.ismod);
            stash.cfg.appcfg.AppSettings.Settings["ismod"].Value = ""+stash.cfg.ismod;
            stash.cfg.appcfg.Save();
            lbCurtext.Text = "当前存档 " + stash.cfg.cursth[stash.cfg.ismod];
        }
    }
}
