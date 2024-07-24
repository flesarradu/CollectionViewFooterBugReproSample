using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionViewFooterBugReproSample.ViewModels
{
    public partial class ItemsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ItemViewModel> _items;
    }
}
