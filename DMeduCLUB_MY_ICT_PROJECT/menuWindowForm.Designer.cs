namespace DMeduCLUB_MY_ICT_PROJECT
{
    partial class menuWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuWindowForm));
            this.menuCategary = new System.Windows.Forms.MenuStrip();
            this.heloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAndViewMemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCategary
            // 
            this.menuCategary.BackColor = System.Drawing.Color.Transparent;
            this.menuCategary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCategary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCategary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heloToolStripMenuItem,
            this.membersDetailsToolStripMenuItem,
            this.noticeToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuCategary.Location = new System.Drawing.Point(0, 0);
            this.menuCategary.Name = "menuCategary";
            this.menuCategary.Size = new System.Drawing.Size(1700, 72);
            this.menuCategary.TabIndex = 0;
            this.menuCategary.Text = "menuStrip1";
            // 
            // heloToolStripMenuItem
            // 
            this.heloToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.heloToolStripMenuItem.Name = "heloToolStripMenuItem";
            this.heloToolStripMenuItem.Size = new System.Drawing.Size(14, 68);
            this.heloToolStripMenuItem.Click += new System.EventHandler(this.heloToolStripMenuItem_Click);
            // 
            // membersDetailsToolStripMenuItem
            // 
            this.membersDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.membersDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.editAndViewMemberDetailsToolStripMenuItem});
            this.membersDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("membersDetailsToolStripMenuItem.Image")));
            this.membersDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.membersDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membersDetailsToolStripMenuItem.Name = "membersDetailsToolStripMenuItem";
            this.membersDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 68);
            this.membersDetailsToolStripMenuItem.Text = "Members Details";
            this.membersDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.addMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addMemberToolStripMenuItem.Image")));
            this.addMemberToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(370, 54);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // editAndViewMemberDetailsToolStripMenuItem
            // 
            this.editAndViewMemberDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editAndViewMemberDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editAndViewMemberDetailsToolStripMenuItem.Image")));
            this.editAndViewMemberDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editAndViewMemberDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAndViewMemberDetailsToolStripMenuItem.Name = "editAndViewMemberDetailsToolStripMenuItem";
            this.editAndViewMemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(370, 54);
            this.editAndViewMemberDetailsToolStripMenuItem.Text = "Edit And View Member Details";
            this.editAndViewMemberDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editAndViewMemberDetailsToolStripMenuItem.Click += new System.EventHandler(this.editAndViewMemberDetailsToolStripMenuItem_Click);
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.noticeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noticeToolStripMenuItem.Image")));
            this.noticeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.noticeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(142, 68);
            this.noticeToolStripMenuItem.Text = "Notice";
            this.noticeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noticeToolStripMenuItem.Click += new System.EventHandler(this.noticeToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(134, 68);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 68);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1700, 880);
            this.Controls.Add(this.menuCategary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuCategary;
            this.MaximumSize = new System.Drawing.Size(1700, 880);
            this.Name = "menuWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuWindowForm";
            this.Load += new System.EventHandler(this.menuWindowForm_Load);
            this.menuCategary.ResumeLayout(false);
            this.menuCategary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuCategary;
        private System.Windows.Forms.ToolStripMenuItem heloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAndViewMemberDetailsToolStripMenuItem;
    }
}