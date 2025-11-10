using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Submission_of_Applications_Klimov.RegexС;

namespace Submission_of_Applications_Klimov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_HomeNumber.Text) && Check.CheckReg(tb_HomeNumber.Text, "^(\\+7)\\d{10}$"))
            {
                if (!string.IsNullOrEmpty(tb_MobileNumber.Text) && Check.CheckReg(tb_MobileNumber.Text, "^(\\+7)\\d{10}$"))
                {
                    if (!string.IsNullOrEmpty(tb_EmailAddress.Text) && Check.CheckReg(tb_EmailAddress.Text, "^[A-Za-z0-9][A-Za-z0-9._%+-]*@(mail|yandex|gmail|permaviat)\\.ru$"))
                    {
                        NavigationService.Navigate(new Parents());
                    }
                    else
                    {
                        MessageBox.Show("Введите свой электронный адрес правильно!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите свой мобильный телефон правильно!");
                }
            }
            else
            {
                MessageBox.Show("Введите свой домашний телефон правильно!");
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
