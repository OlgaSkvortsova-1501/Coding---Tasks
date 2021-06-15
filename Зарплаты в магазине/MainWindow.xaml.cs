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

            if (VodilaButton.IsChecked.Value)
            {

                try
                {

                    Vodila myVodila = new Vodila();


                    myVodila.ZP(Double.Parse(BaseZPText.Text));

         
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "ЗП" + myVodila.Formula3(); 
                    StackVodila.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    BaseZPText.Foreground = Brushes.Red;
                }
            }

            if (MenedjerButton.IsChecked.Value)
            {
                try
                {
                    
                    Menedjer myMenedjer = new Menedjer();

           
                    myMenedjer.Profit(Double.Parse(MonProfitText.Text));
                    myMenedjer.ZP(Double.Parse(BaseZPText.Text));

                  
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "ЗП" + myMenedjer.Formula2(); 
                    StackMenedjer.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    BaseZPText.Foreground = Brushes.Red;
                }


            }

            if (StProvadesButton.IsChecked.Value)
            {

                try
                {

                    StProdaves myStProdaves = new StProdaves();


                    myStProdaves.Profit(Double.Parse(MonProfitText.Text));
                    myStProdaves.ZP(Double.Parse(BaseZPText.Text));


                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "ЗП" + myStProdaves.Formula1();
                    StackStProdaves.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    BaseZPText.Foreground = Brushes.Red;
                }
            }

        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (BaseZPText.Foreground != Brushes.White)
                BaseZPText.Foreground = Brushes.White;
        }
    }  
}
