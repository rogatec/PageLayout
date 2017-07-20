using System.Windows.Input;

namespace PageLayoutService.ViewModels
{
    public interface IMainViewModel
    {
        string Input { get; set; }

        int MaxLineLength { get; set; }

        ICommand Transform { get; }
    }
}
