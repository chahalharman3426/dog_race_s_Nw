using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dog_race_s_Nw
{
    public partial class Form1 : Form
    {
        private String Name = "";
        private int DogNo = 0;
        private int p1 = 100, p2 = 100, p3 = 100;

        //instance of the classes
        DogRunning dogRunning = new DogRunning();
        Better better = new Better();
        public Form1()
        {
            InitializeComponent();
            //using the concept of loop add the number in the box
            int y = 1;
            while (y<=50) {
                cbBetAmount.Items.Add("" + y);
                y++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            if (Name.Equals("Sandeep") && DogNo > 0 && Convert.ToInt32(cbBetAmount.Text) <= p1)
            {
                lblSandeep.Text = "Sandeep set the Bet on " + DogNo + " with " + Convert.ToInt32(cbBetAmount.Text);
                run_btn.Enabled = true;
            }

            else if (Name.Equals("Pardeep") && DogNo > 0 && Convert.ToInt32(cbBetAmount.Text) <= p2)
            {
                lblPardeep.Text = "Pardeep set the Bet on " + DogNo + " with " + Convert.ToInt32(cbBetAmount.Text);
                run_btn.Enabled = true;
            }
            else if (Name.Equals("Jagdeep") && DogNo > 0 && Convert.ToInt32(cbBetAmount.Text) <= p3)
            {
                lblJagdeep.Text = "Jagdeep set the Bet on " + DogNo + " with " + Convert.ToInt32(cbBetAmount.Text);
                run_btn.Enabled = true;
            }
            else {
                MessageBox.Show("Verify the details once ");
            }

            //reset the field to set again 
            Name = "";
            DogNo = 0;
            sandeephas.Checked = false;
            pardeephas.Checked = false;
            jagdeephas.Checked = false;
            dog1.Checked = false;
            dog2.Checked = false;
            dog3.Checked = false;
            dog4.Checked = false;
            cbBetAmount.Text = "";
            
        }

        private void sandeephas_CheckedChanged(object sender, EventArgs e)
        {
            Name = "Sandeep";

        }

        private void pardeephas_CheckedChanged(object sender, EventArgs e)
        {
            Name = "Pardeep";
        }

        private void jagdeephas_CheckedChanged(object sender, EventArgs e)
        {
            Name = "Jagdeep";
        }

        private void dog1_CheckedChanged(object sender, EventArgs e)
        {
            DogNo = 1;
        }

        private void dog2_CheckedChanged(object sender, EventArgs e)
        {
            DogNo = 2;
        }

        private void dog3_CheckedChanged(object sender, EventArgs e)
        {
            DogNo = 3;
        }

        private void dog4_CheckedChanged(object sender, EventArgs e)
        {
            DogNo = 4;
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += dogRunning.run();
            pictureBox2.Left += dogRunning.run();
            pictureBox3.Left += dogRunning.run();
            pictureBox4.Left += dogRunning.run();
            
            if (pictureBox1.Left>dogRunning.lastPoint()) {
                timer1.Stop();
                String []pl1= lblSandeep.Text.Split(' ');
                if (pl1.Length==8) {
                  p1=better.resultDeclaration(lblSandeep.Text, 1, p1);
                }

                String[] pl2 = lblPardeep.Text.Split(' ');
                if (pl2.Length == 8)
                {
                    p2 = better.resultDeclaration(lblPardeep.Text, 1, p2);
                }

                String[] pl3 = lblJagdeep.Text.Split(' ');
                if (pl3.Length == 8)
                {
                    p3 = better.resultDeclaration(lblJagdeep.Text, 1, p3);
                }
                MessageBox.Show("Dog " + 1 + " Won the Race ");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
                pictureBox4.Left = 0;
                lblSandeep.Text = "Sandeep has " + p1 + " Dollar";
                lblPardeep.Text = "Pardeep has " + p2 + " Dollar";
                lblJagdeep.Text = "Jagdeep has " + p3 + " Dollar";
                run_btn.Enabled = false;

            }
            if (pictureBox2.Left > dogRunning.lastPoint())
            {
                timer1.Stop();
                String[] pl1 = lblSandeep.Text.Split(' ');
                if (pl1.Length == 8)
                {
                    p1 = better.resultDeclaration(lblSandeep.Text, 1, p1);
                }

                String[] pl2 = lblPardeep.Text.Split(' ');
                if (pl2.Length == 8)
                {
                    p2 = better.resultDeclaration(lblPardeep.Text, 1, p2);
                }

                String[] pl3 = lblJagdeep.Text.Split(' ');
                if (pl3.Length == 8)
                {
                    p3 = better.resultDeclaration(lblJagdeep.Text, 1, p3);
                }
                MessageBox.Show("Dog " + 2 + " Won the Race ");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
                pictureBox4.Left = 0;
                lblSandeep.Text = "Sandeep has " + p1 + " Dollar";
                lblPardeep.Text = "Pardeep has " + p2 + " Dollar";
                lblJagdeep.Text = "Jagdeep has " + p3 + " Dollar";
                run_btn.Enabled = false;
            }

            if (pictureBox3.Left > dogRunning.lastPoint())
            {
                timer1.Stop();
                String[] pl1 = lblSandeep.Text.Split(' ');
                if (pl1.Length == 8)
                {
                    p1 = better.resultDeclaration(lblSandeep.Text, 1, p1);
                }

                String[] pl2 = lblPardeep.Text.Split(' ');
                if (pl2.Length == 8)
                {
                    p2 = better.resultDeclaration(lblPardeep.Text, 1, p2);
                }

                String[] pl3 = lblJagdeep.Text.Split(' ');
                if (pl3.Length == 8)
                {
                    p3 = better.resultDeclaration(lblJagdeep.Text, 1, p3);
                }
                MessageBox.Show("Dog " + 3 + " Won the Race ");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
                pictureBox4.Left = 0;
                lblSandeep.Text = "Sandeep has " + p1 + " Dollar";
                lblPardeep.Text = "Pardeep has " + p2 + " Dollar";
                lblJagdeep.Text = "Jagdeep has " + p3 + " Dollar";
                run_btn.Enabled = false;
            }

            if (pictureBox4.Left > dogRunning.lastPoint())
            {
                timer1.Stop();
                String[] pl1 = lblSandeep.Text.Split(' ');
                if (pl1.Length == 8)
                {
                    p1 = better.resultDeclaration(lblSandeep.Text, 1, p1);
                }

                String[] pl2 = lblPardeep.Text.Split(' ');
                if (pl2.Length == 8)
                {
                    p2 = better.resultDeclaration(lblPardeep.Text, 1, p2);
                }

                String[] pl3 = lblJagdeep.Text.Split(' ');
                if (pl3.Length == 8)
                {
                    p3 = better.resultDeclaration(lblJagdeep.Text, 1, p3);
                }
                MessageBox.Show("Dog " + 4 + " Won the Race ");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
                pictureBox4.Left = 0;
                lblSandeep.Text = "Sandeep has " + p1 + " Dollar";
                lblPardeep.Text = "Pardeep has " + p2 + " Dollar";
                lblJagdeep.Text = "Jagdeep has " + p3 + " Dollar";
                run_btn.Enabled = false;
            }
        }
    }
}
