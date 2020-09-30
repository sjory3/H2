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

namespace Color_Picker
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
        string hexvalues;
        //Red Slider gets called everytime the Slider in the from changes
        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //sets the label with what the current number is for the red slider
            LableRedValue.Content = RedSlider.Value.ToString();
            //changes the Panel Color to what the sliders is set to
            ColorPanel.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
            //updates hexvalues from the sliders
            hexvalues = String.Format("#{0:X2}{1:X2}{2:X2}", (byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            //updates the hex label with the current hex values
            LableHexValues.Content = hexvalues;

        }

        //Green Slider gets called everytime the slider in the form changes
        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //sets the label with what the current number is for the green slider
            LableGreenValue.Content = GreenSlider.Value.ToString();
            //changes the panel color to what the sliders is set to
            ColorPanel.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
            //updates hexvalue from the sliders
            hexvalues = String.Format("#{0:X2}{1:X2}{2:X2}", (byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            //updates the hex label with the current hex values
            LableHexValues.Content = hexvalues;
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //sets the label with what the current number is for the blue slider
            LableBlueValue.Content = BlueSlider.Value.ToString();
            //changes the panel color to what the sliders is set to
            ColorPanel.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
            //updates hexvalues from the sliders
            hexvalues = String.Format("#{0:X2}{1:X2}{2:X2}", RedSlider.Value, GreenSlider.Value, (byte)BlueSlider.Value);
            //updates the hex label with the current hex values
            LableHexValues.Content = hexvalues;
        }
    }
}
