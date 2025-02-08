using DatosZummy.Classes;
using FluentFTP;

namespace DatosZummy.Forms
{
    public partial class DataForm : Form
    {
        private ZummyData data = new();
        private readonly string initialPath = "/";
        private string currentPath;
        private Stack<string> backStackPath = new Stack<string>();
        private Stack<string> forwardStackPath = new Stack<string>();

        public DataForm()
        {
            InitializeComponent();
        }
        private async void DataForm_Load(object sender, EventArgs e)
        {
            await LoadFilesAndDirectories(initialPath);
            btnBack.Enabled = false;
            btnForward.Enabled = false;
            txtPath.Text = initialPath;
            txtPath.Enabled = false;
        }
        private async void LvFiles_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems[0].ImageIndex == 0)
            {
                backStackPath.Push(initialPath);
                currentPath = initialPath + lvFiles.SelectedItems[0].Text;
                forwardStackPath.Clear();
                await LoadFilesAndDirectories(currentPath);
                EnableNavegationBottons();
                txtPath.Text = currentPath;
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
        private async void btnBack_Click(object sender, EventArgs e)
        {
            if (backStackPath.Count > 0)
            {
                forwardStackPath.Push(currentPath);
                currentPath = backStackPath.Pop();
                await LoadFilesAndDirectories(currentPath);
                EnableNavegationBottons();
                txtPath.Text = currentPath;
            }
        }
        private async void btnForward_Click(object sender, EventArgs e)
        {
            if (forwardStackPath.Count > 0)
            {
                backStackPath.Push(currentPath);
                currentPath = forwardStackPath.Pop();
                await LoadFilesAndDirectories(currentPath);
                EnableNavegationBottons();
                txtPath.Text = currentPath;
            }
        }
        private void EnableNavegationBottons()
        {
            btnBack.Enabled = backStackPath.Count > 0;
            btnForward.Enabled = forwardStackPath.Count > 0;
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

        private void LvFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
    }
}
