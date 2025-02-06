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
            btnCloseConnection = new IconButton();
            btnStartConnection = new IconButton();
            imgZummy = new PictureBox();
            pnlShadowTop = new Panel();
            pnlMain = new Panel();
            shadowMainForm = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            elipseMainForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgZummy).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(228, 31, 39);
            pnlTop.Controls.Add(btnCloseConnection);
            pnlTop.Controls.Add(btnStartConnection);
            pnlTop.Controls.Add(imgZummy);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1006, 98);
            pnlTop.TabIndex = 0;
            // 
            // btnCloseConnection
            // 
            btnCloseConnection.FlatAppearance.BorderSize = 0;
            btnCloseConnection.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseConnection.ForeColor = Color.Red;
            btnCloseConnection.IconChar = IconChar.PowerOff;
            btnCloseConnection.IconColor = Color.Red;
            btnCloseConnection.IconFont = IconFont.Auto;
            btnCloseConnection.IconSize = 27;
            btnCloseConnection.Location = new Point(865, 29);
            btnCloseConnection.Name = "btnCloseConnection";
            btnCloseConnection.Size = new Size(129, 35);
            btnCloseConnection.TabIndex = 3;
            btnCloseConnection.Text = "Salir";
            btnCloseConnection.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCloseConnection.UseVisualStyleBackColor = true;
            btnCloseConnection.Visible = false;
            // 
            // btnStartConnection
            // 
            btnStartConnection.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartConnection.ForeColor = Color.FromArgb(0, 164, 66);
            btnStartConnection.IconChar = IconChar.TowerBroadcast;
            btnStartConnection.IconColor = Color.FromArgb(0, 164, 66);
            btnStartConnection.IconFont = IconFont.Auto;
            btnStartConnection.IconSize = 27;
            btnStartConnection.Location = new Point(865, 30);
            btnStartConnection.Name = "btnStartConnection";
            btnStartConnection.Size = new Size(129, 35);
            btnStartConnection.TabIndex = 2;
            btnStartConnection.Text = "Conectar";
            btnStartConnection.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStartConnection.UseVisualStyleBackColor = true;
            btnStartConnection.Click += BtnStartConnection_Click;
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
        private IconButton btnStartConnection;
        private IconButton btnCloseConnection;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowMainForm;
        private Guna.UI2.WinForms.Guna2Elipse elipseMainForm;
    }
}
