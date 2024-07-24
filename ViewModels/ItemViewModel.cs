using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewFooterBugReproSample.ViewModels
{
    public partial class ItemViewModel : ObservableObject
    {
        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the imageUrl.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
