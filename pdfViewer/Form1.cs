using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "PDF Dosyası |*.pdf";
            if (ofd.ShowDialog() ==DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                textBox1.Text = path;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDDocument doc = PDDocument.load(textBox1.Text);
            PDFTextStripper st = new PDFTextStripper();
            richTextBox1.Text = (st.getText(doc));



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".rtf";
            sfd.Filter = "RTF Dosyası |*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

            }
        }
    }
}
