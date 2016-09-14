using System.Collections.ObjectModel;
using System.Windows;
using System.Linq;
using ModelsLibrary.Payroll;

namespace PayrollSystem.Views.TaxGroups
{
    /// <summary>
    /// Interaction logic for TaxGroupsList.xaml
    /// </summary>
    public partial class TaxGroupsList : IViewable
    {
        private TaxGroupsViewModel _viewModel = new TaxGroupsViewModel();
        private TaxGroupCollection _lookup;
        public TaxGroupsList()
        {
            InitializeComponent();

            Refresh();

            btnRefresh.Click += (sender, args) => Refresh();
            btnAdd.Click += (sender, args) => Add();
            btnEdit.Click += (sender, args) => Edit();
            btnDelete.Click += (sender, args) => Delete();
        }

        #region Implementation of IViewable

        public void Refresh()
        {
            var searchItem = txtFilterByKeyword.Text;
            if (searchItem.Trim().Length == 0)
            {
                _lookup = TaxGroupCollection.GetAll();
                _viewModel = new TaxGroupsViewModel { Collection = TaxGroupCollection.GetAll() };
                DataContext = _viewModel;
            }
            else
            {
                var filteredItem = from item in _lookup
                                   where item.TaxGroupName.ToLower().Contains(searchItem.ToLower())
                                   select item;

                var viewModel = new TaxGroupsViewModel { Collection = new TaxGroupCollection() };
                foreach (var item in filteredItem)
                {
                    viewModel.Collection.Add(item);
                }
                _viewModel = viewModel;
                DataContext = _viewModel;
            }
        }

        public void Add()
        {
            throw new System.NotImplementedException();
        }

        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
