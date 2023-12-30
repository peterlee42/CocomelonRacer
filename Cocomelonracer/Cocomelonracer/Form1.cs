using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Cocomelonracer
{
    public partial class Form1 : Form
    {

        // Win vars
        int tWins, hWins, ties, statTWins, statHWins, statTies;

        bool picMode;

        public class Contender
        {

            protected int iPos;
            protected int iNumStep;
            public Color col;

            //constructors
            public Contender()
            {

                iPos = 1;
                iNumStep = 70;
                col = Color.Gray;

            }

            public Contender(Contender other)
            {

                iPos = other.iPos;
                iNumStep = other.iNumStep;
                col = other.col;

            }

            //getters and setters
            public void SetPos(int pos)
            {
                if (pos <= 0)
                    iPos = 1;
                else
                    iPos = pos;

            }

            public int GetPos()
            {

                return iPos;

            }

            public void SetStep(int step)
            {
                if (step < 0)
                    step *= -1;

                iNumStep = step;

            }

            public int GetStep()
            {

                return iNumStep;

            }  

            //win check method
            public bool HasWon()
            {

                if (iPos >= iNumStep)
                {

                    return true;

                }
                else
                {

                    return false;

                }

            }

        }

        public class Tortoise : Contender
        {
            
            private Random TortoiseRand;

            //constructors
            public Tortoise() : base()
            {

                col = Color.ForestGreen;
                TortoiseRand = new Random();

            }

            public Tortoise(Tortoise other) : base(other)
            {

                col = other.col;
                TortoiseRand = new Random();

            }

            //position update method
            public void UpdateTortlePos()
            {

                int rand;

                rand = TortoiseRand.Next(1, 101);

                // Fast Plod
                if (rand <= 50)
                {

                    iPos = iPos + 3;
                    if (iPos > iNumStep)
                        iPos = iNumStep;

                }
                // Slip
                else if (rand <= 70)
                {

                    iPos = iPos - 6;
                    if (iPos <= 0)
                        iPos = 1;

                }
                // Slow Plod
                else
                {

                    iPos++;
                    if (iPos > iNumStep)
                        iPos = iNumStep;

                }

            }

            //draw method
            public void DrawTortoise(Graphics g)
            {

                Point tl;
                tl = new Point();

                tl.X = ((iPos - 1) * (700 / iNumStep));
                tl.Y = 45;

                SolidBrush TortoiseBrush = new SolidBrush(col);
                g.FillEllipse(TortoiseBrush, tl.X, tl.Y, 10, 10);
                
            }

        }

        public class Hare : Contender
        {

            public Random HareRand;

            //constructors
            public Hare() : base()
            {

                col = Color.Brown;
                HareRand = new Random();

            }

            public Hare(Hare other) : base(other)
            {

                col = other.col;
                HareRand = new Random();

            }

            //update position method
            public void UpdateHarePos()
            {

                int rand;

                rand = HareRand.Next(1, 101);

                // Big Hop
                if (20 < rand && rand <= 40)
                {

                    iPos = iPos + 8;

                    if (iPos > iNumStep)
                        iPos = iNumStep;

                }
                // Big Slip
                else if (rand <= 50)
                {
                    iPos = iPos - 10;

                    if (iPos <= 0)
                        iPos = 1;
                }
                // Small Hop
                else if (rand <= 80)
                { 

                    iPos = iPos + 1;

                    if (iPos > iNumStep)
                        iPos = iNumStep;

                }
                // Small Slip
                else if(rand <= 100)
                {
                    iPos = iPos - 2;

                    if (iPos <= 0)
                        iPos = 1;
                }
            }

            //draw method
            public void DrawHare(Graphics g)
            {

                Point tl;
                tl = new Point();

                tl.X = ((iPos - 1) * (700/iNumStep));
                tl.Y = 145;

                SolidBrush HareBrush = new SolidBrush(col);
                g.FillRectangle(HareBrush, tl.X, tl.Y, 10, 10);

            }

        }

        //instantiate classes
        public Tortoise TortoiseRacer;
        public Hare HareRacer;
        public Form1()
        {

            // Sound on open
            SoundPlayer cocomelon = new SoundPlayer("cocomelon.wav");
            cocomelon.Play();

            //initialize everything
            InitializeComponent();

            TortoiseRacer = new Tortoise();
            HareRacer = new Hare();
            
            tWins = 0;
            hWins = 0;
            ties = 0;

            rbDrawMode.Checked = true;
            picMode = false;

            pbTort.Parent = pbRaceTrack;
            pbHare.Parent = pbRaceTrack;
            
            //check if file exists
            if (File.Exists("racestats.bin"))
            {

                //read from file
                FileStream fs = new FileStream("racestats.bin", FileMode.Open);
                BinaryReader binReader = new BinaryReader(fs);

                statTies = binReader.ReadInt32();
                statTWins = binReader.ReadInt32();
                statHWins = binReader.ReadInt32();
                binReader.Close();
                
            }
            else
            {

                //load default values
                statTies = 0;
                statTWins = 0;
                statHWins = 0;

            }

            // Output wins/ties
            txtGlobalTies.Text = statTies.ToString();
            txtGlobalHWins.Text = statHWins.ToString();
            txtGlobalTWins.Text = statTWins.ToString();

            //draw chart
            cStatChart.Series["s1"].IsValueShownAsLabel = true;

            if (statTies != 0)
            {

                cStatChart.Series["s1"].Points.AddXY("Ties", statTies.ToString());

            }
            if (statHWins != 0)
            {

                cStatChart.Series["s1"].Points.AddXY("Tortoise Wins", statTWins.ToString());

            }
            if (statTWins != 0)
            {

                cStatChart.Series["s1"].Points.AddXY("Hare Wins", statHWins.ToString());

            }

        }

        //draw track method
        public void DrawTrack(Graphics g)
        {

            try
            {
                Pen myPen = new Pen(Color.Black, 200);
                g.DrawLine(myPen, 0, 100, 690, 100);

                Pen middleLinePen = new Pen(Color.Yellow, 25);
                g.DrawLine(middleLinePen, 0, 100, 690, 100);
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        //race start
        private void btnStartRace_Click(object sender, EventArgs e)
        {

            try
            {
                RaceTimer.Start();

                btnStartRace.Enabled = false;
                btnPauseRace.Enabled = true;
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        private void btnResetScoreBoard_Click(object sender, EventArgs e)
        {

            try
            {
                //reset values and output
                tWins = 0;
                hWins = 0;
                ties = 0;

                txtTortWinOut.Text = tWins.ToString();
                txtHareWinOut.Text = hWins.ToString();
                txtTieOut.Text = ties.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //open file and write
            FileStream fs = new FileStream("racestats.bin", FileMode.Create);
            BinaryWriter binWriter = new BinaryWriter(fs);

            binWriter.Write(statTies);
            binWriter.Write(statTWins);
            binWriter.Write(statHWins);

            binWriter.Flush();
            binWriter.Close();

        }

        private void btnChangeTortCol_Click(object sender, EventArgs e)
        {
            try
            {
                // Change colour of tortoise
                colorDialog1.ShowDialog();
                TortoiseRacer.col = colorDialog1.Color;
                pbRaceTrack.Invalidate();
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
        }

        private void btnChangeHareCol_Click(object sender, EventArgs e)
        {
            try
            {
                // Change colour of hare
                colorDialog1.ShowDialog();
                HareRacer.col = colorDialog1.Color;
                pbRaceTrack.Invalidate();
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
        }

        //race pause
        private void btnPauseRace_Click(object sender, EventArgs e)
        {

            try
            {
                RaceTimer.Stop();

                btnStartRace.Enabled = true;
                btnPauseRace.Enabled = false;
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        //reset race
        private void btnResetRace_Click(object sender, EventArgs e)
        {

            try
            {
                // Stop timer and reset pos
                TortoiseRacer.SetPos(1);
                HareRacer.SetPos(1);
                pbRaceTrack.Invalidate();

                RaceTimer.Stop();

                btnStartRace.Enabled = true;
                btnPauseRace.Enabled = false;
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        //draw race track and Contenders
        private void pbRaceTrack_Paint(object sender, PaintEventArgs e)
        {
            //call draw functions
            if (picMode == true)
            {

                int tortX, hareX;
                tortX = (TortoiseRacer.GetPos() - 1) * (700 / TortoiseRacer.GetStep());
                hareX = (HareRacer.GetPos() - 1) * (700 / HareRacer.GetStep());

                pbTort.Location = new Point(tortX, 45);
                pbHare.Location = new Point(hareX, 145);

            }
            else
            {

                DrawTrack(e.Graphics);
                TortoiseRacer.DrawTortoise(e.Graphics);
                HareRacer.DrawHare(e.Graphics);

            }

        }

        //timer
        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //call update pos
                TortoiseRacer.UpdateTortlePos();
                HareRacer.UpdateHarePos();
                pbRaceTrack.Invalidate();

                bool tWon, hWon;

                //get win status
                tWon = TortoiseRacer.HasWon();
                hWon = HareRacer.HasWon();

                //check if win or tie
                if (tWon && hWon)
                {

                    RaceTimer.Stop();
                    MessageBox.Show("It's a tie bruh");

                    statTies++;
                    ties++;
                    txtTieOut.Text = ties.ToString();
                    txtGlobalTies.Text = statTies.ToString();

                    btnPauseRace.Enabled = false;

                }
                else if (tWon)
                {

                    RaceTimer.Stop();
                    MessageBox.Show("Tortoise won yaaa");

                    statTWins++;
                    tWins++;
                    txtTortWinOut.Text = tWins.ToString();
                    txtGlobalTWins.Text = statTWins.ToString();

                    btnPauseRace.Enabled = false;

                }
                else if (hWon)
                {

                    RaceTimer.Stop();
                    MessageBox.Show("Hare won nooo");

                    statHWins++;
                    hWins++;
                    txtHareWinOut.Text = hWins.ToString();
                    txtGlobalHWins.Text = statHWins.ToString();

                    btnPauseRace.Enabled = false;

                }

                // Update chart if won
                if (tWon || hWon)
                {
                    //Clear Chart
                    cStatChart.Series["s1"].Points.Clear();

                    //draw updated chart
                    if (statTies != 0)
                    {

                        cStatChart.Series["s1"].Points.AddXY("Ties", statTies.ToString());

                    }
                    if (statHWins != 0)
                    {

                        cStatChart.Series["s1"].Points.AddXY("Tortoise Wins", statTWins.ToString());

                    }
                    if (statTWins != 0)
                    {

                        cStatChart.Series["s1"].Points.AddXY("Hare Wins", statHWins.ToString());

                    }
                }

                // Boom sound if tort and hare are at same pos
                if (TortoiseRacer.GetPos() == HareRacer.GetPos())
                {

                    SoundPlayer crash = new SoundPlayer("boom.wav");
                    crash.Play();
                    pbBonk.Visible = true;

                }
                else
                {
                    pbBonk.Visible = false;
                }

            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        //settings 
        private void btnConfirmSettings_Click(object sender, EventArgs e)
        {

            try
            {

                //get setting values 
                int RaceSpeed, TrackLength;

                if (rbDrawMode.Checked == true)
                {

                    picMode = false;
                    pbRaceTrack.BackgroundImage = Image.FromFile("checkered.png");
                    pbTort.Visible = false;
                    pbHare.Visible = false;

                }
                else
                {

                    picMode = true;
                    pbRaceTrack.BackgroundImage = Image.FromFile("grass.png");
                    pbTort.Visible = true;
                    pbHare.Visible = true;

                }
                pbRaceTrack.Invalidate();
                
                //check for blank
                if (txtRaceSpeed.Text.Trim() == "" || txtTrackLength.Text.Trim() == "")
                {

                    MessageBox.Show("Please enter all fields");
                    return;

                }

                // Output
                RaceSpeed = Convert.ToInt32(txtRaceSpeed.Text);
                TrackLength = Convert.ToInt32(txtTrackLength.Text);

                //set values 
                TortoiseRacer.SetStep(TrackLength);
                HareRacer.SetStep(TrackLength);

                //convert - to +
                if (RaceSpeed < 0)
                {

                    if (RaceSpeed < 0)
                        RaceSpeed *= -1;

                }

                //Set speed
                RaceTimer.Interval = RaceSpeed;

            }
            catch
            {

                MessageBox.Show("invalid value");

            }

        }

    }
}
