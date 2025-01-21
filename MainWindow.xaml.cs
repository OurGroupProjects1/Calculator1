using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ans="\0";
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        
        private void Print_1(object sender, RoutedEventArgs e)
        {
            //update text
            textbox1.TextChanged -= TextBox_TextChanged;

            //change of text

            textbox1.Text += button1.Content.ToString();

            //changed string
            ans += textbox1.Text;
            return;

        }
        private void Print_plus(object sender, RoutedEventArgs e)
        {
            //update text
            textbox1.TextChanged -= TextBox_TextChanged;

            //change of text
            textbox1.Text += add.Content.ToString();

            //changed string
            ans += textbox1.Text;
            return;

        }
        private void Print_minus(object sender, RoutedEventArgs e)
        {
            //update text
            textbox1.TextChanged -= TextBox_TextChanged;

            //change of text
            
            textbox1.Text += sub.Content.ToString();

            //changed string
            ans += textbox1.Text;
            return;

        }
        private void Print_star(object sender, RoutedEventArgs e)
        {
            //update text
            textbox1.TextChanged -= TextBox_TextChanged;

            //change of text
            textbox1.Text += mul.Content.ToString();

            //changed string
            ans += textbox1.Text;
            return;

        }

        private void Print_slash(object sender, RoutedEventArgs e)
        {
            //update text
            textbox1.TextChanged -= TextBox_TextChanged;

            //change of text
            textbox1.Text += div.Content.ToString();

            //changed string
            ans += textbox1.Text;
            return;

        }

        private void Print_equal(object sender, RoutedEventArgs e)
        {
            //update text
            textbox1.TextChanged -= TextBox_TextChanged;

            //change of text
            textbox1.Text += equal.Content.ToString();

            //changed string
            ans += textbox1.Text;
            return;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            button1.Click += Print_1; 
        }
    }
}