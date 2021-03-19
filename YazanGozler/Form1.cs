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
using System.IO.Ports;

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
            timer1.Interval = 150;
            timer1.Enabled = true;
            timer2.Interval = 150;
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoice("IVONA 2 Filiz");
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 57600;
           // serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private string veri;
        int i = 0;
        int selected = 0;
        int choise = 0;
        int choiseGroup = 0;
        int seciliGroup = 0;
        int seciliHarf = 0;
        private void Speak_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text != "")
            {
                reader.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                reader.SpeakAsync("Acil! Lütfen bana yardım eder misin?");
            }
            richTextBox1.Text = "";
            Speak.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Start();
        }
        private void timerRestart()
        {
            timer2.Stop();
            timer2.Enabled = false;
            i = 0;
            choise = 0;
            choiseGroup = 0;
            seciliGroup = 0;
            seciliHarf = 0;
            veri = "0";
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
            button10.BackColor = Color.WhiteSmoke;
            button11.BackColor = Color.WhiteSmoke;
            button12.BackColor = Color.WhiteSmoke;
            button13.BackColor = Color.WhiteSmoke;
            button14.BackColor = Color.WhiteSmoke;
            button16.BackColor = Color.WhiteSmoke;
            button17.BackColor = Color.WhiteSmoke;
            button18.BackColor = Color.WhiteSmoke;
            button19.BackColor = Color.WhiteSmoke;
            button20.BackColor = Color.WhiteSmoke;
            button21.BackColor = Color.WhiteSmoke;
            button23.BackColor = Color.WhiteSmoke;
            button24.BackColor = Color.WhiteSmoke;
            button25.BackColor = Color.WhiteSmoke;
            button26.BackColor = Color.WhiteSmoke;
            button27.BackColor = Color.WhiteSmoke;
            button28.BackColor = Color.WhiteSmoke;
            button30.BackColor = Color.WhiteSmoke;
            button31.BackColor = Color.WhiteSmoke;
            button32.BackColor = Color.WhiteSmoke;
            button33.BackColor = Color.WhiteSmoke;
            button34.BackColor = Color.WhiteSmoke;
            button35.BackColor = Color.WhiteSmoke;
            button37.BackColor = Color.WhiteSmoke;
            button38.BackColor = Color.WhiteSmoke;
            button39.BackColor = Color.WhiteSmoke;
            button40.BackColor = Color.WhiteSmoke;
            button41.BackColor = Color.WhiteSmoke;
            button42.BackColor = Color.WhiteSmoke;
            Speak.BackColor = Color.WhiteSmoke;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "a";
            timerRestart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "b";
            timerRestart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "c";
            timerRestart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ç";
            timerRestart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "d";
            timerRestart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "e";
            timerRestart();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "f";
            timerRestart();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "g";
            timerRestart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ğ";
            timerRestart();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "h";
            timerRestart();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ı";
            timerRestart();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "i";
            timerRestart();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "j";
            timerRestart();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "k";
            timerRestart();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "l";
            timerRestart();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "m";
            timerRestart();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "n";
            timerRestart();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "o";
            timerRestart();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ö";
            timerRestart();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "p";
            timerRestart();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "r";
            timerRestart();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "s";
            timerRestart();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ş";
            timerRestart();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "t";
            timerRestart();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "u";
            timerRestart();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ü";
            timerRestart();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "v";
            timerRestart();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "y";
            timerRestart();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "z";
            timerRestart();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + " ";
            timerRestart();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string value = richTextBox1.Text;
            if (value == ""){
            }
            else
            {
                string removeLast = value.Substring(0, value.Length - 1);
                richTextBox1.Text = removeLast;
            }
            timerRestart();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            timerRestart();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
            timerRestart();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ",";
            timerRestart();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "?";
            timerRestart();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "!";
            timerRestart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selected == 0)
            {   
                button1.BackColor = Color.LightGreen;
                Speak.BackColor = Color.WhiteSmoke;
                seciliGroup = 0;
            }
            else if (selected == 1)
            { 
                button1.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.LightGreen;
                seciliGroup = 1;
            }
            else if (selected == 2)
            {   
                button8.BackColor = Color.WhiteSmoke;
                button15.BackColor = Color.LightGreen;
                seciliGroup = 2;
            }
            else if (selected == 3)
            {
                button15.BackColor = Color.WhiteSmoke;
                button22.BackColor = Color.LightGreen;
                seciliGroup = 3;
            }
            else if (selected == 4)
            {
                button22.BackColor = Color.WhiteSmoke;
                button29.BackColor = Color.LightGreen;
                seciliGroup = 4;

            }
            else if (selected == 5)
            { 
                button29.BackColor = Color.WhiteSmoke;
                button36.BackColor = Color.LightGreen;
                seciliGroup = 5;
            }
            else if (selected == 6)
            {
                button36.BackColor = Color.WhiteSmoke;
                Speak.BackColor = Color.LightGreen;
                seciliGroup = 6;
            }
            else selected = -1;
            if (i < 10)
            {
                i = i + 1;
            }
            else
            {
                selected = selected + 1;
                i = 0;

            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (choiseGroup == 0)
            {
                if (choise == 0)
                {
                    button2.BackColor = Color.LightGreen;
                    seciliHarf = 0;
                }
                else if (choise == 1)
                {
                    button2.BackColor = Color.WhiteSmoke;
                    button3.BackColor = Color.LightGreen;
                    seciliHarf = 1;
                }
                else if (choise == 2)
                {
                    button3.BackColor = Color.WhiteSmoke;
                    button4.BackColor = Color.LightGreen;
                    seciliHarf = 2;
                }
                else if (choise == 3)
                {
                    button4.BackColor = Color.WhiteSmoke;
                    button5.BackColor = Color.LightGreen;
                    seciliHarf = 3;
                }
                else if (choise == 4)
                {
                    button5.BackColor = Color.WhiteSmoke;
                    button6.BackColor = Color.LightGreen;
                    seciliHarf = 4;
                }
                else if (choise == 5)
                {
                    button6.BackColor = Color.WhiteSmoke;
                    button7.BackColor = Color.LightGreen;
                    seciliHarf = 5;
                }
                else timerRestart();
                 
            }
            else if (choiseGroup == 1){
                if (choise == 0)
                {
                    button9.BackColor = Color.LightGreen;
                    seciliHarf = 0;
                }
                else if (choise == 1)
                {
                    button9.BackColor = Color.WhiteSmoke;
                    button10.BackColor = Color.LightGreen;
                    seciliHarf = 1;
                }
                else if (choise == 2)
                {
                    button10.BackColor = Color.WhiteSmoke;
                    button11.BackColor = Color.LightGreen;
                    seciliHarf = 2;
                }
                else if (choise == 3)
                {
                    button11.BackColor = Color.WhiteSmoke;
                    button12.BackColor = Color.LightGreen;
                    seciliHarf = 3;
                }
                else if (choise == 4)
                {
                    button12.BackColor = Color.WhiteSmoke;
                    button13.BackColor = Color.LightGreen;
                    seciliHarf = 4;
                }
                else if (choise == 5)
                {
                    button13.BackColor = Color.WhiteSmoke;
                    button14.BackColor = Color.LightGreen;
                    seciliHarf = 5;
                }
                else timerRestart();
            }
            else if (choiseGroup == 2){
                if (choise == 0)
                {
                    button16.BackColor = Color.LightGreen;
                    seciliHarf = 0;
                }
                else if (choise == 1)
                {
                    button16.BackColor = Color.WhiteSmoke;
                    button17.BackColor = Color.LightGreen;
                    seciliHarf = 1;
                }
                else if (choise == 2)
                {
                    button17.BackColor = Color.WhiteSmoke;
                    button18.BackColor = Color.LightGreen;
                    seciliHarf = 2;
                }
                else if (choise == 3)
                {
                    button18.BackColor = Color.WhiteSmoke;
                    button19.BackColor = Color.LightGreen;
                    seciliHarf = 3;
                }
                else if (choise == 4)
                {
                    button19.BackColor = Color.WhiteSmoke;
                    button20.BackColor = Color.LightGreen;
                    seciliHarf = 4;
                }
                else if (choise == 5)
                {
                    button20.BackColor = Color.WhiteSmoke;
                    button21.BackColor = Color.LightGreen;
                    seciliHarf = 5;
                }
                else timerRestart();
            }
            else if (choiseGroup == 3){
                if (choise == 0)
                {
                    button23.BackColor = Color.LightGreen;
                    seciliHarf = 0;
                }
                else if (choise == 1)
                {
                    button23.BackColor = Color.WhiteSmoke;
                    button24.BackColor = Color.LightGreen;
                    seciliHarf = 1;
                }
                else if (choise == 2)
                {
                    button24.BackColor = Color.WhiteSmoke;
                    button25.BackColor = Color.LightGreen;
                    seciliHarf = 2;
                }
                else if (choise == 3)
                {
                    button25.BackColor = Color.WhiteSmoke;
                    button26.BackColor = Color.LightGreen;
                    seciliHarf = 3;
                }
                else if (choise == 4)
                {
                    button26.BackColor = Color.WhiteSmoke;
                    button27.BackColor = Color.LightGreen;
                    seciliHarf = 4;
                }
                else if (choise == 5)
                {
                    button27.BackColor = Color.WhiteSmoke;
                    button28.BackColor = Color.LightGreen;
                    seciliHarf = 5;
                }
                else timerRestart();
            }
            else if (choiseGroup == 4){
                if (choise == 0)
                {
                    button30.BackColor = Color.LightGreen;
                    seciliHarf = 0;
                }
                else if (choise == 1)
                {
                    button30.BackColor = Color.WhiteSmoke;
                    button31.BackColor = Color.LightGreen;
                    seciliHarf = 1;
                }
                else if (choise == 2)
                {
                    button31.BackColor = Color.WhiteSmoke;
                    button32.BackColor = Color.LightGreen;
                    seciliHarf = 2;
                }
                else if (choise == 3)
                {
                    button32.BackColor = Color.WhiteSmoke;
                    button33.BackColor = Color.LightGreen;
                    seciliHarf = 3;
                }
                else if (choise == 4)
                {
                    button33.BackColor = Color.WhiteSmoke;
                    button34.BackColor = Color.LightGreen;
                    seciliHarf = 4;
                }
                else if (choise == 5)
                {
                    button34.BackColor = Color.WhiteSmoke;
                    button35.BackColor = Color.LightGreen;
                    seciliHarf = 5;
                }
                else timerRestart();
            }
            else if (choiseGroup == 5){
                if (choise == 0)
                {
                    button37.BackColor = Color.LightGreen;
                    seciliHarf = 0;
                }
                else if (choise == 1)
                {
                    button37.BackColor = Color.WhiteSmoke;
                    button38.BackColor = Color.LightGreen;
                    seciliHarf = 1;
                }
                else if (choise == 2)
                {
                    button38.BackColor = Color.WhiteSmoke;
                    button39.BackColor = Color.LightGreen;
                    seciliHarf = 2;
                }
                else if (choise == 3)
                {
                    button39.BackColor = Color.WhiteSmoke;
                    button40.BackColor = Color.LightGreen;
                    seciliHarf = 3;
                }
                else if (choise == 4)
                {
                    button40.BackColor = Color.WhiteSmoke;
                    button41.BackColor = Color.LightGreen;
                    seciliHarf = 4;
                }
                else if (choise == 5)
                {
                    button41.BackColor = Color.WhiteSmoke;
                    button42.BackColor = Color.LightGreen;
                    seciliHarf = 5;
                }
                else timerRestart();
            }
            if( i < 10)
            {
                i++;
            }
            else
            {
                choise++;
                i = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Enabled = false;
            i = 0;
            selected = 0;
            choiseGroup = 0;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Enabled = false;
            i = 0;
            selected = 0;
            choiseGroup = 1;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Enabled = false;
            i = 0;
            selected = 0;
            choiseGroup = 2;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Enabled = false;
            i = 0;
            selected = 0;
            choiseGroup = 3;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Enabled = false;
            i = 0;
            selected = 0;
            choiseGroup = 4;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.WhiteSmoke;
            timer1.Stop();
            timer1.Enabled = false;
            i = 0;
            selected = 0;
            choiseGroup = 5;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            veri = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displayData_event));
        }
        private void displayData_event(object sender, EventArgs e)
        {

            int deger = Convert.ToInt16(veri);
            if(deger == 1)
            {
                metinYaz(sender, e);
            }
            
        }
        
        private void metinYaz(object sender, EventArgs e)
        {
            
            if (button1.BackColor.ToString() == "Color [LightGreen]") button1_Click(sender, e);
            else if (button8.BackColor.ToString() == "Color [LightGreen]") button8_Click(sender, e);
            else if (button15.BackColor.ToString() == "Color [LightGreen]") button15_Click(sender, e);
            else if (button22.BackColor.ToString() == "Color [LightGreen]") button22_Click(sender, e);
            else if (button29.BackColor.ToString() == "Color [LightGreen]") button29_Click(sender, e);
            else if (button36.BackColor.ToString() == "Color [LightGreen]") button36_Click(sender, e);
            else if (Speak.BackColor.ToString() == "Color [LightGreen]") Speak_Click(sender, e);
            else if (button2.BackColor.ToString() == "Color [LightGreen]") button2_Click(sender, e);
            else if (button3.BackColor.ToString() == "Color [LightGreen]") button3_Click(sender, e);
            else if (button4.BackColor.ToString() == "Color [LightGreen]") button4_Click(sender, e);
            else if (button5.BackColor.ToString() == "Color [LightGreen]") button5_Click(sender, e);
            else if (button6.BackColor.ToString() == "Color [LightGreen]") button6_Click(sender, e);
            else if (button7.BackColor.ToString() == "Color [LightGreen]") button7_Click(sender, e);
            else if (button9.BackColor.ToString() == "Color [LightGreen]") button9_Click(sender, e);
            else if (button10.BackColor.ToString() == "Color [LightGreen]") button10_Click(sender, e);
            else if (button11.BackColor.ToString() == "Color [LightGreen]") button11_Click(sender, e);
            else if (button12.BackColor.ToString() == "Color [LightGreen]") button12_Click(sender, e);
            else if (button13.BackColor.ToString() == "Color [LightGreen]") button13_Click(sender, e);
            else if (button14.BackColor.ToString() == "Color [LightGreen]") button14_Click(sender, e);
            else if (button16.BackColor.ToString() == "Color [LightGreen]") button16_Click(sender, e);
            else if (button17.BackColor.ToString() == "Color [LightGreen]") button17_Click(sender, e);
            else if (button18.BackColor.ToString() == "Color [LightGreen]") button18_Click(sender, e);
            else if (button19.BackColor.ToString() == "Color [LightGreen]") button19_Click(sender, e);
            else if (button20.BackColor.ToString() == "Color [LightGreen]") button20_Click(sender, e);
            else if (button21.BackColor.ToString() == "Color [LightGreen]") button21_Click(sender, e);
            else if (button23.BackColor.ToString() == "Color [LightGreen]") button23_Click(sender, e);
            else if (button24.BackColor.ToString() == "Color [LightGreen]") button24_Click(sender, e);
            else if (button25.BackColor.ToString() == "Color [LightGreen]") button25_Click(sender, e);
            else if (button26.BackColor.ToString() == "Color [LightGreen]") button26_Click(sender, e);
            else if (button27.BackColor.ToString() == "Color [LightGreen]") button27_Click(sender, e);
            else if (button28.BackColor.ToString() == "Color [LightGreen]") button28_Click(sender, e);
            else if (button30.BackColor.ToString() == "Color [LightGreen]") button30_Click(sender, e);
            else if (button31.BackColor.ToString() == "Color [LightGreen]") button31_Click(sender, e);
            else if (button32.BackColor.ToString() == "Color [LightGreen]") button32_Click(sender, e);
            else if (button33.BackColor.ToString() == "Color [LightGreen]") button33_Click(sender, e);
            else if (button34.BackColor.ToString() == "Color [LightGreen]") button34_Click(sender, e);
            else if (button35.BackColor.ToString() == "Color [LightGreen]") button35_Click(sender, e);
            else if (button37.BackColor.ToString() == "Color [LightGreen]") button37_Click(sender, e);
            else if (button38.BackColor.ToString() == "Color [LightGreen]") button38_Click(sender, e);
            else if (button39.BackColor.ToString() == "Color [LightGreen]") button39_Click(sender, e);
            else if (button40.BackColor.ToString() == "Color [LightGreen]") button40_Click(sender, e);
            else if (button41.BackColor.ToString() == "Color [LightGreen]") button41_Click(sender, e);
            else if (button42.BackColor.ToString() == "Color [LightGreen]") button42_Click(sender, e);
          
            /*
            if (timer1.Enabled)
            {
                if (seciliGroup == 0) button1_Click(sender, e);
                else if (seciliGroup == 1) button8_Click(sender, e);
                else if (seciliGroup == 2) button15_Click(sender, e);
                else if (seciliGroup == 3) button22_Click(sender, e);
                else if (seciliGroup == 4) button29_Click(sender, e);
                else if (seciliGroup == 5) button36_Click(sender, e);
                else if (seciliGroup == 6) Speak_Click(sender, e);
            }
            else
            {
                if (choiseGroup == 0 && seciliHarf == 0) button2_Click(sender, e);
                else if (choiseGroup == 0 && seciliHarf == 1) button3_Click(sender, e);
                else if (choiseGroup == 0 && seciliHarf == 2) button4_Click(sender, e);
                else if (choiseGroup == 0 && seciliHarf == 3) button5_Click(sender, e);
                else if (choiseGroup == 0 && seciliHarf == 4) button6_Click(sender, e);
                else if (choiseGroup == 0 && seciliHarf == 5) button7_Click(sender, e);
                else if (choiseGroup == 1 && seciliHarf == 0) button9_Click(sender, e);
                else if (choiseGroup == 1 && seciliHarf == 1) button10_Click(sender, e);
                else if (choiseGroup == 1 && seciliHarf == 2) button11_Click(sender, e);
                else if (choiseGroup == 1 && seciliHarf == 3) button12_Click(sender, e);
                else if (choiseGroup == 1 && seciliHarf == 4) button13_Click(sender, e);
                else if (choiseGroup == 1 && seciliHarf == 5) button14_Click(sender, e);
                else if (choiseGroup == 2 && seciliHarf == 0) button16_Click(sender, e);
                else if (choiseGroup == 2 && seciliHarf == 1) button17_Click(sender, e);
                else if (choiseGroup == 2 && seciliHarf == 2) button18_Click(sender, e);
                else if (choiseGroup == 2 && seciliHarf == 3) button19_Click(sender, e);
                else if (choiseGroup == 2 && seciliHarf == 4) button20_Click(sender, e);
                else if (choiseGroup == 2 && seciliHarf == 5) button21_Click(sender, e);
                else if (choiseGroup == 3 && seciliHarf == 0) button23_Click(sender, e);
                else if (choiseGroup == 3 && seciliHarf == 1) button24_Click(sender, e);
                else if (choiseGroup == 3 && seciliHarf == 2) button25_Click(sender, e);
                else if (choiseGroup == 3 && seciliHarf == 3) button26_Click(sender, e);
                else if (choiseGroup == 3 && seciliHarf == 4) button27_Click(sender, e);
                else if (choiseGroup == 3 && seciliHarf == 5) button28_Click(sender, e);
                else if (choiseGroup == 4 && seciliHarf == 0) button30_Click(sender, e);
                else if (choiseGroup == 4 && seciliHarf == 1) button31_Click(sender, e);
                else if (choiseGroup == 4 && seciliHarf == 2) button32_Click(sender, e);
                else if (choiseGroup == 4 && seciliHarf == 3) button33_Click(sender, e);
                else if (choiseGroup == 4 && seciliHarf == 4) button34_Click(sender, e);
                else if (choiseGroup == 4 && seciliHarf == 5) button35_Click(sender, e);
                else if (choiseGroup == 5 && seciliHarf == 0) button37_Click(sender, e);
                else if (choiseGroup == 5 && seciliHarf == 1) button38_Click(sender, e);
                else if (choiseGroup == 5 && seciliHarf == 2) button39_Click(sender, e);
                else if (choiseGroup == 5 && seciliHarf == 3) button40_Click(sender, e);
                else if (choiseGroup == 5 && seciliHarf == 4) button41_Click(sender, e);
                else if (choiseGroup == 5 && seciliHarf == 5) button42_Click(sender, e);
            }*/
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }
    }
}
