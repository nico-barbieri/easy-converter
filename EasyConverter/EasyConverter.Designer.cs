namespace EasyConverter
{
    partial class EasyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyConverter));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            FileList = new ListBox();
            AddFiles = new CustomControls.RJControls.RJButton();
            RemoveFiles = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            ExtensionSelection = new CustomControls.RJControls.RJComboBox();
            label2 = new Label();
            Convert = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EasyConverterLight_svgrepo_com_;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Daikon-SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(228, 226, 227);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(57, 12);
            label1.Name = "label1";
            label1.Size = new Size(207, 43);
            label1.TabIndex = 1;
            label1.Text = "EasyConverter";
            // 
            // FileList
            // 
            FileList.AllowDrop = true;
            FileList.BackColor = Color.FromArgb(216, 212, 216);
            FileList.BorderStyle = BorderStyle.None;
            FileList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileList.ForeColor = Color.FromArgb(30, 39, 54);
            FileList.FormattingEnabled = true;
            FileList.ItemHeight = 15;
            FileList.Location = new Point(12, 78);
            FileList.Name = "FileList";
            FileList.SelectionMode = SelectionMode.MultiExtended;
            FileList.Size = new Size(316, 105);
            FileList.TabIndex = 5;
            FileList.DragDrop += FileList_DragDrop;
            FileList.DragEnter += FileList_DragEnter;
            // 
            // AddFiles
            // 
            AddFiles.BackColor = Color.FromArgb(30, 88, 150);
            AddFiles.BackgroundColor = Color.FromArgb(30, 88, 150);
            AddFiles.BorderColor = Color.PaleVioletRed;
            AddFiles.BorderRadius = 0;
            AddFiles.BorderSize = 0;
            AddFiles.Cursor = Cursors.Hand;
            AddFiles.FlatAppearance.BorderSize = 0;
            AddFiles.FlatStyle = FlatStyle.Flat;
            AddFiles.ForeColor = Color.FromArgb(228, 226, 227);
            AddFiles.Location = new Point(175, 189);
            AddFiles.Name = "AddFiles";
            AddFiles.Size = new Size(153, 30);
            AddFiles.TabIndex = 6;
            AddFiles.Text = "Add files...";
            AddFiles.TextColor = Color.FromArgb(228, 226, 227);
            AddFiles.UseVisualStyleBackColor = false;
            AddFiles.Click += AddFiles_Click;
            // 
            // RemoveFiles
            // 
            RemoveFiles.BackColor = Color.FromArgb(30, 88, 150);
            RemoveFiles.BackgroundColor = Color.FromArgb(30, 88, 150);
            RemoveFiles.BorderColor = Color.PaleVioletRed;
            RemoveFiles.BorderRadius = 0;
            RemoveFiles.BorderSize = 0;
            RemoveFiles.Cursor = Cursors.Hand;
            RemoveFiles.FlatAppearance.BorderSize = 0;
            RemoveFiles.FlatStyle = FlatStyle.Flat;
            RemoveFiles.ForeColor = Color.White;
            RemoveFiles.Location = new Point(12, 189);
            RemoveFiles.Name = "RemoveFiles";
            RemoveFiles.Size = new Size(157, 30);
            RemoveFiles.TabIndex = 7;
            RemoveFiles.Text = "Remove files...";
            RemoveFiles.TextColor = Color.White;
            RemoveFiles.UseVisualStyleBackColor = false;
            RemoveFiles.Click += RemoveFiles_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 88, 150);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 66);
            panel1.TabIndex = 1;
            // 
            // ExtensionSelection
            // 
            ExtensionSelection.AutoCompleteMode = AutoCompleteMode.Suggest;
            ExtensionSelection.AutoCompleteSource = AutoCompleteSource.ListItems;
            ExtensionSelection.BackColor = Color.FromArgb(30, 88, 150);
            ExtensionSelection.BorderColor = Color.FromArgb(30, 88, 150);
            ExtensionSelection.BorderSize = 0;
            ExtensionSelection.DropDownStyle = ComboBoxStyle.DropDown;
            ExtensionSelection.Font = new Font("Segoe UI", 10F);
            ExtensionSelection.ForeColor = Color.FromArgb(228, 226, 227);
            ExtensionSelection.IconColor = Color.FromArgb(228, 226, 227);
            ExtensionSelection.ListBackColor = Color.FromArgb(30, 88, 150);
            ExtensionSelection.ListTextColor = Color.FromArgb(228, 226, 227);
            ExtensionSelection.Location = new Point(13, 256);
            ExtensionSelection.MinimumSize = new Size(200, 30);
            ExtensionSelection.Name = "ExtensionSelection";
            ExtensionSelection.Size = new Size(315, 30);
            ExtensionSelection.TabIndex = 8;
            ExtensionSelection.Texts = "";
            ExtensionSelection.OnSelectedIndexChanged += ExtensionSelection_OnSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(228, 226, 227);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 39, 54);
            label2.Location = new Point(12, 232);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 9;
            label2.Text = "Convert to...";
            // 
            // Convert
            // 
            Convert.BackColor = Color.FromArgb(30, 88, 150);
            Convert.BackgroundColor = Color.FromArgb(30, 88, 150);
            Convert.BorderColor = Color.PaleVioletRed;
            Convert.BorderRadius = 0;
            Convert.BorderSize = 0;
            Convert.Cursor = Cursors.Hand;
            Convert.FlatAppearance.BorderSize = 0;
            Convert.FlatStyle = FlatStyle.Flat;
            Convert.ForeColor = Color.White;
            Convert.Location = new Point(12, 292);
            Convert.Name = "Convert";
            Convert.Size = new Size(316, 40);
            Convert.TabIndex = 10;
            Convert.Text = "Convert!";
            Convert.TextColor = Color.White;
            Convert.UseVisualStyleBackColor = false;
            Convert.Click += Convert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 226, 227);
            ClientSize = new Size(340, 345);
            Controls.Add(Convert);
            Controls.Add(label2);
            Controls.Add(ExtensionSelection);
            Controls.Add(panel1);
            Controls.Add(RemoveFiles);
            Controls.Add(AddFiles);
            Controls.Add(FileList);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = " EasyConverter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ListBox FileList;
        private CustomControls.RJControls.RJButton AddFiles;
        private CustomControls.RJControls.RJButton RemoveFiles;
        private Panel panel1;
        private CustomControls.RJControls.RJComboBox ExtensionSelection;
        private Label label2;
        private CustomControls.RJControls.RJButton Convert;
    }
}
