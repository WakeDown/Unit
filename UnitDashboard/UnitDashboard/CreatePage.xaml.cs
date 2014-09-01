using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace UnitDashboard
{
    public partial class CreatePage : Page
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            string[] data = new string[4];
            data[0] = TBlock_0.Text;
            data[1] = TBlock_1.Text;
            data[2] = CBox_0.SelectedItem.ToString();
            data[3] = CBox_1.SelectedItem.ToString();
        }
    }
}
