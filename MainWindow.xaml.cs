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

namespace WpfApp3._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            objectRisovanie.DefaultDrawingAttributes.Color = Colors.SpringGreen;
        }

        private void ListBoxItem_MouseEnter(object sender, MouseEventArgs e)
        {
            objectRisovanie.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void ListBoxItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            objectRisovanie.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void ListBoxItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            objectRisovanie.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Slider_MouseLeave(object sender, MouseEventArgs e)
        {
            objectRisovanie.DefaultDrawingAttributes.Width = slid.Value/2;
          //  risovalka.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void rb2_Click(object sender, RoutedEventArgs e)
        {
            if (RadioBitton1.IsChecked == true)
            {
                RadioBitton2.IsChecked = false;
                RadioBitton3.IsChecked = false;
            }
        }

        private void rb3_Click(object sender, RoutedEventArgs e)
        {
            if (RadioBitton2.IsChecked == true)
            {
                RadioBitton1.IsChecked = false;
                RadioBitton3.IsChecked = false;
            }
        }

        private void rb1_Click(object sender, RoutedEventArgs e)
        {
            if (RadioBitton3.IsChecked == true)
            {
                RadioBitton1.IsChecked =  false;
                RadioBitton3.IsChecked = false;  
            }
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            if (RadioBitton1.IsChecked==true)
            {
                objectRisovanie.EditingMode = InkCanvasEditingMode.Ink;
            }
            if (RadioBitton2.IsChecked==true)
            {
                objectRisovanie.EditingMode = InkCanvasEditingMode.EraseByPoint;
            }
            if (RadioBitton3.IsChecked==true)
            {
                objectRisovanie.EditingMode = InkCanvasEditingMode.InkAndGesture;
            }
        }
    }
}
