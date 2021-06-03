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

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        public MainWindow()
        {
            InitializeComponent();
            a = 0;
        }


        private void Button_Click13_MouseUp(object sender, MouseButtonEventArgs e)
        {
           
            a = 0;
            text.Text = 0 + "кг";
        }

        private void Button_Click_MouseUp(object sender, MouseButtonEventArgs e)
        {
            a++;
            text.Text = a + "кг";
        }

        
    }
}
