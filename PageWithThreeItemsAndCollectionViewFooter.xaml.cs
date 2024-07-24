using CollectionViewFooterBugReproSample.ViewModels;
using System.Collections.ObjectModel;

namespace CollectionViewFooterBugReproSample
{
    public partial class PageWithThreeItemsAndCollectionViewFooter : ContentPage
    {
        public PageWithThreeItemsAndCollectionViewFooter()
        {
            InitializeComponent();

            ItemsViewModel itemsViewModel = new ItemsViewModel
            {
                Items = new ObservableCollection<ItemViewModel> {
                    new ItemViewModel {
                        Description = "Item 1",
                        ImageUrl = "dotnet_bot.png"
                    },
                    new ItemViewModel {
                        Description = "Item 2",
                        ImageUrl = "dotnet_bot.png"
                    },
                    new ItemViewModel {
                        Description = "Item 3",
                        ImageUrl = "dotnet_bot.png"
                    },
                },
            };

            BindingContext = itemsViewModel;
        }
    }
}