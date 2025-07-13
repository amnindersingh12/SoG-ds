﻿
using SoG_SGreader.CustomControls;
using System.Windows.Forms;

namespace SoG_SGreader
{
    partial class FrmLoadSaveGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadSaveGame));
            this.btnLoadSaveGame = new System.Windows.Forms.Button();
            this.btnStartWithoitLoading = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblSaveGameCount = new System.Windows.Forms.Label();
            this.lstvSaveGames = new System.Windows.Forms.ListView();
            this.columnSavefile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCharName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new SoG_SGreader.CustomControls.PixelBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadSaveGame
            // 
            this.btnLoadSaveGame.Enabled = false;
            this.btnLoadSaveGame.Location = new System.Drawing.Point(233, 137);
            this.btnLoadSaveGame.Name = "btnLoadSaveGame";
            this.btnLoadSaveGame.Size = new System.Drawing.Size(85, 55);
            this.btnLoadSaveGame.TabIndex = 0;
            this.btnLoadSaveGame.Text = "Load";
            this.btnLoadSaveGame.UseVisualStyleBackColor = true;
            this.btnLoadSaveGame.Click += new System.EventHandler(this.BtnLoadSaveGame_Click);
            // 
            // btnStartWithoitLoading
            // 
            this.btnStartWithoitLoading.Location = new System.Drawing.Point(327, 165);
            this.btnStartWithoitLoading.Name = "btnStartWithoitLoading";
            this.btnStartWithoitLoading.Size = new System.Drawing.Size(25, 25);
            this.btnStartWithoitLoading.TabIndex = 3;
            this.btnStartWithoitLoading.Text = "...";
            this.btnStartWithoitLoading.UseVisualStyleBackColor = true;
            this.btnStartWithoitLoading.Click += new System.EventHandler(this.BtnStartWithoitLoading_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(0, 192);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(361, 25);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "[lblFilePath]";
            // 
            // lblSaveGameCount
            // 
            this.lblSaveGameCount.AutoSize = true;
            this.lblSaveGameCount.Location = new System.Drawing.Point(236, 120);
            this.lblSaveGameCount.Name = "lblSaveGameCount";
            this.lblSaveGameCount.Size = new System.Drawing.Size(113, 13);
            this.lblSaveGameCount.TabIndex = 5;
            this.lblSaveGameCount.Text = "No Savegames found!";
            // 
            // lstvSaveGames
            // 
            this.lstvSaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvSaveGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSavefile,
            this.columnSex,
            this.columnCharName});
            this.lstvSaveGames.FullRowSelect = true;
            this.lstvSaveGames.GridLines = true;
            this.lstvSaveGames.HideSelection = false;
            this.lstvSaveGames.LabelWrap = false;
            this.lstvSaveGames.Location = new System.Drawing.Point(3, 1);
            this.lstvSaveGames.MultiSelect = false;
            this.lstvSaveGames.Name = "lstvSaveGames";
            this.lstvSaveGames.Scrollable = false;
            this.lstvSaveGames.Size = new System.Drawing.Size(227, 189);
            this.lstvSaveGames.SmallImageList = this.imageList1;
            this.lstvSaveGames.TabIndex = 6;
            this.lstvSaveGames.UseCompatibleStateImageBehavior = false;
            this.lstvSaveGames.View = System.Windows.Forms.View.Details;
            this.lstvSaveGames.SelectedIndexChanged += new System.EventHandler(this.LstvSaveGames_SelectedIndexChanged);
            this.lstvSaveGames.DoubleClick += new System.EventHandler(this.lstvSaveGames_DoubleClick);
            // 
            // columnSavefile
            // 
            this.columnSavefile.Text = "Slot";
            this.columnSavefile.Width = 30;
            // 
            // columnSex
            // 
            this.columnSex.Text = "Sex";
            this.columnSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSex.Width = 30;
            // 
            // columnCharName
            // 
            this.columnCharName.Text = "Character";
            this.columnCharName.Width = 235;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save_small.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::SoG_SGreader.Properties.Resources.icon;
            this.pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.pictureBox1.Location = new System.Drawing.Point(236, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChooseFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseFolder.Image")));
            this.btnChooseFolder.Location = new System.Drawing.Point(327, 135);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(25, 25);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // FrmLoadSaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(361, 217);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstvSaveGames);
            this.Controls.Add(this.lblSaveGameCount);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnStartWithoitLoading);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnLoadSaveGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLoadSaveGame";
            this.Text = "SoG: Savegame Editor v0.9.0 by tolik518";
            this.Load += new System.EventHandler(this.FrmLoadSaveGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSaveGame;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnStartWithoitLoading;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblSaveGameCount;
        private System.Windows.Forms.ListView lstvSaveGames;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnSavefile;
        private System.Windows.Forms.ColumnHeader columnCharName;
        private PixelBox pictureBox1;
        private ColumnHeader columnSex;
    }
}