
namespace BankSystem
{
    partial class TransferForm
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
            this.chequingBalance = new System.Windows.Forms.Label();
            this.savingBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkSaving = new System.Windows.Forms.RadioButton();
            this.checkChequing = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Transfer_button = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_receiverAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chequingBalance
            // 
            this.chequingBalance.AutoSize = true;
            this.chequingBalance.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequingBalance.Location = new System.Drawing.Point(322, 216);
            this.chequingBalance.Name = "chequingBalance";
            this.chequingBalance.Size = new System.Drawing.Size(59, 20);
            this.chequingBalance.TabIndex = 31;
            this.chequingBalance.Text = "label6";
            // 
            // savingBalance
            // 
            this.savingBalance.AutoSize = true;
            this.savingBalance.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingBalance.Location = new System.Drawing.Point(522, 216);
            this.savingBalance.Name = "savingBalance";
            this.savingBalance.Size = new System.Drawing.Size(59, 20);
            this.savingBalance.TabIndex = 30;
            this.savingBalance.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Balance";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(453, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 54);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 45);
            this.label3.TabIndex = 27;
            this.label3.Text = "Transfer";
            // 
            // checkSaving
            // 
            this.checkSaving.AutoSize = true;
            this.checkSaving.Location = new System.Drawing.Point(527, 172);
            this.checkSaving.Name = "checkSaving";
            this.checkSaving.Size = new System.Drawing.Size(145, 24);
            this.checkSaving.TabIndex = 26;
            this.checkSaving.TabStop = true;
            this.checkSaving.Text = "Saving Account";
            this.checkSaving.UseVisualStyleBackColor = true;
            // 
            // checkChequing
            // 
            this.checkChequing.AutoSize = true;
            this.checkChequing.Location = new System.Drawing.Point(327, 172);
            this.checkChequing.Name = "checkChequing";
            this.checkChequing.Size = new System.Drawing.Size(165, 24);
            this.checkChequing.TabIndex = 25;
            this.checkChequing.TabStop = true;
            this.checkChequing.Text = "Chequing Account";
            this.checkChequing.UseVisualStyleBackColor = true;
            this.checkChequing.Checked = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Account";
            // 
            // Transfer_button
            // 
            this.Transfer_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Transfer_button.Location = new System.Drawing.Point(170, 384);
            this.Transfer_button.Margin = new System.Windows.Forms.Padding(2);
            this.Transfer_button.Name = "Transfer_button";
            this.Transfer_button.Size = new System.Drawing.Size(180, 54);
            this.Transfer_button.TabIndex = 23;
            this.Transfer_button.Text = "Proceed";
            this.Transfer_button.UseVisualStyleBackColor = true;
            this.Transfer_button.Click += new System.EventHandler(this.Transfer_button_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(327, 305);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(345, 27);
            this.txt_Amount.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Amount";
            // 
            // txt_receiverAccount
            // 
            this.txt_receiverAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receiverAccount.Location = new System.Drawing.Point(328, 261);
            this.txt_receiverAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_receiverAccount.Name = "txt_receiverAccount";
            this.txt_receiverAccount.Size = new System.Drawing.Size(345, 27);
            this.txt_receiverAccount.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Receiver Account";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.txt_receiverAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chequingBalance);
            this.Controls.Add(this.savingBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkSaving);
            this.Controls.Add(this.checkChequing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transfer_button);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chequingBalance;
        private System.Windows.Forms.Label savingBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton checkSaving;
        private System.Windows.Forms.RadioButton checkChequing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Transfer_button;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_receiverAccount;
        private System.Windows.Forms.Label label5;
    }
}