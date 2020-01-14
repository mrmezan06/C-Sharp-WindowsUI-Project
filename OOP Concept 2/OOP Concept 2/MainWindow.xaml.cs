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

namespace OOP_Concept_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked";
            Button btn = new Button();
            btn.Content = "Button 1";
            btn.Margin = new Thickness(10, 10, 200, 200);
            btn.Click += btn_Click;
            ((Grid)((Button)sender).Parent).Children.Add(btn);
        }
        private void btn_Click(object sender, RoutedEventArgs e) {
            ((Button)sender).Content = "Clicked!!";
        }
    }
}
