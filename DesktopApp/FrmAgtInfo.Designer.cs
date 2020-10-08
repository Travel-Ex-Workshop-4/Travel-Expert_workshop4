namespace DesktopApp
{
    partial class FrmAgtInfo
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
            this.LblAgencyId = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblMiddleInitial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAgencyId
            // 
            this.LblAgencyId.Location = new System.Drawing.Point(222, 80);
            this.LblAgencyId.Name = "LblAgencyId";
            this.LblAgencyId.Size = new System.Drawing.Size(87, 20);
            this.LblAgencyId.TabIndex = 0;
            this.LblAgencyId.Text = "Agency Id:";
            // 
            // LblFirstName
            // 
            this.LblFirstName.Location = new System.Drawing.Point(222, 123);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(87, 20);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name:";
            // 
            // LblLastName
            // 
            this.LblLastName.Location = new System.Drawing.Point(222, 162);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(87, 20);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Last Name:";
            // 
            // LblMiddleInitial
            // 
            this.LblMiddleInitial.Location = new System.Drawing.Point(222, 203);
            this.LblMiddleInitial.Name = "LblMiddleInitial";
            this.LblMiddleInitial.Size = new System.Drawing.Size(87, 20);
            this.LblMiddleInitial.TabIndex = 3;
            this.LblMiddleInitial.Text = "Middle Initial:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(222, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agency Id:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(222, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Agency Id:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(222, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Agency Id:";
            // 
            // FrmAgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblMiddleInitial);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblAgencyId);
            this.Name = "FrmAgtInfo";
            this.Text = "FrmAgtInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAgencyId;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblMiddleInitial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}