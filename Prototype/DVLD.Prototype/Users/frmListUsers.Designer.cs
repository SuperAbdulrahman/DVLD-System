using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Users
{
    partial class frmListUsers
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private IconGlyph iconTitle;
        private Button btnAddNewUser;
        private DataGridView dgvUsersList;
        private Label lblRecords;
        private Label lblRecordsCountValue;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
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
            this.btnAddNewUser = new Button();
            this.dgvUsersList = new DataGridView();
            this.lblRecords = new Label();
            this.lblRecordsCountValue = new Label();
            this.btnClose = new Button();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.SuspendLayout();
            //
            // iconTitle
            //
            this.iconTitle.Icon = IconKind.Lock;
            this.iconTitle.Tint = AppTheme.Accent;
            this.iconTitle.Location = new Point(24, 22);
            this.iconTitle.Size = new Size(32, 32);
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(64, 22);
            this.lblTitle.Text = "Manage Users";
            //
            // btnAddNewUser
            //
            AppTheme.ApplyPrimaryButton(this.btnAddNewUser);
            this.btnAddNewUser.Location = new Point(730, 22);
            this.btnAddNewUser.Size = new Size(150, 34);
            this.btnAddNewUser.Text = "+ Add New User";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            //
            // dgvUsersList
            //
            this.dgvUsersList.Location = new Point(24, 76);
            this.dgvUsersList.Size = new Size(856, 380);
            this.dgvUsersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppTheme.StyleGrid(this.dgvUsersList);
            //
            // lblRecords
            //
            this.lblRecords.AutoSize = true;
            AppTheme.ApplyCaption(this.lblRecords);
            this.lblRecords.Location = new Point(24, 468);
            this.lblRecords.Text = "Records:";
            //
            // lblRecordsCountValue
            //
            this.lblRecordsCountValue.AutoSize = true;
            AppTheme.ApplyValue(this.lblRecordsCountValue);
            this.lblRecordsCountValue.Location = new Point(90, 468);
            this.lblRecordsCountValue.Text = "0";
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(780, 460);
            this.btnClose.Size = new Size(100, 36);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.deleteToolStripMenuItem });
            //
            // deleteToolStripMenuItem
            //
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            //
            // frmListUsers
            //
            this.ClientSize = new Size(904, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.iconTitle);
            this.CancelButton = this.btnClose;
            this.Text = "Manage Users";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
