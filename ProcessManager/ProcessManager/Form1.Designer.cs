
namespace ProcessManager
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EntryListbox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ExecutableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessPriority = new System.Windows.Forms.ComboBox();
            this.CPUAffinities = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.KillProcessFlag = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "executable|*.exe";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EntryListbox
            // 
            this.EntryListbox.ContextMenuStrip = this.contextMenuStrip1;
            this.EntryListbox.FormattingEnabled = true;
            this.EntryListbox.ItemHeight = 15;
            this.EntryListbox.Location = new System.Drawing.Point(439, 12);
            this.EntryListbox.Name = "EntryListbox";
            this.EntryListbox.Size = new System.Drawing.Size(357, 319);
            this.EntryListbox.TabIndex = 0;
            this.EntryListbox.Visible = false;
            this.EntryListbox.SelectedValueChanged += new System.EventHandler(this.EntryListbox_SelectedValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Add";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Save";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Executable(*.exe):";
            this.label1.Visible = false;
            // 
            // ExecutableName
            // 
            this.ExecutableName.Location = new System.Drawing.Point(110, 22);
            this.ExecutableName.Name = "ExecutableName";
            this.ExecutableName.Size = new System.Drawing.Size(243, 23);
            this.ExecutableName.TabIndex = 2;
            this.ExecutableName.Visible = false;
            this.ExecutableName.Click += new System.EventHandler(this.textBox1_Click);
            this.ExecutableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Process priority:";
            this.label2.Visible = false;
            // 
            // ProcessPriority
            // 
            this.ProcessPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessPriority.FormattingEnabled = true;
            this.ProcessPriority.Items.AddRange(new object[] {
            "1 (low)",
            "2 (below normal)",
            "3 (normal)",
            "4 (above normal)",
            "5 (high)",
            "6 (realtime)"});
            this.ProcessPriority.Location = new System.Drawing.Point(110, 92);
            this.ProcessPriority.Name = "ProcessPriority";
            this.ProcessPriority.Size = new System.Drawing.Size(243, 23);
            this.ProcessPriority.TabIndex = 4;
            this.ProcessPriority.Visible = false;
            this.ProcessPriority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.ProcessPriority.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // CPUAffinities
            // 
            this.CPUAffinities.FormattingEnabled = true;
            this.CPUAffinities.Items.AddRange(new object[] {
            "<All Processors>"});
            this.CPUAffinities.Location = new System.Drawing.Point(110, 155);
            this.CPUAffinities.Name = "CPUAffinities";
            this.CPUAffinities.ScrollAlwaysVisible = true;
            this.CPUAffinities.Size = new System.Drawing.Size(243, 112);
            this.CPUAffinities.TabIndex = 5;
            this.CPUAffinities.Visible = false;
            this.CPUAffinities.VisibleChanged += new System.EventHandler(this.CPUAffinities_VisibleChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPU Affinity:";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KillProcessFlag
            // 
            this.KillProcessFlag.AutoSize = true;
            this.KillProcessFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KillProcessFlag.Location = new System.Drawing.Point(13, 277);
            this.KillProcessFlag.Name = "KillProcessFlag";
            this.KillProcessFlag.Size = new System.Drawing.Size(90, 19);
            this.KillProcessFlag.TabIndex = 10;
            this.KillProcessFlag.Text = "Kill Process?";
            this.KillProcessFlag.UseVisualStyleBackColor = true;
            this.KillProcessFlag.Visible = false;
            this.KillProcessFlag.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(340, 65);
            this.button4.TabIndex = 11;
            this.button4.Text = "Execute";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.KillProcessFlag);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPUAffinities);
            this.Controls.Add(this.ProcessPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecutableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntryListbox);
            this.Name = "Form1";
            this.Text = "ProcessManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox EntryListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExecutableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProcessPriority;
        private System.Windows.Forms.CheckedListBox CPUAffinities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox KillProcessFlag;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

