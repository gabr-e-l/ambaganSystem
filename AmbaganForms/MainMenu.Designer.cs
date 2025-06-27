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
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(214, 129);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 55);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create a List";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(214, 212);
            btnView.Name = "btnView";
            btnView.Size = new Size(150, 55);
            btnView.TabIndex = 1;
            btnView.Text = "View Lists";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 55);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete a Record";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(214, 386);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 55);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search a Record";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnCreate);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnView;
        private Button btnDelete;
        private Button btnSearch;
    }
}