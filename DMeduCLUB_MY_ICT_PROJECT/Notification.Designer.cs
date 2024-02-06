namespace DMeduCLUB_MY_ICT_PROJECT
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNoteMemberDetails = new System.Windows.Forms.DataGridView();
            this.dgvNoteComment = new System.Windows.Forms.DataGridView();
            this.dgvNoteServises = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNoteSubmit = new System.Windows.Forms.Button();
            this.btnNoteSave = new System.Windows.Forms.Button();
            this.txtNoteComment = new System.Windows.Forms.TextBox();
            this.cbNoteSeason = new System.Windows.Forms.CheckBox();
            this.cbNoteTrip = new System.Windows.Forms.CheckBox();
            this.btnNoteRemove1 = new System.Windows.Forms.Button();
            this.btnNoteRemove2 = new System.Windows.Forms.Button();
            this.txtNoteId1 = new System.Windows.Forms.TextBox();
            this.txtNoteId2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNoteClear = new System.Windows.Forms.Button();
            this.btnNoteclear2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteMemberDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteServises)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 86);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(1262, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Exit";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1262, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(471, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification";
            // 
            // dgvNoteMemberDetails
            // 
            this.dgvNoteMemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteMemberDetails.Location = new System.Drawing.Point(22, 235);
            this.dgvNoteMemberDetails.Name = "dgvNoteMemberDetails";
            this.dgvNoteMemberDetails.RowHeadersWidth = 51;
            this.dgvNoteMemberDetails.RowTemplate.Height = 24;
            this.dgvNoteMemberDetails.Size = new System.Drawing.Size(394, 452);
            this.dgvNoteMemberDetails.TabIndex = 1;
            // 
            // dgvNoteComment
            // 
            this.dgvNoteComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteComment.Location = new System.Drawing.Point(439, 396);
            this.dgvNoteComment.Name = "dgvNoteComment";
            this.dgvNoteComment.RowHeadersWidth = 51;
            this.dgvNoteComment.RowTemplate.Height = 24;
            this.dgvNoteComment.Size = new System.Drawing.Size(450, 291);
            this.dgvNoteComment.TabIndex = 2;
            this.dgvNoteComment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoteComment_CellClick);
            this.dgvNoteComment.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNoteComment_RowHeaderMouseClick);
            // 
            // dgvNoteServises
            // 
            this.dgvNoteServises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteServises.Location = new System.Drawing.Point(907, 396);
            this.dgvNoteServises.Name = "dgvNoteServises";
            this.dgvNoteServises.RowHeadersWidth = 51;
            this.dgvNoteServises.RowTemplate.Height = 24;
            this.dgvNoteServises.Size = new System.Drawing.Size(429, 291);
            this.dgvNoteServises.TabIndex = 3;
            this.dgvNoteServises.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNoteServises_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Member Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(901, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member other Servises";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(433, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notice And CommentBox";
            // 
            // btnNoteSubmit
            // 
            this.btnNoteSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNoteSubmit.Location = new System.Drawing.Point(1191, 328);
            this.btnNoteSubmit.Name = "btnNoteSubmit";
            this.btnNoteSubmit.Size = new System.Drawing.Size(145, 53);
            this.btnNoteSubmit.TabIndex = 8;
            this.btnNoteSubmit.Text = "Submit";
            this.btnNoteSubmit.UseVisualStyleBackColor = true;
            this.btnNoteSubmit.Click += new System.EventHandler(this.btnNoteSubmit_Click);
            // 
            // btnNoteSave
            // 
            this.btnNoteSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNoteSave.Location = new System.Drawing.Point(439, 328);
            this.btnNoteSave.Name = "btnNoteSave";
            this.btnNoteSave.Size = new System.Drawing.Size(145, 53);
            this.btnNoteSave.TabIndex = 9;
            this.btnNoteSave.Text = "Save";
            this.btnNoteSave.UseVisualStyleBackColor = true;
            this.btnNoteSave.Click += new System.EventHandler(this.btnNoteSave_Click);
            // 
            // txtNoteComment
            // 
            this.txtNoteComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteComment.ForeColor = System.Drawing.Color.Maroon;
            this.txtNoteComment.Location = new System.Drawing.Point(439, 249);
            this.txtNoteComment.Multiline = true;
            this.txtNoteComment.Name = "txtNoteComment";
            this.txtNoteComment.Size = new System.Drawing.Size(450, 62);
            this.txtNoteComment.TabIndex = 10;
            // 
            // cbNoteSeason
            // 
            this.cbNoteSeason.AutoSize = true;
            this.cbNoteSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoteSeason.ForeColor = System.Drawing.Color.Maroon;
            this.cbNoteSeason.Location = new System.Drawing.Point(907, 226);
            this.cbNoteSeason.Name = "cbNoteSeason";
            this.cbNoteSeason.Size = new System.Drawing.Size(152, 26);
            this.cbNoteSeason.TabIndex = 11;
            this.cbNoteSeason.Text = "Season Need";
            this.cbNoteSeason.UseVisualStyleBackColor = true;
            // 
            // cbNoteTrip
            // 
            this.cbNoteTrip.AutoSize = true;
            this.cbNoteTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoteTrip.ForeColor = System.Drawing.Color.Maroon;
            this.cbNoteTrip.Location = new System.Drawing.Point(1128, 226);
            this.cbNoteTrip.Name = "cbNoteTrip";
            this.cbNoteTrip.Size = new System.Drawing.Size(187, 26);
            this.cbNoteTrip.TabIndex = 12;
            this.cbNoteTrip.Text = "Join Member Trip";
            this.cbNoteTrip.UseVisualStyleBackColor = true;
            // 
            // btnNoteRemove1
            // 
            this.btnNoteRemove1.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteRemove1.Location = new System.Drawing.Point(847, 334);
            this.btnNoteRemove1.Name = "btnNoteRemove1";
            this.btnNoteRemove1.Size = new System.Drawing.Size(42, 40);
            this.btnNoteRemove1.TabIndex = 13;
            this.btnNoteRemove1.Text = "-";
            this.btnNoteRemove1.UseVisualStyleBackColor = true;
            this.btnNoteRemove1.Click += new System.EventHandler(this.btnNoteRemove1_Click);
            // 
            // btnNoteRemove2
            // 
            this.btnNoteRemove2.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteRemove2.Location = new System.Drawing.Point(907, 334);
            this.btnNoteRemove2.Name = "btnNoteRemove2";
            this.btnNoteRemove2.Size = new System.Drawing.Size(42, 40);
            this.btnNoteRemove2.TabIndex = 14;
            this.btnNoteRemove2.Text = "-";
            this.btnNoteRemove2.UseVisualStyleBackColor = true;
            this.btnNoteRemove2.Click += new System.EventHandler(this.btnNoteRemove2_Click);
            // 
            // txtNoteId1
            // 
            this.txtNoteId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteId1.Location = new System.Drawing.Point(551, 221);
            this.txtNoteId1.Name = "txtNoteId1";
            this.txtNoteId1.Size = new System.Drawing.Size(338, 24);
            this.txtNoteId1.TabIndex = 15;
            // 
            // txtNoteId2
            // 
            this.txtNoteId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteId2.Location = new System.Drawing.Point(1016, 258);
            this.txtNoteId2.Name = "txtNoteId2";
            this.txtNoteId2.Size = new System.Drawing.Size(320, 24);
            this.txtNoteId2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "member Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "member Id";
            // 
            // btnNoteClear
            // 
            this.btnNoteClear.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteClear.Location = new System.Drawing.Point(744, 334);
            this.btnNoteClear.Name = "btnNoteClear";
            this.btnNoteClear.Size = new System.Drawing.Size(97, 40);
            this.btnNoteClear.TabIndex = 19;
            this.btnNoteClear.Text = "Text Clear";
            this.btnNoteClear.UseVisualStyleBackColor = true;
            this.btnNoteClear.Click += new System.EventHandler(this.btnNoteClear_Click);
            // 
            // btnNoteclear2
            // 
            this.btnNoteclear2.Font = new System.Drawing.Font("Rockwell Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteclear2.Location = new System.Drawing.Point(962, 334);
            this.btnNoteclear2.Name = "btnNoteclear2";
            this.btnNoteclear2.Size = new System.Drawing.Size(97, 40);
            this.btnNoteclear2.TabIndex = 20;
            this.btnNoteclear2.Text = "Text Clear";
            this.btnNoteclear2.UseVisualStyleBackColor = true;
            this.btnNoteclear2.Click += new System.EventHandler(this.btnNoteclear2_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 710);
            this.Controls.Add(this.btnNoteclear2);
            this.Controls.Add(this.btnNoteClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoteId2);
            this.Controls.Add(this.txtNoteId1);
            this.Controls.Add(this.btnNoteRemove2);
            this.Controls.Add(this.btnNoteRemove1);
            this.Controls.Add(this.cbNoteTrip);
            this.Controls.Add(this.cbNoteSeason);
            this.Controls.Add(this.txtNoteComment);
            this.Controls.Add(this.btnNoteSave);
            this.Controls.Add(this.btnNoteSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNoteServises);
            this.Controls.Add(this.dgvNoteComment);
            this.Controls.Add(this.dgvNoteMemberDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1348, 710);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteMemberDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteServises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNoteMemberDetails;
        private System.Windows.Forms.DataGridView dgvNoteComment;
        private System.Windows.Forms.DataGridView dgvNoteServises;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNoteSubmit;
        private System.Windows.Forms.Button btnNoteSave;
        private System.Windows.Forms.TextBox txtNoteComment;
        private System.Windows.Forms.CheckBox cbNoteSeason;
        private System.Windows.Forms.CheckBox cbNoteTrip;
        private System.Windows.Forms.Button btnNoteRemove1;
        private System.Windows.Forms.Button btnNoteRemove2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNoteId1;
        private System.Windows.Forms.TextBox txtNoteId2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNoteClear;
        private System.Windows.Forms.Button btnNoteclear2;
    }
}