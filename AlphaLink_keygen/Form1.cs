using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlphaLink_keygen.Properties;
using NAudio.Wave;

namespace AlphaLink_keygen
{
    public partial class Form1 : Form
    {
        private string Md5Salt;
        private string trialSalt = "SlbjMF%%uB!eS8nYV8aOg65v0Wdb9w8kHeBysVnT7Wjowzz&sbi!9JXrCX#Rqb6uT*JZUoj@r^D8HVAwU*ZTe1wY8X7p6qXDUys9n4r0kU1Q7A^TqTbUSDI5cltxRBHL65^NzTAlv!75nO%aGnkhY7FRba9$ESrSvNC#*8Bo9lnxaTGdY8N#obWTLh&x5!Jg5gWLdzT*jNPK4jSwK9ZVxf96xujmaeuzU^3u^twItFEetKIVcAj!cM^Hv&";
        private string permanentSalt = "IK0c*D2nxZlFvEn@KYSt3P%9yBFEUme&8t4Une$J$zG3rFQdpryM$zYUp%ti^9EBV0bfDCipxPWM&suz&QISHeTbqcMGA9adG!Ng1VNyR8xor@BkBq2TmkLG5lvv&O@1i@3AavpH$YP9Vjy2CU^x$MNMaLtvV&h@dax7EmANTJdithg4CHDDVkUPu5HGYwKId$o2SSjO@YVgOYNSsBb#GoMsJxqgVZT&xd*v!G#Rs6fdaGIJGSWCJcWwb4";

        private bool muted = false;
        MemoryStream ms = new MemoryStream(Resources.music);
        private Mp3FileReader reader;
        WaveOut waveOut = new WaveOut(); // or WaveOutEvent()
        public Form1()
        {
            InitializeComponent();
            Icon = Resources.icon;
            Md5Salt = permanentSalt;
            UpdateVolumeButton();
            MusicInit();
        }

        private void UpdateVolumeButton()
        {
            if (muted)
                muteButton.BackgroundImage = Resources.music_off;
            
            else
                muteButton.BackgroundImage = Resources.music_on;
            
        }

        private void MusicInit()
        {
            reader = new Mp3FileReader(ms);
            waveOut.Init(reader);
            waveOut.PlaybackStopped += (sender, args) =>
            {
                reader.Seek(0, SeekOrigin.Begin);
                waveOut.Play();
            };
            waveOut.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toHash = registrationNumberTextBox.Text + usernameTextBox.Text + Md5Salt;
            MemoryStream ms = new MemoryStream(Encoding.ASCII.GetBytes(toHash));
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] a = md5.ComputeHash(ms);
            string encoded = BitConverter.ToString(a).Replace("-", string.Empty).ToUpper();
            char last = encoded.Last();
            for (int i = 1; i <= 4; i++)
            {
                encoded = encoded.Insert(i * 4 + i - 1, "-");
            }

            encoded = encoded.Insert(23, last.ToString());
            encoded = encoded.Substring(0, 24);
            resultTextBox.Text = encoded;
        }

        private void resultTextBox_Enter(object sender, EventArgs e)
        {
            if(resultTextBox.Text != "")
                Clipboard.SetText(resultTextBox.Text);
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton which = (RadioButton) sender;
            if (which.Text == "Permanent")
                Md5Salt = permanentSalt;
            
            else
                Md5Salt = trialSalt;
            
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            muted = !muted;

            waveOut.Volume = muted ? 0 : 1;
            UpdateVolumeButton();
        }
    }
}
