
namespace GenderEqualityApp
{
    partial class HeatMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatMap));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnMin = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.AppIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.AppName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.bunifuPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.AllowFocused = false;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.AutoSizeHeight = true;
            this.btnClose.BorderRadius = 14;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.IsCircle = false;
            this.btnClose.Location = new System.Drawing.Point(897, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 48;
            this.btnClose.TabStop = false;
            this.btnClose.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.AllowFocused = false;
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMin.AutoSizeHeight = true;
            this.btnMin.BorderRadius = 14;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.IsCircle = false;
            this.btnMin.Location = new System.Drawing.Point(863, 7);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(29, 29);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 47;
            this.btnMin.TabStop = false;
            this.btnMin.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // AppIcon
            // 
            this.AppIcon.AllowFocused = false;
            this.AppIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppIcon.AutoSizeHeight = true;
            this.AppIcon.BorderRadius = 14;
            this.AppIcon.Image = ((System.Drawing.Image)(resources.GetObject("AppIcon.Image")));
            this.AppIcon.IsCircle = false;
            this.AppIcon.Location = new System.Drawing.Point(14, 7);
            this.AppIcon.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(29, 29);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppIcon.TabIndex = 46;
            this.AppIcon.TabStop = false;
            this.AppIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // AppName
            // 
            this.AppName.AllowParentOverrides = false;
            this.AppName.AutoEllipsis = false;
            this.AppName.CursorType = null;
            this.AppName.Font = new System.Drawing.Font("Archivo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.AppName.Location = new System.Drawing.Point(49, 11);
            this.AppName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.AppName.Name = "AppName";
            this.AppName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AppName.Size = new System.Drawing.Size(59, 19);
            this.AppName.TabIndex = 45;
            this.AppName.Text = "iRespond";
            this.AppName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.AppName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 10;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.pictureBox6);
            this.bunifuPanel5.Controls.Add(this.label2);
            this.bunifuPanel5.Location = new System.Drawing.Point(9, 44);
            this.bunifuPanel5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(916, 87);
            this.bunifuPanel5.TabIndex = 44;
            this.bunifuPanel5.Click += new System.EventHandler(this.bunifuPanel5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(508, -90);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(441, 273);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Archivo ExtraBold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 20, 5, 6);
            this.label2.Size = new System.Drawing.Size(205, 76);
            this.label2.TabIndex = 10;
            this.label2.Text = "Heat Map";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.AppIcon);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel5);
            this.bunifuPanel1.Controls.Add(this.btnClose);
            this.bunifuPanel1.Controls.Add(this.btnMin);
            this.bunifuPanel1.Controls.Add(this.AppName);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 1);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(937, 145);
            this.bunifuPanel1.TabIndex = 49;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // HeatMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(937, 663);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "HeatMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeatMap";
            this.Load += new System.EventHandler(this.HeatMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.bunifuPanel5.ResumeLayout(false);
            this.bunifuPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox btnClose;
        private Bunifu.UI.WinForms.BunifuPictureBox btnMin;
        private Bunifu.UI.WinForms.BunifuPictureBox AppIcon;
        private Bunifu.UI.WinForms.BunifuLabel AppName;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
    }
}