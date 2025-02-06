namespace DatosZummy.Forms
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDates = new Panel();
            btnSearchData = new FontAwesome.Sharp.IconButton();
            dtpFinal = new DateTimePicker();
            dtpInitial = new DateTimePicker();
            lblFinishDate = new Label();
            lblInitialDate = new Label();
            pnlShadow = new Panel();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            lvFiles = new ListView();
            nameFile = new ColumnHeader();
            dateFile = new ColumnHeader();
            tvData = new TreeView();
            pnlDates.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDates
            // 
            pnlDates.BackColor = Color.WhiteSmoke;
            pnlDates.Controls.Add(btnSearchData);
            pnlDates.Controls.Add(dtpFinal);
            pnlDates.Controls.Add(dtpInitial);
            pnlDates.Controls.Add(lblFinishDate);
            pnlDates.Controls.Add(lblInitialDate);
            pnlDates.Dock = DockStyle.Top;
            pnlDates.Location = new Point(0, 0);
            pnlDates.Name = "pnlDates";
            pnlDates.Size = new Size(1006, 54);
            pnlDates.TabIndex = 0;
            // 
            // btnSearchData
            // 
            btnSearchData.AutoEllipsis = true;
            btnSearchData.BackColor = SystemColors.Window;
            btnSearchData.FlatAppearance.BorderColor = Color.DarkGray;
            btnSearchData.FlatAppearance.BorderSize = 2;
            btnSearchData.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchData.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearchData.IconColor = Color.Black;
            btnSearchData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchData.IconSize = 27;
            btnSearchData.Location = new Point(859, 10);
            btnSearchData.Name = "btnSearchData";
            btnSearchData.Size = new Size(135, 37);
            btnSearchData.TabIndex = 4;
            btnSearchData.Text = "Buscar datos";
            btnSearchData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchData.UseVisualStyleBackColor = false;
            btnSearchData.Click += BtnSearchData_ClickAsync;
            // 
            // dtpFinal
            // 
            dtpFinal.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            dtpFinal.Font = new Font("Century Gothic", 9F);
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(347, 17);
            dtpFinal.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpFinal.MinDate = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(123, 22);
            dtpFinal.TabIndex = 3;
            dtpFinal.Value = new DateTime(2025, 1, 30, 0, 0, 0, 0);
            // 
            // dtpInitial
            // 
            dtpInitial.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            dtpInitial.CustomFormat = "";
            dtpInitial.Font = new Font("Century Gothic", 9F);
            dtpInitial.Format = DateTimePickerFormat.Short;
            dtpInitial.Location = new Point(133, 17);
            dtpInitial.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpInitial.MinDate = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            dtpInitial.Name = "dtpInitial";
            dtpInitial.Size = new Size(123, 22);
            dtpInitial.TabIndex = 2;
            dtpInitial.Value = new DateTime(2025, 1, 30, 0, 0, 0, 0);
            // 
            // lblFinishDate
            // 
            lblFinishDate.AutoSize = true;
            lblFinishDate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            lblFinishDate.Location = new Point(262, 20);
            lblFinishDate.Name = "lblFinishDate";
            lblFinishDate.Size = new Size(79, 16);
            lblFinishDate.TabIndex = 1;
            lblFinishDate.Text = "Fecha final";
            // 
            // lblInitialDate
            // 
            lblInitialDate.AutoSize = true;
            lblInitialDate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            lblInitialDate.Location = new Point(31, 20);
            lblInitialDate.Name = "lblInitialDate";
            lblInitialDate.Size = new Size(91, 16);
            lblInitialDate.TabIndex = 0;
            lblInitialDate.Text = "Fecha Inicial";
            // 
            // pnlShadow
            // 
            pnlShadow.BackColor = Color.Gainsboro;
            pnlShadow.Location = new Point(0, 54);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(1006, 5);
            pnlShadow.TabIndex = 1;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // lvFiles
            // 
            lvFiles.Columns.AddRange(new ColumnHeader[] { nameFile, dateFile });
            lvFiles.Location = new Point(12, 65);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(412, 399);
            lvFiles.TabIndex = 2;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.List;
            // 
            // nameFile
            // 
            nameFile.Text = "Nombre";
            // 
            // dateFile
            // 
            dateFile.Text = "Fecha";
            // 
            // trvData
            // 
            tvData.Location = new Point(430, 65);
            tvData.Name = "trvData";
            tvData.Size = new Size(564, 399);
            tvData.TabIndex = 3;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 476);
            ControlBox = false;
            Controls.Add(tvData);
            Controls.Add(lvFiles);
            Controls.Add(pnlDates);
            Controls.Add(pnlShadow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            pnlDates.ResumeLayout(false);
            pnlDates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDates;
        private Panel pnlShadow;
        private Label lblFinishDate;
        private Label lblInitialDate;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInitial;
        private FontAwesome.Sharp.IconButton btnSearchData;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ListView lvFiles;
        private ColumnHeader nameFile;
        private ColumnHeader dateFile;
        private TreeView tvData;
    }
}