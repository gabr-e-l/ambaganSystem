namespace AmbaganForms
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAccNumber = new TextBox();
            txtPIN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtAccNumber
            // 
            txtAccNumber.Location = new Point(69, 264);
            txtAccNumber.Name = "txtAccNumber";
            txtAccNumber.Size = new Size(227, 27);
            txtAccNumber.TabIndex = 0;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(69, 396);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(227, 27);
            txtPIN.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 105);
            label1.Name = "label1";
            label1.Size = new Size(206, 46);
            label1.TabIndex = 2;
            label1.Text = "Ambagan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 240);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 3;
            label2.Text = "Account Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 372);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 4;
            label3.Text = "PIN:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(141, 477);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPIN);
            Controls.Add(txtAccNumber);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccNumber;
        private TextBox txtPIN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
    }
}
