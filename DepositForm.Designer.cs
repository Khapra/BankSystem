
namespace BankSystem
{
    partial class DepositForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.Deposit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkChequing = new System.Windows.Forms.RadioButton();
            this.checkSaving = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chequingBalance = new System.Windows.Forms.Label();
            this.savingBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(285, 269);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(345, 27);
            this.txt_Amount.TabIndex = 3;
            // 
            // Deposit_button
            // 
            this.Deposit_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Deposit_button.Location = new System.Drawing.Point(167, 351);
            this.Deposit_button.Margin = new System.Windows.Forms.Padding(2);
            this.Deposit_button.Name = "Deposit_button";
            this.Deposit_button.Size = new System.Drawing.Size(180, 54);
            this.Deposit_button.TabIndex = 4;
            this.Deposit_button.Text = "Proceed";
            this.Deposit_button.UseVisualStyleBackColor = true;
            this.Deposit_button.Click += new System.EventHandler(this.Deposit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account";
            // 
            // checkChequing
            // 
            this.checkChequing.AutoSize = true;
            this.checkChequing.Location = new System.Drawing.Point(285, 195);
            this.checkChequing.Name = "checkChequing";
            this.checkChequing.Size = new System.Drawing.Size(165, 24);
            this.checkChequing.TabIndex = 6;
            this.checkChequing.TabStop = true;
            this.checkChequing.Text = "Chequing Account";
            this.checkChequing.UseVisualStyleBackColor = true;
            this.checkChequing.Checked = true;
            // 
            // checkSaving
            // 
            this.checkSaving.AutoSize = true;
            this.checkSaving.Location = new System.Drawing.Point(485, 195);
            this.checkSaving.Name = "checkSaving";
            this.checkSaving.Size = new System.Drawing.Size(145, 24);
            this.checkSaving.TabIndex = 7;
            this.checkSaving.TabStop = true;
            this.checkSaving.Text = "Saving Account";
            this.checkSaving.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deposit";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(450, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chequingBalance
            // 
            this.chequingBalance.AutoSize = true;
            this.chequingBalance.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequingBalance.Location = new System.Drawing.Point(281, 234);
            this.chequingBalance.Name = "chequingBalance";
            this.chequingBalance.Size = new System.Drawing.Size(59, 20);
            this.chequingBalance.TabIndex = 34;
            this.chequingBalance.Text = "label6";
            // 
            // savingBalance
            // 
            this.savingBalance.AutoSize = true;
            this.savingBalance.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingBalance.Location = new System.Drawing.Point(481, 234);
            this.savingBalance.Name = "savingBalance";
            this.savingBalance.Size = new System.Drawing.Size(59, 20);
            this.savingBalance.TabIndex = 33;
            this.savingBalance.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Balance";
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.chequingBalance);
            this.Controls.Add(this.savingBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkSaving);
            this.Controls.Add(this.checkChequing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deposit_button);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button Deposit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton checkChequing;
        private System.Windows.Forms.RadioButton checkSaving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label chequingBalance;
        private System.Windows.Forms.Label savingBalance;
        private System.Windows.Forms.Label label4;
    }
}