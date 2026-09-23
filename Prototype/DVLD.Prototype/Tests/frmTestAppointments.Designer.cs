using System.Drawing;
using System.Windows.Forms;
using DVLD.Prototype.Common;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Tests
{
    partial class frmTestAppointments
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private IconGlyph iconTitle;
        private Button btnAddNewTestAppointment;
        private DataGridView dgvAppointmentsList;
        private Label lblRecords;
        private Label lblRecordsCountValue;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem takeTestToolStripMenuItem;

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
            this.btnAddNewTestAppointment = new Button();
            this.dgvAppointmentsList = new DataGridView();
            this.lblRecords = new Label();
            this.lblRecordsCountValue = new Label();
            this.btnClose = new Button();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.takeTestToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).BeginInit();
            this.SuspendLayout();
            //
            // iconTitle
            //
            this.iconTitle.Icon = IconKind.Test;
            this.iconTitle.Tint = AppTheme.Accent;
            this.iconTitle.Location = new Point(24, 22);
            this.iconTitle.Size = new Size(32, 32);
            //
            // lblTitle
            //
            AppTheme.ApplyPageTitle(this.lblTitle);
            this.lblTitle.Location = new Point(64, 22);
            this.lblTitle.Text = "Test Appointments";
            //
            // btnAddNewTestAppointment
            //
            AppTheme.ApplyPrimaryButton(this.btnAddNewTestAppointment);
            this.btnAddNewTestAppointment.Location = new Point(700, 22);
            this.btnAddNewTestAppointment.Size = new Size(160, 34);
            this.btnAddNewTestAppointment.Text = "+ New Appointment";
            this.btnAddNewTestAppointment.Click += new System.EventHandler(this.btnAddNewTestAppointment_Click);
            //
            // dgvAppointmentsList
            //
            this.dgvAppointmentsList.Location = new Point(24, 76);
            this.dgvAppointmentsList.Size = new Size(836, 340);
            this.dgvAppointmentsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointmentsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppTheme.StyleGrid(this.dgvAppointmentsList);
            //
            // lblRecords
            //
            this.lblRecords.AutoSize = true;
            AppTheme.ApplyCaption(this.lblRecords);
            this.lblRecords.Location = new Point(24, 428);
            this.lblRecords.Text = "Records:";
            //
            // lblRecordsCountValue
            //
            this.lblRecordsCountValue.AutoSize = true;
            AppTheme.ApplyValue(this.lblRecordsCountValue);
            this.lblRecordsCountValue.Location = new Point(90, 428);
            this.lblRecordsCountValue.Text = "0";
            //
            // btnClose
            //
            AppTheme.ApplySecondaryButton(this.btnClose);
            this.btnClose.Location = new Point(760, 420);
            this.btnClose.Size = new Size(100, 36);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.takeTestToolStripMenuItem });
            //
            // takeTestToolStripMenuItem
            //
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            //
            // frmTestAppointments
            //
            this.ClientSize = new Size(884, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCountValue);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAppointmentsList);
            this.Controls.Add(this.btnAddNewTestAppointment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.iconTitle);
            this.CancelButton = this.btnClose;
            this.Text = "Test Appointments";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
