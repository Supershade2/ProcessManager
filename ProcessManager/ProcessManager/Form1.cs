using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
namespace ProcessManager
{
    public partial class Form1 : Form
    {
        bool Isdrawn = false;
        Process p = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (EntryData.Load()) 
            {
                EntryListbox.Items.AddRange(EntryData.GetEntryKeys());
                EntryListbox.Visible = true;
            }
            else 
            {
                if (Isdrawn) 
                {
                    e.Graphics.Clear(DefaultBackColor);
                }
                else 
                {
                    String drawString = "Click here or drag in executable to modify";

                        // Create font and brush.
                        Font drawFont = new Font("Arial", 16);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        // Create rectangle for drawing.
                        float x = 0.0F;
                        float y = (Size.Height/2)-20;
                        float width = Size.Width;
                        float height = Size.Height;
                        RectangleF drawRect = new RectangleF(x, y, width, height);

                        // Draw rectangle to screen.
                        Pen blackPen = new Pen(Color.Black);
                        //e.Graphics.DrawRectangle(blackPen, x, y, width, height);

                        // Set format of string.
                        StringFormat drawFormat = new StringFormat();
                        drawFormat.Alignment = StringAlignment.Center;
                        // Draw string to screen.
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
                    Isdrawn = true;
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ExecutableName.Text = openFileDialog1.SafeFileName;
            EntryListbox.Items.Add(System.IO.Path.GetFileName(openFileDialog1.SafeFileName));
            if (!EntryListbox.Visible)
            {
                EntryListbox.Visible = true;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null) 
            {
                for (int i = 0; i < files.Length; i++) 
                {
                    if (files[i].EndsWith(".exe")) 
                    {
                        EntryListbox.Items.Add(System.IO.Path.GetFileName(files[i]));
                        if (!EntryListbox.Visible) 
                        {
                            EntryListbox.Visible = true;
                        }
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (KillProcessFlag.Checked) 
            {
                KillProcessFlag.Text = "Kill Process";
            }
            else 
            {
                KillProcessFlag.Text = "Kill Process?";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void EntryListbox_SelectedValueChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to save changes?", "Save changes", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) 
            {
                ManageData(false);
            }
            else 
            { 
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            switch (item.Text)
            {
                case "Add":
                    DialogResult dialogResult = MessageBox.Show("Select an executable","",MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK) 
                    {
                        ManageData(false);
                    }
                    break;
                case "Save":
                    break;
                case "Delete":
                    break;
                default:
                    break;
            }
        }
        private void ManageData(bool delete) 
        {
            List<bool> affinities = new List<bool>();
            foreach (var item in CPUAffinities.Items)
            {
                if (CPUAffinities.CheckedItems.Contains(item))
                {
                    affinities.Add(true);
                }
                else
                {
                    affinities.Add(false);
                }
            }
            EntryData.ManageEntries(new EntryObject(ExecutableName.Text, ProcessPriority.SelectedIndex, affinities, KillProcessFlag.Checked, delete));
        }

        private void CPUAffinities_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
