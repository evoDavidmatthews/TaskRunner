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
            AvailableFunctionsList = new ListBox();
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
            DescriptionBox.Location = new Point(186, 20);
            DescriptionBox.Margin = new Padding(3, 2, 3, 2);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(515, 319);
            DescriptionBox.TabIndex = 1;
            // 
            // AvailableFunctionsList
            // 
            AvailableFunctionsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AvailableFunctionsList.BackColor = SystemColors.Window;
            AvailableFunctionsList.ForeColor = SystemColors.ActiveCaptionText;
            AvailableFunctionsList.FormattingEnabled = true;
            AvailableFunctionsList.ItemHeight = 15;
            AvailableFunctionsList.Location = new Point(0, 20);
            AvailableFunctionsList.Margin = new Padding(3, 2, 3, 2);
            AvailableFunctionsList.MaximumSize = new Size(181, 4);
            AvailableFunctionsList.MinimumSize = new Size(4, 750);
            AvailableFunctionsList.Name = "AvailableFunctionsList";
            AvailableFunctionsList.Size = new Size(181, 739);
            AvailableFunctionsList.TabIndex = 2;
            AvailableFunctionsList.SelectedIndexChanged += AvailableFunctionsList_SelectedIndexChanged;
            // 
            // RunButton
            // 
            RunButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RunButton.BackColor = SystemColors.Window;
            RunButton.ForeColor = SystemColors.ActiveCaptionText;
            RunButton.Location = new Point(535, 296);
            RunButton.Margin = new Padding(3, 2, 3, 2);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(111, 22);
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "import";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            Controls.Add(RunButton);
            Controls.Add(AvailableFunctionsList);
            Controls.Add(DescriptionBox);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private ListBox AvailableFunctionsList;
        private Button RunButton;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem importToolStripMenuItem;
    }
}
