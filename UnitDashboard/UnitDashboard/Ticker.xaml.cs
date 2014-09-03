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

namespace UnitDashboard
{
    public partial class Ticker : Page
    {
        public Ticker()
        {
            InitializeComponent();

            string text = "Бегууууууууууууууууууууущая строка";
            int length = text.Length;
            int w = (int)(SystemParameters.PrimaryScreenWidth);
            OptionsTicket.From = w + length;
            OptionsTicket.To = -length * 6;
            TBTicker.FontSize = 15;
            TBTicker.Text = text;
        }
    }
}
