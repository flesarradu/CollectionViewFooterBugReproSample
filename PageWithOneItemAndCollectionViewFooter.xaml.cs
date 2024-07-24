using CollectionViewFooterBugReproSample.ViewModels;
using System.Collections.ObjectModel;

namespace CollectionViewFooterBugReproSample
{
    public partial class PageWithOneItemAndCollectionViewFooter : ContentPage
    {
        public PageWithOneItemAndCollectionViewFooter()
        {
            InitializeComponent();

            ItemsViewModel itemsViewModel = new ItemsViewModel
            {
                Items = new ObservableCollection<ItemViewModel> {
                    new ItemViewModel {
                        Description = "Item 1",
                        ImageUrl = "dotnet_bot.png"
                    },
                }
            };

            BindingContext = itemsViewModel;
        }

        private void GoToPageWithOneItemWithoutCollectionViewFooter(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageWithOneItemWithoutCollectionViewFooter());
        }
        
        private void GoToPageWithThreeItemsAndCollectionViewFooter(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageWithThreeItemsAndCollectionViewFooter());
        }
    }
}
