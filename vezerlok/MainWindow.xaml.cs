using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vezerlok
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

        private void kuldes(object sender, RoutedEventArgs e)
        {
            string eredmeny = "";
            bool elfogadva = false;
            
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                eredmeny += "Név: " + textbox.Text + "\n";
            }
            if (!string.IsNullOrEmpty(passwordbox.Password))
            {
                eredmeny += "A jelszó meg van adva.\n";
            }
            string nem = "";
            if(ferfi.IsChecked == true)
            {
                nem = "Férfi";
            }
            else if(no.IsChecked == true)
            {
                nem = "Nő";
            }
            if(feltetelek.IsChecked == true)
            {
                elfogadva = true;
                eredmeny += "Felhasználási feltételek elfogadva.\n";
            }
            else if (feltetelek.IsChecked == false)
            {
                elfogadva = false;
                eredmeny += "Felhasználási feltételek nincsenek elfogadva.\n";
            }
            
            eredmeny += "Nem: " + nem + "\n";
            if(elfogadva && nem !="" && feltetelek.IsChecked == true)
            {
                MessageBox.Show(eredmeny);
            }
            else if(elfogadva == false)
            {
                MessageBox.Show("Fogadd el a felhasználási feltételeket vagy nem írom ki az eredményt!");
            }  
            else if(nem == "")
            {
                MessageBox.Show("Válassz nemet!");
            }
        }
    }
}