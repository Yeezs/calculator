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
using System.Data;

namespace calculator
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


        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (Display.Text == "0")
            {
                Display.Text = button.Content.ToString();
            }
            else
            {
                Display.Text += button.Content.ToString();
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)(sender);
            Display.Text += button.Content.ToString();
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)(sender);

            DataTable dt = new DataTable();

            string expression =(string)Display.Text;

            var result = dt.Compute(expression, "");
            Display.Text = result.ToString();
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }
    }
}
