using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace ValueConverters
{
    /// <summary>
    /// Interaction logic for MultiValueConverter.xaml
    /// </summary>
    public partial class MultiValueConverter : Window
    {
        private decimal total = 0;
        public MultiValueConverter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.Total.ToString());
            total = decimal.Parse(this.Total.Text);
        }
    }
}
