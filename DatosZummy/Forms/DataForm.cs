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
        private List<string> itemsSelectedPath = new List<string>();
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

                foreach (var item in filesAndDirectories
                    .Where(i => i.Type == FtpObjectType.Directory)
                    .OrderBy(i => i.Name))
                {
                    ListViewItem itemLv = new ListViewItem(item.Name);
                    itemLv.ImageIndex = 0;
                    itemLv.Tag = item;
                    lvFiles.Items.Add(itemLv);
                }
                foreach (var item in filesAndDirectories
                    .Where(i => i.Type == FtpObjectType.File)
                    .OrderBy(i => i.Name))
                {
                    ListViewItem itemLv = new ListViewItem(item.Name);
                    itemLv.ImageIndex = GetImageIndexForExtension(Path.GetExtension(item.FullName));
                    itemLv.Tag = item;
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
                case ".xlsx":
                    return 1;
                case ".csv":
                    return 2;
                case ".docx":
                    return 3;
                default:
                    return 4;
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
            btn.ForeColor = Color.FromArgb(0, 164, 96);
            btn.BackColor = Color.White;
        }
        private void BtnBackAndGo_MouseLeave(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.IconColor = Color.White;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(0, 164, 96);
        }
        private void BtnBackAndGo_MouseHover(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton btn = (FontAwesome.Sharp.IconButton)sender;
            btn.IconColor = Color.FromArgb(0, 164, 96);
            btn.ForeColor = Color.FromArgb(0, 164, 96);
            btn.BackColor = Color.White;
        }

        private void LvFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvFiles.SelectedItems.Count > 0)
            {
                itemsSelectedPath.Clear();
                foreach (ListViewItem item in lvFiles.SelectedItems)
                {
                    FtpListItem itemFtp = (FtpListItem)item.Tag;
                    if (itemFtp.Type == FtpObjectType.File)
                    {
                        itemsSelectedPath.Add(itemFtp.FullName);
                    }
                }
            }
        }
        private void btnFolderDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = fdPathLocalDownload.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPathDownload.Text = fdPathLocalDownload.SelectedPath;
            }
        }
        //private void LvFiles_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int count = 0;
        //    try
        //    {
        //        foreach (FtpListItem item in lvFiles.SelectedItems)
        //        {
        //            if(item.Type == FtpObjectType.File)
        //            {
        //                count++;
        //                selectedItem = item;
        //            }
        //        }
        //        if (count == lvFiles.SelectedItems.Count)
        //        {
        //            //Descargar los archivos, pasan
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show($"Ha ocurrido un problema al intentar descargar el archivo. ({selectedItem.Name})",
        //        "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
