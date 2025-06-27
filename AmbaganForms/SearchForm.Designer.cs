namespace AmbaganForms
{
    partial class SearchForm
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
            txtName = new TextBox();
            btnSearch = new Button();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(31, 251);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(517, 364);
            listBox1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 127);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(214, 170);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 36);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(451, 697);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(97, 36);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 104);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter a Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 228);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Records:";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHome);
            Controls.Add(btnSearch);
            Controls.Add(txtName);
            Controls.Add(listBox1);
            Name = "SearchForm";
            Text = "Search Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox txtName;
        private Button btnSearch;
        private Button btnHome;
        private Label label1;
        private Label label2;
    }
}