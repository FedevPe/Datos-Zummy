using System.Runtime.InteropServices;
using DatosZummy.Class;
using FluentFTP;

namespace DatosZummy.Forms
{
    public partial class DataForm : Form
    {
        private ZummyData data = new();
        private readonly string initialPath = "/";
        private string currentlyItemSelected;
        private List<FtpListItem> files;
        private List<FtpListItem> directories;

        public DataForm()
        {
            InitializeComponent();
        }
        private async void DataForm_Load(object sender, EventArgs e)
        {
            await LoadDirectories(initialPath);
        }

        private void BtnSearchData_Click(object sender, EventArgs e)
        {

        }
        public async Task LoadDirectories(string path)
        {
            lvFiles.Items.Clear();
            try
            {
                List<FtpListItem> directories = new List<FtpListItem>(await data.GetDirectoriesAsync(path));
                foreach (var directory in directories)
                {
                    lvFiles.Items.Add(directory.Name, 0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar cargar los archivos.",
                "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task LoadFiles(string path)
        {
            lvFiles.Items.Clear();
            try
            {
                List<FtpListItem> files = new List<FtpListItem>(await data.GetFilesAsync(path));

                foreach (var file in files)
                {
                    lvFiles.Items.Add(file.Name, 1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar cargar los archivos.",
                "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
