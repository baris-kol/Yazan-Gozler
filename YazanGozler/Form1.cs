using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace YazanGozler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Speak_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoice("IVONA 2 Filiz");
                reader.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("İlk Önce Metin Giriniz.");
            }
        }

       
    }
}
