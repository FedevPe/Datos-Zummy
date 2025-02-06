using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosZummy.Class;
using FluentFTP;

namespace DatosZummy.Forms
{
    public partial class DataForm : Form
    {
        private ZummyData data = new();
        private readonly string initialDirectory = "/";

        public DataForm()
        {
            InitializeComponent();
        }

        private async void BtnSearchData_ClickAsync(object sender, EventArgs e)
        {
            /// MEMCARD/TEMP/
            List<FtpListItem> files = new List<FtpListItem>(await data.GetFilesAsync(initialDirectory));

            TreeNode treeNode = new(initialDirectory);
            treeNode.Text = initialDirectory;
            tvData.Nodes.Add(treeNode);

            foreach (var file in files)
            {
                ListViewItem listViewItem = new(file.Name);
                listViewItem.SubItems.Add(file.Created.ToString());
                lvFiles.Items.Add(listViewItem);
            }
        }
        private async void LoadNodeFTP(TreeNode node, string path)
        {
            foreach (var item in await data.GetFilesAsync(path))
            {
                TreeNode childNode = new TreeNode(item.Name);
                childNode.Tag = item.FullName;

                node.Nodes.Add(childNode);

                if (item.Type == FtpObjectType.Directory)
                {
                    LoadNodeFTP(childNode, item.FullName);
                }
            }
        }
    }
}
