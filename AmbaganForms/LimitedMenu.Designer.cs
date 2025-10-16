namespace AmbaganForms
{
    partial class LimitedMenu
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
            btnView = new Button();
            btnSearch = new Button();
            btnLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.Location = new Point(217, 199);
            btnView.Name = "btnView";
            btnView.Size = new Size(142, 90);
            btnView.TabIndex = 0;
            btnView.Text = "View Lists";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(217, 347);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 90);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search a Record";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(217, 507);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 90);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 88);
            label1.Name = "label1";
            label1.Size = new Size(139, 51);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // LimitedMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 753);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnSearch);
            Controls.Add(btnView);
            Name = "LimitedMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnView;
        private Button btnSearch;
        private Button btnLogout;
        private Label label1;
    }
}