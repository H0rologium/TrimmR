using FlyleafLib.MediaPlayer;

namespace TrimmR
{
    partial class TrimmR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ffmpeglabel = new System.Windows.Forms.Label();
            this.OpenFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.openbtn = new System.Windows.Forms.Button();
            this.videopane = new System.Windows.Forms.Panel();
            this.flyleafplayer = new FlyleafLib.Controls.Flyleaf();
            this.pausebtn = new System.Windows.Forms.Button();
            this.timelabel = new System.Windows.Forms.Label();
            this.startpointbtn = new System.Windows.Forms.Button();
            this.endpointbtn = new System.Windows.Forms.Button();
            this.splabel = new System.Windows.Forms.Label();
            this.eplabel = new System.Windows.Forms.Label();
            this.resetptsbtn = new System.Windows.Forms.Button();
            this.trimandexportbtn = new System.Windows.Forms.Button();
            this.replayfromstartbtn = new System.Windows.Forms.Button();
            this.skiplabel = new System.Windows.Forms.Label();
            this.skipfwbtn1 = new System.Windows.Forms.Button();
            this.skipfwbtn2 = new System.Windows.Forms.Button();
            this.skipfwbtn3 = new System.Windows.Forms.Button();
            this.skipbwbtn1 = new System.Windows.Forms.Button();
            this.skipbwbtn2 = new System.Windows.Forms.Button();
            this.skipbwbtn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unloadbtn = new System.Windows.Forms.Button();
            this.skipField = new System.Windows.Forms.TextBox();
            this.jmpBtn = new System.Windows.Forms.Button();
            this.jumptoHelp = new System.Windows.Forms.Button();
            this.videopane.SuspendLayout();
            this.SuspendLayout();
            // 
            // ffmpeglabel
            // 
            this.ffmpeglabel.AutoSize = true;
            this.ffmpeglabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ffmpeglabel.ForeColor = System.Drawing.Color.Black;
            this.ffmpeglabel.Location = new System.Drawing.Point(25, 20);
            this.ffmpeglabel.Name = "ffmpeglabel";
            this.ffmpeglabel.Size = new System.Drawing.Size(24, 32);
            this.ffmpeglabel.TabIndex = 0;
            this.ffmpeglabel.Text = "_";
            // 
            // OpenFileDiag
            // 
            this.OpenFileDiag.FileName = "OpenFileDiag";
            this.OpenFileDiag.Title = "Open Video File";
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(344, 20);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(119, 32);
            this.openbtn.TabIndex = 1;
            this.openbtn.Text = "Open Video";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.PickFile_Click);
            // 
            // videopane
            // 
            this.videopane.Controls.Add(this.flyleafplayer);
            this.videopane.Location = new System.Drawing.Point(1, 99);
            this.videopane.Name = "videopane";
            this.videopane.Size = new System.Drawing.Size(420, 339);
            this.videopane.TabIndex = 2;
            // 
            // flyleafplayer
            // 
            this.flyleafplayer.BackColor = System.Drawing.Color.Black;
            this.flyleafplayer.Location = new System.Drawing.Point(0, 0);
            this.flyleafplayer.Name = "flyleafplayer";
            this.flyleafplayer.Size = new System.Drawing.Size(420, 339);
            this.flyleafplayer.TabIndex = 0;
            // 
            // pausebtn
            // 
            this.pausebtn.Location = new System.Drawing.Point(431, 101);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(357, 27);
            this.pausebtn.TabIndex = 3;
            this.pausebtn.Text = "PAUSE";
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtnclick);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.timelabel.Location = new System.Drawing.Point(114, 64);
            this.timelabel.MinimumSize = new System.Drawing.Size(120, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(120, 32);
            this.timelabel.TabIndex = 4;
            this.timelabel.Text = "Time:";
            // 
            // startpointbtn
            // 
            this.startpointbtn.Location = new System.Drawing.Point(430, 133);
            this.startpointbtn.Name = "startpointbtn";
            this.startpointbtn.Size = new System.Drawing.Size(127, 44);
            this.startpointbtn.TabIndex = 5;
            this.startpointbtn.Text = "Mark Start Point";
            this.startpointbtn.UseVisualStyleBackColor = true;
            this.startpointbtn.Click += new System.EventHandler(this.markStartTrim);
            // 
            // endpointbtn
            // 
            this.endpointbtn.Location = new System.Drawing.Point(431, 183);
            this.endpointbtn.Name = "endpointbtn";
            this.endpointbtn.Size = new System.Drawing.Size(127, 44);
            this.endpointbtn.TabIndex = 6;
            this.endpointbtn.Text = "Mark End Point (EOF by default)";
            this.endpointbtn.UseVisualStyleBackColor = true;
            this.endpointbtn.Click += new System.EventHandler(this.markEndTrim);
            // 
            // splabel
            // 
            this.splabel.AutoSize = true;
            this.splabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.splabel.Location = new System.Drawing.Point(563, 140);
            this.splabel.Name = "splabel";
            this.splabel.Size = new System.Drawing.Size(78, 25);
            this.splabel.TabIndex = 7;
            this.splabel.Text = "SPLabel";
            // 
            // eplabel
            // 
            this.eplabel.AutoSize = true;
            this.eplabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eplabel.ForeColor = System.Drawing.Color.Cyan;
            this.eplabel.Location = new System.Drawing.Point(563, 190);
            this.eplabel.Name = "eplabel";
            this.eplabel.Size = new System.Drawing.Size(78, 25);
            this.eplabel.TabIndex = 8;
            this.eplabel.Text = "EPLabel";
            // 
            // resetptsbtn
            // 
            this.resetptsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetptsbtn.Location = new System.Drawing.Point(658, 166);
            this.resetptsbtn.Name = "resetptsbtn";
            this.resetptsbtn.Size = new System.Drawing.Size(120, 30);
            this.resetptsbtn.TabIndex = 9;
            this.resetptsbtn.Text = "Reset Points";
            this.resetptsbtn.UseVisualStyleBackColor = true;
            this.resetptsbtn.Click += new System.EventHandler(this.resetPoints);
            // 
            // trimandexportbtn
            // 
            this.trimandexportbtn.BackColor = System.Drawing.Color.Gray;
            this.trimandexportbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trimandexportbtn.ForeColor = System.Drawing.Color.Lime;
            this.trimandexportbtn.Location = new System.Drawing.Point(425, 396);
            this.trimandexportbtn.Name = "trimandexportbtn";
            this.trimandexportbtn.Size = new System.Drawing.Size(370, 47);
            this.trimandexportbtn.TabIndex = 10;
            this.trimandexportbtn.Text = "Trim and Export";
            this.trimandexportbtn.UseVisualStyleBackColor = false;
            this.trimandexportbtn.Click += new System.EventHandler(this.exportTrim);
            // 
            // replayfromstartbtn
            // 
            this.replayfromstartbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.replayfromstartbtn.Location = new System.Drawing.Point(431, 230);
            this.replayfromstartbtn.Name = "replayfromstartbtn";
            this.replayfromstartbtn.Size = new System.Drawing.Size(357, 27);
            this.replayfromstartbtn.TabIndex = 11;
            this.replayfromstartbtn.Text = "Replay From Start";
            this.replayfromstartbtn.UseVisualStyleBackColor = true;
            this.replayfromstartbtn.Click += new System.EventHandler(this.replayFromStart);
            // 
            // skiplabel
            // 
            this.skiplabel.AutoSize = true;
            this.skiplabel.BackColor = System.Drawing.Color.Silver;
            this.skiplabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skiplabel.Location = new System.Drawing.Point(431, 263);
            this.skiplabel.Name = "skiplabel";
            this.skiplabel.Size = new System.Drawing.Size(203, 21);
            this.skiplabel.TabIndex = 12;
            this.skiplabel.Text = "Skip Ahead / Skip Backward";
            // 
            // skipfwbtn1
            // 
            this.skipfwbtn1.Location = new System.Drawing.Point(431, 296);
            this.skipfwbtn1.Name = "skipfwbtn1";
            this.skipfwbtn1.Size = new System.Drawing.Size(39, 23);
            this.skipfwbtn1.TabIndex = 13;
            this.skipfwbtn1.Text = ">";
            this.skipfwbtn1.UseVisualStyleBackColor = true;
            this.skipfwbtn1.Click += new System.EventHandler(this.skipFw1Sec);
            // 
            // skipfwbtn2
            // 
            this.skipfwbtn2.Location = new System.Drawing.Point(431, 325);
            this.skipfwbtn2.Name = "skipfwbtn2";
            this.skipfwbtn2.Size = new System.Drawing.Size(39, 23);
            this.skipfwbtn2.TabIndex = 14;
            this.skipfwbtn2.Text = ">>";
            this.skipfwbtn2.UseVisualStyleBackColor = true;
            this.skipfwbtn2.Click += new System.EventHandler(this.skipFW30Seconds);
            // 
            // skipfwbtn3
            // 
            this.skipfwbtn3.Location = new System.Drawing.Point(430, 354);
            this.skipfwbtn3.Name = "skipfwbtn3";
            this.skipfwbtn3.Size = new System.Drawing.Size(40, 23);
            this.skipfwbtn3.TabIndex = 15;
            this.skipfwbtn3.Text = ">>>";
            this.skipfwbtn3.UseVisualStyleBackColor = true;
            this.skipfwbtn3.Click += new System.EventHandler(this.skipFW1Minute);
            // 
            // skipbwbtn1
            // 
            this.skipbwbtn1.Location = new System.Drawing.Point(549, 296);
            this.skipbwbtn1.Name = "skipbwbtn1";
            this.skipbwbtn1.Size = new System.Drawing.Size(39, 23);
            this.skipbwbtn1.TabIndex = 16;
            this.skipbwbtn1.Text = "<";
            this.skipbwbtn1.UseVisualStyleBackColor = true;
            this.skipbwbtn1.Click += new System.EventHandler(this.skipBW1Second);
            // 
            // skipbwbtn2
            // 
            this.skipbwbtn2.Location = new System.Drawing.Point(549, 325);
            this.skipbwbtn2.Name = "skipbwbtn2";
            this.skipbwbtn2.Size = new System.Drawing.Size(39, 23);
            this.skipbwbtn2.TabIndex = 17;
            this.skipbwbtn2.Text = "<<";
            this.skipbwbtn2.UseVisualStyleBackColor = true;
            this.skipbwbtn2.Click += new System.EventHandler(this.skipBW30Seconds);
            // 
            // skipbwbtn3
            // 
            this.skipbwbtn3.Location = new System.Drawing.Point(549, 356);
            this.skipbwbtn3.Name = "skipbwbtn3";
            this.skipbwbtn3.Size = new System.Drawing.Size(39, 23);
            this.skipbwbtn3.TabIndex = 18;
            this.skipbwbtn3.Text = "<<<";
            this.skipbwbtn3.UseVisualStyleBackColor = true;
            this.skipbwbtn3.Click += new System.EventHandler(this.skipBW1Minute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(470, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "1 Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(469, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "30 Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(469, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "1 Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(594, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "1 Second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(594, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "30 Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(594, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "1 Minute";
            // 
            // unloadbtn
            // 
            this.unloadbtn.Location = new System.Drawing.Point(605, 72);
            this.unloadbtn.Name = "unloadbtn";
            this.unloadbtn.Size = new System.Drawing.Size(183, 23);
            this.unloadbtn.TabIndex = 24;
            this.unloadbtn.Text = "Stop / Close";
            this.unloadbtn.UseVisualStyleBackColor = true;
            this.unloadbtn.Click += new System.EventHandler(this.stopAndUnload);
            // 
            // skipField
            // 
            this.skipField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skipField.Location = new System.Drawing.Point(688, 263);
            this.skipField.MaxLength = 8;
            this.skipField.Name = "skipField";
            this.skipField.Size = new System.Drawing.Size(100, 29);
            this.skipField.TabIndex = 25;
            this.skipField.Text = "hh:mm:ss";
            this.skipField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skipField.Click += new System.EventHandler(this.jumpFieldClick);
            // 
            // jmpBtn
            // 
            this.jmpBtn.Location = new System.Drawing.Point(688, 296);
            this.jmpBtn.Name = "jmpBtn";
            this.jmpBtn.Size = new System.Drawing.Size(65, 23);
            this.jmpBtn.TabIndex = 26;
            this.jmpBtn.Text = "Jump To";
            this.jmpBtn.UseVisualStyleBackColor = true;
            this.jmpBtn.Click += new System.EventHandler(this.jumpToSpecificTime);
            // 
            // jumptoHelp
            // 
            this.jumptoHelp.Location = new System.Drawing.Point(759, 296);
            this.jumptoHelp.Name = "jumptoHelp";
            this.jumptoHelp.Size = new System.Drawing.Size(29, 23);
            this.jumptoHelp.TabIndex = 27;
            this.jumptoHelp.Text = "?";
            this.jumptoHelp.UseVisualStyleBackColor = true;
            this.jumptoHelp.Click += new System.EventHandler(this.showJumpToHelp);
            // 
            // TrimmR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jumptoHelp);
            this.Controls.Add(this.jmpBtn);
            this.Controls.Add(this.skipField);
            this.Controls.Add(this.unloadbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skipbwbtn3);
            this.Controls.Add(this.skipbwbtn2);
            this.Controls.Add(this.skipbwbtn1);
            this.Controls.Add(this.skipfwbtn3);
            this.Controls.Add(this.skipfwbtn2);
            this.Controls.Add(this.skipfwbtn1);
            this.Controls.Add(this.skiplabel);
            this.Controls.Add(this.replayfromstartbtn);
            this.Controls.Add(this.trimandexportbtn);
            this.Controls.Add(this.resetptsbtn);
            this.Controls.Add(this.eplabel);
            this.Controls.Add(this.splabel);
            this.Controls.Add(this.endpointbtn);
            this.Controls.Add(this.startpointbtn);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.videopane);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.ffmpeglabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrimmR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrimmR";
            this.videopane.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        #region Model Methods
        private Label ffmpeglabel; 
        private void UpdateFFMPEGLabelText(string newContent)
        {
            ffmpeglabel.Text = newContent;
            return;
        }
        private void UpdateTimeStamps(long currenttime, long videolength)
        {
            if (videolength != duration) convertTime(videolength, true);
            timelabel.Text = $"Time: {convertTime(currenttime)}";
            return;
        }
        private long duration;
        private string convertTime(long unit, bool durationn = false)
        {
            
            if (unit <= 0) return "err";
            string sunit = unit.ToString();
            if (durationn)duration = unit;
            return $"{sunit.Substring(0,sunit.Length-7)}:{sunit.Substring(sunit.Length-6, sunit.Length-6)} / {duration.ToString().Substring(0,duration.ToString().Length-7)}:{duration.ToString().Substring(duration.ToString().Length-6,duration.ToString().Length-7)}";
        }
        private void skipTo(int millisAmountToSkipBy, bool forwards = true)
        {
            if (!player.CanPlay) return;
            if (player.IsPlaying) pausebtnclick(new object(), new EventArgs());
            Thread.Sleep(300);
            player.Seek(millisAmountToSkipBy*1000,forwards);
            return;
        }
        #endregion
        private OpenFileDialog OpenFileDiag;
        private Button openbtn;
        private Panel videopane;
        private FlyleafLib.Controls.Flyleaf flyleafplayer;
        private Button pausebtn;
        private Label timelabel;
        private Button startpointbtn;
        private Button endpointbtn;
        private Label splabel;
        private Label eplabel;
        private Button resetptsbtn;
        private Button trimandexportbtn;
        private Button replayfromstartbtn;
        private Label skiplabel;
        private Button skipfwbtn1;
        private Button skipfwbtn2;
        private Button skipfwbtn3;
        private Button skipbwbtn1;
        private Button skipbwbtn2;
        private Button skipbwbtn3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button unloadbtn;
        private TextBox skipField;
        private Button jmpBtn;
        private Button jumptoHelp;
    }
}