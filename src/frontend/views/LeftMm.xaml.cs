using frontend.viewmodels;
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




namespace frontend.views
{
    /// <summary>
    /// Interaktionslogik für LeftMm.xaml
    /// </summary>
    public partial class LeftMm : UserControl
    {
        public LeftMmModel ViewModel { get; set; } = new LeftMmModel();

        public LeftMm()
        {
            InitializeComponent();
            bttn_1.Content = ViewModel.ButtonTextItem[0];
            bttn_2.Content = ViewModel.ButtonTextItem[1];
            bttn_3.Content = ViewModel.ButtonTextItem[2];
            bttn_4.Content = ViewModel.ButtonTextItem[3];

        }
    }
}