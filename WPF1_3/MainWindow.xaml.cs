using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WPF1_3
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient web = new WebClient();
                web.Encoding = Encoding.UTF8;
                string json = web.DownloadString(@"https://apis.is/car?number=" + txtCarnumber.Text);
                CarInfo carinfo = JsonConvert.DeserializeObject<CarInfo>(json);
                Car c = carinfo.results[0];

                txtType.Text = c.type;
                txtColor.Text = c.color;
            }
            catch (Exception)
            {
                MessageBox.Show("Bíll með númerið " + txtCarnumber.Text + " fannst ekki");
            }
 

        }
    }
}
