using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PayrollSystem.Views.Helpers.SearchModule
{
    public partial class SearchWindow
    {
        public SearchWindow()
        {
            InitializeComponent();
            txtFilterByKeyword.Search += (sender, args) => FilterByKeyword();

            Loaded += (sender, args) => txtFilterByKeyword.Focus();

            //txtFilterByKeyword.Search += (s, e) => OnItemSelected();

            KeyDown += (s, e) =>
                {
                    if (e.Key == Key.F12)
                    {
                        OnItemSelected();
                    }
                };
        }

        private readonly SearchItemViewModel _viewModel;

        public SearchItem SelectedItem { get; set; }

        public SearchWindow(IEnumerable<SearchItem> searchItems)
            : this()
        {
            _viewModel = new SearchItemViewModel {SearchItems = new SearchItems()};
            foreach (var searchItem in searchItems)
            {
                _viewModel.SearchItems.Add(searchItem);
            }
            DataContext = _viewModel;
        }

        private void FilterByKeyword()
        {
            string keyword = txtFilterByKeyword.Text.ToUpper();
            IOrderedEnumerable<SearchItem> query = from item in _viewModel.SearchItems
                                                   where item.ItemName.ToUpper().Contains(keyword.ToUpper())
                                                   orderby item.ItemName
                                                   select item;
            grdList.ItemsSource = query;
        }

        private void OnDataGridRowMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OnItemSelected();
        }

        private void OnItemSelected()
        {
            if (_viewModel.SelectedItem != null)
            {
                SelectedItem = _viewModel.SelectedItem;
                DialogResult = true;
                Close();
            }
            else
            {
                const string message = "Please select an existing record from the list.";
                MessageBoxes.ShowAlert(message);
            }
        }
    }
}
