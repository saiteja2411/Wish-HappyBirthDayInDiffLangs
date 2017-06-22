using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WishBdayInDiffLangs
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {

                case (0):
                    textBlock2.Text = "Janmadinar Subhechcha Janalo";
                    break;
                case (1):
                    textBlock2.Text = "Shuvo Jonmodin!";
                    break;
               
                case (2):
                    textBlock2.Text = "Janma Divas Mubarak!";
                    break;
                case (3):
                    textBlock2.Text = "Janam Din ki badhai!";
                    break;
                case (4):
                    textBlock2.Text = "Huttida Habba Subashayagalu!";
                    break;
                case (5):
                    textBlock2.Text = "Voharvod Mubarak Chuy!";
                    break;
                case (6):
                    textBlock2.Text = "Hanv Tuka kuxal bhorit \nzolmacho dis auvndetam";
                    break;
                
                case (7):
                    textBlock2.Text = "Pirannal Aasamsakal! or\nJanmadinasamsakal!";
                    break;
                
                case (8):
                    textBlock2.Text = "Wadhdiwasachya Shubhechha";
                    break;
                case (9):
                    textBlock2.Text = "Janmadhin ko Subha kamana!";
                    break;
                case (10):
                    textBlock2.Text = "Janmadina Abhinandan!";
                    break;
                case (11):
                    textBlock2.Text = " Janam din diyan wadhayian!";
                    break;
                case (12):
                    textBlock2.Text = "Janam ghaanth ri badhai, \nkhoob jeeyo!";
                    break;
                case (13):
                    textBlock2.Text = "Ravihi janmadinam aacharati!";
                    break;
                
               
                case (14):
                    textBlock2.Text = "Janam Diya Ji Wadhayon";
                    break;
                case (15):
                    textBlock2.Text = "Piranda naal vaazhthukkal!";
                    break;
                case (16):
                    textBlock2.Text = "Puttina Roju Shubakanksalu!";
                    break;
                case (17):
                    textBlock2.Text = " Janam Din Mubarak";
                    break;
            }

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            listBox1.Items.Add("assamese");
            listBox1.Items.Add("bengali");
           
            listBox1.Items.Add("gujrati");
            listBox1.Items.Add("hindi");
            listBox1.Items.Add("kanada");
            listBox1.Items.Add("kashmiri");
            listBox1.Items.Add("konkani");
            
            listBox1.Items.Add("malyalam");
            
            listBox1.Items.Add("marathi");
            listBox1.Items.Add("nepali");
            listBox1.Items.Add("oriya");
            listBox1.Items.Add("punjabi");
            listBox1.Items.Add("rajesthani");
            listBox1.Items.Add("sanskrit");
       
            listBox1.Items.Add("sindhi");
            listBox1.Items.Add("tamil");
            listBox1.Items.Add("telugu");
            listBox1.Items.Add("urdu");
            
            
        }
    }
}