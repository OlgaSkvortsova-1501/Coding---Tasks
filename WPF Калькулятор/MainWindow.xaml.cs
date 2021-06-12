using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float a, b, d;
        int num, zifra = 0;
        bool ravno = false, nol = true, pointt = true, znak = true, m = true;
        string oxrana;
        int lenght, c, zifri;
        string point = ".";



        private void Clear()
        {
            text.Text = "";  
        }

        private void Button_0_to_9()
        {
            nol = true;
            zifra += 1;
            

        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            
            text.Text += "1";
            Button_0_to_9();
           
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            
            text.Text += "2";
            Button_0_to_9();
            
        }

        private void Button_3_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "3";
            Button_0_to_9();
        }

        private void Button_4_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "4";
            Button_0_to_9();
        }

        private void Button_5_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "5";
            Button_0_to_9();
        }

        private void Button_6_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "6";
            Button_0_to_9();
        }

       

        private void Button_7_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "7";
            Button_0_to_9();
        }

        private void Button_8_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "8";
            Button_0_to_9();
        }

        

        private void Button_9_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "9";
            Button_0_to_9();
        }

       
        private void Button_Clean_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            text.Text = "";
            oxrana = ""; 
            Button_0_to_9();
            c = 0;
        }

      

        private void Button_0_Click(object senden, RoutedEventArgs e)
        {
            
            text.Text += "0";
            Button_0_to_9();
        }

        private void Button_Point_Click(object sender, RoutedEventArgs e)
        {
           
                if (c == 0)
                {
                    text.Text += point;
                    c += 1;
                }
           
            

        }

        


        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
           
            Deistvie(1);
           
        }

       
        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            
            Deistvie(2);
            
        }

        private void Button_Ymnozenie_Click(object sender, RoutedEventArgs e)
        {
            
            Deistvie(3);
         
        }

        private void Button_del_Click(object sender, RoutedEventArgs e)
        {
            
            Deistvie(4);
            
        }

       
       

        private void Deistvie(int deistv)
        {
            if (zifra > 0)
            {
                switch (deistv)
                {
                    case 1:
                        d = '+';
                        num = 1;
                        break;
                    case 2:
                        d = '-';
                        num = 2;
                        break;
                    case 3:
                        d = '/';
                        num = 3;
                        break;
                    case 4:
                        d = '*';
                        num = 4;
                        break;

                    default:
                        break;

                }

                a = Convert.ToSingle(text.Text);
                text.Clear();
                oxrana = Convert.ToString(a) + d;
                znak = true;
                zifra = 0;
            }
           

        }

      
        private void IDontKnow()
        {
            
            
                try
                {
                    switch (num)
                    {
                        case 1:
                            b = a + Convert.ToSingle(text.Text);
                            text.Text = Convert.ToString(b);
                            break;
                        case 2:
                            b = a - Convert.ToSingle(text.Text);
                            text.Text = Convert.ToString(b);
                            break;
                        case 3:
                            b = a * Convert.ToSingle(text.Text);
                            text.Text = Convert.ToString(b);
                            break;
                        case 4:
                            b = a / Convert.ToSingle(text.Text);
                            text.Text = Convert.ToString(b);
                            break;



                    }
                }
                catch (Exception)
                {
                    Clear();
                }

                b = a;
            
        
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Ravno_Click(object sender, RoutedEventArgs e)
        {
            ravno = true;
            IDontKnow();

            for (int c = 0; c <= Convert.ToInt32(text.Text.Length); c++)
            {
                m = Convert.ToBoolean(point);

                if (m == true)
                {

                    text.Text = "";
                }


            }
        }
    }   
}
