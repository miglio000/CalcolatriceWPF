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

namespace Calcolatrice
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

        private void btnSomma_Click(object sender, RoutedEventArgs e)
        {
            if (txtValore1.Text != "" && txtValore2.Text != "")
            {
                try
                {
                    double primovalore = double.Parse(txtValore1.Text);
                    double secondovalore = double.Parse(txtValore2.Text);
                    lblRisultato.Content = primovalore + secondovalore;

                }
                catch (Exception)
                {
                    MessageBox.Show("Valori non validi", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori", "Empty space", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSottrazione_Click(object sender, RoutedEventArgs e)
        {
            if (txtValore1.Text != "" && txtValore2.Text != "")
            {
                try
                {
                    double primovalore = double.Parse(txtValore1.Text);
                    double secondovalore = double.Parse(txtValore2.Text);
                    lblRisultato.Content = primovalore - secondovalore;
                }
                catch (Exception)
                {
                    MessageBox.Show("Valori non validi", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori", "Empty space", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnMoltiplicazione_Click(object sender, RoutedEventArgs e)
        {
            if (txtValore1.Text != "" && txtValore2.Text != "")
            {
                try
                {
                    double primovalore = double.Parse(txtValore1.Text);
                    double secondovalore = double.Parse(txtValore2.Text);
                    lblRisultato.Content = primovalore * secondovalore;

                }
                catch (Exception)
                {
                    MessageBox.Show("Valori non validi", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori", "Empty space", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDivisione_Click(object sender, RoutedEventArgs e)
        {
            if (txtValore1.Text != "" && txtValore2.Text != "")
            {
                try
                {
                    double primovalore = double.Parse(txtValore1.Text);
                    double secondovalore = double.Parse(txtValore2.Text);
                    lblRisultato.Content = primovalore / secondovalore;

                }
                catch (Exception)
                {
                    MessageBox.Show("Valori non validi", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori", "Empty space", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
