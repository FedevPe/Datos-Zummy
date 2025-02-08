using FontAwesome.Sharp;

namespace DatosZummy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlTop = new Panel();
            btnDisconnect = new IconButton();
            btnConnect = new IconButton();
            imgZummy = new PictureBox();
            pnlShadowTop = new Panel();
            pnlMain = new Panel();
            shadowMainForm = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            elipseMainForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            elpBtnConnect = new Guna.UI2.WinForms.Guna2Elipse(components);
            elpBtnDisconnect = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgZummy).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(228, 31, 39);
            pnlTop.Controls.Add(btnDisconnect);
            pnlTop.Controls.Add(btnConnect);
            pnlTop.Controls.Add(imgZummy);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1006, 98);
            pnlTop.TabIndex = 0;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.White;
            btnDisconnect.FlatAppearance.BorderSize = 0;
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisconnect.ForeColor = Color.Red;
            btnDisconnect.IconChar = IconChar.PowerOff;
            btnDisconnect.IconColor = Color.Red;
            btnDisconnect.IconFont = IconFont.Auto;
            btnDisconnect.IconSize = 27;
            btnDisconnect.Location = new Point(865, 30);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(129, 35);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Salir";
            btnDisconnect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Visible = false;
            btnDisconnect.MouseEnter += BtnConnectAndDisconect_MouseEnter;
            btnDisconnect.MouseLeave += BtnConnectAndDisconnect_MouseLeave;
            btnDisconnect.MouseHover += BtnConnectAndDisconect_MouseEnter;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.White;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.FromArgb(0, 164, 66);
            btnConnect.IconChar = IconChar.TowerBroadcast;
            btnConnect.IconColor = Color.FromArgb(0, 164, 66);
            btnConnect.IconFont = IconFont.Auto;
            btnConnect.IconSize = 27;
            btnConnect.Location = new Point(865, 30);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(129, 35);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Conectar";
            btnConnect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += BtnStartConnection_Click;
            btnConnect.MouseEnter += BtnConnectAndDisconect_MouseEnter;
            btnConnect.MouseLeave += BtnConnectAndDisconnect_MouseLeave;
            btnConnect.MouseHover += BtnConnectAndDisconect_MouseEnter;
            // 
            // imgZummy
            // 
            imgZummy.Image = (Image)resources.GetObject("imgZummy.Image");
            imgZummy.Location = new Point(3, 3);
            imgZummy.Name = "imgZummy";
            imgZummy.Size = new Size(167, 92);
            imgZummy.SizeMode = PictureBoxSizeMode.StretchImage;
            imgZummy.TabIndex = 0;
            imgZummy.TabStop = false;
            // 
            // pnlShadowTop
            // 
            pnlShadowTop.BackColor = Color.FromArgb(152, 20, 26);
            pnlShadowTop.Dock = DockStyle.Top;
            pnlShadowTop.ForeColor = SystemColors.ButtonShadow;
            pnlShadowTop.Location = new Point(0, 98);
            pnlShadowTop.Name = "pnlShadowTop";
            pnlShadowTop.Size = new Size(1006, 5);
            pnlShadowTop.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.WhiteSmoke;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 103);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1006, 476);
            pnlMain.TabIndex = 2;
            // 
            // shadowMainForm
            // 
            shadowMainForm.TargetForm = this;
            // 
            // elipseMainForm
            // 
            elipseMainForm.TargetControl = this;
            // 
            // elpBtnConnect
            // 
            elpBtnConnect.TargetControl = btnConnect;
            // 
            // elpBtnDisconnect
            // 
            elpBtnDisconnect.TargetControl = btnDisconnect;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 579);
            Controls.Add(pnlMain);
            Controls.Add(pnlShadowTop);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zummy";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgZummy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private PictureBox imgZummy;
        private Panel pnlShadowTop;
        private Panel pnlMain;
        private IconButton btnConnect;
        private IconButton btnDisconnect;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowMainForm;
        private Guna.UI2.WinForms.Guna2Elipse elipseMainForm;
        private Guna.UI2.WinForms.Guna2Elipse elpBtnConnect;
        private Guna.UI2.WinForms.Guna2Elipse elpBtnDisconnect;
    }
}
