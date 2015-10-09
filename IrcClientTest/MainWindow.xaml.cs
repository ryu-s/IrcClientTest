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
using System.ComponentModel;
namespace IrcClientTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            viewModel.Data = "0";
            DataContext = viewModel;
            listView.Items.Add("server");
            listView.Items.Add("channel");
        }
        bool b = true;
        ViewModel viewModel = new ViewModel();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (b)
                viewModel.Data = "1";
            else
                viewModel.Data = "2";
            b = !b;
        }
        private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;

        }
        private void listViewItem_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void listView_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var listViewItem = (ListViewItem)listView.ItemContainerGenerator.ContainerFromItem(listView.SelectedItem);
            if (listView.InputHitTest(e.GetPosition(listViewItem)) != null)
            {
                //itemをクリック

            }
            else
            {
                //item以外

            }
            listView.SelectedItem = null;
        }
    }
    public class ViewModel : INotifyPropertyChanged
    {
        private string data;
        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Data)));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
