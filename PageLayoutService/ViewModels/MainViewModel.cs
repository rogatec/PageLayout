using PageLayoutService.Models;
using PageLayoutService.ViewModels.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace PageLayoutService.ViewModels
{
    public class MainViewModel : IMainViewModel, INotifyPropertyChanged
    {
        #region "Properties"

        private IPageLayoutHandler pageLayoutHandler;

        private string _Input;

        public string Input
        {
            get { return _Input; }
            set
            {
                _Input = value;
                RaisePropertyChanged("Input");
            }
        }

        private int _MaxLineLength;

        public int MaxLineLength
        {
            get { return _MaxLineLength; }
            set
            {
                _MaxLineLength = value;
                RaisePropertyChanged("MaxLineLength");
            }
        }

        public string ResultText { get { return pageLayoutHandler.ResultText; } }

        private ICommand _Transform;
        public ICommand Transform
        {
            get
            {
                if (_Transform == null)
                {
                    _Transform = new TransformCommand<IPageLayoutHandler>(TransformExecute);
                }

                return _Transform;
            }
        }

        #endregion "Properties"

        #region "Methods"

        public MainViewModel()
        {
            pageLayoutHandler = new PageLayoutHandler();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public IPageLayoutHandler GetPageLayoutHandler()
        {
            return pageLayoutHandler;
        }

        private void TransformExecute(object parameter)
        {
            pageLayoutHandler.Umbrechen(Input, MaxLineLength);
            RaisePropertyChanged("ResultText");
        }

        #endregion "Methods"
    }
}