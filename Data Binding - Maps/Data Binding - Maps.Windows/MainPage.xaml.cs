using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Data_Binding___Maps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        BindingData bd = new BindingData(); 
        public MainPage()
        {
            this.InitializeComponent();
            setDataContext();


            mainsta.DataContext = new BindingData
            {
                id = 1,
                name = "Mohamed",
                num = 5
            };
        }
        private void setDataContext()
        {
            ConetnGrid.DataContext = bd;
        }

        private void NavigateBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MapPage));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtblock2.Text = bd.name;
        }
    }
}
