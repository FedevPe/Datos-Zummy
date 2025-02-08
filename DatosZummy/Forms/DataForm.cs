using DatosZummy.Classes;
using FluentFTP;

namespace DatosZummy.Forms
{
    public partial class DataForm : Form
    {
        private ZummyData data = new();
        private readonly string initialPath = "/";
        private FtpListItem currentItem = new();
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
            currentItem.FullName = initialPath;
        }
        private async void LvFiles_MouseDoubleClick(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems[0].ImageIndex == 0)
            {
                backStackPath.Push(currentItem.FullName);
                currentItem = (FtpListItem)lvFiles.SelectedItems[0].Tag;
                forwardStackPath.Clear();
                await LoadFilesAndDirectories(currentItem.FullName);
                EnableNavegationBottons();
                txtPath.Text = "";
                txtPath.Text = currentItem.FullName;
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
                    ListViewItem itemLv = new ListViewItem(item.Name);

                    if (item.Type == FtpObjectType.Directory)
                    {
                        itemLv.ImageIndex = 0;
                        itemLv.Tag = item;
                    }
                    else
                    {
                        itemLv.ImageIndex = GetImageIndexForExtension(Path.GetExtension(item.Name));
                        itemLv.Tag = item;
                    }

                    lvFiles.Items.Add(itemLv);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar cargar los archivos.",
                "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetImageIndexForExtension(string extension)
        {
            switch (extension)
            {
                case ".csv":
                    return 3;
                case ".xlsx":
                    return 2;
                case ".docx":
                    return 4;
                default:
                    return 0;
            }
        }
        private async void BtnBack_Click(object sender, EventArgs e)
        {
            if (backStackPath.Count > 0)
            {
                forwardStackPath.Push(currentItem.FullName);
                currentItem.FullName = backStackPath.Pop();
                await LoadFilesAndDirectories(currentItem.FullName);
                EnableNavegationBottons();
                txtPath.Text = "";
                txtPath.Text = currentItem.FullName;
            }
        }
        private async void BtnForward_Click(object sender, EventArgs e)
        {
            if (forwardStackPath.Count > 0)
            {
                backStackPath.Push(currentItem.FullName);
                currentItem.FullName = forwardStackPath.Pop();
                await LoadFilesAndDirectories(currentItem.FullName);
                EnableNavegationBottons();
                txtPath.Text = "";
                txtPath.Text = currentItem.FullName;
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
