﻿//adventure game andrew henderson nov 8
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Adventure_game
{
    public partial class Form1 : Form
    {        Random randGen = new  Random() ;
        int scene = 0;
        int day = 0;
        int Starve = 0 ;

        SoundPlayer player = new SoundPlayer(Properties.Resources.print);
        public Form1()
        {
            InitializeComponent();
            debugLabel.Text = scene + "";
            dayLabel.Text = day + "";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            int rand = randGen.Next(1, 10);
            /// to the next appropriate scene
            
            

            if (e.KeyCode == Keys.M)     //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 4) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 99; }
                else if (scene == 8) { scene = 99; }
                else if (scene == 11) { scene = 99; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 10) { scene = 100; }
                else if (scene == 7) { scene = 100; }
                else if (scene == 16) { scene = 100; }
                else if (scene == 18) { scene = 100; }
                else if (scene == 6)
                {
                    if (rand > 90) { scene = 8; }
                    else { scene = 9; }
                }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { scene = 100; }
                else if (scene == 14) { scene = 100; }
                else if (scene == 2) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 17) { scene = 15; }
                else if (scene == 11) { scene = 1; }
                else if (scene == 99) { scene = 0; }
                else if (scene == 100) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 4) { scene = 7; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 2) { scene = 20; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 12) { scene = 1; }
                else if (scene == 20) { scene = 17; }
                else if (scene == 17) { scene = 18; }
                else if (scene == 100) { scene = 101; }
            }
            else if (e.KeyCode == Keys.N)  //green button press
            {
                if (scene == 12) { scene = 14; }
              
            }
            else if (e.KeyCode == Keys.Tab)  //debug button press
            {
                debugLabel.Visible = true;

            }

            debugLabel.Text = scene + " debug";
            dayLabel.Text = "day "+day  ;

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You are a bear. You wake up from sleep and feel very hungry. \n Where do you go to look for food?";
                    redLabel.Text = "river ";
                    blueLabel.Text = "woods ";
                    break;

                case 1:
                    outputLabel.Text = "You approach the river. \n Do you try to catch a fish or to cross the river?" ;
                        
                      redLabel.Text = "cross ";
                    blueLabel.Text = "catch fish ";
                    break;

                case 2:
                    outputLabel.Text = "You wander into the woods and spot a deer. \n Do you charge or try to sneak up on it? ";
                      
                      redLabel.Text = "sneek  ";
                    blueLabel.Text = "charge ";
                    break;

                case 3:
                    outputLabel.Text = "As you cross you see a pack of wild monkeys charging you. \n Do you run or attack?";  
                      redLabel.Text = "run ";
                    blueLabel.Text = "attack ";
                    break;

                case 4:
                    outputLabel.Text = "You catch 3 fish. \n Do you stay and catch more or do you cross the river? ";
                       
                      redLabel.Text = "cross ";
                    blueLabel.Text = "catch more ";
                    break;

                case 5:
                    outputLabel.Text = "The monkeys overrun you. You have died";
                      redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    break;

                case 6:
                    outputLabel.Text = "You stand up on your back legs. \n Do you try a windmill manouever or several dropkicks?" ;
                        
                    redLabel.Text = "windmill ";
                    blueLabel.Text = "dropkick ";
                    break;
                case 7:
                    outputLabel.Text = "You catch 3 more fish. You have enough food for the night.";
                    redLabel.Text = "continue  ";
                    blueLabel.Text = " ";
                    break;
                    

                case 8:
                    outputLabel.Text = "You are overwhelmed by a tide of monkeys and die  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    player.Play();
                    break;
                    

                case 9:
                    outputLabel.Text = "You defeat all the monkeys.\n Do you continue to hunt or sleep? ";
                    redLabel.Text = "hunt ";
                    blueLabel.Text = "sleep ";
                    break;
                    

                case 10:
                    outputLabel.Text = "you have a great sleep  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    break;
                    

                case 11:
                    outputLabel.Text = "You stay up all night and die from exhaustion. ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    player.Play();
                    break;
                    

                case 12:
                    outputLabel.Text = "You use your bear-like stealth and surprise the deer. You are now full. \n Do you stay to find more deer, go to the river or sleep?  ";
                    redLabel.Text = "serach ";
                    blueLabel.Text = "river ";
                    greenLabel.Text = "sleep";
                    break;
                    

                case 13:
                    outputLabel.Text = "You spot a sheep and it doesn't seem to notice you. Do you attack or go back to sleep? ";
                    redLabel.Text = "sleep ";
                    blueLabel.Text = "attack ";
                    greenLabel.Text = "";
                    break;
                    

                case 14:
                    outputLabel.Text = "you have a good nights sleep ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    greenLabel.Text = "";
                    break;

                 case 15:
                    outputLabel.Text = "The sheep was actually a cos-playing wolf. It injures you and runs off.  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    greenLabel.Text = " ";
                    player.Play();
                    break;

                 case 16:
                    outputLabel.Text = "you have a good nights sleep ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = "  ";
                    greenLabel.Text = "";
                    break;

                 case 17:
                    outputLabel.Text = "you spot a Sheep. it does not see you yet what do you do \n attack or sleep ";
                    redLabel.Text = "attack ";
                    blueLabel.Text = "sleep ";
                    greenLabel.Text = "";
                    break;

                 case 18:
                    outputLabel.Text = "you have a bad nights sleep with no food  ";
                    redLabel.Text = "continue ";
                    blueLabel.Text = " ";
                    greenLabel.Text = "";
                    Starve++; 
                    break;

                 case 19:
                    outputLabel.Text = "WIP "; // not used 
                    break;

                 case 20:
                    outputLabel.Text = "the dear gets spooked and runs away do you \n go to the river or look for more dear  ";
                    redLabel.Text = "river ";
                    blueLabel.Text = "more dear ";
                    greenLabel.Text = "";
                    break;

                 case 99: //loser restart 
                    outputLabel.Text = "You died. Do you want to try again? ";
                    redLabel.Text = "yes ";
                    blueLabel.Text = "no ";
                    greenLabel.Text = "";
                    break; 

                 case 100: // win restart 
                    outputLabel.Text = "You survived. Do you want to continue to the next day? ";
                    redLabel.Text = "yes ";
                    blueLabel.Text = "no ";
                    greenLabel.Text = "";
                    day++;
                    break;

                 case 101: //closing 
                    outputLabel.Text = " ";
                    Thread.Sleep(100);
                    this.Close();
                    break;
                    

            }

        }
    }
}
