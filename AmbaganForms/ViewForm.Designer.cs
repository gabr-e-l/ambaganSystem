namespace AmbaganForms
{
    partial class ViewForm
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
            btnView = new Button();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 264);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(23, 386);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(534, 304);
            listBox2.TabIndex = 1;
            // 
            // txtListName
            // 
            txtListName.Location = new Point(341, 72);
            txtListName.Name = "txtListName";
            txtListName.Size = new Size(216, 27);
            txtListName.TabIndex = 2;
            // 
            // btnView
            // 
            btnView.Location = new Point(400, 117);
            btnView.Name = "btnView";
            btnView.Size = new Size(104, 44);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(463, 712);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 5;
            label1.Text = "Available Lists:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 49);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 6;
            label2.Text = "Enter a List to View:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 363);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Contents:";
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHome);
            Controls.Add(btnView);
            Controls.Add(txtListName);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "ViewForm";
            Text = "ViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox txtListName;
        private Button btnView;
        private Button btnHome;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}