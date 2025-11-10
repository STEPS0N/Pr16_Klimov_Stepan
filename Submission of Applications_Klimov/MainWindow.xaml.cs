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

namespace Submission_of_Applications_Klimov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            OpenStartPage(pages.statement);
        }

        public enum pages
        {
            statement
        }

        public void OpenStartPage(pages _page)
        {
            if (_page == pages.statement)
            {
                frame.Navigate(new Pages.Statement());
            }
        }

    }
}