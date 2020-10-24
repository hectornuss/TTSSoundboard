using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace tts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SpeechSynthesizer ss_ = new SpeechSynthesizer();
            ss_.SetOutputToDefaultAudioDevice();
            ss_.Speak(richTextBox1.Text);
        }
    }
}
