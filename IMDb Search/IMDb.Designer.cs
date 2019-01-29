namespace IMDb_Search
{
    partial class IMDb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMDb));
            this.SearchByTitleTxtbx = new MetroFramework.Controls.MetroTextBox();
            this.SearchByTitleBtn = new MetroFramework.Controls.MetroButton();
            this.SearchByTitleLbl = new MetroFramework.Controls.MetroLabel();
            this.MInfoPanel = new System.Windows.Forms.Panel();
            this.imdbLink = new System.Windows.Forms.LinkLabel();
            this.Actors = new System.Windows.Forms.Label();
            this.imdbRating = new System.Windows.Forms.Label();
            this.Writer = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.GenreLbl = new System.Windows.Forms.Label();
            this.Awards = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.RuntimeLbl = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.RatedLbl = new System.Windows.Forms.Label();
            this.YoutubePlayer = new System.Windows.Forms.WebBrowser();
            this.nextTip = new System.Windows.Forms.ToolTip(this.components);
            this.backTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.LoadPic = new System.Windows.Forms.PictureBox();
            this.PosterPctbx = new System.Windows.Forms.PictureBox();
            this.MInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByTitleTxtbx
            // 
            // 
            // 
            // 
            this.SearchByTitleTxtbx.CustomButton.Image = null;
            this.SearchByTitleTxtbx.CustomButton.Location = new System.Drawing.Point(318, 2);
            this.SearchByTitleTxtbx.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByTitleTxtbx.CustomButton.Name = "";
            this.SearchByTitleTxtbx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchByTitleTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchByTitleTxtbx.CustomButton.TabIndex = 1;
            this.SearchByTitleTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchByTitleTxtbx.CustomButton.UseSelectable = true;
            this.SearchByTitleTxtbx.CustomButton.Visible = false;
            this.SearchByTitleTxtbx.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchByTitleTxtbx.Lines = new string[0];
            this.SearchByTitleTxtbx.Location = new System.Drawing.Point(934, 62);
            this.SearchByTitleTxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByTitleTxtbx.MaxLength = 32767;
            this.SearchByTitleTxtbx.Name = "SearchByTitleTxtbx";
            this.SearchByTitleTxtbx.PasswordChar = '\0';
            this.SearchByTitleTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchByTitleTxtbx.SelectedText = "";
            this.SearchByTitleTxtbx.SelectionLength = 0;
            this.SearchByTitleTxtbx.SelectionStart = 0;
            this.SearchByTitleTxtbx.ShortcutsEnabled = true;
            this.SearchByTitleTxtbx.Size = new System.Drawing.Size(342, 26);
            this.SearchByTitleTxtbx.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SearchByTitleTxtbx.TabIndex = 0;
            this.SearchByTitleTxtbx.UseCustomBackColor = true;
            this.SearchByTitleTxtbx.UseCustomForeColor = true;
            this.SearchByTitleTxtbx.UseSelectable = true;
            this.SearchByTitleTxtbx.UseStyleColors = true;
            this.SearchByTitleTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchByTitleTxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchByTitleBtn
            // 
            this.SearchByTitleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchByTitleBtn.Location = new System.Drawing.Point(1285, 62);
            this.SearchByTitleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByTitleBtn.Name = "SearchByTitleBtn";
            this.SearchByTitleBtn.Size = new System.Drawing.Size(74, 26);
            this.SearchByTitleBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SearchByTitleBtn.TabIndex = 1;
            this.SearchByTitleBtn.Text = "Search";
            this.SearchByTitleBtn.UseCustomBackColor = true;
            this.SearchByTitleBtn.UseCustomForeColor = true;
            this.SearchByTitleBtn.UseSelectable = true;
            this.SearchByTitleBtn.Click += new System.EventHandler(this.SearchByTitleBtn_Click);
            // 
            // SearchByTitleLbl
            // 
            this.SearchByTitleLbl.AutoSize = true;
            this.SearchByTitleLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SearchByTitleLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SearchByTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchByTitleLbl.Location = new System.Drawing.Point(931, 25);
            this.SearchByTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchByTitleLbl.Name = "SearchByTitleLbl";
            this.SearchByTitleLbl.Size = new System.Drawing.Size(64, 25);
            this.SearchByTitleLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.SearchByTitleLbl.TabIndex = 2;
            this.SearchByTitleLbl.Text = "Search";
            this.SearchByTitleLbl.UseCustomBackColor = true;
            this.SearchByTitleLbl.UseCustomForeColor = true;
            // 
            // MInfoPanel
            // 
            this.MInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            this.MInfoPanel.Controls.Add(this.LoadPic);
            this.MInfoPanel.Controls.Add(this.imdbLink);
            this.MInfoPanel.Controls.Add(this.Actors);
            this.MInfoPanel.Controls.Add(this.imdbRating);
            this.MInfoPanel.Controls.Add(this.Writer);
            this.MInfoPanel.Controls.Add(this.Country);
            this.MInfoPanel.Controls.Add(this.GenreLbl);
            this.MInfoPanel.Controls.Add(this.Awards);
            this.MInfoPanel.Controls.Add(this.Language);
            this.MInfoPanel.Controls.Add(this.Director);
            this.MInfoPanel.Controls.Add(this.RuntimeLbl);
            this.MInfoPanel.Controls.Add(this.Plot);
            this.MInfoPanel.Controls.Add(this.TitleLbl);
            this.MInfoPanel.Controls.Add(this.RatedLbl);
            this.MInfoPanel.Controls.Add(this.YoutubePlayer);
            this.MInfoPanel.Location = new System.Drawing.Point(539, 110);
            this.MInfoPanel.Name = "MInfoPanel";
            this.MInfoPanel.Size = new System.Drawing.Size(819, 688);
            this.MInfoPanel.TabIndex = 4;
            // 
            // imdbLink
            // 
            this.imdbLink.AutoSize = true;
            this.imdbLink.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbLink.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.imdbLink.Location = new System.Drawing.Point(5, 571);
            this.imdbLink.Name = "imdbLink";
            this.imdbLink.Size = new System.Drawing.Size(0, 23);
            this.imdbLink.TabIndex = 4;
            this.imdbLink.Click += new System.EventHandler(this.imdbLink_Click);
            // 
            // Actors
            // 
            this.Actors.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Actors.Location = new System.Drawing.Point(3, 263);
            this.Actors.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(813, 73);
            this.Actors.TabIndex = 3;
            this.Actors.Text = "label1";
            // 
            // imdbRating
            // 
            this.imdbRating.AutoSize = true;
            this.imdbRating.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imdbRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.imdbRating.Location = new System.Drawing.Point(3, 528);
            this.imdbRating.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.imdbRating.Name = "imdbRating";
            this.imdbRating.Size = new System.Drawing.Size(96, 27);
            this.imdbRating.TabIndex = 3;
            this.imdbRating.Text = "label1";
            // 
            // Writer
            // 
            this.Writer.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Writer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Writer.Location = new System.Drawing.Point(3, 220);
            this.Writer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Writer.Name = "Writer";
            this.Writer.Size = new System.Drawing.Size(813, 23);
            this.Writer.TabIndex = 3;
            this.Writer.Text = "label1";
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Country.Location = new System.Drawing.Point(3, 442);
            this.Country.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(813, 23);
            this.Country.TabIndex = 3;
            this.Country.Text = "label1";
            // 
            // GenreLbl
            // 
            this.GenreLbl.AutoSize = true;
            this.GenreLbl.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.GenreLbl.Location = new System.Drawing.Point(3, 134);
            this.GenreLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.GenreLbl.Name = "GenreLbl";
            this.GenreLbl.Size = new System.Drawing.Size(96, 27);
            this.GenreLbl.TabIndex = 3;
            this.GenreLbl.Text = "label1";
            // 
            // Awards
            // 
            this.Awards.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Awards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Awards.Location = new System.Drawing.Point(3, 485);
            this.Awards.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(813, 23);
            this.Awards.TabIndex = 3;
            this.Awards.Text = "label1";
            // 
            // Language
            // 
            this.Language.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Language.Location = new System.Drawing.Point(3, 399);
            this.Language.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(813, 23);
            this.Language.TabIndex = 3;
            this.Language.Text = "label1";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Director.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Director.Location = new System.Drawing.Point(3, 177);
            this.Director.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(96, 27);
            this.Director.TabIndex = 3;
            this.Director.Text = "label1";
            // 
            // RuntimeLbl
            // 
            this.RuntimeLbl.AutoSize = true;
            this.RuntimeLbl.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.RuntimeLbl.Location = new System.Drawing.Point(3, 91);
            this.RuntimeLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.RuntimeLbl.Name = "RuntimeLbl";
            this.RuntimeLbl.Size = new System.Drawing.Size(96, 27);
            this.RuntimeLbl.TabIndex = 3;
            this.RuntimeLbl.Text = "label1";
            // 
            // Plot
            // 
            this.Plot.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Plot.Location = new System.Drawing.Point(3, 356);
            this.Plot.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(813, 23);
            this.Plot.TabIndex = 3;
            this.Plot.Text = "label1";
            // 
            // TitleLbl
            // 
            this.TitleLbl.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.TitleLbl.Location = new System.Drawing.Point(7, 0);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(787, 33);
            this.TitleLbl.TabIndex = 3;
            this.TitleLbl.Text = "label1";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RatedLbl
            // 
            this.RatedLbl.AutoSize = true;
            this.RatedLbl.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.RatedLbl.Location = new System.Drawing.Point(3, 48);
            this.RatedLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.RatedLbl.Name = "RatedLbl";
            this.RatedLbl.Size = new System.Drawing.Size(96, 27);
            this.RatedLbl.TabIndex = 3;
            this.RatedLbl.Text = "label1";
            // 
            // YoutubePlayer
            // 
            this.YoutubePlayer.Location = new System.Drawing.Point(473, 513);
            this.YoutubePlayer.Margin = new System.Windows.Forms.Padding(1);
            this.YoutubePlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.YoutubePlayer.Name = "YoutubePlayer";
            this.YoutubePlayer.Size = new System.Drawing.Size(348, 183);
            this.YoutubePlayer.TabIndex = 1;
            this.YoutubePlayer.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IMDb_Search.Properties.Resources.icons8_IMDb_48px;
            this.pictureBox3.Location = new System.Drawing.Point(24, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // back
            // 
            this.back.Image = global::IMDb_Search.Properties.Resources.icons8_Previous_52px;
            this.back.Location = new System.Drawing.Point(1200, 804);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(76, 73);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 5;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            // 
            // next
            // 
            this.next.Image = global::IMDb_Search.Properties.Resources.icons8_Next_52px;
            this.next.Location = new System.Drawing.Point(1282, 804);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(76, 73);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next.TabIndex = 5;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            this.next.MouseEnter += new System.EventHandler(this.next_MouseEnter);
            // 
            // LoadPic
            // 
            this.LoadPic.Image = global::IMDb_Search.Properties.Resources.ezgif_com_gif_maker;
            this.LoadPic.Location = new System.Drawing.Point(0, 3);
            this.LoadPic.Name = "LoadPic";
            this.LoadPic.Size = new System.Drawing.Size(816, 696);
            this.LoadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadPic.TabIndex = 5;
            this.LoadPic.TabStop = false;
            // 
            // PosterPctbx
            // 
            this.PosterPctbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PosterPctbx.Image = global::IMDb_Search.Properties.Resources._1024px_No_image_available_svg;
            this.PosterPctbx.Location = new System.Drawing.Point(24, 110);
            this.PosterPctbx.Name = "PosterPctbx";
            this.PosterPctbx.Size = new System.Drawing.Size(501, 688);
            this.PosterPctbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PosterPctbx.TabIndex = 3;
            this.PosterPctbx.TabStop = false;
            // 
            // IMDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 884);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.MInfoPanel);
            this.Controls.Add(this.PosterPctbx);
            this.Controls.Add(this.SearchByTitleLbl);
            this.Controls.Add(this.SearchByTitleBtn);
            this.Controls.Add(this.SearchByTitleTxtbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IMDb";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "IMDb Search";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.SlateGray;
            this.MInfoPanel.ResumeLayout(false);
            this.MInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPctbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox SearchByTitleTxtbx;
        private MetroFramework.Controls.MetroButton SearchByTitleBtn;
        private MetroFramework.Controls.MetroLabel SearchByTitleLbl;
        private System.Windows.Forms.PictureBox PosterPctbx;
        private System.Windows.Forms.Panel MInfoPanel;
        private System.Windows.Forms.WebBrowser YoutubePlayer;
        private System.Windows.Forms.Label RatedLbl;
        private System.Windows.Forms.Label RuntimeLbl;
        private System.Windows.Forms.Label GenreLbl;
        private System.Windows.Forms.Label Actors;
        private System.Windows.Forms.Label Writer;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.LinkLabel imdbLink;
        private System.Windows.Forms.Label imdbRating;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Awards;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox LoadPic;
        private System.Windows.Forms.ToolTip nextTip;
        private System.Windows.Forms.ToolTip backTip;
    }
}

