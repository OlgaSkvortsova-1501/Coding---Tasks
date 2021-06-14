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

namespace Зарплаты_в_магазине
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

        

        private void Добавить_Click(object sender, RoutedEventArgs e)
        {

            if (VodilaSphere.IsChecked.Value)
            {

                try
                {

                    Vodila myVodila = new Vodila();


                    myVodila.III2(Double.Parse(Textt.Text));

         
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "ЗП" + myVodila.Formula3(); 
                    Text3.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    ZPText.Foreground = Brushes.Red;
                }
            }

            if (MenedjerCylinder.IsChecked.Value)
            {
                try
                {
                    
                    Menedjer myMenedjer = new Menedjer();

           
                    myMenedjer.OOO1(Double.Parse(Text.Text));
                    myMenedjer.OOO2(Double.Parse(Textt.Text));

                  
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "ЗП" + myMenedjer.Formula2(); 
                    Text2.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    ZPText.Foreground = Brushes.Red;
                }


            }

            if (StProvadesCircle.IsChecked.Value)
            {

                try
                {

                    StProdaves myStProdaves = new StProdaves();


                    myStProdaves.PPP1(Double.Parse(Text.Text));
                    myStProdaves.PPP2(Double.Parse(Textt.Text));


                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "ЗП" + myStProdaves.Formula1();
                    Text1.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    ZPText.Foreground = Brushes.Red;
                }
            }

        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ZPText.Foreground != Brushes.Black)
                ZPText.Foreground = Brushes.Black;
        }
    }  
}
