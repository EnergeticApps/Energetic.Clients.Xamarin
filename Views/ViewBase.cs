using Energetic.Clients.ViewModels;
using System;
using Xamarin.Forms;

namespace Energetic.Clients.Xamarin.Views
{
    public abstract class ViewBase<TViewModel> : ContentPage
        where TViewModel : ViewModelBase
    {
        public ViewBase(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        protected TViewModel ViewModel { get; }
    }
}
