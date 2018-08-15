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
using System.ComponentModel;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using System.Runtime.CompilerServices;
using System.IO;

namespace UITelega
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //INotifyPropertyChanged
    {
        List<User> users;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            users = new List<User>
            {
                new User { Name = "Aleksandr Hryhorenko 0", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 1", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString()  },
                new User { Name = "Aleksandr Hryhorenko 2", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 3", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 4", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 5", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 6", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 7", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 8", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 9", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() },
                new User { Name = "Aleksandr Hryhorenko 10", PhoneNumber = "+380 67 213 83 45", Username = "ALLHry", DateVisit = dt.ToShortDateString() }
            };
            this.DataContext = users;

            string pathPhoto = System.Reflection.Assembly.GetExecutingAssembly().Location.TrimEnd("UITelega.exe".ToCharArray()) + "ph01.jpg";
            if (!File.Exists(pathPhoto))
                return;

            HelperCl.ResizeImg(pathPhoto);
            foreach (var item in users)
                item.Avatar = HelperCl.pathPh;
        }

        private void TitleForm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void BtnMinTitle_Click(object sender, RoutedEventArgs e)
        {
            Button btmTitle = sender as Button;

            switch ((sender as Button).Name)
            {
                case "BtnMinTitle":
                    this.WindowState = WindowState.Minimized;
                    break;

                case "BtnMaxTitle":
                    this.WindowState = this.WindowState == WindowState.Maximized ?
                        WindowState.Normal : WindowState.Maximized;
                    break;

                case "BtnCloseTitle":
                    this.Close();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) {}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewGroup ng = new NewGroup();
            HelperCl.AnimationForm(ng);
            ng.ShowDialog();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewChannel nch = new NewChannel();
            HelperCl.AnimationForm(nch);
            nch.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Contacts c = new Contacts(users);
            HelperCl.AnimationForm(c);
            c.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Calls c = new Calls(users);
            HelperCl.AnimationForm(c);
            c.ShowDialog();
        }
    }
}
