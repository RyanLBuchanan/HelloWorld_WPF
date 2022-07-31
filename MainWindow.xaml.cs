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

namespace HelloWorld_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //// Create the StackPanel
            //StackPanel stackPanel = new StackPanel();
            //this.Content = stackPanel;

            //// Create the Button
            //Button button = new Button();
            //button.Content = "Click me, three!";
            //button.HorizontalAlignment = HorizontalAlignment.Left;
            //button.Margin = new Thickness(150);
            //button.VerticalAlignment = VerticalAlignment.Top;
            //button.Width = 100;
            //stackPanel.Children.Add(button);
        }

        //public static readonly DependencyProperty SetTextProperty =
        //    DependencyProperty.Register("SetText", typeof(string), typeof(UserControl), new
        //        PropertyMetadata("", new PropertyChangedCallback(OnSetTextChanged)));

        //public string SetText
        //{
        //    get { return (string)GetValue(SetTextProperty);  }
        //    set { SetValue(SetTextProperty, value); }
        //}

        //private static void OnSetTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    UserControl UserControlControl = d as UserControl;
        //    UserControlControl.OnSetTextChanged(e);
        //}

        //private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        //{
        //    tbTest.Text = e.NewValue.ToString()
        //}
    }
}
