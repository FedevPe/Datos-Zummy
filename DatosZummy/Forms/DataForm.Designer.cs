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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlShadowTop = new Panel();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconList = new ImageList(components);
            lvFiles = new ListView();
            pnlTop = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pnlBot = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnFolderDialog = new FontAwesome.Sharp.IconButton();
            btnDownload = new FontAwesome.Sharp.IconButton();
            txtPathDownload = new Guna.UI2.WinForms.Guna2TextBox();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnForward = new FontAwesome.Sharp.IconButton();
            bntBackElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnGoElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            iconDropDownButton2 = new FontAwesome.Sharp.IconDropDownButton();
            fdPathLocalDownload = new FolderBrowserDialog();
            elpBtnDownload = new Guna.UI2.WinForms.Guna2Elipse(components);
            elpBtnFolderDialog = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlBot.SuspendLayout();
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
            iconList.Images.SetKeyName(1, "excel.png");
            iconList.Images.SetKeyName(2, "csvIcon.png");
            iconList.Images.SetKeyName(3, "doc.png");
            iconList.Images.SetKeyName(4, "archivoDesconocido.png");
            // 
            // lvFiles
            // 
            lvFiles.BorderStyle = BorderStyle.None;
            lvFiles.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvFiles.HideSelection = true;
            lvFiles.LargeImageList = iconList;
            lvFiles.Location = new Point(12, 126);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(982, 277);
            lvFiles.SmallImageList = iconList;
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
            pnlBot.Controls.Add(btnFolderDialog);
            pnlBot.Controls.Add(btnDownload);
            pnlBot.Controls.Add(txtPathDownload);
            pnlBot.FillColor = Color.WhiteSmoke;
            pnlBot.Location = new Point(-11, 409);
            pnlBot.Name = "pnlBot";
            pnlBot.ShadowColor = Color.Black;
            pnlBot.ShadowShift = 2;
            pnlBot.Size = new Size(1026, 76);
            pnlBot.TabIndex = 0;
            // 
            // btnFolderDialog
            // 
            btnFolderDialog.BackColor = Color.FromArgb(255, 235, 0);
            btnFolderDialog.FlatAppearance.BorderSize = 0;
            btnFolderDialog.FlatStyle = FlatStyle.Flat;
            btnFolderDialog.Font = new Font("Century Gothic", 9.75F);
            btnFolderDialog.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnFolderDialog.IconColor = Color.Black;
            btnFolderDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFolderDialog.IconSize = 25;
            btnFolderDialog.Location = new Point(846, 11);
            btnFolderDialog.Name = "btnFolderDialog";
            btnFolderDialog.Size = new Size(38, 39);
            btnFolderDialog.TabIndex = 9;
            btnFolderDialog.UseVisualStyleBackColor = false;
            btnFolderDialog.Click += btnFolderDialog_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(0, 164, 96);
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Century Gothic", 9.75F);
            btnDownload.ForeColor = Color.White;
            btnDownload.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnDownload.IconColor = Color.White;
            btnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDownload.IconSize = 30;
            btnDownload.Location = new Point(891, 11);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(114, 39);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "Descargar";
            btnDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += BtnDownload_Click;
            btnDownload.MouseEnter += BtnBackAndGo_MouseEnter;
            btnDownload.MouseLeave += BtnBackAndGo_MouseLeave;
            btnDownload.MouseHover += BtnBackAndGo_MouseHover;
            // 
            // txtPathDownload
            // 
            txtPathDownload.BackColor = Color.Transparent;
            txtPathDownload.BorderColor = Color.Gainsboro;
            txtPathDownload.BorderRadius = 6;
            txtPathDownload.CustomizableEdges = customizableEdges1;
            txtPathDownload.DefaultText = "";
            txtPathDownload.DisabledState.BorderColor = Color.Gainsboro;
            txtPathDownload.DisabledState.FillColor = Color.White;
            txtPathDownload.DisabledState.ForeColor = Color.Black;
            txtPathDownload.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPathDownload.Enabled = false;
            txtPathDownload.FocusedState.BorderColor = Color.FromArgb(0, 164, 96);
            txtPathDownload.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPathDownload.ForeColor = Color.Black;
            txtPathDownload.Location = new Point(382, 12);
            txtPathDownload.Margin = new Padding(5);
            txtPathDownload.Name = "txtPathDownload";
            txtPathDownload.PasswordChar = '\0';
            txtPathDownload.PlaceholderForeColor = Color.Gainsboro;
            txtPathDownload.PlaceholderText = "Selecciona una carpeta";
            txtPathDownload.ReadOnly = true;
            txtPathDownload.SelectedText = "";
            txtPathDownload.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPathDownload.Size = new Size(502, 38);
            txtPathDownload.TabIndex = 7;
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
            btnBack.Click += BtnBack_Click;
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
            btnForward.Click += BtnForward_Click;
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
            txtPath.CustomizableEdges = customizableEdges3;
            txtPath.DefaultText = "";
            txtPath.DisabledState.BorderColor = Color.Gainsboro;
            txtPath.DisabledState.FillColor = Color.White;
            txtPath.DisabledState.ForeColor = Color.Black;
            txtPath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPath.FocusedState.BorderColor = Color.FromArgb(0, 164, 96);
            txtPath.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPath.ForeColor = Color.Black;
            txtPath.Location = new Point(101, 73);
            txtPath.Margin = new Padding(5);
            txtPath.Name = "txtPath";
            txtPath.PasswordChar = '\0';
            txtPath.PlaceholderForeColor = Color.Black;
            txtPath.PlaceholderText = "";
            txtPath.ReadOnly = true;
            txtPath.SelectedText = "";
            txtPath.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPath.Size = new Size(594, 30);
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
            // elpBtnDownload
            // 
            elpBtnDownload.TargetControl = btnDownload;
            // 
            // elpBtnFolderDialog
            // 
            elpBtnFolderDialog.TargetControl = btnFolderDialog;
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
            pnlBot.ResumeLayout(false);
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
        private FolderBrowserDialog fdPathLocalDownload;
        private FontAwesome.Sharp.IconButton btnFolderDialog;
        private FontAwesome.Sharp.IconButton btnDownload;
        private Guna.UI2.WinForms.Guna2TextBox txtPathDownload;
        private Guna.UI2.WinForms.Guna2Elipse elpBtnDownload;
        private Guna.UI2.WinForms.Guna2Elipse elpBtnFolderDialog;
    }
}