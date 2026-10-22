namespace BoxRoom_Helper
{
    partial class IGDB_Lookup
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
            GameListBox = new ListBox();
            lblPreviewTitle = new Label();
            txtPreview = new TextBox();
            btnUseSelected = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // GameListBox
            // 
            GameListBox.FormattingEnabled = true;
            GameListBox.Location = new Point(12, 12);
            GameListBox.Name = "GameListBox";
            GameListBox.Size = new Size(321, 499);
            GameListBox.TabIndex = 0;
            GameListBox.SelectedIndexChanged += GameListBox_SelectedIndexChanged;
            // 
            // lblPreviewTitle
            // 
            lblPreviewTitle.AutoSize = true;
            lblPreviewTitle.Location = new Point(350, 12);
            lblPreviewTitle.Name = "lblPreviewTitle";
            lblPreviewTitle.Size = new Size(48, 15);
            lblPreviewTitle.TabIndex = 1;
            lblPreviewTitle.Text = "Preview";
            // 
            // txtPreview
            // 
            txtPreview.Location = new Point(350, 35);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.ReadOnly = true;
            txtPreview.ScrollBars = ScrollBars.Vertical;
            txtPreview.Size = new Size(427, 481);
            txtPreview.TabIndex = 2;
            // 
            // btnUseSelected
            // 
            btnUseSelected.Location = new Point(648, 528);
            btnUseSelected.Name = "btnUseSelected";
            btnUseSelected.Size = new Size(129, 27);
            btnUseSelected.TabIndex = 3;
            btnUseSelected.Text = "Use Selected";
            btnUseSelected.UseVisualStyleBackColor = true;
            btnUseSelected.Click += btnUseSelected_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(542, 528);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 27);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // IGDB_Lookup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 564);
            Controls.Add(btnCancel);
            Controls.Add(btnUseSelected);
            Controls.Add(txtPreview);
            Controls.Add(lblPreviewTitle);
            Controls.Add(GameListBox);
            Name = "IGDB_Lookup";
            Text = "IGDB Lookup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox GameListBox;
        private Label lblPreviewTitle;
        private TextBox txtPreview;
        private Button btnUseSelected;
        private Button btnCancel;
    }
}