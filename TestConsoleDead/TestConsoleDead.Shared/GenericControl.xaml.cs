using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestConsoleDead.Shared.Models;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TestConsoleDead.Shared
{
    public sealed partial class GenericControl : UserControl
    {
        public GenericControl()
        {
            this.InitializeComponent();
            //this.DataContext = this;
            DataContextChanged += (s, e) =>
            {
                var createModel = this.DataContext as TestViewModel;
                CreateControl(createModel.CreateModel);
            };
        }

        private void CreateControl(Test t) {
            var grid = new Grid();
            grid.SetBinding(Grid.DataContextProperty, new Binding { Source = DataContext, Mode = BindingMode.TwoWay });
            //grid.DataContext = this.DataContext;
            var tb = new TextBlock();
            tb.SetBinding(TextBlock.TextProperty, new Binding { Source = t.HeaderText, Mode = BindingMode.TwoWay
                 , UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged});

            grid.Children.Add(tb);
            gridlayout.Children.Add(grid);
        }
    }
}
