﻿namespace Client
{
    partial class Form_Onlineroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Onlineroom));
            this.pbBackgroundONLR = new System.Windows.Forms.PictureBox();
            this.btBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbRoomname = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.btMaximized = new Guna.UI2.WinForms.Guna2Button();
            this.btExit = new Guna.UI2.WinForms.Guna2Button();
            this.btMenu = new Guna.UI2.WinForms.Guna2Button();
            this.tbEnterchat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btReaction = new Guna.UI2.WinForms.Guna2Button();
            this.btUpload = new Guna.UI2.WinForms.Guna2Button();
            this.pbFirstavatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btSecondavatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbFirstusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnVideo = new System.Windows.Forms.Panel();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pnTool = new System.Windows.Forms.Panel();
            this.csVideo = new ColorSlider.ColorSlider();
            this.btPause = new Guna.UI2.WinForms.Guna2Button();
            this.btMute = new Guna.UI2.WinForms.Guna2Button();
            this.csSound = new ColorSlider.ColorSlider();
            this.btPlaying = new Guna.UI2.WinForms.Guna2Button();
            this.lbMaxTime = new System.Windows.Forms.Label();
            this.lbTiming = new System.Windows.Forms.Label();
            this.btUnmute = new Guna.UI2.WinForms.Guna2Button();
            this.btBackTime = new Guna.UI2.WinForms.Guna2Button();
            this.btFowardTime = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Videoplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundONLR)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstavatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSecondavatar)).BeginInit();
            this.pnVideo.SuspendLayout();
            this.pnTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Videoplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackgroundONLR
            // 
            this.pbBackgroundONLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackgroundONLR.Image = ((System.Drawing.Image)(resources.GetObject("pbBackgroundONLR.Image")));
            this.pbBackgroundONLR.Location = new System.Drawing.Point(0, 0);
            this.pbBackgroundONLR.Name = "pbBackgroundONLR";
            this.pbBackgroundONLR.Size = new System.Drawing.Size(1030, 550);
            this.pbBackgroundONLR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackgroundONLR.TabIndex = 0;
            this.pbBackgroundONLR.TabStop = false;
            this.pbBackgroundONLR.MouseEnter += new System.EventHandler(this.pbBackgroundONLR_MouseEnter);
            this.pbBackgroundONLR.MouseLeave += new System.EventHandler(this.pbBackgroundONLR_MouseLeave);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBack.BackgroundImage")));
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBack.FillColor = System.Drawing.Color.Transparent;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(21, 5);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "guna2Button1";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.Controls.Add(this.lbRoomname);
            this.pnHeader.Controls.Add(this.lbID);
            this.pnHeader.Location = new System.Drawing.Point(56, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(798, 45);
            this.pnHeader.TabIndex = 13;
            // 
            // lbRoomname
            // 
            this.lbRoomname.AutoSize = true;
            this.lbRoomname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbRoomname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbRoomname.ForeColor = System.Drawing.Color.White;
            this.lbRoomname.Location = new System.Drawing.Point(249, 6);
            this.lbRoomname.Name = "lbRoomname";
            this.lbRoomname.Size = new System.Drawing.Size(154, 32);
            this.lbRoomname.TabIndex = 28;
            this.lbRoomname.Text = "Room_name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(465, 14);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(49, 15);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "123456";
            // 
            // btMinimized
            // 
            this.btMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMinimized.BackgroundImage")));
            this.btMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMinimized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMinimized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMinimized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMinimized.FillColor = System.Drawing.Color.Transparent;
            this.btMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMinimized.ForeColor = System.Drawing.Color.White;
            this.btMinimized.Location = new System.Drawing.Point(860, 10);
            this.btMinimized.Name = "btMinimized";
            this.btMinimized.Size = new System.Drawing.Size(25, 25);
            this.btMinimized.TabIndex = 12;
            this.btMinimized.Text = "guna2Button1";
            this.btMinimized.Click += new System.EventHandler(this.btMinimized_Click);
            // 
            // btMaximized
            // 
            this.btMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btMaximized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMaximized.BackgroundImage")));
            this.btMaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMaximized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMaximized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMaximized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMaximized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMaximized.FillColor = System.Drawing.Color.Transparent;
            this.btMaximized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMaximized.ForeColor = System.Drawing.Color.White;
            this.btMaximized.Location = new System.Drawing.Point(928, 15);
            this.btMaximized.Name = "btMaximized";
            this.btMaximized.Size = new System.Drawing.Size(15, 15);
            this.btMaximized.TabIndex = 11;
            this.btMaximized.Text = "guna2Button1";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExit.FillColor = System.Drawing.Color.Transparent;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(982, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(20, 20);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "guna2Button1";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMenu.BackgroundImage")));
            this.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMenu.FillColor = System.Drawing.Color.Transparent;
            this.btMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMenu.ForeColor = System.Drawing.Color.White;
            this.btMenu.Location = new System.Drawing.Point(56, 472);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(32, 32);
            this.btMenu.TabIndex = 15;
            this.btMenu.Text = "guna2Button1";
            // 
            // tbEnterchat
            // 
            this.tbEnterchat.BackColor = System.Drawing.Color.Transparent;
            this.tbEnterchat.BorderColor = System.Drawing.Color.White;
            this.tbEnterchat.BorderRadius = 10;
            this.tbEnterchat.BorderThickness = 2;
            this.tbEnterchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEnterchat.DefaultText = "";
            this.tbEnterchat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEnterchat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEnterchat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEnterchat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEnterchat.FillColor = System.Drawing.Color.Transparent;
            this.tbEnterchat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEnterchat.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.tbEnterchat.ForeColor = System.Drawing.Color.White;
            this.tbEnterchat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEnterchat.Location = new System.Drawing.Point(810, 461);
            this.tbEnterchat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEnterchat.Name = "tbEnterchat";
            this.tbEnterchat.PasswordChar = '\0';
            this.tbEnterchat.PlaceholderForeColor = System.Drawing.Color.White;
            this.tbEnterchat.PlaceholderText = "Enter chat ...";
            this.tbEnterchat.SelectedText = "";
            this.tbEnterchat.Size = new System.Drawing.Size(192, 43);
            this.tbEnterchat.TabIndex = 16;
            this.tbEnterchat.TextOffset = new System.Drawing.Point(23, 0);
            // 
            // btReaction
            // 
            this.btReaction.BackColor = System.Drawing.Color.Black;
            this.btReaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReaction.BackgroundImage")));
            this.btReaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReaction.FillColor = System.Drawing.Color.Transparent;
            this.btReaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btReaction.ForeColor = System.Drawing.Color.White;
            this.btReaction.Location = new System.Drawing.Point(817, 467);
            this.btReaction.Name = "btReaction";
            this.btReaction.Size = new System.Drawing.Size(36, 32);
            this.btReaction.TabIndex = 17;
            // 
            // btUpload
            // 
            this.btUpload.AutoRoundedCorners = true;
            this.btUpload.BackColor = System.Drawing.Color.Transparent;
            this.btUpload.BorderRadius = 21;
            this.btUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpload.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btUpload.ForeColor = System.Drawing.Color.Black;
            this.btUpload.Location = new System.Drawing.Point(638, 464);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(128, 45);
            this.btUpload.TabIndex = 22;
            this.btUpload.Text = "Upload";
            this.btUpload.UseTransparentBackground = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // pbFirstavatar
            // 
            this.pbFirstavatar.BackColor = System.Drawing.Color.Transparent;
            this.pbFirstavatar.Image = ((System.Drawing.Image)(resources.GetObject("pbFirstavatar.Image")));
            this.pbFirstavatar.ImageRotate = 0F;
            this.pbFirstavatar.InitialImage = null;
            this.pbFirstavatar.Location = new System.Drawing.Point(123, 448);
            this.pbFirstavatar.Name = "pbFirstavatar";
            this.pbFirstavatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFirstavatar.Size = new System.Drawing.Size(61, 56);
            this.pbFirstavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstavatar.TabIndex = 23;
            this.pbFirstavatar.TabStop = false;
            this.pbFirstavatar.UseTransparentBackground = true;
            this.pbFirstavatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // btSecondavatar
            // 
            this.btSecondavatar.BackColor = System.Drawing.Color.Transparent;
            this.btSecondavatar.Image = ((System.Drawing.Image)(resources.GetObject("btSecondavatar.Image")));
            this.btSecondavatar.ImageRotate = 0F;
            this.btSecondavatar.InitialImage = null;
            this.btSecondavatar.Location = new System.Drawing.Point(225, 448);
            this.btSecondavatar.Name = "btSecondavatar";
            this.btSecondavatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btSecondavatar.Size = new System.Drawing.Size(61, 56);
            this.btSecondavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btSecondavatar.TabIndex = 24;
            this.btSecondavatar.TabStop = false;
            this.btSecondavatar.UseTransparentBackground = true;
            // 
            // lbFirstusername
            // 
            this.lbFirstusername.AutoSize = true;
            this.lbFirstusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbFirstusername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbFirstusername.ForeColor = System.Drawing.Color.White;
            this.lbFirstusername.Location = new System.Drawing.Point(128, 508);
            this.lbFirstusername.Name = "lbFirstusername";
            this.lbFirstusername.Size = new System.Drawing.Size(51, 19);
            this.lbFirstusername.TabIndex = 25;
            this.lbFirstusername.Text = "ovapil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "miranee";
            // 
            // pnVideo
            // 
            this.pnVideo.BackColor = System.Drawing.Color.Black;
            this.pnVideo.Controls.Add(this.btSearch);
            this.pnVideo.Controls.Add(this.pnTool);
            this.pnVideo.Controls.Add(this.tbSearch);
            this.pnVideo.Controls.Add(this.Videoplayer);
            this.pnVideo.Location = new System.Drawing.Point(12, 43);
            this.pnVideo.Name = "pnVideo";
            this.pnVideo.Size = new System.Drawing.Size(778, 392);
            this.pnVideo.TabIndex = 36;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Black;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearch.FillColor = System.Drawing.Color.Transparent;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(166, 14);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(39, 35);
            this.btSearch.TabIndex = 37;
            this.btSearch.Visible = false;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.Black;
            this.pnTool.Controls.Add(this.csVideo);
            this.pnTool.Controls.Add(this.btPause);
            this.pnTool.Controls.Add(this.btMute);
            this.pnTool.Controls.Add(this.csSound);
            this.pnTool.Controls.Add(this.btPlaying);
            this.pnTool.Controls.Add(this.lbMaxTime);
            this.pnTool.Controls.Add(this.lbTiming);
            this.pnTool.Controls.Add(this.btUnmute);
            this.pnTool.Controls.Add(this.btBackTime);
            this.pnTool.Controls.Add(this.btFowardTime);
            this.pnTool.Location = new System.Drawing.Point(0, 331);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(778, 64);
            this.pnTool.TabIndex = 31;
            this.pnTool.Visible = false;
            // 
            // csVideo
            // 
            this.csVideo.BackColor = System.Drawing.Color.Transparent;
            this.csVideo.BarInnerColor = System.Drawing.Color.White;
            this.csVideo.BarPenColorBottom = System.Drawing.Color.White;
            this.csVideo.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.csVideo.BorderRoundRectSize = new System.Drawing.Size(12, 12);
            this.csVideo.CausesValidation = false;
            this.csVideo.DrawSemitransparentThumb = false;
            this.csVideo.ElapsedInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.csVideo.ElapsedPenColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.csVideo.ElapsedPenColorTop = System.Drawing.Color.DeepSkyBlue;
            this.csVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.csVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.csVideo.LargeChange = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.csVideo.Location = new System.Drawing.Point(157, 40);
            this.csVideo.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.csVideo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.csVideo.Name = "csVideo";
            this.csVideo.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.csVideo.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.csVideo.ShowDivisionsText = true;
            this.csVideo.ShowSmallScale = false;
            this.csVideo.Size = new System.Drawing.Size(471, 28);
            this.csVideo.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.csVideo.TabIndex = 39;
            this.csVideo.Text = "colorSlider2";
            this.csVideo.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.csVideo.ThumbPenColor = System.Drawing.Color.Transparent;
            this.csVideo.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.csVideo.ThumbSize = new System.Drawing.Size(1, 1);
            this.csVideo.TickAdd = 0F;
            this.csVideo.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.csVideo.TickDivide = 0F;
            this.csVideo.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.csVideo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.csVideo_Scroll);
            this.csVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.csVideo_MouseDown);
            this.csVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.csVideo_MouseUp);
            // 
            // btPause
            // 
            this.btPause.BackColor = System.Drawing.Color.Transparent;
            this.btPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPause.BackgroundImage")));
            this.btPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPause.FillColor = System.Drawing.Color.Transparent;
            this.btPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btPause.ForeColor = System.Drawing.Color.White;
            this.btPause.Location = new System.Drawing.Point(371, 5);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(33, 33);
            this.btPause.TabIndex = 41;
            this.btPause.Visible = false;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btMute
            // 
            this.btMute.BackColor = System.Drawing.Color.Transparent;
            this.btMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMute.BackgroundImage")));
            this.btMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMute.FillColor = System.Drawing.Color.Transparent;
            this.btMute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMute.ForeColor = System.Drawing.Color.White;
            this.btMute.Location = new System.Drawing.Point(181, 9);
            this.btMute.Name = "btMute";
            this.btMute.Size = new System.Drawing.Size(25, 25);
            this.btMute.TabIndex = 40;
            this.btMute.Visible = false;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // csSound
            // 
            this.csSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.csSound.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.csSound.BarPenColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.csSound.BarPenColorTop = System.Drawing.Color.DeepSkyBlue;
            this.csSound.BorderRoundRectSize = new System.Drawing.Size(12, 12);
            this.csSound.CausesValidation = false;
            this.csSound.DrawSemitransparentThumb = false;
            this.csSound.ElapsedInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.csSound.ElapsedPenColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.csSound.ElapsedPenColorTop = System.Drawing.Color.DeepSkyBlue;
            this.csSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.csSound.ForeColor = System.Drawing.Color.White;
            this.csSound.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.csSound.Location = new System.Drawing.Point(211, 7);
            this.csSound.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.csSound.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.csSound.Name = "csSound";
            this.csSound.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.csSound.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.csSound.ShowDivisionsText = true;
            this.csSound.ShowSmallScale = false;
            this.csSound.Size = new System.Drawing.Size(90, 29);
            this.csSound.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.csSound.TabIndex = 43;
            this.csSound.Text = "colorSlider1";
            this.csSound.ThumbInnerColor = System.Drawing.Color.White;
            this.csSound.ThumbPenColor = System.Drawing.Color.Transparent;
            this.csSound.ThumbRoundRectSize = new System.Drawing.Size(12, 12);
            this.csSound.ThumbSize = new System.Drawing.Size(12, 12);
            this.csSound.TickAdd = 0F;
            this.csSound.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.csSound.TickDivide = 0F;
            this.csSound.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.csSound.ValueChanged += new System.EventHandler(this.csSound_ValueChanged);
            this.csSound.Scroll += new System.Windows.Forms.ScrollEventHandler(this.csSound_Scroll);
            // 
            // btPlaying
            // 
            this.btPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPlaying.BackgroundImage")));
            this.btPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPlaying.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPlaying.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPlaying.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPlaying.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPlaying.FillColor = System.Drawing.Color.Transparent;
            this.btPlaying.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btPlaying.ForeColor = System.Drawing.Color.White;
            this.btPlaying.Location = new System.Drawing.Point(371, 5);
            this.btPlaying.Name = "btPlaying";
            this.btPlaying.Size = new System.Drawing.Size(33, 33);
            this.btPlaying.TabIndex = 41;
            this.btPlaying.Click += new System.EventHandler(this.btPlaying_Click);
            // 
            // lbMaxTime
            // 
            this.lbMaxTime.AutoSize = true;
            this.lbMaxTime.ForeColor = System.Drawing.Color.White;
            this.lbMaxTime.Location = new System.Drawing.Point(634, 44);
            this.lbMaxTime.Name = "lbMaxTime";
            this.lbMaxTime.Size = new System.Drawing.Size(38, 16);
            this.lbMaxTime.TabIndex = 1;
            this.lbMaxTime.Text = "00:00";
            // 
            // lbTiming
            // 
            this.lbTiming.AutoSize = true;
            this.lbTiming.ForeColor = System.Drawing.Color.White;
            this.lbTiming.Location = new System.Drawing.Point(96, 44);
            this.lbTiming.Name = "lbTiming";
            this.lbTiming.Size = new System.Drawing.Size(38, 16);
            this.lbTiming.TabIndex = 0;
            this.lbTiming.Text = "00:00";
            this.lbTiming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btUnmute
            // 
            this.btUnmute.BackColor = System.Drawing.Color.Transparent;
            this.btUnmute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUnmute.BackgroundImage")));
            this.btUnmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUnmute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUnmute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUnmute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUnmute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUnmute.FillColor = System.Drawing.Color.Transparent;
            this.btUnmute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btUnmute.ForeColor = System.Drawing.Color.White;
            this.btUnmute.Location = new System.Drawing.Point(181, 9);
            this.btUnmute.Name = "btUnmute";
            this.btUnmute.Size = new System.Drawing.Size(25, 25);
            this.btUnmute.TabIndex = 35;
            this.btUnmute.Click += new System.EventHandler(this.btUnmute_Click);
            // 
            // btBackTime
            // 
            this.btBackTime.BackColor = System.Drawing.Color.Transparent;
            this.btBackTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackTime.BackgroundImage")));
            this.btBackTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBackTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBackTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBackTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBackTime.FillColor = System.Drawing.Color.Transparent;
            this.btBackTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBackTime.ForeColor = System.Drawing.Color.White;
            this.btBackTime.Location = new System.Drawing.Point(329, 7);
            this.btBackTime.Name = "btBackTime";
            this.btBackTime.Size = new System.Drawing.Size(30, 30);
            this.btBackTime.TabIndex = 2;
            this.btBackTime.UseTransparentBackground = true;
            this.btBackTime.Click += new System.EventHandler(this.btBackTime_Click);
            // 
            // btFowardTime
            // 
            this.btFowardTime.BackColor = System.Drawing.Color.Transparent;
            this.btFowardTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFowardTime.BackgroundImage")));
            this.btFowardTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFowardTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFowardTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFowardTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFowardTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFowardTime.FillColor = System.Drawing.Color.Transparent;
            this.btFowardTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btFowardTime.ForeColor = System.Drawing.Color.White;
            this.btFowardTime.Location = new System.Drawing.Point(414, 7);
            this.btFowardTime.Name = "btFowardTime";
            this.btFowardTime.Size = new System.Drawing.Size(30, 30);
            this.btFowardTime.TabIndex = 1;
            this.btFowardTime.UseTransparentBackground = true;
            this.btFowardTime.Click += new System.EventHandler(this.btFowardTime_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.AutoRoundedCorners = true;
            this.tbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tbSearch.BorderRadius = 20;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FillColor = System.Drawing.Color.Black;
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(157, 9);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tbSearch.PlaceholderText = "What do you want to play?";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(456, 43);
            this.tbSearch.TabIndex = 38;
            this.tbSearch.TextOffset = new System.Drawing.Point(25, 0);
            this.tbSearch.Visible = false;
            // 
            // OFD
            // 
            this.OFD.FileName = "Open File";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Videoplayer
            // 
            this.Videoplayer.Enabled = true;
            this.Videoplayer.Location = new System.Drawing.Point(-13, 0);
            this.Videoplayer.Name = "Videoplayer";
            this.Videoplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Videoplayer.OcxState")));
            this.Videoplayer.Size = new System.Drawing.Size(616, 395);
            this.Videoplayer.TabIndex = 32;
            // 
            // Form_Onlineroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 550);
            this.Controls.Add(this.pnVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFirstusername);
            this.Controls.Add(this.btSecondavatar);
            this.Controls.Add(this.pbFirstavatar);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btReaction);
            this.Controls.Add(this.tbEnterchat);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btMinimized);
            this.Controls.Add(this.btMaximized);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pbBackgroundONLR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Onlineroom";
            this.Text = "Form_Onlineroom";
            this.Load += new System.EventHandler(this.Form_Onlineroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundONLR)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstavatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSecondavatar)).EndInit();
            this.pnVideo.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Videoplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackgroundONLR;
        private Guna.UI2.WinForms.Guna2Button btBack;
        private System.Windows.Forms.Panel pnHeader;
        private Guna.UI2.WinForms.Guna2Button btMinimized;
        private Guna.UI2.WinForms.Guna2Button btMaximized;
        private Guna.UI2.WinForms.Guna2Button btExit;
        private Guna.UI2.WinForms.Guna2Button btMenu;
        private Guna.UI2.WinForms.Guna2TextBox tbEnterchat;
        private Guna.UI2.WinForms.Guna2Button btReaction;
        private Guna.UI2.WinForms.Guna2Button btUpload;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFirstavatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btSecondavatar;
        private System.Windows.Forms.Label lbFirstusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbRoomname;
        private System.Windows.Forms.Panel pnVideo;
        private System.Windows.Forms.Panel pnTool;
        private ColorSlider.ColorSlider csVideo;
        private Guna.UI2.WinForms.Guna2Button btPause;
        private Guna.UI2.WinForms.Guna2Button btMute;
        private ColorSlider.ColorSlider csSound;
        private Guna.UI2.WinForms.Guna2Button btPlaying;
        private System.Windows.Forms.Label lbMaxTime;
        private System.Windows.Forms.Label lbTiming;
        private Guna.UI2.WinForms.Guna2Button btUnmute;
        private Guna.UI2.WinForms.Guna2Button btBackTime;
        private Guna.UI2.WinForms.Guna2Button btFowardTime;
        private AxWMPLib.AxWindowsMediaPlayer Videoplayer;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
    }
}