using CollectionViewFooterBugReproSample.ViewModels;
using System.Collections.ObjectModel;

namespace CollectionViewFooterBugReproSample
{
    public partial class PageWithOneItemWithoutCollectionViewFooter : ContentPage
    {
        public PageWithOneItemWithoutCollectionViewFooter()
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
    }
}