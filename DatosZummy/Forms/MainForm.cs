using DatosZummy.Classes;
using DatosZummy.Forms;

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
            //OpenForm(new DataForm());
            //btnStartConnection.Enabled = false;
            //btnStartConnection.Visible = false;
            //btnCloseConnection.Enabled = true;
            //btnCloseConnection.Visible = true;

            
            if (await connection.ConnectAsync())
            {
                OpenForm(new DataForm());
                btnStartConnection.Enabled = false;
                btnStartConnection.Visible = false;
                btnCloseConnection.Enabled = true;
                btnCloseConnection.Visible = true;
            }
            else
            {
                MessageBox.Show(connection.Ex.Message);
                //MessageBox.Show("Ha ocurrido un problema al intentar establecer la conexión con el servidor.",
                //    "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
