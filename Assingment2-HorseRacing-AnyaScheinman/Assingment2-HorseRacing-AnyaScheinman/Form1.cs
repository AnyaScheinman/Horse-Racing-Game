//Anya Scheinman
//ascheinman4585@conestogac.on.ca
//8154585
//* Assignment 2-Horse Racing Game
//* Revision History
//Anya Scheinman, 2022.10.28: Created
//Anya Scheinman, 2022.10.31: Code Added
//Anya Scheinman, 2022.11.1: Code Added
//Anya Scheinman, 2022.11.2: Code Added
//Anya Scheinman, 2022.11.3: Code Added
//Anya Scheinman, 2022.11.3: Added Comments
//Anya Scheinman, 2022.11.4: Finished project



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.AxHost;


namespace Assingment2_HorseRacing_AnyaScheinman
{
    public partial class Form1 : Form
    {
     
        //center of the racing circle
        int centerX = 188;
        int centerY = 188;

        //starting point for each horse
        float degrees1 = 204;
        float degrees2 = 204;
        float degrees3 = 204;

        // radius of the circle for each horse.
        int radius1 = 160;
        int radius2 = 120;
        int radius3 = 85;

        //speed of the horses
        float velocity1, velocity2, velocity3;
       
        // the order of horses 
        int horseOrder = 1;

        //time variables for calculating start time, end time, and time span.
        DateTime startTime;
        DateTime endTime1, endTime2,endTime3;      
        TimeSpan timeSpan1, timeSpan2, timeSpan3;
       
       

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creating a random to make each horse go at a diffrence speed randomaly
            Random r = new Random();
            int minSpeed = 5;
            int maxSpeed = 10;
            int minInterval = 200;
            int maxInterval = 600;

            //calculting horse speed
            velocity1 = (float)(2 * Math.PI / r.Next(20, 20));
            velocity2 = (float)(2 * Math.PI / r.Next(25, 25));
            velocity3 = (float)(2 * Math.PI / r.Next(25, 25));

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //re starting the application when the restart button is clicked
            Application.Restart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //starting the timer
            timer1.Start();

            //setting the start time to the current time
            startTime = DateTime.Now;
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //creating the circle for horse 1
            int circlePosX = (int)(centerX + Math.Cos(degrees1) * radius1);
            int circlePosY = (int)(centerY + Math.Sin(degrees1) * radius1);

            //setting horse 1 to the correct coodinates so it travels in a circle
            horse1.Left = circlePosX;
            horse1.Top = circlePosY;

            label2.Text = degrees1.ToString();
            label3.Text = degrees3.ToString();
            label4.Text = degrees3.ToString();


            //setting the degrees. when the horse reaches this point the horse stops. 
            if (degrees1 >= 208.4242)
            {
                //setting the end time to now
                endTime1 = DateTime.Now;

                //setting the time span to equal the end time minus the start time
                timeSpan1 = (endTime1 - startTime);
               
                //if the horse order is equal to one, show which horse won, show the speed and the time it took.
                if (horseOrder == 1)
                {
                   
                    txtWinner.Text += "Horse #1!";
                    txtSpeed.Text += Math.Round(velocity1 * 100);

                    txtTiming.Text = timeSpan1.TotalSeconds.ToString();
             
                }
                horseOrder++;
            }
            else
            {
                ////set the degrees to add and equal the velocity.
                degrees1 += (float)((velocity1));
            }

            //creating the circle for horse 2
            int circlePosX2 = (int)(centerX + Math.Cos(degrees2) * radius2);
            int circlePosY2 = (int)(centerY + Math.Sin(degrees2) * radius2);

            //setting horse 2 to the correct coodinates so it travels in a circle
            horse2.Left = circlePosX2;
            horse2.Top = circlePosY2;


            //setting the degrees. when the horse reaches this point the horse stops. 
            if (degrees2 >= 208.5172)
            {
                //setting the end time to now
                endTime2 = DateTime.Now;

                //setting the time span to equal the end time minus the start time
                timeSpan2 = (endTime2 - startTime);

                if (horseOrder == 1)
                {
                  
                    txtWinner.Text += "Horse #2!";
                    txtSpeed.Text += Math.Round(velocity2 * 100);

                   
                    txtTiming.Text = timeSpan2.TotalSeconds.ToString();
                }
                horseOrder++;
            }
            else
            {
               degrees2 += (float)((velocity2));
            }

            //creating the circle for horse 3
            int circlePosX3 = (int)(centerX + Math.Cos(degrees3) * radius3);
            int circlePosY3 = (int)(centerY + Math.Sin(degrees3) * radius3);


            //setting horse 3 to the correct coodinates so it travels in a circle
            horse3.Left = circlePosX3;
            horse3.Top = circlePosY3;


            //setting the degrees. when the horse reaches this point the horse stops. 
            if (degrees3 >= 208.4242)
            {
                //setting the end time to now
                endTime3 = DateTime.Now;

                //setting the time span to equal the end time minus the start time
                timeSpan3 = (endTime3 - startTime);
                if (horseOrder == 1)
                {
                    txtWinner.Text += "Horse #3!";
                    txtSpeed.Text += Math.Round(velocity3 * 100);

                    endTime3 = DateTime.Now;
                    txtTiming.Text = timeSpan3.TotalSeconds.ToString();
                }
                horseOrder++;
            }
            else
            {
               degrees3 += (float)((velocity3));
            }

            if(horseOrder == 4)
            {
                lblTiming1.Text = Math.Round(timeSpan1.TotalSeconds).ToString();
                lblTiming2.Text = Math.Round(timeSpan2.TotalSeconds).ToString();
                lblTiming3.Text = Math.Round(timeSpan3.TotalSeconds).ToString();
                lblSpeed1.Text = Math.Round(velocity1).ToString();
                lblSpeed2.Text = Math.Round(velocity2).ToString();
                lblSpeed3.Text = Math.Round(velocity3).ToString();


                timer1.Stop();
            }


        }


    }


}


