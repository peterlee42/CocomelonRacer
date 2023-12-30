namespace Cocomelonracer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.btnPauseRace = new System.Windows.Forms.Button();
            this.btnResetRace = new System.Windows.Forms.Button();
            this.RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.gbRaceSettings = new System.Windows.Forms.GroupBox();
            this.rbPicMode = new System.Windows.Forms.RadioButton();
            this.txtTrackLength = new System.Windows.Forms.TextBox();
            this.rbDrawMode = new System.Windows.Forms.RadioButton();
            this.lblTrackLength = new System.Windows.Forms.Label();
            this.txtRaceSpeed = new System.Windows.Forms.TextBox();
            this.lblRaceSpeed = new System.Windows.Forms.Label();
            this.btnChangeTortCol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetScoreBoard = new System.Windows.Forms.Button();
            this.txtTieOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHareWinOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTortWinOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGlobalTies = new System.Windows.Forms.TextBox();
            this.lblGlobalTies = new System.Windows.Forms.Label();
            this.txtGlobalHWins = new System.Windows.Forms.TextBox();
            this.lblGlobalHWins = new System.Windows.Forms.Label();
            this.txtGlobalTWins = new System.Windows.Forms.TextBox();
            this.lblGlobalTWins = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cStatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbBonk = new System.Windows.Forms.PictureBox();
            this.pbCOCOMELON = new System.Windows.Forms.PictureBox();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.pbTort = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeHareCol = new System.Windows.Forms.Button();
            this.btnConfirmSettings = new System.Windows.Forms.Button();
            this.gbRaceSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cStatChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBonk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCOCOMELON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartRace
            // 
            this.btnStartRace.Location = new System.Drawing.Point(6, 24);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(185, 23);
            this.btnStartRace.TabIndex = 1;
            this.btnStartRace.Text = "Start";
            this.btnStartRace.UseVisualStyleBackColor = true;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // btnPauseRace
            // 
            this.btnPauseRace.Enabled = false;
            this.btnPauseRace.Location = new System.Drawing.Point(6, 53);
            this.btnPauseRace.Name = "btnPauseRace";
            this.btnPauseRace.Size = new System.Drawing.Size(185, 23);
            this.btnPauseRace.TabIndex = 2;
            this.btnPauseRace.Text = "Pause";
            this.btnPauseRace.UseVisualStyleBackColor = true;
            this.btnPauseRace.Click += new System.EventHandler(this.btnPauseRace_Click);
            // 
            // btnResetRace
            // 
            this.btnResetRace.Location = new System.Drawing.Point(6, 82);
            this.btnResetRace.Name = "btnResetRace";
            this.btnResetRace.Size = new System.Drawing.Size(185, 23);
            this.btnResetRace.TabIndex = 3;
            this.btnResetRace.Text = "Reset";
            this.btnResetRace.UseVisualStyleBackColor = true;
            this.btnResetRace.Click += new System.EventHandler(this.btnResetRace_Click);
            // 
            // RaceTimer
            // 
            this.RaceTimer.Tick += new System.EventHandler(this.RaceTimer_Tick);
            // 
            // gbRaceSettings
            // 
            this.gbRaceSettings.Controls.Add(this.btnChangeHareCol);
            this.gbRaceSettings.Controls.Add(this.btnChangeTortCol);
            this.gbRaceSettings.Controls.Add(this.rbPicMode);
            this.gbRaceSettings.Controls.Add(this.txtTrackLength);
            this.gbRaceSettings.Controls.Add(this.rbDrawMode);
            this.gbRaceSettings.Controls.Add(this.lblTrackLength);
            this.gbRaceSettings.Controls.Add(this.btnConfirmSettings);
            this.gbRaceSettings.Controls.Add(this.txtRaceSpeed);
            this.gbRaceSettings.Controls.Add(this.lblRaceSpeed);
            this.gbRaceSettings.Location = new System.Drawing.Point(530, 218);
            this.gbRaceSettings.Name = "gbRaceSettings";
            this.gbRaceSettings.Size = new System.Drawing.Size(204, 197);
            this.gbRaceSettings.TabIndex = 4;
            this.gbRaceSettings.TabStop = false;
            this.gbRaceSettings.Text = "Race Settings";
            // 
            // rbPicMode
            // 
            this.rbPicMode.AutoSize = true;
            this.rbPicMode.Location = new System.Drawing.Point(13, 137);
            this.rbPicMode.Name = "rbPicMode";
            this.rbPicMode.Size = new System.Drawing.Size(88, 17);
            this.rbPicMode.TabIndex = 1;
            this.rbPicMode.Text = "Picture Mode";
            this.rbPicMode.UseVisualStyleBackColor = true;
            // 
            // txtTrackLength
            // 
            this.txtTrackLength.Location = new System.Drawing.Point(13, 88);
            this.txtTrackLength.Name = "txtTrackLength";
            this.txtTrackLength.Size = new System.Drawing.Size(129, 20);
            this.txtTrackLength.TabIndex = 4;
            this.txtTrackLength.Text = "70";
            // 
            // rbDrawMode
            // 
            this.rbDrawMode.AutoSize = true;
            this.rbDrawMode.Location = new System.Drawing.Point(13, 114);
            this.rbDrawMode.Name = "rbDrawMode";
            this.rbDrawMode.Size = new System.Drawing.Size(80, 17);
            this.rbDrawMode.TabIndex = 0;
            this.rbDrawMode.Text = "Draw Mode";
            this.rbDrawMode.UseVisualStyleBackColor = true;
            // 
            // lblTrackLength
            // 
            this.lblTrackLength.AutoSize = true;
            this.lblTrackLength.Location = new System.Drawing.Point(10, 70);
            this.lblTrackLength.Name = "lblTrackLength";
            this.lblTrackLength.Size = new System.Drawing.Size(71, 13);
            this.lblTrackLength.TabIndex = 3;
            this.lblTrackLength.Text = "Track Length";
            // 
            // txtRaceSpeed
            // 
            this.txtRaceSpeed.Location = new System.Drawing.Point(13, 43);
            this.txtRaceSpeed.Name = "txtRaceSpeed";
            this.txtRaceSpeed.Size = new System.Drawing.Size(129, 20);
            this.txtRaceSpeed.TabIndex = 1;
            this.txtRaceSpeed.Text = "100";
            // 
            // lblRaceSpeed
            // 
            this.lblRaceSpeed.AutoSize = true;
            this.lblRaceSpeed.Location = new System.Drawing.Point(10, 23);
            this.lblRaceSpeed.Name = "lblRaceSpeed";
            this.lblRaceSpeed.Size = new System.Drawing.Size(132, 13);
            this.lblRaceSpeed.TabIndex = 0;
            this.lblRaceSpeed.Text = "Race Speed (milliseconds)";
            // 
            // btnChangeTortCol
            // 
            this.btnChangeTortCol.Location = new System.Drawing.Point(148, 53);
            this.btnChangeTortCol.Name = "btnChangeTortCol";
            this.btnChangeTortCol.Size = new System.Drawing.Size(54, 57);
            this.btnChangeTortCol.TabIndex = 6;
            this.btnChangeTortCol.Text = "Change Tortoise Colour";
            this.btnChangeTortCol.UseVisualStyleBackColor = true;
            this.btnChangeTortCol.Click += new System.EventHandler(this.btnChangeTortCol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetScoreBoard);
            this.groupBox1.Controls.Add(this.txtTieOut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHareWinOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTortWinOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(530, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // btnResetScoreBoard
            // 
            this.btnResetScoreBoard.Location = new System.Drawing.Point(13, 95);
            this.btnResetScoreBoard.Name = "btnResetScoreBoard";
            this.btnResetScoreBoard.Size = new System.Drawing.Size(178, 28);
            this.btnResetScoreBoard.TabIndex = 6;
            this.btnResetScoreBoard.Text = "Reset ScoreBoard";
            this.btnResetScoreBoard.UseVisualStyleBackColor = true;
            this.btnResetScoreBoard.Click += new System.EventHandler(this.btnResetScoreBoard_Click);
            // 
            // txtTieOut
            // 
            this.txtTieOut.Location = new System.Drawing.Point(91, 69);
            this.txtTieOut.Name = "txtTieOut";
            this.txtTieOut.ReadOnly = true;
            this.txtTieOut.Size = new System.Drawing.Size(100, 20);
            this.txtTieOut.TabIndex = 5;
            this.txtTieOut.TabStop = false;
            this.txtTieOut.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ties:";
            // 
            // txtHareWinOut
            // 
            this.txtHareWinOut.Location = new System.Drawing.Point(91, 43);
            this.txtHareWinOut.Name = "txtHareWinOut";
            this.txtHareWinOut.ReadOnly = true;
            this.txtHareWinOut.Size = new System.Drawing.Size(100, 20);
            this.txtHareWinOut.TabIndex = 3;
            this.txtHareWinOut.TabStop = false;
            this.txtHareWinOut.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hare Wins:";
            // 
            // txtTortWinOut
            // 
            this.txtTortWinOut.Location = new System.Drawing.Point(91, 17);
            this.txtTortWinOut.Name = "txtTortWinOut";
            this.txtTortWinOut.ReadOnly = true;
            this.txtTortWinOut.Size = new System.Drawing.Size(100, 20);
            this.txtTortWinOut.TabIndex = 1;
            this.txtTortWinOut.TabStop = false;
            this.txtTortWinOut.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tortoise Wins:";
            // 
            // txtGlobalTies
            // 
            this.txtGlobalTies.Location = new System.Drawing.Point(147, 168);
            this.txtGlobalTies.Name = "txtGlobalTies";
            this.txtGlobalTies.ReadOnly = true;
            this.txtGlobalTies.Size = new System.Drawing.Size(104, 20);
            this.txtGlobalTies.TabIndex = 5;
            this.txtGlobalTies.TabStop = false;
            // 
            // lblGlobalTies
            // 
            this.lblGlobalTies.AutoSize = true;
            this.lblGlobalTies.Location = new System.Drawing.Point(66, 171);
            this.lblGlobalTies.Name = "lblGlobalTies";
            this.lblGlobalTies.Size = new System.Drawing.Size(30, 13);
            this.lblGlobalTies.TabIndex = 4;
            this.lblGlobalTies.Text = "Ties:";
            // 
            // txtGlobalHWins
            // 
            this.txtGlobalHWins.Location = new System.Drawing.Point(147, 142);
            this.txtGlobalHWins.Name = "txtGlobalHWins";
            this.txtGlobalHWins.ReadOnly = true;
            this.txtGlobalHWins.Size = new System.Drawing.Size(104, 20);
            this.txtGlobalHWins.TabIndex = 3;
            this.txtGlobalHWins.TabStop = false;
            // 
            // lblGlobalHWins
            // 
            this.lblGlobalHWins.AutoSize = true;
            this.lblGlobalHWins.Location = new System.Drawing.Point(66, 145);
            this.lblGlobalHWins.Name = "lblGlobalHWins";
            this.lblGlobalHWins.Size = new System.Drawing.Size(60, 13);
            this.lblGlobalHWins.TabIndex = 2;
            this.lblGlobalHWins.Text = "Hare Wins:";
            // 
            // txtGlobalTWins
            // 
            this.txtGlobalTWins.Location = new System.Drawing.Point(147, 116);
            this.txtGlobalTWins.Name = "txtGlobalTWins";
            this.txtGlobalTWins.ReadOnly = true;
            this.txtGlobalTWins.Size = new System.Drawing.Size(104, 20);
            this.txtGlobalTWins.TabIndex = 1;
            this.txtGlobalTWins.TabStop = false;
            // 
            // lblGlobalTWins
            // 
            this.lblGlobalTWins.AutoSize = true;
            this.lblGlobalTWins.Location = new System.Drawing.Point(66, 119);
            this.lblGlobalTWins.Name = "lblGlobalTWins";
            this.lblGlobalTWins.Size = new System.Drawing.Size(75, 13);
            this.lblGlobalTWins.TabIndex = 0;
            this.lblGlobalTWins.Text = "Tortoise Wins:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(208, 218);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 336);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtGlobalHWins);
            this.tabPage1.Controls.Add(this.lblGlobalTWins);
            this.tabPage1.Controls.Add(this.txtGlobalTies);
            this.tabPage1.Controls.Add(this.txtGlobalTWins);
            this.tabPage1.Controls.Add(this.lblGlobalHWins);
            this.tabPage1.Controls.Add(this.lblGlobalTies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(308, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Global Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cStatChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(308, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stat Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cStatChart
            // 
            chartArea1.Name = "ChartArea1";
            this.cStatChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cStatChart.Legends.Add(legend1);
            this.cStatChart.Location = new System.Drawing.Point(13, 7);
            this.cStatChart.Name = "cStatChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.YValuesPerPoint = 4;
            this.cStatChart.Series.Add(series1);
            this.cStatChart.Size = new System.Drawing.Size(300, 300);
            this.cStatChart.TabIndex = 0;
            this.cStatChart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartRace);
            this.groupBox2.Controls.Add(this.btnPauseRace);
            this.groupBox2.Controls.Add(this.btnResetRace);
            this.groupBox2.Location = new System.Drawing.Point(9, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 120);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Race controls";
            // 
            // pbBonk
            // 
            this.pbBonk.BackgroundImage = global::Cocomelonracer.Properties.Resources.bonk;
            this.pbBonk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBonk.Location = new System.Drawing.Point(314, 90);
            this.pbBonk.Name = "pbBonk";
            this.pbBonk.Size = new System.Drawing.Size(104, 58);
            this.pbBonk.TabIndex = 11;
            this.pbBonk.TabStop = false;
            this.pbBonk.Visible = false;
            // 
            // pbCOCOMELON
            // 
            this.pbCOCOMELON.BackgroundImage = global::Cocomelonracer.Properties.Resources.CocomelonLogo;
            this.pbCOCOMELON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCOCOMELON.Location = new System.Drawing.Point(8, 345);
            this.pbCOCOMELON.Name = "pbCOCOMELON";
            this.pbCOCOMELON.Size = new System.Drawing.Size(198, 209);
            this.pbCOCOMELON.TabIndex = 10;
            this.pbCOCOMELON.TabStop = false;
            // 
            // pbHare
            // 
            this.pbHare.BackColor = System.Drawing.Color.Transparent;
            this.pbHare.BackgroundImage = global::Cocomelonracer.Properties.Resources.hare;
            this.pbHare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHare.Location = new System.Drawing.Point(8, 157);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(30, 30);
            this.pbHare.TabIndex = 7;
            this.pbHare.TabStop = false;
            this.pbHare.Visible = false;
            // 
            // pbTort
            // 
            this.pbTort.BackColor = System.Drawing.Color.Transparent;
            this.pbTort.BackgroundImage = global::Cocomelonracer.Properties.Resources.tort;
            this.pbTort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTort.Location = new System.Drawing.Point(8, 57);
            this.pbTort.Name = "pbTort";
            this.pbTort.Size = new System.Drawing.Size(30, 30);
            this.pbTort.TabIndex = 6;
            this.pbTort.TabStop = false;
            this.pbTort.Visible = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackColor = System.Drawing.Color.Transparent;
            this.pbRaceTrack.BackgroundImage = global::Cocomelonracer.Properties.Resources.checkered;
            this.pbRaceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRaceTrack.Location = new System.Drawing.Point(8, 12);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(720, 200);
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            this.pbRaceTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRaceTrack_Paint);
            // 
            // btnChangeHareCol
            // 
            this.btnChangeHareCol.Location = new System.Drawing.Point(148, 119);
            this.btnChangeHareCol.Name = "btnChangeHareCol";
            this.btnChangeHareCol.Size = new System.Drawing.Size(54, 57);
            this.btnChangeHareCol.TabIndex = 7;
            this.btnChangeHareCol.Text = "Change Hare Colour";
            this.btnChangeHareCol.UseVisualStyleBackColor = true;
            this.btnChangeHareCol.Click += new System.EventHandler(this.btnChangeHareCol_Click);
            // 
            // btnConfirmSettings
            // 
            this.btnConfirmSettings.Location = new System.Drawing.Point(13, 158);
            this.btnConfirmSettings.Name = "btnConfirmSettings";
            this.btnConfirmSettings.Size = new System.Drawing.Size(129, 30);
            this.btnConfirmSettings.TabIndex = 2;
            this.btnConfirmSettings.Text = "Confirm Settings";
            this.btnConfirmSettings.UseVisualStyleBackColor = true;
            this.btnConfirmSettings.Click += new System.EventHandler(this.btnConfirmSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 566);
            this.Controls.Add(this.pbBonk);
            this.Controls.Add(this.pbCOCOMELON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbHare);
            this.Controls.Add(this.pbTort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRaceSettings);
            this.Controls.Add(this.pbRaceTrack);
            this.Name = "Form1";
            this.Text = "Racing Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbRaceSettings.ResumeLayout(false);
            this.gbRaceSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cStatChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBonk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCOCOMELON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Button btnPauseRace;
        private System.Windows.Forms.Button btnResetRace;
        private System.Windows.Forms.Timer RaceTimer;
        private System.Windows.Forms.GroupBox gbRaceSettings;
        private System.Windows.Forms.TextBox txtRaceSpeed;
        private System.Windows.Forms.Label lblRaceSpeed;
        private System.Windows.Forms.TextBox txtTrackLength;
        private System.Windows.Forms.Label lblTrackLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetScoreBoard;
        private System.Windows.Forms.TextBox txtTieOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHareWinOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTortWinOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPicMode;
        private System.Windows.Forms.RadioButton rbDrawMode;
        private System.Windows.Forms.PictureBox pbTort;
        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.TextBox txtGlobalTies;
        private System.Windows.Forms.Label lblGlobalTies;
        private System.Windows.Forms.TextBox txtGlobalHWins;
        private System.Windows.Forms.Label lblGlobalHWins;
        private System.Windows.Forms.TextBox txtGlobalTWins;
        private System.Windows.Forms.Label lblGlobalTWins;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cStatChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbCOCOMELON;
        private System.Windows.Forms.PictureBox pbBonk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeTortCol;
        private System.Windows.Forms.Button btnChangeHareCol;
        private System.Windows.Forms.Button btnConfirmSettings;
    }
}

