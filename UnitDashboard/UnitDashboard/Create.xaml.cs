using System;
using System.Windows;
using System.Windows.Controls;

namespace UnitDashboard
{
    public partial class Create : Page
    {
        public Create()
        {
            InitializeComponent();

            FBlock_0.Source = new Uri("TemplatePage/Template_0.xaml", UriKind.Relative);
            FBlock_1.Source = new Uri("TemplatePage/Template_1.xaml", UriKind.Relative);
            FBlock_2.Source = new Uri("TemplatePage/Template_2.xaml", UriKind.Relative);
            FBlock_3.Source = new Uri("TemplatePage/Template_3.xaml", UriKind.Relative);
            FBlock_4.Source = new Uri("TemplatePage/Template_4.xaml", UriKind.Relative);
            FBlock_5.Source = new Uri("TemplatePage/Template_5.xaml", UriKind.Relative);
        }

        private void Border_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("TemplatePage/CreatePage_0.xaml", UriKind.Relative));
        }

        private void Border_MouseDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("TemplatePage/Template_1.xaml", UriKind.Relative));
        }

        private void Border_MouseDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("TemplatePage/Template_2.xaml", UriKind.Relative));
        }

        private void Border_MouseDown_4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("TemplatePage/Template_3.xaml", UriKind.Relative));
        }

        private void Border_MouseDown_5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("TemplatePage/Template_4.xaml", UriKind.Relative));
        }

        private void Border_MouseDown_6(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("TemplatePage/Template_5.xaml", UriKind.Relative));
        }
    }
}
