namespace BankSystem
{
    partial class EmployeeLogin
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
            this.openCreateForm = new System.Windows.Forms.Button();
            this.LoginClient = new System.Windows.Forms.Button();
            this.AccountNumber_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openCreateForm
            // 
            this.openCreateForm.Location = new System.Drawing.Point(437, 492);
            this.openCreateForm.Margin = new System.Windows.Forms.Padding(4);
            this.openCreateForm.Name = "openCreateForm";
            this.openCreateForm.Size = new System.Drawing.Size(251, 51);
            this.openCreateForm.TabIndex = 4;
            this.openCreateForm.Text = "Create Client";
            this.openCreateForm.UseVisualStyleBackColor = true;
            this.openCreateForm.Visible = false;
            // 
            // LoginClient
            // 
            this.LoginClient.Location = new System.Drawing.Point(437, 324);
            this.LoginClient.Margin = new System.Windows.Forms.Padding(4);
            this.LoginClient.Name = "LoginClient";
            this.LoginClient.Size = new System.Drawing.Size(251, 51);
            this.LoginClient.TabIndex = 5;
            this.LoginClient.Text = "Client Login";
            this.LoginClient.UseVisualStyleBackColor = true;
            this.LoginClient.Visible = false;
            this.LoginClient.Click += new System.EventHandler(this.LoginClient_Click);
            // 
            // AccountNumber_txt
            // 
            this.AccountNumber_txt.Location = new System.Drawing.Point(407, 258);
            this.AccountNumber_txt.Name = "AccountNumber_txt";
            this.AccountNumber_txt.Size = new System.Drawing.Size(366, 31);
            this.AccountNumber_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Account Number";
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountNumber_txt);
            this.Controls.Add(this.LoginClient);
            this.Controls.Add(this.openCreateForm);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCreateForm;
        private System.Windows.Forms.Button LoginClient;
        private System.Windows.Forms.TextBox AccountNumber_txt;
        private System.Windows.Forms.Label label1;
    }
}