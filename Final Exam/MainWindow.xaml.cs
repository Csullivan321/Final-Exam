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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Display phone in list box
            var query = from a in db.Phones
                        orderby a.Name
                        select a.Name;

            //var result = query.ToList();
            lstbxPhone.ItemsSource = query.ToList();
        }

        private void lstbxPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            

            // display phone price
            Phone selectedphone = lstbxPhone.SelectedItem as Phone;

            if(selectedphone != null)
            {
                var query = from a in db.Phones
                            where a.Name.Equals(selectedphone)
                            select new PhonePrice
                            {
                                Price = a.Price
                            };

                //Pricetxtblk.Text.Equals(PhonePrice)

                //show image
                Phoneimg.Source = new BitmapImage(new Uri($"/images/{selectedphone.PhoneImage}"));
                            
            }

        }
        public class PhonePrice : Phone
        {
            public override string ToString()
            {
                return string.Format("Price : {0}",Price);
            }
        }
    }
}
