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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlShadowTop = new Panel();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconList = new ImageList(components);
            lvFiles = new ListView();
            pnlTop = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pnlBot = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnForward = new FontAwesome.Sharp.IconButton();
            bntBackElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnGoElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            iconDropDownButton2 = new FontAwesome.Sharp.IconDropDownButton();
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
            lvFiles.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvFiles.HideSelection = true;
            lvFiles.LargeImageList = iconList;
            lvFiles.Location = new Point(0, 126);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(1006, 277);
            lvFiles.SmallImageList = iconList;
            lvFiles.Sorting = SortOrder.Ascending;
            lvFiles.TabIndex = 2;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.ItemSelectionChanged += LvFiles_ItemSelectionChanged;
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
            pnlBot.FillColor = Color.WhiteSmoke;
            pnlBot.Location = new Point(-11, 409);
            pnlBot.Name = "pnlBot";
            pnlBot.ShadowColor = Color.Black;
            pnlBot.ShadowShift = 2;
            pnlBot.Size = new Size(1026, 76);
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
            btnBack.Click += btnBack_Click;
            btnBack.MouseEnter += BtnBackAndGo_MouseEnter;
            btnBack.MouseLeave += BtnBackAndGo_MouseLeave;
            btnBack.MouseHover += BtnBackAndGo_MouseHover;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.FromArgb(0, 164, 96);
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btnForward.IconColor = Color.White;
            btnForward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnForward.IconSize = 25;
            btnForward.Location = new Point(58, 73);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(35, 30);
            btnForward.TabIndex = 5;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            btnForward.MouseEnter += BtnBackAndGo_MouseEnter;
            btnForward.MouseLeave += BtnBackAndGo_MouseLeave;
            btnForward.MouseHover += BtnBackAndGo_MouseHover;
            // 
            // bntBackElipse
            // 
            bntBackElipse.TargetControl = btnBack;
            // 
            // btnGoElipse
            // 
            btnGoElipse.TargetControl = btnForward;
            // 
            // txtPath
            // 
            txtPath.BorderColor = Color.Gainsboro;
            txtPath.BorderRadius = 6;
            txtPath.CustomizableEdges = customizableEdges1;
            txtPath.DefaultText = "";
            txtPath.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPath.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPath.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPath.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPath.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPath.ForeColor = Color.Black;
            txtPath.Location = new Point(100, 74);
            txtPath.Margin = new Padding(4);
            txtPath.Name = "txtPath";
            txtPath.PasswordChar = '\0';
            txtPath.PlaceholderForeColor = Color.Black;
            txtPath.PlaceholderText = "";
            txtPath.ReadOnly = true;
            txtPath.SelectedText = "";
            txtPath.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPath.Size = new Size(520, 29);
            txtPath.TabIndex = 6;
            // 
            // iconDropDownButton2
            // 
            iconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton2.IconColor = Color.Black;
            iconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton2.Name = "iconDropDownButton2";
            iconDropDownButton2.Size = new Size(23, 23);
            iconDropDownButton2.Text = "iconDropDownButton2";
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 476);
            ControlBox = false;
            Controls.Add(txtPath);
            Controls.Add(btnForward);
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
        private FontAwesome.Sharp.IconButton btnForward;
        private Guna.UI2.WinForms.Guna2Elipse bntBackElipse;
        private Guna.UI2.WinForms.Guna2Elipse btnGoElipse;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton2;
    }
}