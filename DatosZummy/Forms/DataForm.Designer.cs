namespace DatosZummy.Forms
{
    partial class DataForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            pnlShadowTop = new Panel();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconList = new ImageList(components);
            lvFiles = new ListView();
            pnlTop = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pnlBot = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnGo = new FontAwesome.Sharp.IconButton();
            bntBackElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnGoElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // pnlShadowTop
            // 
            pnlShadowTop.BackColor = Color.Gainsboro;
            pnlShadowTop.Location = new Point(0, 54);
            pnlShadowTop.Name = "pnlShadowTop";
            pnlShadowTop.Size = new Size(1006, 5);
            pnlShadowTop.TabIndex = 1;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "carpeta.png");
            iconList.Images.SetKeyName(1, "archivo-csv.png");
            iconList.Images.SetKeyName(2, "");
            iconList.Images.SetKeyName(3, "");
            // 
            // lvFiles
            // 
            lvFiles.BorderStyle = BorderStyle.None;
            lvFiles.HideSelection = true;
            lvFiles.LargeImageList = iconList;
            lvFiles.Location = new Point(0, 126);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(1006, 277);
            lvFiles.SmallImageList = iconList;
            lvFiles.Sorting = SortOrder.Ascending;
            lvFiles.TabIndex = 2;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.MouseDoubleClick += LvFiles_MouseDoubleClick;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Gainsboro;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.FillColor = Color.WhiteSmoke;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.ShadowColor = Color.Black;
            pnlTop.ShadowShift = 1;
            pnlTop.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            pnlTop.Size = new Size(1006, 67);
            pnlTop.TabIndex = 3;
            // 
            // pnlBot
            // 
            pnlBot.BackColor = Color.Gainsboro;
            pnlBot.Dock = DockStyle.Bottom;
            pnlBot.FillColor = Color.WhiteSmoke;
            pnlBot.Location = new Point(0, 409);
            pnlBot.Name = "pnlBot";
            pnlBot.ShadowColor = Color.Black;
            pnlBot.ShadowShift = 2;
            pnlBot.Size = new Size(1006, 67);
            pnlBot.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 164, 96);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnBack.IconColor = Color.White;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 25;
            btnBack.Location = new Point(12, 73);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(35, 30);
            btnBack.TabIndex = 4;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.MouseEnter += BtnBackAndGo_MouseEnter;
            btnBack.MouseLeave += BtnBackAndGo_MouseLeave;
            btnBack.MouseHover += BtnBackAndGo_MouseHover;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(0, 164, 96);
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btnGo.IconColor = Color.White;
            btnGo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGo.IconSize = 25;
            btnGo.Location = new Point(58, 73);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(35, 30);
            btnGo.TabIndex = 5;
            btnGo.UseVisualStyleBackColor = false;
            btnGo.MouseEnter += BtnBackAndGo_MouseEnter;
            btnGo.MouseLeave += BtnBackAndGo_MouseLeave;
            btnGo.MouseHover += BtnBackAndGo_MouseHover;
            // 
            // bntBackElipse
            // 
            bntBackElipse.TargetControl = btnBack;
            // 
            // btnGoElipse
            // 
            btnGoElipse.TargetControl = btnGo;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 476);
            ControlBox = false;
            Controls.Add(btnGo);
            Controls.Add(btnBack);
            Controls.Add(pnlBot);
            Controls.Add(pnlTop);
            Controls.Add(lvFiles);
            Controls.Add(pnlShadowTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += DataForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlShadowTop;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ImageList iconList;
        private ListView lvFiles;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTop;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlBot;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnGo;
        private Guna.UI2.WinForms.Guna2Elipse bntBackElipse;
        private Guna.UI2.WinForms.Guna2Elipse btnGoElipse;
    }
}