using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.People
{
    partial class ManagePeopleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private IconGlyph iconTitle;
        private Button btnAddNewPerson;
        private Button btnFindPerson;
        private DataGridView dgvPeopleList;
        private Label lblRecords;
        private Label lblRecordsCountValue;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Label();
            this.iconTitle = new IconGlyph();
            this.btnAddNewPerson = new Button();
            this.btnFindPerson = new Button();
            this.dgvPeopleList = new DataGridView();
            this.lblRecords = new Label();
            this.lblRecordsCountValue = new Label();
            this.btnClose = new Button();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new ToolStripMenuItem();
            this.deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.SuspendLayout();
            //
            // iconTitle
            //
            this.iconTitle.Icon = IconKind.People;
            this.iconTitle.Tint = AppTheme.Accent;
            this.iconTitle.Location = new Point(24, 22);
            this.iconTitle.Size = new Size(32, 32);
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(64, 22);
            this.lblTitle.Text = "Manage People";
            //
            // btnFindPerson
            //
            AppTheme.ApplySecondaryButton(this.btnFindPerson);
            this.btnFindPerson.Location = new Point(900, 22);
            this.btnFindPerson.Size = new Size(130, 34);
            this.btnFindPerson.Text = "Find Person";
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            //
            // btnAddNewPerson
            //
            AppTheme.ApplyPrimaryButton(this.btnAddNewPerson);
            this.btnAddNewPerson.Location = new Point(1040, 22);
            this.btnAddNewPerson.Size = new Size(150, 34);
            this.btnAddNewPerson.Text = "+ Add New Person";
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            //
            // dgvPeopleList
            //
            this.dgvPeopleList.Location = new Point(24, 76);
            this.dgvPeopleList.Size = new Size(1166, 420);
            this.dgvPeopleList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeopleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeopleList.DoubleClick += new System.EventHandler(this.dgvPeopleList_DoubleClick);
            AppTheme.StyleGrid(this.dgvPeopleList);
            //
            // lblRecords
            //
            this.lblRecords.AutoSize = true;
            AppTheme.ApplyCaption(this.lblRecords);
            this.lblRecords.Location = new Point(24, 508);
            this.lblRecords.Text = "Records:";
            //
            // lblRecordsCountValue
            //
            this.lblRecordsCountValue.AutoSize = true;
            AppTheme.ApplyValue(this.lblRecordsCountValue);
            this.lblRecordsCountValue.Location = new Point(90, 508);
            this.lblRecordsCountValue.Text = "0";
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(1090, 500);
            this.btnClose.Size = new Size(100, 36);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
                this.showDetailsToolStripMenuItem, this.deleteToolStripMenuItem });
            //
            // showDetailsToolStripMenuItem
            //
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            //
            // deleteToolStripMenuItem
            //
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            //
            // ManagePeopleForm
            //
            this.ClientSize = new Size(1214, 560);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvPeopleList);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.iconTitle);
            this.CancelButton = this.btnClose;
            this.Text = "Manage People";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
