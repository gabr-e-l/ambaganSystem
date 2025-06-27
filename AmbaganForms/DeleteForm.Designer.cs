namespace AmbaganForms
{
    partial class DeleteForm
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            txtListName = new TextBox();
            txtName = new TextBox();
            btnView = new Button();
            btnDelete1 = new Button();
            btnDelete2 = new Button();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(22, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(279, 304);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(22, 413);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(279, 304);
            listBox2.TabIndex = 1;
            // 
            // txtListName
            // 
            txtListName.Location = new Point(335, 70);
            txtListName.Name = "txtListName";
            txtListName.Size = new Size(221, 27);
            txtListName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(335, 436);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 3;
            // 
            // btnView
            // 
            btnView.Location = new Point(462, 125);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete1
            // 
            btnDelete1.Location = new Point(462, 197);
            btnDelete1.Name = "btnDelete1";
            btnDelete1.Size = new Size(94, 29);
            btnDelete1.TabIndex = 5;
            btnDelete1.Text = "Delete";
            btnDelete1.UseVisualStyleBackColor = true;
            btnDelete1.Click += btnDelete1_Click;
            // 
            // btnDelete2
            // 
            btnDelete2.Location = new Point(462, 498);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(94, 29);
            btnDelete2.TabIndex = 6;
            btnDelete2.Text = "Delete";
            btnDelete2.UseVisualStyleBackColor = true;
            btnDelete2.Click += btnDelete2_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(462, 712);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 7;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 8;
            label1.Text = "Available Lists:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 47);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 9;
            label2.Text = "Enter List Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 390);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Contents:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 413);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 11;
            label4.Text = "Enter Name:";
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHome);
            Controls.Add(btnDelete2);
            Controls.Add(btnDelete1);
            Controls.Add(btnView);
            Controls.Add(txtName);
            Controls.Add(txtListName);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "DeleteForm";
            Text = "Delete Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox txtListName;
        private TextBox txtName;
        private Button btnView;
        private Button btnDelete1;
        private Button btnDelete2;
        private Button btnHome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}