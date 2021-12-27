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

namespace FastBrowse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            browser.Navigate("https://fastbrowse-newtab.netlify.app/");
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            browser.Navigate(url.Text);
        }
    
        private void back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                browser.GoBack();
            }
            catch { browser.Navigate("https://fastbrowse-newtab.netlify.app/"); }
        }

        private void forward_Click(object sender, RoutedEventArgs e)
        {
            browser.GoForward();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            browser.Navigate("https://fastbrowse-newtab.netlify.app/");
        }
    }
}
