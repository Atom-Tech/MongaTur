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

namespace MongaTur.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double width, height;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void fechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void maximizar_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Maximized)
            {
                maximize.Visibility = Visibility.Collapsed;
                restore.Visibility = Visibility.Visible;
                height = Height;
                width = Width;
                WindowState = WindowState.Maximized;
            }
            else
            {
                maximize.Visibility = Visibility.Visible;
                restore.Visibility = Visibility.Collapsed;
                Height = height;
                Width = width;
                WindowState = WindowState.Normal;
            }
        }

        private bool _isMouseDown = false;

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown && this.WindowState == WindowState.Maximized)
            {
                _isMouseDown = false;
                this.WindowState = WindowState.Normal;
            }
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _isMouseDown = true;
            this.DragMove();
        }

        private void Pontos_Selected(object sender, RoutedEventArgs e)
        {
            Root.Navigate(new Views.ListaPontos());
        }

        private void Root_Navigated(object sender, NavigationEventArgs e)
        {
            if (Root.CanGoBack)
                botaoVoltar.Visibility = Visibility.Visible;
            else
                botaoVoltar.Visibility = Visibility.Collapsed;
        }

        private void botaoVoltar_Click(object sender, RoutedEventArgs e)
        {
            Root.GoBack();
        }

        private void Home_Selected(object sender, RoutedEventArgs e)
        {
            Root.Navigate(new Views.Home());
        }

        private void TitleBar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isMouseDown = false;
        }

    }
}
