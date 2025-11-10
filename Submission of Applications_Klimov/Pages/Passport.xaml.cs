using Microsoft.Win32;
using Submission_of_Applications_Klimov.RegexС;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Submission_of_Applications_Klimov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Passport.xaml
    /// </summary>
    public partial class Passport : Page
    {
        public Passport()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            //if (!string.IsNullOrEmpty(tb_Lastname.Text) && Check.CheckReg(tb_Lastname.Text, "^[А-ЯЁ][а-яё]*$"))
            //{
            //    if (!string.IsNullOrEmpty(tb_Firstname.Text) && Check.CheckReg(tb_Firstname.Text, "^[А-ЯЁ][а-яё]*$"))
            //    {
            //        if (!string.IsNullOrEmpty(tb_Middlename.Text) && Check.CheckReg(tb_Middlename.Text, "^[А-ЯЁ][а-яё]*$"))
            //        {
            //            if (!string.IsNullOrEmpty(tb_DateofBirth.Text) && Check.CheckReg(tb_DateofBirth.Text, "^\\d{2}[.]\\d{2}[.]\\d{4}$"))
            //            {
            //                if (!string.IsNullOrEmpty(tb_Citizenship.Text) && Check.CheckReg(tb_Citizenship.Text, "^[А-ЯЁ][а-яё]*$"))
            //                {
            //                    if (!string.IsNullOrEmpty(tb_PlaceofBirth.Text) && Check.CheckReg(tb_PlaceofBirth.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
            //                    {
            //                        if (!string.IsNullOrEmpty(tb_SerialandNumber.Text) && Check.CheckReg(tb_SerialandNumber.Text, "^\\d{4}[- ]\\d{6}$"))
            //                        {
            //                            if (!string.IsNullOrEmpty(tb_DateofIssue.Text) && Check.CheckReg(tb_DateofIssue.Text, "^\\d{2}[.]\\d{2}[.]\\d{4}$"))
            //                            {
            //                                if (!string.IsNullOrEmpty(tb_DepartmentCode.Text) && Check.CheckReg(tb_DepartmentCode.Text, "^\\d{3}[-]\\d{3}$"))
            //                                {
            //                                    if (!string.IsNullOrEmpty(tb_Issued.Text) && Check.CheckReg(tb_Issued.Text, "^[А-ЯЁ0-9\\s]*$"))
            //                                    {
            //                                        if (!string.IsNullOrEmpty(tb_AddressRegistration.Text) && Check.CheckReg(tb_AddressRegistration.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
            //                                        {
            //                                            if (!string.IsNullOrEmpty(tb_District.Text) && Check.CheckReg(tb_District.Text, "^[А-ЯЁ][а-яё]*$"))
            //                                            {
            //                                                if (!string.IsNullOrEmpty(tb_AddressRegistrationFact.Text) && Check.CheckReg(tb_AddressRegistrationFact.Text, "^[А-Яа-яЁё0-9.\\-, ]*$"))
            //                                                {
            //                                                    if (!string.IsNullOrEmpty(tb_DistrictFact.Text) && Check.CheckReg(tb_DistrictFact.Text, "^[А-ЯЁ][а-яё]*$"))
            //                                                    {
            //                                                        if (string.IsNullOrEmpty(Link.Text))
            //                                                        {
            //                                                            MessageBox.Show("Необходимо прикрепить сканы страниц паспорта!");
            //                                                            return;
            //                                                        }

            //                                                        if (!File.Exists(Link.Text))
            //                                                        {
            //                                                            MessageBox.Show("Выбранный файл не существует!");
            //                                                            return;
            //                                                        }

            //                                                        NavigationService.Navigate(new Contacts());
            //                                                    }
            //                                                    else
            //                                                    {
            //                                                        MessageBox.Show("Введите свой район фактического проживания правильно!");
            //                                                    }
            //                                                }
            //                                                else
            //                                                {
            //                                                    MessageBox.Show("Введите свой адрес фактического проживания правильно!");
            //                                                }
            //                                            }
            //                                            else
            //                                            {
            //                                                MessageBox.Show("Введите свой район по прописке правильно!");
            //                                            }
            //                                        }
            //                                        else
            //                                        {
            //                                            MessageBox.Show("Введите свой адрес по прописке правильно!");
            //                                        }
            //                                    }
            //                                    else
            //                                    {
            //                                        MessageBox.Show("Введите кем выдан пасспорт правильно!");
            //                                    }
            //                                }
            //                                else
            //                                {
            //                                    MessageBox.Show("Введите код подразделения правильно!");
            //                                }
            //                            }
            //                            else
            //                            {
            //                                MessageBox.Show("Введите дату выдачи паспорта правильно!");
            //                            }
            //                        }
            //                        else
            //                        {
            //                            MessageBox.Show("Неправильно указаны серия и номер паспорта!");
            //                        }
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Введите своё место рождения правильно!");
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Введите своё гражданство правильно!");
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Введите свою дату рождения правильно!");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Введите своё отчество!");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Введите своё имя!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Введите свою фамилию!");
            //}

            NavigationService.Navigate(new Contacts());
        }

        private void ChooseImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.pdf)|*.png;*.jpeg;*.jpg;*.pdf|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Выберите файл паспорта";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFile = openFileDialog.FileName;

                string extension = System.IO.Path.GetExtension(selectedFile).ToLower();
                if (extension != ".png" && extension != ".jpeg" && extension != ".jpg" && extension != ".pdf")
                {
                    MessageBox.Show("Неподдерживаемый формат файла. Выберите файл в формате PNG, JPEG, JPG или PDF.");
                    return;
                }

                Link.Text = selectedFile;
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
