using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PayrollSystem.Views.Helpers.SearchModule
{
    public partial class SearchWindow
    {
        public SearchWindow()
        {
            InitializeComponent();
            txtFilterByKeyword.TextChanged += (sender, args) => FilterByKeyword();

            Loaded += (sender, args) => txtFilterByKeyword.Focus();

            grdList.MouseDoubleClick += (s, e) => SelectedItemOnMouseDoubleClick();

            btnSelect.Click += (s, e) => SelectButtonOnClick();
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

        private void SelectButtonOnClick()
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

        private void BaseWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtFilterByKeyword.Focus();
        }

        private void SelectedItemOnMouseDoubleClick()
        {
            if (_viewModel.SelectedItem == null) return;
            SelectedItem = _viewModel.SelectedItem;
            DialogResult = true;
            Close();
        }
    }
}
