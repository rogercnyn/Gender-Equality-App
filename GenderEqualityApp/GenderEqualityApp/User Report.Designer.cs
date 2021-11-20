
namespace GenderEqualityApp
{
    partial class User_Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Report));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel49 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel49
            // 
            this.bunifuLabel49.AllowParentOverrides = false;
            this.bunifuLabel49.AutoEllipsis = false;
            this.bunifuLabel49.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel49.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel49.Font = new System.Drawing.Font("Heebo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.bunifuLabel49.Location = new System.Drawing.Point(14, 16);
            this.bunifuLabel49.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel49.Name = "bunifuLabel49";
            this.bunifuLabel49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel49.Size = new System.Drawing.Size(104, 34);
            this.bunifuLabel49.TabIndex = 24;
            this.bunifuLabel49.Text = "Username";
            this.bunifuLabel49.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel49.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Location = new System.Drawing.Point(-12, 57);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(592, 10);
            this.bunifuPanel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gothic A1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 216);
            this.label1.TabIndex = 28;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // User_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuLabel49);
            this.Name = "User_Report";
            this.Size = new System.Drawing.Size(571, 304);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel49;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}
