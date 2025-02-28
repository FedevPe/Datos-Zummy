using DatosZummy.Classes;
using DatosZummy.Forms;
using System.Net.NetworkInformation;

namespace DatosZummy
{
    public partial class MainForm : Form
    {
        private ServerConnection connection = new();
        private ZummyData zummyData = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnStartConnection_Click(object sender, EventArgs e)
        {
            if (await connection.ConnectAsync())
            {
                OpenForm(new DataForm());
                btnConnect.Enabled = false;
                btnConnect.Visible = false;
                btnDisconnect.Enabled = true;
                btnDisconnect.Visible = true;
            }
            else
            {
                MessageBox.Show(connection.Ex?.Message ?? "Error desconocido al intentar conectarse al servidor.");
                //MessageBox.Show("Ha ocurrido un problema al intentar establecer la conexión con el servidor.",
                //    "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnConnectAndDisconect_MouseEnter(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;

            if (btn.Text == "Conectar")
            {
                btn.IconColor = Color.White;
                btn.BackColor = Color.FromArgb(0, 164, 66);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.IconColor = Color.White;
                btn.BackColor = Color.FromArgb(255, 155, 100);
                btn.ForeColor = Color.White;
            }
        }
        private void BtnConnectAndDisconnect_MouseLeave(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;

            if (btn.Text == "Conectar")
            {
                btn.IconColor = Color.FromArgb(0, 164, 66);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(0, 164, 66);
            }
            else
            {
                btn.IconColor = Color.Red;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Red;
            }
        }
        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            form.Show();
            form.BringToFront();
            form.Focus();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
