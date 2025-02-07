using DatosZummy.Classes;
using FluentFTP;

namespace DatosZummy.Forms
{
    public partial class DataForm : Form
    {
        private ZummyData data = new();
        private readonly string initialPath = "/";
        private string currentlyItemSelected;

        public DataForm()
        {
            InitializeComponent();
        }
        private async void DataForm_Load(object sender, EventArgs e)
        {
            await LoadFilesAndDirectories(initialPath);
        }
        private async void LvFiles_MouseDoubleClick(object sender, EventArgs e)
        {
            currentlyItemSelected = lvFiles.SelectedItems[0].Text;

            if (lvFiles.SelectedItems[0].ImageIndex == 0)
            {
                await LoadFilesAndDirectories(initialPath + currentlyItemSelected);
            }
        }
        public async Task LoadFilesAndDirectories(string path)
        {
            lvFiles.Items.Clear();
            try
            {
                List<FtpListItem> filesAndDirectories = new List<FtpListItem>(await data.GetListingAsync(path));
                foreach (var item in filesAndDirectories)
                {
                    if (item.Type == FtpObjectType.Directory)
                    {
                        lvFiles.Items.Add("directory", item.Name, 0);
                    }
                    else
                    {
                        lvFiles.Items.Add("file", item.Name, 1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar cargar los archivos.",
                "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackAndGo_MouseEnter(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.IconColor = Color.FromArgb(0, 164, 96);
            btn.BackColor = Color.White;
        }
        private void BtnBackAndGo_MouseLeave(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.IconColor = Color.White;
            btn.BackColor = Color.FromArgb(0, 164, 96);
        }
        private void BtnBackAndGo_MouseHover(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.IconColor = Color.FromArgb(0, 164, 96);
            btn.BackColor = Color.White;
        }
    }
}
