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

namespace cinemcass
{


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {




        private readonly Model1Container1 _container = new Model1Container1();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _container;
        }


        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            var cinema
                = new cinema
                {
                    header = headerNameTxt.Text,
                    col = colNameTxt.Text
                };
            _container.cinemaSet.Add(cinema);
            _container.SaveChanges();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _container.cinemaSet.Load();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cinema p1 = _container.cinemaSet.FirstOrDefault();
            if (p1 != null)
            {
                _container.cinemaSet.Remove(p1);
                _container.SaveChanges();
            }
        }

       
        
    }
}    
        
           

