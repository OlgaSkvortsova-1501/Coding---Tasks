using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Редактор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool i = false;
        public MainWindow()
        {
            InitializeComponent();
            Shrift.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
        }
           


        

    

       

        private void Shrift_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (Shrift.SelectedItem != null)
                text.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, Shrift.SelectedItem);
              
           

        }

        
        

        private void Razmer_TextChanged(object sender, TextChangedEventArgs e)
        {
            text.Selection.ApplyPropertyValue(Inline.FontSizeProperty, Razmer.Text);
            Razmer.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            double shrift;
           
            if (text != null)
                if (Double.TryParse(Shrift.Text, out shrift ))
                {

                    text.Selection.ApplyPropertyValue(Inline.FontSizeProperty, shrift);
                    text.Focus();
                }
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            this.text.Foreground = Brushes.Blue;
           
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            this.text.Foreground = Brushes.Green;
           
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            this.text.Foreground = Brushes.Black;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.text.Foreground = Brushes.White;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            this.text.Foreground = Brushes.Red;
          
        }

        private void text_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                object temp = text.Selection.GetPropertyValue(Inline.FontWeightProperty);
                Jirni.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
                temp = text.Selection.GetPropertyValue(Inline.FontStyleProperty);
                Kursiv.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
                temp = text.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
                Cherk.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

                temp = text.Selection.GetPropertyValue(Inline.FontFamilyProperty);
                Shrift.SelectedItem = temp;
                temp = text.Selection.GetPropertyValue(Inline.FontSizeProperty);
                Razmer.Text = temp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }


}

      
	


