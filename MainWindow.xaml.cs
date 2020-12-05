using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Grunt
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            SoundPlayer sp = new SoundPlayer($@"{path}\grunt.wav");
            sp.Play();
        }
    }
}
