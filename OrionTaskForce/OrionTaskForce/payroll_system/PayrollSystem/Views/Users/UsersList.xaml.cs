using System.Linq;
using System.Collections.ObjectModel;
using PayrollSystem.Models;

namespace PayrollSystem.Views.Users
{
    public partial class UsersList : IManageModel
    {
        private UsersViewModel _viewModel = new UsersViewModel();
        private readonly UsersViewModel _lookup = new UsersViewModel();
        public UsersList()
        {
            InitializeComponent();
            _lookup.RefreshCollection();
            Refresh();

            btnRefresh.Click += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
            btnResetPassword.Click += (sender, e) => ResetPassword();
        }

        private void ResetPassword()
        {
            if (_viewModel.SelectedItem == null) return;

            if(MessageBoxes.ShowConfirmation("Reset password for selected user?") == System.Windows.Forms.DialogResult.Yes)
            {
                _viewModel.SelectedItem.Password = "password";
                _viewModel.SelectedItem.Update();
            }
        }

        #region Implementation of IViewable

        public void Refresh()
        {
            var tempModel = new UsersViewModel();
            tempModel.Collection = new ObservableCollection<User>();

            var searchItem = txtFilterByKeyword.Text;
            if (searchItem.Trim().Length == 0)
            {
                foreach (var item in _lookup.Collection)
                {
                    tempModel.Collection.Add(item);
                }
            }
            else
            {
                var filteredItem = from item in _lookup.Collection
                                   where item.Name.ToLower().Contains(searchItem.ToLower())
                                   select item;

                foreach (var item in filteredItem)
                {
                    tempModel.Collection.Add(item);
                }
            }

            _viewModel = tempModel;
            DataContext = _viewModel;
        }

        public void Add()
        {
            var newItem = new User();
            var view = new UserView(newItem);
            if(view.ShowDialog() == true)
            {
                _lookup.Collection.Add(newItem);
                Refresh();
                _viewModel.SelectedItem = _viewModel.Collection.FirstOrDefault(item => item.Id == newItem.Id);
                if (_viewModel.SelectedItem != null) dataGrid1.ScrollIntoView(_viewModel.SelectedItem);
            }
        }

        public void Edit()
        {
            if(_viewModel.SelectedItem == null) return;

            var currentItem = new User();
            currentItem.Read(_viewModel.SelectedItem.Id);
            var view = new UserView(currentItem);
            if (view.ShowDialog() == true)
            {
                _viewModel.SelectedItem.Read(currentItem.Id);
            }
        }

        public void Delete()
        {
            if (_viewModel.SelectedItem == null) return;

            const string message = "Do you really want to delete this record?";
            if (MessageBoxes.ShowConfirmation(message) == System.Windows.Forms.DialogResult.Yes)
            {
                var item = _viewModel.SelectedItem;
                var result = item.Destroy();
                if (!result.Success)
                {
                    MessageBoxes.ShowAlert(result.Message);
                    return;
                }
                _lookup.Collection.Remove(item);
                _viewModel.Collection.Remove(item);
                _viewModel.SelectedItem = null;
            }
        }

        #endregion
    }
}
