namespace DVLD.Applications
{
    partial class frmRenewLicenseApplication
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
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lliShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lliShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbRenewLicenseApplicationInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblLicenseFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblIssueDateValue = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblAppDateValue = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblExperationDateValue = new System.Windows.Forms.Label();
            this.lblRenewedLicenseIDValue = new System.Windows.Forms.Label();
            this.lblRIAppIDValue = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblRIAppID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblExperationDate = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.License.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbRenewLicenseApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRenew.Enabled = false;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(910, 931);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(133, 43);
            this.btnRenew.TabIndex = 68;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(748, 931);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 43);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lliShowLicenseInfo
            // 
            this.lliShowLicenseInfo.AutoSize = true;
            this.lliShowLicenseInfo.Enabled = false;
            this.lliShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lliShowLicenseInfo.Location = new System.Drawing.Point(206, 941);
            this.lliShowLicenseInfo.Name = "lliShowLicenseInfo";
            this.lliShowLicenseInfo.Size = new System.Drawing.Size(152, 23);
            this.lliShowLicenseInfo.TabIndex = 66;
            this.lliShowLicenseInfo.TabStop = true;
            this.lliShowLicenseInfo.Text = "Show License Info:";
            this.lliShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliShowLicenseInfo_LinkClicked);
            // 
            // lliShowLicenseHistory
            // 
            this.lliShowLicenseHistory.AutoSize = true;
            this.lliShowLicenseHistory.Enabled = false;
            this.lliShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lliShowLicenseHistory.Location = new System.Drawing.Point(24, 941);
            this.lliShowLicenseHistory.Name = "lliShowLicenseHistory";
            this.lliShowLicenseHistory.Size = new System.Drawing.Size(173, 23);
            this.lliShowLicenseHistory.TabIndex = 67;
            this.lliShowLicenseHistory.TabStop = true;
            this.lliShowLicenseHistory.Text = "Show Licnese History";
            this.lliShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lliShowLicenseHistory_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(212, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(613, 54);
            this.lblTitle.TabIndex = 65;
            this.lblTitle.Text = "International License Application";
            // 
            // gbRenewLicenseApplicationInfo
            // 
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox5);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblTotalFees);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblLicenseFeesValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblTotalFeesValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox3);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox2);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.txtNotes);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox1);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblNotes);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblLicenseFees);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox8);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblOldLicenseIDValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblOldLicenseID);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox6);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblIssueDateValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblCreatedByValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblAppDateValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblAppFeesValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblExperationDateValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblRenewedLicenseIDValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblRIAppIDValue);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox4);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblRIAppID);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox9);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox7);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblIssueDate);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblAppDate);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox10);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.pictureBox11);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblExperationDate);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblAppFees);
            this.gbRenewLicenseApplicationInfo.Controls.Add(this.lblRenewedLicenseID);
            this.gbRenewLicenseApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRenewLicenseApplicationInfo.Location = new System.Drawing.Point(21, 579);
            this.gbRenewLicenseApplicationInfo.Name = "gbRenewLicenseApplicationInfo";
            this.gbRenewLicenseApplicationInfo.Size = new System.Drawing.Size(1022, 346);
            this.gbRenewLicenseApplicationInfo.TabIndex = 71;
            this.gbRenewLicenseApplicationInfo.TabStop = false;
            this.gbRenewLicenseApplicationInfo.Text = "Renew License Application Info";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pictureBox5.Location = new System.Drawing.Point(714, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.Location = new System.Drawing.Point(500, 203);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(107, 28);
            this.lblTotalFees.TabIndex = 86;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // lblLicenseFeesValue
            // 
            this.lblLicenseFeesValue.AutoSize = true;
            this.lblLicenseFeesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFeesValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLicenseFeesValue.Location = new System.Drawing.Point(223, 206);
            this.lblLicenseFeesValue.Name = "lblLicenseFeesValue";
            this.lblLicenseFeesValue.Size = new System.Drawing.Size(28, 25);
            this.lblLicenseFeesValue.TabIndex = 85;
            this.lblLicenseFeesValue.Text = "??";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalFeesValue.Location = new System.Drawing.Point(750, 220);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(28, 25);
            this.lblTotalFeesValue.TabIndex = 84;
            this.lblTotalFeesValue.Text = "??";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(714, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(187, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNotes.Location = new System.Drawing.Point(228, 249);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(736, 84);
            this.txtNotes.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(187, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(19, 249);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 28);
            this.lblNotes.TabIndex = 79;
            this.lblNotes.Text = "Notes:";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblLicenseFees.Location = new System.Drawing.Point(19, 208);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(131, 28);
            this.lblLicenseFees.TabIndex = 63;
            this.lblLicenseFees.Text = "License Fees:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pictureBox8.Location = new System.Drawing.Point(714, 77);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 62;
            this.pictureBox8.TabStop = false;
            // 
            // lblOldLicenseIDValue
            // 
            this.lblOldLicenseIDValue.AutoSize = true;
            this.lblOldLicenseIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOldLicenseIDValue.Location = new System.Drawing.Point(750, 82);
            this.lblOldLicenseIDValue.Name = "lblOldLicenseIDValue";
            this.lblOldLicenseIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblOldLicenseIDValue.TabIndex = 61;
            this.lblOldLicenseIDValue.Text = "??";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblOldLicenseID.Location = new System.Drawing.Point(500, 77);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(148, 28);
            this.lblOldLicenseID.TabIndex = 60;
            this.lblOldLicenseID.Text = "Old License ID:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(187, 126);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 59;
            this.pictureBox6.TabStop = false;
            // 
            // lblIssueDateValue
            // 
            this.lblIssueDateValue.AutoSize = true;
            this.lblIssueDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDateValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblIssueDateValue.Location = new System.Drawing.Point(223, 126);
            this.lblIssueDateValue.Name = "lblIssueDateValue";
            this.lblIssueDateValue.Size = new System.Drawing.Size(28, 25);
            this.lblIssueDateValue.TabIndex = 54;
            this.lblIssueDateValue.Text = "??";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCreatedByValue.Location = new System.Drawing.Point(750, 174);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(28, 25);
            this.lblCreatedByValue.TabIndex = 53;
            this.lblCreatedByValue.Text = "??";
            // 
            // lblAppDateValue
            // 
            this.lblAppDateValue.AutoSize = true;
            this.lblAppDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDateValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAppDateValue.Location = new System.Drawing.Point(223, 86);
            this.lblAppDateValue.Name = "lblAppDateValue";
            this.lblAppDateValue.Size = new System.Drawing.Size(28, 25);
            this.lblAppDateValue.TabIndex = 51;
            this.lblAppDateValue.Text = "??";
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeesValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAppFeesValue.Location = new System.Drawing.Point(223, 166);
            this.lblAppFeesValue.Name = "lblAppFeesValue";
            this.lblAppFeesValue.Size = new System.Drawing.Size(28, 25);
            this.lblAppFeesValue.TabIndex = 50;
            this.lblAppFeesValue.Text = "??";
            // 
            // lblExperationDateValue
            // 
            this.lblExperationDateValue.AutoSize = true;
            this.lblExperationDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperationDateValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblExperationDateValue.Location = new System.Drawing.Point(750, 128);
            this.lblExperationDateValue.Name = "lblExperationDateValue";
            this.lblExperationDateValue.Size = new System.Drawing.Size(28, 25);
            this.lblExperationDateValue.TabIndex = 49;
            this.lblExperationDateValue.Text = "??";
            // 
            // lblRenewedLicenseIDValue
            // 
            this.lblRenewedLicenseIDValue.AutoSize = true;
            this.lblRenewedLicenseIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRenewedLicenseIDValue.Location = new System.Drawing.Point(750, 36);
            this.lblRenewedLicenseIDValue.Name = "lblRenewedLicenseIDValue";
            this.lblRenewedLicenseIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblRenewedLicenseIDValue.TabIndex = 47;
            this.lblRenewedLicenseIDValue.Text = "??";
            // 
            // lblRIAppIDValue
            // 
            this.lblRIAppIDValue.AutoSize = true;
            this.lblRIAppIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRIAppIDValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRIAppIDValue.Location = new System.Drawing.Point(223, 46);
            this.lblRIAppIDValue.Name = "lblRIAppIDValue";
            this.lblRIAppIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblRIAppIDValue.TabIndex = 46;
            this.lblRIAppIDValue.Text = "??";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(187, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // lblRIAppID
            // 
            this.lblRIAppID.AutoSize = true;
            this.lblRIAppID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblRIAppID.Location = new System.Drawing.Point(19, 43);
            this.lblRIAppID.Name = "lblRIAppID";
            this.lblRIAppID.Size = new System.Drawing.Size(112, 28);
            this.lblRIAppID.TabIndex = 44;
            this.lblRIAppID.Text = "R.L.App ID:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Person_32;
            this.pictureBox9.Location = new System.Drawing.Point(714, 167);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 42;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox7.Location = new System.Drawing.Point(187, 85);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(500, 161);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(115, 28);
            this.lblCreatedBy.TabIndex = 39;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblIssueDate.Location = new System.Drawing.Point(19, 126);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(112, 28);
            this.lblIssueDate.TabIndex = 38;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.Location = new System.Drawing.Point(19, 84);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(167, 28);
            this.lblAppDate.TabIndex = 37;
            this.lblAppDate.Text = "Application Date:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox10.Location = new System.Drawing.Point(187, 167);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD.Properties.Resources.ApplicationType;
            this.pictureBox11.Location = new System.Drawing.Point(714, 125);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 35);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 34;
            this.pictureBox11.TabStop = false;
            // 
            // lblExperationDate
            // 
            this.lblExperationDate.AutoSize = true;
            this.lblExperationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblExperationDate.Location = new System.Drawing.Point(500, 119);
            this.lblExperationDate.Name = "lblExperationDate";
            this.lblExperationDate.Size = new System.Drawing.Size(155, 28);
            this.lblExperationDate.TabIndex = 32;
            this.lblExperationDate.Text = "Expiration Date:";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(19, 167);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(166, 28);
            this.lblAppFees.TabIndex = 30;
            this.lblAppFees.Text = "Application Fees:";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(500, 35);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(199, 28);
            this.lblRenewedLicenseID.TabIndex = 29;
            this.lblRenewedLicenseID.Text = "Renewed License ID:";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(2, 54);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1053, 532);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 70;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmRenewLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 981);
            this.Controls.Add(this.gbRenewLicenseApplicationInfo);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lliShowLicenseInfo);
            this.Controls.Add(this.lliShowLicenseHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Name = "frmRenewLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Licenese Application";
            this.Load += new System.EventHandler(this.frmRenewLicenseApplication_Load);
            this.gbRenewLicenseApplicationInfo.ResumeLayout(false);
            this.gbRenewLicenseApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lliShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lliShowLicenseHistory;
        private System.Windows.Forms.Label lblTitle;
        private License.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbRenewLicenseApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblIssueDateValue;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblAppDateValue;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblExperationDateValue;
        private System.Windows.Forms.Label lblRenewedLicenseIDValue;
        private System.Windows.Forms.Label lblRIAppIDValue;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblRIAppID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblExperationDate;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblLicenseFeesValue;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}