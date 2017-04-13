using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shadercontrol
{
    public partial class Form1 : Form
    {
        string[] lines = File.ReadAllLines("D:/Mastereffect.h");
        

        public Form1()
        {
            InitializeComponent();
        }

        private void bufferOn_Click(object sender, EventArgs e)
        {
            string bufferLine = lines[14];
            bufferLine = bufferLine.Replace(lines[14], "#define USE_DEPTHBUFFER_OUTPUT 1");
            lines[14] = bufferLine;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void bufferOff_Click(object sender, EventArgs e)
        {
            string bufferLine = lines[14];
            bufferLine = bufferLine.Replace(lines[14], "#define USE_DEPTHBUFFER_OUTPUT 0");
            lines[14] = bufferLine;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void manualFocusDepth_Scroll(object sender, EventArgs e)
        {
            double finalValue = manualFocusDepth.Value / 100d;
            focusDepthText.Text = finalValue.ToString();
        }

        private void manualFocusDepth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void manualFocusDepth_MouseUp(object sender, MouseEventArgs e)
        {
            double value = manualFocusDepth.Value / 10d;
            string valueToString = value.ToString();
            string cleanValue = valueToString.Replace(".", string.Empty);
            string valueStr = "#define DOF_MANUALFOCUSDEPTH 0" + "." + cleanValue;

            string focusDepth = lines[330];
            focusDepth = focusDepth.Replace(lines[330], valueStr);
            lines[330] = focusDepth;
            System.Threading.Thread.Sleep(2000);
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string focusDepth = lines[330];
            string blurRad = lines[328];
            focusDepth = focusDepth.Replace(lines[330], "#define DOF_MANUALFOCUSDEPTH 0");
            blurRad = blurRad.Replace(lines[328], "#define DOF_BLURRADIUS 5");
            lines[330] = focusDepth;
            lines[328] = blurRad;
            File.WriteAllLines("D:/MasterEffect.h", lines);
        }
        
        private void blurRadius_Scroll(object sender, EventArgs e)
        {
            double blurValue = blurRadius.Value;
            blurRadiusText.Text = blurValue.ToString();
        }

        private void blurRadius_MouseUp(object sender, MouseEventArgs e)
        {
            double blurValue = blurRadius.Value;
            string valueStr = "#define DOF_BLURRADIUS " + blurValue;

            string blurRad = lines[328];
            blurRad = blurRad.Replace(lines[328], valueStr);
            lines[328] = blurRad;
            System.Threading.Thread.Sleep(2000);
            File.WriteAllLines("D:/MasterEffect.h", lines);
        }

        private void spltOn_Click(object sender, EventArgs e)
        {
            string splitScrn = lines[15];
            splitScrn = splitScrn.Replace(lines[15], "#define USE_SPLITSCREEN 1");
            lines[15] = splitScrn;
            File.WriteAllLines("D:/MasterEffect.h", lines);
        }

        private void spltOff_Click(object sender, EventArgs e)
        {
            string splitScrn = lines[15];
            splitScrn = splitScrn.Replace(lines[15], "#define USE_SPLITSCREEN 0");
            lines[15] = splitScrn;
            File.WriteAllLines("D:/MasterEffect.h", lines);
        }

        private void bloomON_Click(object sender, EventArgs e)
        {
            string bloomOn = lines[53];
            bloomOn = bloomOn.Replace(lines[53], "#define USE_BLOOM 1");
            lines[53] = bloomOn;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void bloomOFF_Click(object sender, EventArgs e)
        {
            string bloomOff = lines[53];
            bloomOff = bloomOff.Replace(lines[53], "#define USE_BLOOM 0");
            lines[53] = bloomOff;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void ssaoON_Click(object sender, EventArgs e)
        {
            string ssaoOn = lines[60];
            ssaoOn = ssaoOn.Replace(lines[60], "#define USE_AMBIENTOCCLUSION 1");
            lines[60] = ssaoOn;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void ssaoOFF_Click(object sender, EventArgs e)
        {
            string ssaoOff = lines[60];
            ssaoOff = ssaoOff.Replace(lines[60], "#define USE_AMBIENTOCCLUSION 0");
            lines[60] = ssaoOff;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void depthSetBtn_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(depthSetBox.Text);

            if (value < 1 || value > 100)
            {
                MessageBox.Show("Please enter a number 1-100", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double newValue = value / 100d;
                string btnVar = newValue.ToString();
                string depthVal = "#define DOF_MANUALFOCUSDEPTH " + btnVar;

                focusDepthText.Text = btnVar;

                string focusDepth = lines[330];
                focusDepth = focusDepth.Replace(lines[330], depthVal);
                lines[330] = focusDepth;
                System.Threading.Thread.Sleep(2000);
                File.WriteAllLines("D:/MasterEffect.h", lines);
            }
        }

        private void blurSetBtn_Click(object sender, EventArgs e)
        {
            string btnVar = blurSetBox.Text;
            int blurInt = Convert.ToInt16(btnVar);

            if (blurInt < 5 || blurInt > 50)
            {
                MessageBox.Show("Please enter a number 5-50", "Incorrect value", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                string blurVal = "#define DOF_BLURRADIUS " + btnVar;

                blurRadiusText.Text = btnVar;

                string blurRadius = lines[328];
                blurRadius = blurRadius.Replace(lines[328], blurVal);
                lines[328] = blurRadius;
                System.Threading.Thread.Sleep(2000);
                File.WriteAllLines("D:/MasterEffect.h", lines);
            }
        }

        private void smaaON_Click(object sender, EventArgs e)
        {
            string smaaOn = lines[68];
            smaaOn = smaaOn.Replace(lines[68], "#define USE_SMAA 1");
            lines[68] = smaaOn;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }

        private void smaaOFF_Click(object sender, EventArgs e)
        {
            string smaaOff = lines[68];
            smaaOff = smaaOff.Replace(lines[68], "#define USE_SMAA 0");
            lines[68] = smaaOff;
            File.WriteAllLines("D:/Mastereffect.h", lines);
        }
    }
}
