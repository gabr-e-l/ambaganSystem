namespace AmbaganForms
{
    partial class CreateForm
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
            txtListName = new TextBox();
            txtName = new TextBox();
            txtGAmount = new TextBox();
            txtSAmount = new TextBox();
            listBox1 = new ListBox();
            btnAdd = new Button();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtListName
            // 
            txtListName.Location = new Point(28, 55);
            txtListName.Name = "txtListName";
            txtListName.Size = new Size(283, 27);
            txtListName.TabIndex = 0;
            txtListName.TextChanged += txtListName_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(28, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 27);
            txtName.TabIndex = 1;
            // 
            // txtGAmount
            // 
            txtGAmount.Location = new Point(28, 229);
            txtGAmount.Name = "txtGAmount";
            txtGAmount.Size = new Size(283, 27);
            txtGAmount.TabIndex = 2;
            // 
            // txtSAmount
            // 
            txtSAmount.Location = new Point(367, 55);
            txtSAmount.Name = "txtSAmount";
            txtSAmount.Size = new Size(187, 27);
            txtSAmount.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 322);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(526, 364);
            listBox1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(460, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Entry";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(460, 706);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 35);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter List Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 129);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 206);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 9;
            label3.Text = "Given Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 32);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 10;
            label4.Text = "Set Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 299);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Contents:";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHome);
            Controls.Add(btnAdd);
            Controls.Add(listBox1);
            Controls.Add(txtSAmount);
            Controls.Add(txtGAmount);
            Controls.Add(txtName);
            Controls.Add(txtListName);
            Name = "CreateForm";
            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtListName;
        private TextBox txtName;
        private TextBox txtGAmount;
        private TextBox txtSAmount;
        private ListBox listBox1;
        private Button btnAdd;
        private Button btnHome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}