namespace RssReader
{
    partial class Rss
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
            refreshButton = new Button();
            titlesComboBox = new ComboBox();
            linkLabel = new LinkLabel();
            channelTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            refreshButton.Location = new Point(494, 23);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(175, 23);
            refreshButton.TabIndex = 0;
            refreshButton.Text = "Refresh Feed";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // titlesComboBox
            // 
            titlesComboBox.FormattingEnabled = true;
            titlesComboBox.Location = new Point(12, 60);
            titlesComboBox.Name = "titlesComboBox";
            titlesComboBox.Size = new Size(657, 23);
            titlesComboBox.TabIndex = 1;
            titlesComboBox.SelectedIndexChanged += titlesComboBox_SelectedIndexChanged;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel.Location = new Point(12, 305);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(146, 21);
            linkLabel.TabIndex = 2;
            linkLabel.TabStop = true;
            linkLabel.Text = "Link Appears here";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // channelTextBox
            // 
            channelTextBox.Location = new Point(12, 23);
            channelTextBox.Name = "channelTextBox";
            channelTextBox.Size = new Size(476, 23);
            channelTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 89);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(657, 203);
            descriptionTextBox.TabIndex = 4;
            // 
            // Rss
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 344);
            Controls.Add(descriptionTextBox);
            Controls.Add(channelTextBox);
            Controls.Add(linkLabel);
            Controls.Add(titlesComboBox);
            Controls.Add(refreshButton);
            Name = "Rss";
            Text = "Rss Reader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshButton;
        private ComboBox titlesComboBox;
        private LinkLabel linkLabel;
        private TextBox channelTextBox;
        private TextBox descriptionTextBox;
    }
}