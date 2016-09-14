using DatabaseLibrary;
namespace PayrollSystem.Views.Detachments
{
    /// <summary>
    /// Interaction logic for DetachmentView.xaml
    /// </summary>
    public partial class DetachmentView
    {
        public DetachmentView(AbstractModel viewModel)
        {
            InitializeComponent();

            ViewModel = viewModel;
            DataContext = ViewModel;

            btnSave.Content = ViewModel.Id == 0 ? "Create" : "Update";
            btnSave.Click += (sender, args) => Save();
            btnCancel.Click += (sender, args) => Close();
        }
    }
}
