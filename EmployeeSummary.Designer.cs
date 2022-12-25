
namespace BankSystem
{
    partial class EmployeeSummary
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
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewSavingTransaction = new System.Windows.Forms.Button();
            this.saveBalanceLabel = new System.Windows.Forms.Label();
            this.saveAccNumberLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openWithdrawForm = new System.Windows.Forms.Button();
            this.openTransferForm = new System.Windows.Forms.Button();
            this.openDepositForm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cheqBalanceLabel = new System.Windows.Forms.Label();
            this.viewChequingTransaction = new System.Windows.Forms.Button();
            this.cheqAccNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.welcomeUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(333, 44);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(333, 44);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(333, 44);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1470, 42);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewSavingTransaction
            // 
            this.viewSavingTransaction.Location = new System.Drawing.Point(20, 196);
            this.viewSavingTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.viewSavingTransaction.Name = "viewSavingTransaction";
            this.viewSavingTransaction.Size = new System.Drawing.Size(251, 51);
            this.viewSavingTransaction.TabIndex = 4;
            this.viewSavingTransaction.Text = "View Transactions";
            this.viewSavingTransaction.UseVisualStyleBackColor = true;
            // 
            // saveBalanceLabel
            // 
            this.saveBalanceLabel.AutoSize = true;
            this.saveBalanceLabel.Location = new System.Drawing.Point(248, 100);
            this.saveBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveBalanceLabel.Name = "saveBalanceLabel";
            this.saveBalanceLabel.Size = new System.Drawing.Size(70, 25);
            this.saveBalanceLabel.TabIndex = 3;
            this.saveBalanceLabel.Text = "label4";
            // 
            // saveAccNumberLabel
            // 
            this.saveAccNumberLabel.AutoSize = true;
            this.saveAccNumberLabel.Location = new System.Drawing.Point(248, 52);
            this.saveAccNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveAccNumberLabel.Name = "saveAccNumberLabel";
            this.saveAccNumberLabel.Size = new System.Drawing.Size(70, 25);
            this.saveAccNumberLabel.TabIndex = 2;
            this.saveAccNumberLabel.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewSavingTransaction);
            this.groupBox2.Controls.Add(this.saveBalanceLabel);
            this.groupBox2.Controls.Add(this.saveAccNumberLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(319, 509);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(703, 277);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saving Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account number :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Balance :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // openWithdrawForm
            // 
            this.openWithdrawForm.Location = new System.Drawing.Point(8, 95);
            this.openWithdrawForm.Margin = new System.Windows.Forms.Padding(4);
            this.openWithdrawForm.Name = "openWithdrawForm";
            this.openWithdrawForm.Size = new System.Drawing.Size(251, 51);
            this.openWithdrawForm.TabIndex = 1;
            this.openWithdrawForm.Text = "Withdraw";
            this.openWithdrawForm.UseVisualStyleBackColor = true;
            // 
            // openTransferForm
            // 
            this.openTransferForm.Location = new System.Drawing.Point(8, 153);
            this.openTransferForm.Margin = new System.Windows.Forms.Padding(4);
            this.openTransferForm.Name = "openTransferForm";
            this.openTransferForm.Size = new System.Drawing.Size(251, 51);
            this.openTransferForm.TabIndex = 2;
            this.openTransferForm.Text = "Transfer";
            this.openTransferForm.UseVisualStyleBackColor = true;
            // 
            // openDepositForm
            // 
            this.openDepositForm.Location = new System.Drawing.Point(8, 36);
            this.openDepositForm.Margin = new System.Windows.Forms.Padding(4);
            this.openDepositForm.Name = "openDepositForm";
            this.openDepositForm.Size = new System.Drawing.Size(251, 51);
            this.openDepositForm.TabIndex = 0;
            this.openDepositForm.Text = "Deposit";
            this.openDepositForm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.openWithdrawForm);
            this.groupBox3.Controls.Add(this.openTransferForm);
            this.groupBox3.Controls.Add(this.openDepositForm);
            this.groupBox3.Location = new System.Drawing.Point(16, 170);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 616);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // cheqBalanceLabel
            // 
            this.cheqBalanceLabel.AutoSize = true;
            this.cheqBalanceLabel.Location = new System.Drawing.Point(248, 100);
            this.cheqBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cheqBalanceLabel.Name = "cheqBalanceLabel";
            this.cheqBalanceLabel.Size = new System.Drawing.Size(70, 25);
            this.cheqBalanceLabel.TabIndex = 3;
            this.cheqBalanceLabel.Text = "label4";
            // 
            // viewChequingTransaction
            // 
            this.viewChequingTransaction.Location = new System.Drawing.Point(20, 185);
            this.viewChequingTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.viewChequingTransaction.Name = "viewChequingTransaction";
            this.viewChequingTransaction.Size = new System.Drawing.Size(251, 51);
            this.viewChequingTransaction.TabIndex = 3;
            this.viewChequingTransaction.Text = "View Transactions";
            this.viewChequingTransaction.UseVisualStyleBackColor = true;
            // 
            // cheqAccNumberLabel
            // 
            this.cheqAccNumberLabel.AutoSize = true;
            this.cheqAccNumberLabel.Location = new System.Drawing.Point(248, 51);
            this.cheqAccNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cheqAccNumberLabel.Name = "cheqAccNumberLabel";
            this.cheqAccNumberLabel.Size = new System.Drawing.Size(70, 25);
            this.cheqAccNumberLabel.TabIndex = 2;
            this.cheqAccNumberLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account number :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheqBalanceLabel);
            this.groupBox1.Controls.Add(this.viewChequingTransaction);
            this.groupBox1.Controls.Add(this.cheqAccNumberLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(319, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(703, 267);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chequing Account";
            // 
            // welcomeUser
            // 
            this.welcomeUser.AutoSize = true;
            this.welcomeUser.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUser.Location = new System.Drawing.Point(309, 170);
            this.welcomeUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeUser.Name = "welcomeUser";
            this.welcomeUser.Size = new System.Drawing.Size(400, 54);
            this.welcomeUser.TabIndex = 7;
            this.welcomeUser.Text = "Welcome, User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Unflag Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 378);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Report Lost";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EmployeeSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 874);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.welcomeUser);
            this.Name = "EmployeeSummary";
            this.Text = "EmployeeSummary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button viewSavingTransaction;
        private System.Windows.Forms.Label saveBalanceLabel;
        private System.Windows.Forms.Label saveAccNumberLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openWithdrawForm;
        private System.Windows.Forms.Button openTransferForm;
        private System.Windows.Forms.Button openDepositForm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label cheqBalanceLabel;
        private System.Windows.Forms.Button viewChequingTransaction;
        private System.Windows.Forms.Label cheqAccNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label welcomeUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}