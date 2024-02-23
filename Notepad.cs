using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BT_qua_trinh.Buoi_05
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_noiDung.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Documents|*.txt";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = open_dialog.FileName;
                richTextBox_noiDung.Text = File.ReadAllText(file_path);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Documents|*.txt";
            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = save_dialog.FileName;
                using (StreamWriter writer = new StreamWriter(file_path))
                {
                    writer.Write(richTextBox_noiDung.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font_dialog = new FontDialog();
            if (font_dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox_noiDung.SelectionFont = font_dialog.Font;
            }
        }

        private void colorSelectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color_dialog = new ColorDialog();
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox_noiDung.SelectionColor = color_dialog.Color;
            }
        }

        private void colorBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color_dialog = new ColorDialog();
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox_noiDung.SelectionBackColor = color_dialog.Color;
            }
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about_notepad = new About();
            if (about_notepad.ShowDialog() == DialogResult.OK)
            {
                about_notepad.Close();
            }    
        }
    }
}
