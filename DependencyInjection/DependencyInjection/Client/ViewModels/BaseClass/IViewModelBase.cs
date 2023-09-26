using System.ComponentModel;

namespace DependencyInjection.Client.ViewModels.BaseClass
{
    public interface IViewModelBase
    {
        public bool IsBusy { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
