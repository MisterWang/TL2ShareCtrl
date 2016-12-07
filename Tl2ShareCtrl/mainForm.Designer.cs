namespace TN2ShareCtrl
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbIsMod = new System.Windows.Forms.CheckBox();
            this.lbCurtext = new System.Windows.Forms.Label();
            this.lsbSharelist = new System.Windows.Forms.ListBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbIsMod
            // 
            this.cbIsMod.AutoSize = true;
            this.cbIsMod.Location = new System.Drawing.Point(13, 13);
            this.cbIsMod.Name = "cbIsMod";
            this.cbIsMod.Size = new System.Drawing.Size(66, 16);
            this.cbIsMod.TabIndex = 0;
            this.cbIsMod.Text = "mod模式";
            this.cbIsMod.UseVisualStyleBackColor = true;
            this.cbIsMod.CheckedChanged += new System.EventHandler(this.cbIsMod_CheckedChanged);
            // 
            // lbCurtext
            // 
            this.lbCurtext.AutoSize = true;
            this.lbCurtext.Location = new System.Drawing.Point(110, 13);
            this.lbCurtext.Name = "lbCurtext";
            this.lbCurtext.Size = new System.Drawing.Size(53, 12);
            this.lbCurtext.TabIndex = 1;
            this.lbCurtext.Text = "当前存档";
            // 
            // lsbSharelist
            // 
            this.lsbSharelist.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbSharelist.FormattingEnabled = true;
            this.lsbSharelist.ItemHeight = 16;
            this.lsbSharelist.Location = new System.Drawing.Point(13, 42);
            this.lsbSharelist.Name = "lsbSharelist";
            this.lsbSharelist.Size = new System.Drawing.Size(404, 196);
            this.lsbSharelist.TabIndex = 2;
            this.lsbSharelist.SelectedIndexChanged += new System.EventHandler(this.lsbSharelist_SelectedIndexChanged);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(441, 215);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "替换";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 261);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lsbSharelist);
            this.Controls.Add(this.lbCurtext);
            this.Controls.Add(this.cbIsMod);
            this.Name = "mainForm";
            this.Text = "tL2share";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsMod;
        private System.Windows.Forms.Label lbCurtext;
        private System.Windows.Forms.ListBox lsbSharelist;
        private System.Windows.Forms.Button btnReplace;
    }
}

