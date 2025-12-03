using frontend.views;
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
using System.Windows.Shapes;

namespace frontend
{
    /// <summary>
    /// Interaktionslogik für GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private LeftMm leftMm;

        public GameWindow(Window parentWindow)

        {
            Owner = parentWindow;
            InitializeComponent();
        }

        public GameWindow(LeftMm leftMm)
        {
            this.leftMm = leftMm;
        }
    }
}