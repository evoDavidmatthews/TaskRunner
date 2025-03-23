namespace TaskRunner
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
            components = new System.ComponentModel.Container();
            DescriptionBox = new TextBox();
            AvailableTasksList = new ListBox();
            RunButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DescriptionBox
            // 
            DescriptionBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionBox.BackColor = SystemColors.Window;
            DescriptionBox.ForeColor = SystemColors.ActiveCaptionText;
            DescriptionBox.Location = new Point(213, 27);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(588, 424);
            DescriptionBox.TabIndex = 1;
            // 
            // AvailableFunctionsList
            // 
            AvailableTasksList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AvailableTasksList.BackColor = SystemColors.Window;
            AvailableTasksList.ForeColor = SystemColors.ActiveCaptionText;
            AvailableTasksList.FormattingEnabled = true;
            AvailableTasksList.Location = new Point(0, 27);
            AvailableTasksList.MaximumSize = new Size(206, 4);
            AvailableTasksList.MinimumSize = new Size(4, 999);
            AvailableTasksList.Name = "AvailableFunctionsList";
            AvailableTasksList.Size = new Size(206, 984);
            AvailableTasksList.TabIndex = 2;
            AvailableTasksList.SelectedIndexChanged += AvailableTasksList_SelectedIndexChanged;
            // 
            // RunButton
            // 
            RunButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RunButton.BackColor = SystemColors.Window;
            RunButton.ForeColor = SystemColors.ActiveCaptionText;
            RunButton.Location = new Point(611, 395);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(127, 29);
            RunButton.TabIndex = 3;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = false;
            RunButton.Click += RunButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 24);
            toolStripMenuItem1.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "import";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 451);
            Controls.Add(menuStrip1);
            Controls.Add(RunButton);
            Controls.Add(AvailableTasksList);
            Controls.Add(DescriptionBox);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Task Runner";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox DescriptionBox;
        private ListBox AvailableTasksList;
        private Button RunButton;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem importToolStripMenuItem;
    }
}
