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
using MediaPlayer.UI.Controllers;

namespace MediaPlayer.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MPWindow : Window
    {
        public MPWindow()
        {
            InitializeComponent();
        }

        private void Exit_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ApplicationController.Exit(this);
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            LibraryController.AddSong();
        }
    }
}
