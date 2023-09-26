using System.ComponentModel;

namespace DependencyInjection.Client.ViewModels.BaseClass
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
    }
}
