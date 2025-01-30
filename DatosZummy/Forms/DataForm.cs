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
        
        public DataForm()
        {
            InitializeComponent();
        }

        private async void BtnSearchData_ClickAsync(object sender, EventArgs e)
        {
            /// MEMCARD / TEMP /
            List<FtpListItem> files = new List<FtpListItem>(await data.GetFilesAsync("/MEMCARD/TEMP/"));
            lvFiles.Items.Clear();

            foreach (var file in files)
            {
                ListViewItem listViewItem = new(file.Name);
                listViewItem.SubItems.Add(file.Created.ToString());
                lvFiles.Items.Add(listViewItem);
            }
        }
    }
}
