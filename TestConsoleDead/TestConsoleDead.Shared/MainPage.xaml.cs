using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestConsoleDead.Shared;
using TestConsoleDead.Shared.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestConsoleDead
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public TestViewModel viewModel { get; set; } = new TestViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = viewModel;
        }

        public void clickBtn(object sender, RoutedEventArgs e) {

            var m = ((Button)sender).DataContext as TestViewModel;
            m.CreateModel.HeaderText = "tripathi";
            viewModel = m;
            var s = new GenericControl {
                
                DataContext = viewModel
            };
        }

    }
}
