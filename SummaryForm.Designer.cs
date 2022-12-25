
namespace BankSystem
{
    partial class SummaryForm
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
            this.welcomeUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheqBalanceLabel = new System.Windows.Forms.Label();
            this.viewChequingTransaction = new System.Windows.Forms.Button();
            this.cheqAccNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openCreateForm = new System.Windows.Forms.Button();
            this.openWithdrawForm = new System.Windows.Forms.Button();
            this.openTransferForm = new System.Windows.Forms.Button();
            this.openDepositForm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewSavingTransaction = new System.Windows.Forms.Button();
            this.saveBalanceLabel = new System.Windows.Forms.Label();
            this.saveAccNumberLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeUser
            // 
            this.welcomeUser.AutoSize = true;
            this.welcomeUser.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUser.Location = new System.Drawing.Point(232, 61);
            this.welcomeUser.Name = "welcomeUser";
            this.welcomeUser.Size = new System.Drawing.Size(304, 41);
            this.welcomeUser.TabIndex = 0;
            this.welcomeUser.Text = "Welcome, User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheqBalanceLabel);
            this.groupBox1.Controls.Add(this.viewChequingTransaction);
            this.groupBox1.Controls.Add(this.cheqAccNumberLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(239, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chequing Account";
            // 
            // cheqBalanceLabel
            // 
            this.cheqBalanceLabel.AutoSize = true;
            this.cheqBalanceLabel.Location = new System.Drawing.Point(186, 75);
            this.cheqBalanceLabel.Name = "cheqBalanceLabel";
            this.cheqBalanceLabel.Size = new System.Drawing.Size(51, 20);
            this.cheqBalanceLabel.TabIndex = 3;
            this.cheqBalanceLabel.Text = "label4";
            // 
            // viewChequingTransaction
            // 
            this.viewChequingTransaction.Location = new System.Drawing.Point(15, 139);
            this.viewChequingTransaction.Name = "viewChequingTransaction";
            this.viewChequingTransaction.Size = new System.Drawing.Size(188, 38);
            this.viewChequingTransaction.TabIndex = 3;
            this.viewChequingTransaction.Text = "View Transactions";
            this.viewChequingTransaction.UseVisualStyleBackColor = true;
            this.viewChequingTransaction.Click += new System.EventHandler(this.viewChequingTransaction_Click);
            // 
            // cheqAccNumberLabel
            // 
            this.cheqAccNumberLabel.AutoSize = true;
            this.cheqAccNumberLabel.Location = new System.Drawing.Point(186, 38);
            this.cheqAccNumberLabel.Name = "cheqAccNumberLabel";
            this.cheqAccNumberLabel.Size = new System.Drawing.Size(51, 20);
            this.cheqAccNumberLabel.TabIndex = 2;
            this.cheqAccNumberLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account number :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.openCreateForm);
            this.groupBox3.Controls.Add(this.openWithdrawForm);
            this.groupBox3.Controls.Add(this.openTransferForm);
            this.groupBox3.Controls.Add(this.openDepositForm);
            this.groupBox3.Location = new System.Drawing.Point(12, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 462);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // openCreateForm
            // 
            this.openCreateForm.Location = new System.Drawing.Point(6, 187);
            this.openCreateForm.Name = "openCreateForm";
            this.openCreateForm.Size = new System.Drawing.Size(188, 38);
            this.openCreateForm.TabIndex = 3;
            this.openCreateForm.Text = "Create Client";
            this.openCreateForm.UseVisualStyleBackColor = true;
            this.openCreateForm.Visible = false;
            this.openCreateForm.Click += new System.EventHandler(this.openCreateForm_Click);
            // 
            // openWithdrawForm
            // 
            this.openWithdrawForm.Location = new System.Drawing.Point(6, 71);
            this.openWithdrawForm.Name = "openWithdrawForm";
            this.openWithdrawForm.Size = new System.Drawing.Size(188, 38);
            this.openWithdrawForm.TabIndex = 1;
            this.openWithdrawForm.Text = "Withdraw";
            this.openWithdrawForm.UseVisualStyleBackColor = true;
            this.openWithdrawForm.Click += new System.EventHandler(this.openWithdrawForm_Click);
            // 
            // openTransferForm
            // 
            this.openTransferForm.Location = new System.Drawing.Point(6, 115);
            this.openTransferForm.Name = "openTransferForm";
            this.openTransferForm.Size = new System.Drawing.Size(188, 38);
            this.openTransferForm.TabIndex = 2;
            this.openTransferForm.Text = "Transfer";
            this.openTransferForm.UseVisualStyleBackColor = true;
            this.openTransferForm.Click += new System.EventHandler(this.openTransferForm_Click);
            // 
            // openDepositForm
            // 
            this.openDepositForm.Location = new System.Drawing.Point(6, 27);
            this.openDepositForm.Name = "openDepositForm";
            this.openDepositForm.Size = new System.Drawing.Size(188, 38);
            this.openDepositForm.TabIndex = 0;
            this.openDepositForm.Text = "Deposit";
            this.openDepositForm.UseVisualStyleBackColor = true;
            this.openDepositForm.Click += new System.EventHandler(this.openDepositForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Balance :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account number :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewSavingTransaction);
            this.groupBox2.Controls.Add(this.saveBalanceLabel);
            this.groupBox2.Controls.Add(this.saveAccNumberLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(239, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saving Account";
            // 
            // viewSavingTransaction
            // 
            this.viewSavingTransaction.Location = new System.Drawing.Point(15, 147);
            this.viewSavingTransaction.Name = "viewSavingTransaction";
            this.viewSavingTransaction.Size = new System.Drawing.Size(188, 38);
            this.viewSavingTransaction.TabIndex = 4;
            this.viewSavingTransaction.Text = "View Transactions";
            this.viewSavingTransaction.UseVisualStyleBackColor = true;
            this.viewSavingTransaction.Click += new System.EventHandler(this.viewSavingTransaction_Click);
            // 
            // saveBalanceLabel
            // 
            this.saveBalanceLabel.AutoSize = true;
            this.saveBalanceLabel.Location = new System.Drawing.Point(186, 75);
            this.saveBalanceLabel.Name = "saveBalanceLabel";
            this.saveBalanceLabel.Size = new System.Drawing.Size(51, 20);
            this.saveBalanceLabel.TabIndex = 3;
            this.saveBalanceLabel.Text = "label4";
            // 
            // saveAccNumberLabel
            // 
            this.saveAccNumberLabel.AutoSize = true;
            this.saveAccNumberLabel.Location = new System.Drawing.Point(186, 39);
            this.saveAccNumberLabel.Name = "saveAccNumberLabel";
            this.saveAccNumberLabel.Size = new System.Drawing.Size(51, 20);
            this.saveAccNumberLabel.TabIndex = 2;
            this.saveAccNumberLabel.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.welcomeUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Summary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummaryForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button viewChequingTransaction;
        private System.Windows.Forms.Button openTransferForm;
        private System.Windows.Forms.Button openDepositForm;
        private System.Windows.Forms.Button openWithdrawForm;
        private System.Windows.Forms.Label cheqBalanceLabel;
        private System.Windows.Forms.Label cheqAccNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label saveBalanceLabel;
        private System.Windows.Forms.Label saveAccNumberLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button viewSavingTransaction;
        protected System.Windows.Forms.Button openCreateForm;
    }
}