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
using ConverterLibrary;

namespace WpfApp1
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

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            Converter c = new Converter();
            decimal meters;
            decimal.TryParse(txtHeight.Text, out meters);
            decimal kilograms;
            decimal.TryParse(txtWeight.Text, out kilograms);
            lblResult.Content = "BMI: " + c.GetBMI(meters,kilograms).ToString();
        }

        private bool IsValidInput(string txt)
        {
            bool IsValid = System.Text.RegularExpressions.Regex.IsMatch(txt, @"\d{0,3}");
            return IsValid;
        }

        private void ToggleButton(bool IsValid, TextBox tbx)
        {
            if (IsValid)
            {
                tbx.Background = Brushes.White;
                btnGet.IsEnabled = true;
            }
            else
            {
                tbx.Background = Brushes.Yellow;
                btnGet.IsEnabled = false;
            }
        }

        private void txtWeight_LostFocus(object sender, RoutedEventArgs e)
        {
            bool IsValid = IsValidInput(txtWeight.Text);
            ToggleButton(IsValid, txtWeight);
        }

        private void txtHeight_LostFocus(object sender, RoutedEventArgs e)
        {
            bool IsValid = IsValidInput(txtHeight.Text);
            ToggleButton(IsValid, txtHeight);
        }
    }
}
