using System.Collections.Generic;
using NUnit.Framework;
using PageLayoutService.ViewModels;

namespace PageLayoutServiceTests.ViewModels {
    [TestFixture]
    public class MainViewModelTests {
        private MainViewModel _viewModel;
        private List<string> _propertiesChanged;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
            _viewModel = new MainViewModel();

            _propertiesChanged = new List<string>();
            _viewModel.PropertyChanged += (sender, e) => _propertiesChanged.Add(e.PropertyName);
        }

        [Test]
        public void InputProperty_HasChanged_NewInputValue() {
            _viewModel.Input = "Test";

            Assert.Contains("Input", _propertiesChanged);
            Assert.That(_viewModel.Input, Is.EqualTo("Test"));
        }

        [Test]
        public void MaxLineLenghProperty_HasChanged_NewMaxLineValue() {
            _viewModel.MaxLineLength = 1;

            Assert.Contains("MaxLineLength", _propertiesChanged);
            Assert.That(_viewModel.MaxLineLength, Is.EqualTo(1));
        }

        // TODO: ResultText testing??
    }
}