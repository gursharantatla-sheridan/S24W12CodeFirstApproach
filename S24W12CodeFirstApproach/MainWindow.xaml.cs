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

namespace S24W12CodeFirstApproach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // define the object of context class
        SchoolContext db = new SchoolContext();

        public MainWindow()
        {
            InitializeComponent();
            PopulateStandardComboBox();
        }

        private void PopulateStandardComboBox()
        {
            cmbStandard.ItemsSource = db.Standards.ToList();
            cmbStandard.DisplayMemberPath = "Name";
            cmbStandard.SelectedValuePath = "StandardId";
        }
    }
}