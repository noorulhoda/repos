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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for USerControl1.xaml
    /// </summary>
    public partial class USerControl1 : UserControl
    {
        //clr proprty (get /set usgin setvalue(); getValue()
        //static depencepropty


        public int font//clr property
        {
            get { return (int)GetValue(fontProperty); }
            set { SetValue(fontProperty, value); }
        }

        // Using a DependencyProperty as the backing store for font.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty fontProperty =
            DependencyProperty.Register
            ("font", typeof(int), typeof(USerControl1), new PropertyMetadata(10));

        public int clr//clr property
        {
            get { return (int)GetValue(clrProperty); }
            set { SetValue(clrProperty, value); }
        }

        // Using a DependencyProperty as the backing store for font.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty clrProperty =
            DependencyProperty.Register
            ("font", typeof(Color), typeof(USerControl1), new PropertyMetadata(10));

        public USerControl1()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            font = int.Parse(txt.Text);
            Color mycolor  =new Color();
           bool Color = Enum.TryParse<Color>((string)CmbColors.SelectedItem, out mycolor);
        }
    }
}
