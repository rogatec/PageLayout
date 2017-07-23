using PageLayoutService.Models;
using PageLayoutService.ViewModels.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace PageLayoutService.ViewModels {
    public class MainViewModel : IMainViewModel, INotifyPropertyChanged {
        #region "Properties"

        private readonly IPageLayoutHandler _pageLayoutHandler;

        private string _input;

        public string Input {
            get => _input;
            set {
                _input = value;
                RaisePropertyChanged("Input");
            }
        }

        private int _maxLineLength;

        public int MaxLineLength {
            get => _maxLineLength;
            set {
                _maxLineLength = value;
                RaisePropertyChanged("MaxLineLength");
            }
        }

        public string ResultText => _pageLayoutHandler.ResultText;

        private ICommand _transform;

        public ICommand Transform => _transform ??
                                     (_transform = new TransformCommand<IPageLayoutHandler>(TransformExecute));

        #endregion "Properties"

        #region "Methods"

        public MainViewModel() {
            _pageLayoutHandler = new PageLayoutHandler();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private void TransformExecute(object parameter) {
            _pageLayoutHandler.Umbrechen(Input, MaxLineLength);
            RaisePropertyChanged("ResultText");
        }

        #endregion "Methods"
    }
}