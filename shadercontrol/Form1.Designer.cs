namespace shadercontrol
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.manualFocusDepth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blurRadius = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.bufferOn = new System.Windows.Forms.Button();
            this.bufferOff = new System.Windows.Forms.Button();
            this.focusDepthText = new System.Windows.Forms.Label();
            this.blurRadiusText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spltOff = new System.Windows.Forms.Button();
            this.spltOn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bloomOFF = new System.Windows.Forms.Button();
            this.bloomON = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ssaoOFF = new System.Windows.Forms.Button();
            this.ssaoON = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.depthSetBox = new System.Windows.Forms.TextBox();
            this.depthSetBtn = new System.Windows.Forms.Button();
            this.blurSetBtn = new System.Windows.Forms.Button();
            this.blurSetBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.smaaOFF = new System.Windows.Forms.Button();
            this.smaaON = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manualFocusDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // manualFocusDepth
            // 
            this.manualFocusDepth.Location = new System.Drawing.Point(12, 28);
            this.manualFocusDepth.Maximum = 100;
            this.manualFocusDepth.Name = "manualFocusDepth";
            this.manualFocusDepth.Size = new System.Drawing.Size(206, 45);
            this.manualFocusDepth.TabIndex = 0;
            this.manualFocusDepth.TickFrequency = 10;
            this.manualFocusDepth.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.manualFocusDepth.Scroll += new System.EventHandler(this.manualFocusDepth_Scroll);
            this.manualFocusDepth.ValueChanged += new System.EventHandler(this.manualFocusDepth_ValueChanged);
            this.manualFocusDepth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualFocusDepth_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Focus Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blur Radius";
            // 
            // blurRadius
            // 
            this.blurRadius.Location = new System.Drawing.Point(11, 106);
            this.blurRadius.Maximum = 50;
            this.blurRadius.Minimum = 5;
            this.blurRadius.Name = "blurRadius";
            this.blurRadius.Size = new System.Drawing.Size(207, 45);
            this.blurRadius.TabIndex = 3;
            this.blurRadius.TickFrequency = 5;
            this.blurRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.blurRadius.Value = 5;
            this.blurRadius.Scroll += new System.EventHandler(this.blurRadius_Scroll);
            this.blurRadius.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blurRadius_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show Depth Buffer";
            // 
            // bufferOn
            // 
            this.bufferOn.Location = new System.Drawing.Point(397, 28);
            this.bufferOn.Name = "bufferOn";
            this.bufferOn.Size = new System.Drawing.Size(75, 23);
            this.bufferOn.TabIndex = 5;
            this.bufferOn.Text = "On";
            this.bufferOn.UseVisualStyleBackColor = true;
            this.bufferOn.Click += new System.EventHandler(this.bufferOn_Click);
            // 
            // bufferOff
            // 
            this.bufferOff.Location = new System.Drawing.Point(484, 28);
            this.bufferOff.Name = "bufferOff";
            this.bufferOff.Size = new System.Drawing.Size(75, 23);
            this.bufferOff.TabIndex = 6;
            this.bufferOff.Text = "Off";
            this.bufferOff.UseVisualStyleBackColor = true;
            this.bufferOff.Click += new System.EventHandler(this.bufferOff_Click);
            // 
            // focusDepthText
            // 
            this.focusDepthText.AutoSize = true;
            this.focusDepthText.Location = new System.Drawing.Point(225, 43);
            this.focusDepthText.Name = "focusDepthText";
            this.focusDepthText.Size = new System.Drawing.Size(13, 13);
            this.focusDepthText.TabIndex = 7;
            this.focusDepthText.Text = "0";
            // 
            // blurRadiusText
            // 
            this.blurRadiusText.AutoSize = true;
            this.blurRadiusText.Location = new System.Drawing.Point(225, 120);
            this.blurRadiusText.Name = "blurRadiusText";
            this.blurRadiusText.Size = new System.Drawing.Size(13, 13);
            this.blurRadiusText.TabIndex = 8;
            this.blurRadiusText.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(509, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Copyright";
            // 
            // spltOff
            // 
            this.spltOff.Location = new System.Drawing.Point(484, 79);
            this.spltOff.Name = "spltOff";
            this.spltOff.Size = new System.Drawing.Size(75, 23);
            this.spltOff.TabIndex = 12;
            this.spltOff.Text = "Off";
            this.spltOff.UseVisualStyleBackColor = true;
            this.spltOff.Click += new System.EventHandler(this.spltOff_Click);
            // 
            // spltOn
            // 
            this.spltOn.Location = new System.Drawing.Point(397, 79);
            this.spltOn.Name = "spltOn";
            this.spltOn.Size = new System.Drawing.Size(75, 23);
            this.spltOn.TabIndex = 11;
            this.spltOn.Text = "On";
            this.spltOn.UseVisualStyleBackColor = true;
            this.spltOn.Click += new System.EventHandler(this.spltOn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enable Splitscreen";
            // 
            // bloomOFF
            // 
            this.bloomOFF.Location = new System.Drawing.Point(484, 128);
            this.bloomOFF.Name = "bloomOFF";
            this.bloomOFF.Size = new System.Drawing.Size(75, 23);
            this.bloomOFF.TabIndex = 15;
            this.bloomOFF.Text = "Off";
            this.bloomOFF.UseVisualStyleBackColor = true;
            this.bloomOFF.Click += new System.EventHandler(this.bloomOFF_Click);
            // 
            // bloomON
            // 
            this.bloomON.Location = new System.Drawing.Point(397, 128);
            this.bloomON.Name = "bloomON";
            this.bloomON.Size = new System.Drawing.Size(75, 23);
            this.bloomON.TabIndex = 14;
            this.bloomON.Text = "On";
            this.bloomON.UseVisualStyleBackColor = true;
            this.bloomON.Click += new System.EventHandler(this.bloomON_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enable Bloom";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssaoOFF
            // 
            this.ssaoOFF.Location = new System.Drawing.Point(484, 179);
            this.ssaoOFF.Name = "ssaoOFF";
            this.ssaoOFF.Size = new System.Drawing.Size(75, 23);
            this.ssaoOFF.TabIndex = 18;
            this.ssaoOFF.Text = "Off";
            this.ssaoOFF.UseVisualStyleBackColor = true;
            this.ssaoOFF.Click += new System.EventHandler(this.ssaoOFF_Click);
            // 
            // ssaoON
            // 
            this.ssaoON.Location = new System.Drawing.Point(397, 179);
            this.ssaoON.Name = "ssaoON";
            this.ssaoON.Size = new System.Drawing.Size(75, 23);
            this.ssaoON.TabIndex = 17;
            this.ssaoON.Text = "On";
            this.ssaoON.UseVisualStyleBackColor = true;
            this.ssaoON.Click += new System.EventHandler(this.ssaoON_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enable SSAO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthSetBox
            // 
            this.depthSetBox.Location = new System.Drawing.Point(261, 43);
            this.depthSetBox.Name = "depthSetBox";
            this.depthSetBox.Size = new System.Drawing.Size(100, 20);
            this.depthSetBox.TabIndex = 19;
            // 
            // depthSetBtn
            // 
            this.depthSetBtn.Location = new System.Drawing.Point(274, 69);
            this.depthSetBtn.Name = "depthSetBtn";
            this.depthSetBtn.Size = new System.Drawing.Size(75, 23);
            this.depthSetBtn.TabIndex = 20;
            this.depthSetBtn.Text = "Set Depth";
            this.depthSetBtn.UseVisualStyleBackColor = true;
            this.depthSetBtn.Click += new System.EventHandler(this.depthSetBtn_Click);
            // 
            // blurSetBtn
            // 
            this.blurSetBtn.Location = new System.Drawing.Point(274, 146);
            this.blurSetBtn.Name = "blurSetBtn";
            this.blurSetBtn.Size = new System.Drawing.Size(75, 23);
            this.blurSetBtn.TabIndex = 22;
            this.blurSetBtn.Text = "Set Blur";
            this.blurSetBtn.UseVisualStyleBackColor = true;
            this.blurSetBtn.Click += new System.EventHandler(this.blurSetBtn_Click);
            // 
            // blurSetBox
            // 
            this.blurSetBox.Location = new System.Drawing.Point(261, 120);
            this.blurSetBox.Name = "blurSetBox";
            this.blurSetBox.Size = new System.Drawing.Size(100, 20);
            this.blurSetBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "1-100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "5-50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(558, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "@CLCCO";
            // 
            // smaaOFF
            // 
            this.smaaOFF.Location = new System.Drawing.Point(484, 231);
            this.smaaOFF.Name = "smaaOFF";
            this.smaaOFF.Size = new System.Drawing.Size(75, 23);
            this.smaaOFF.TabIndex = 28;
            this.smaaOFF.Text = "Off";
            this.smaaOFF.UseVisualStyleBackColor = true;
            this.smaaOFF.Click += new System.EventHandler(this.smaaOFF_Click);
            // 
            // smaaON
            // 
            this.smaaON.Location = new System.Drawing.Point(397, 231);
            this.smaaON.Name = "smaaON";
            this.smaaON.Size = new System.Drawing.Size(75, 23);
            this.smaaON.TabIndex = 27;
            this.smaaON.Text = "On";
            this.smaaON.UseVisualStyleBackColor = true;
            this.smaaON.Click += new System.EventHandler(this.smaaON_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Enable SMAA";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 297);
            this.Controls.Add(this.smaaOFF);
            this.Controls.Add(this.smaaON);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.blurSetBtn);
            this.Controls.Add(this.blurSetBox);
            this.Controls.Add(this.depthSetBtn);
            this.Controls.Add(this.depthSetBox);
            this.Controls.Add(this.ssaoOFF);
            this.Controls.Add(this.ssaoON);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bloomOFF);
            this.Controls.Add(this.bloomON);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spltOff);
            this.Controls.Add(this.spltOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blurRadiusText);
            this.Controls.Add(this.focusDepthText);
            this.Controls.Add(this.bufferOff);
            this.Controls.Add(this.bufferOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blurRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualFocusDepth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DCPL\'s Shader Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.manualFocusDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar manualFocusDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar blurRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bufferOn;
        private System.Windows.Forms.Button bufferOff;
        private System.Windows.Forms.Label focusDepthText;
        private System.Windows.Forms.Label blurRadiusText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button spltOff;
        private System.Windows.Forms.Button spltOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bloomOFF;
        private System.Windows.Forms.Button bloomON;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ssaoOFF;
        private System.Windows.Forms.Button ssaoON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox depthSetBox;
        private System.Windows.Forms.Button depthSetBtn;
        private System.Windows.Forms.Button blurSetBtn;
        private System.Windows.Forms.TextBox blurSetBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button smaaOFF;
        private System.Windows.Forms.Button smaaON;
        private System.Windows.Forms.Label label11;
    }
}

