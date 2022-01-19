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
using System.Data.Entity;

namespace SQL.TestApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentDb DbContext;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            //this.DataContext = DbContext;
            //DbContext.Students.OrderBy(a => a.LastName);
            //StudentsDataGrid.ItemsSource = DbContext.Students.Local;
        }

        void MainWindow_Loaded(object s, RoutedEventArgs e)
        {
            DbContext = new StudentDb();
            DbContext.Students.OrderBy(x => x.Id).Load();
            StudentsDataGrid.ItemsSource = DbContext.Students.Local;
            StudentsDataGrid.Columns[0].IsReadOnly = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DbContext.SaveChanges();
        }



        public void StudentsDataGrid_InitializingNewItem(object sender, AddingNewItemEventArgs e)
        {
            c = true;
        }

        public void StudentsDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (c == true)
            {
                int a = StudentsDataGrid.Items.Count;

                (StudentsDataGrid.SelectedItem as Student).Id = a - 1;

                c = false;
            }
        }
        bool c = false;

    } 
}
