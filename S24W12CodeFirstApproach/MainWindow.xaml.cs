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

        private void LoadStudents()
        {
            grdStudents.ItemsSource = db.Students.ToList();
            grdStudents.Columns[3].Visibility = Visibility.Hidden;
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            LoadStudents();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Student std = new Student();
            std.Name = txtName.Text;
            std.StandardId = (int)cmbStandard.SelectedValue;

            db.Students.Add(std);
            db.SaveChanges();

            LoadStudents();
            MessageBox.Show("New student added");
        }
    }
}