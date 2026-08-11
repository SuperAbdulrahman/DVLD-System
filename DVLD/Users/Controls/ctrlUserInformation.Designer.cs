namespace DVLD.Users.Controls
{
    partial class ctrlUserInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlLoginInfoCard1 = new DVLD.Users.ctrlLoginInfoCard();
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // ctrlLoginInfoCard1
            // 
            this.ctrlLoginInfoCard1.Location = new System.Drawing.Point(15, 334);
            this.ctrlLoginInfoCard1.Name = "ctrlLoginInfoCard1";
            this.ctrlLoginInfoCard1.Size = new System.Drawing.Size(1027, 150);
            this.ctrlLoginInfoCard1.TabIndex = 1;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1058, 340);
            this.ctrlPersonCard1.TabIndex = 2;
            // 
            // ctrlUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlLoginInfoCard1);
            this.Name = "ctrlUserInformation";
            this.Size = new System.Drawing.Size(1058, 498);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlLoginInfoCard ctrlLoginInfoCard1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
