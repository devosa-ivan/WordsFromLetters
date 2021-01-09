using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordsFromLetters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] abc_magyar = { "", " ","a", "á", "b", "c","d","e","é","f","g","h","i","j","k","l","m","n","ny","o","ó","ö","ő","p","q","r","s","sz","t","ty","dz","dzs","u","ú","ü","ű","x","y", "v", "w","z","zs",""};
        //private string[] abc_magyar = {"", " ", "a", "á", "b", "c", "d", ""};
        int abc_betuszama = 0;
        string[] abc;
        int pos_minus = 1;//szóköz helye
        int pos_actual = 2;//a betűvel kezd
        int pos_plus = 3;
    
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abc = abc_magyar;
            abc_betuszama = abc.Length;
            label_minus.Text = abc[pos_minus];
            label_actual.Text = abc[pos_actual];
            label_plus.Text = abc[pos_plus];

        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            if ((pos_plus + 1) < abc.Length)
            {
                debug();
                pos_minus++;
                label_minus.Text = abc[pos_minus];
                pos_actual++;
                label_actual.Text = abc[pos_actual];
                pos_plus++;
                label_plus.Text = abc[pos_plus];
                debug();
            }
            else
            {
                debug();
                pos_minus=0;
                label_minus.Text = abc[pos_minus];
                pos_actual=1;
                label_actual.Text = abc[pos_actual];
                pos_plus=2;
                label_plus.Text = abc[pos_plus];
                debug();
            }
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            if((pos_minus - 1) >= 0)
            {
                debug();
                pos_minus--;
                label_minus.Text = abc[pos_minus];
                pos_actual--;
                label_actual.Text = abc[pos_actual];
                pos_plus--;
                label_plus.Text = abc[pos_plus];
                debug();
            }
            else
            {
                debug();
                pos_minus = abc.Length - 3;
                label_minus.Text = abc[pos_minus];
                pos_actual = abc.Length - 2;
                label_actual.Text = abc[pos_actual];
                pos_plus = abc.Length-1;
                label_plus.Text = abc[pos_plus];
                debug();
            }
        }

        private void debug()
        {
            toolStripStatusLabel1.Text = pos_minus.ToString();
            toolStripStatusLabel2.Text = pos_actual.ToString();
            toolStripStatusLabel3.Text = pos_plus.ToString();


        }

        private void Button_select_word_Click(object sender, EventArgs e)
        {
            richTextBox_display_text.AppendText(abc[pos_actual]);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            button_plus.PerformClick();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                //button1_Click(this,e);
                button_select_word.PerformClick();
            if (e.KeyCode == Keys.RButton)
                button_select_word.PerformClick();
            if (e.KeyCode == Keys.Left)
                button_minus.PerformClick();
            if (e.KeyCode == Keys.Right)
                button_plus.PerformClick();
            //if (e.KeyCode == Keys.Space)
            //    button_Next_Question.PerformClick();

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void SúgóHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            if (DialogResult.Yes == MessageBox.Show("Elmenti a szöveget?" + Environment.NewLine + "Do you want to save the text?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            //e.Cancel = true; //kilépés megszakítása
            {
                //mentés
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //c# user document folder
                saveFileDialog1.Title = "Save text File";
                //saveFileDialog1.CheckFileExists = true;
                //saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox_display_text.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                    MessageBox.Show(saveFileDialog1.FileName,"Elmentve | Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
