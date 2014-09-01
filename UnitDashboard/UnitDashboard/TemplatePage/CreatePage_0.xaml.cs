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

namespace UnitDashboard.TemplatePage
{
    public partial class CreatePage_0 : Page
    {
        public CreatePage_0()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] str = new string[16];
            str[0] = TBlock_0.GetLineText(0);
            str[1] = TBlock_1.GetLineText(0);
            str[2] = TBlock_2.GetLineText(0);
            str[3] = TBlock_3.GetLineText(0);
            str[4] = TBlock_4.GetLineText(0);
            str[5] = TBlock_5.GetLineText(0);
            str[6] = TBlock_6.GetLineText(0);
            str[7] = TBlock_7.GetLineText(0);
            str[8] = TBlock_8.GetLineText(0);
            str[9] = TBlock_9.GetLineText(0);
            str[10] = TBlock_10.GetLineText(0);
            str[11] = TBlock_11.GetLineText(0);
            str[12] = TBlock_12.GetLineText(0);
            str[13] = TBlock_13.GetLineText(0);
            str[14] = TBlock_14.GetLineText(0);
            str[15] = TBlock_15.GetLineText(0);

            NavigationService.Navigate(new Uri("CompletePage_0.xaml", UriKind.Relative), str);
        }
    }
}
