using MarsRoverProblem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRoverProblem
{
    public partial class MarsRover : Form
    {
        bool toggle = true;
        public MarsRover()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var maxPoints = input1.Text.Trim().Split(' ').Select(int.Parse).ToList();
                var startPositions = input2.Text.Trim().Split(' ');
                Position position = new Position();

                if (startPositions.Count() == 3)
                {
                    position.X = Convert.ToInt32(startPositions[0]);
                    position.Y = Convert.ToInt32(startPositions[1]);
                    position.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
                }

                var moves = input3.Text.Trim();


                position.StartMoving(maxPoints, moves);
                output.Text = position.X + " " + position.Y + " " + position.Direction.ToString();
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
            }

        }

        private void buttonTestCase_Click(object sender, EventArgs e)
        {
            if (toggle)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                toggle = false;

            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                toggle = true;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            input1.Text = "5 5";
            input2.Text = "1 2 N";
            input3.Text = "LMLMLMLMM";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            input1.Text = "5 5";
            input2.Text = "3 3 E";
            input3.Text = "MMRMMRMRRM";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            input1.Text = "";
            input2.Text = "";
            input3.Text = "";
        }
    }
}
