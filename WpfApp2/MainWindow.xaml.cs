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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow main;
        public MainWindow()
        {
            InitializeComponent();
           main= this;

            first = false;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ColorChangeModel();
        }
        bool first;
        private void CountDown_Click(object sender, RoutedEventArgs e)
        {

            if (typeof(CounterViewModel) != DataContext.GetType())
                DataContext = new CounterViewModel();
        }

        private void ColorChanger_Click(object sender, RoutedEventArgs e)
        {
           if (typeof(ColorChangeModel) != DataContext.GetType())
                DataContext = new ColorChangeModel();        
             
        }
    }
}
