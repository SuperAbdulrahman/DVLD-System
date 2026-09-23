using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.ApplicationTypes
{
    partial class frmManageApplicationTypes
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private IconGlyph iconTitle;
        private DataGridView dgvApplicationTypes;
        private Label lblRecords;
        private Label lblRecordsCountValue;
        private Button btnSimulateFailure;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;

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
            this.dgvApplicationTypes = new DataGridView();
            this.lblRecords = new Label();
            this.lblRecordsCountValue = new Label();
            this.btnSimulateFailure = new Button();
            this.btnClose = new Button();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.SuspendLayout();
            //
            // iconTitle
            //
            this.iconTitle.Icon = IconKind.IdCard;
            this.iconTitle.Tint = AppTheme.Accent;
            this.iconTitle.Location = new Point(24, 22);
            this.iconTitle.Size = new Size(32, 32);
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(64, 22);
            this.lblTitle.Text = "Manage Application Types";
            //
            // dgvApplicationTypes
            //
            this.dgvApplicationTypes.Location = new Point(24, 76);
            this.dgvApplicationTypes.Size = new Size(700, 380);
            this.dgvApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppTheme.StyleGrid(this.dgvApplicationTypes);
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
            // btnSimulateFailure
            //
            AppTheme.ApplyDangerButton(this.btnSimulateFailure);
            this.btnSimulateFailure.Location = new Point(494, 460);
            this.btnSimulateFailure.Size = new Size(230, 36);
            this.btnSimulateFailure.Text = "Simulate Save Failure";
            this.btnSimulateFailure.Click += new System.EventHandler(this.btnSimulateFailure_Click);
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(624, 22);
            this.btnClose.Size = new Size(100, 34);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.editToolStripMenuItem });
            //
            // editToolStripMenuItem
            //
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            //
            // frmManageApplicationTypes
            //
            this.ClientSize = new Size(748, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSimulateFailure);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.iconTitle);
            this.CancelButton = this.btnClose;
            this.Text = "Manage Application Types";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
