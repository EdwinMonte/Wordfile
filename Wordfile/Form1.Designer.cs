namespace Wordfile
{
    partial class Form1
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
            btnSelectFolder = new Button();
            btnProcessFolder = new Button();
            btnSaveaText = new Button();
            btnSaveaWord = new Button();
            btnOpenTextFile = new Button();
            txtFolder = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(44, 27);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(166, 81);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            // 
            // btnProcessFolder
            // 
            btnProcessFolder.Location = new Point(516, 27);
            btnProcessFolder.Name = "btnProcessFolder";
            btnProcessFolder.Size = new Size(134, 81);
            btnProcessFolder.TabIndex = 1;
            btnProcessFolder.Text = "Process Folder";
            btnProcessFolder.UseVisualStyleBackColor = true;
            // 
            // btnSaveaText
            // 
            btnSaveaText.Location = new Point(747, 185);
            btnSaveaText.Name = "btnSaveaText";
            btnSaveaText.Size = new Size(171, 81);
            btnSaveaText.TabIndex = 2;
            btnSaveaText.Text = "Save Text";
            btnSaveaText.UseVisualStyleBackColor = true;
            btnSaveaText.Click += btnSaveaText_Click;
            // 
            // btnSaveaWord
            // 
            btnSaveaWord.Location = new Point(322, 180);
            btnSaveaWord.Name = "btnSaveaWord";
            btnSaveaWord.Size = new Size(172, 90);
            btnSaveaWord.TabIndex = 3;
            btnSaveaWord.Text = "Save a Word ";
            btnSaveaWord.UseVisualStyleBackColor = true;
            
            // 
            // btnOpenTextFile
            // 
            btnOpenTextFile.Location = new Point(44, 185);
            btnOpenTextFile.Name = "btnOpenTextFile";
            btnOpenTextFile.Size = new Size(197, 80);
            btnOpenTextFile.TabIndex = 4;
            btnOpenTextFile.Text = "Open Text File";
            btnOpenTextFile.UseVisualStyleBackColor = true;
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(232, 54);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(262, 27);
            txtFolder.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(670, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 292);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(996, 262);
            textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 560);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtFolder);
            Controls.Add(btnOpenTextFile);
            Controls.Add(btnSaveaWord);
            Controls.Add(btnSaveaText);
            Controls.Add(btnProcessFolder);
            Controls.Add(btnSelectFolder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFolder;
        private Button btnProcessFolder;
        private Button btnSaveaText;
        private Button btnSaveaWord;
        private Button btnOpenTextFile;
        private TextBox txtFolder;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
