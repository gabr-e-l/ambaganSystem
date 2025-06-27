namespace AmbaganForms
{
    partial class MainMenu
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
            btnCreate = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(214, 175);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 55);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create a List";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(214, 271);
            btnView.Name = "btnView";
            btnView.Size = new Size(150, 55);
            btnView.TabIndex = 1;
            btnView.Text = "View Lists";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 55);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete a Record";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(214, 462);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 55);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search a Record";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(214, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 55);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 63);
            label1.Name = "label1";
            label1.Size = new Size(146, 54);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnCreate);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnView;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnLogout;
        private Label label1;
    }
}