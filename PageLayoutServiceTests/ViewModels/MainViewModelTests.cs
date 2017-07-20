using NUnit.Framework;
using System.Collections.Generic;

namespace PageLayoutService.ViewModels.Tests
{
    [TestFixture()]
    public class MainViewModelTests
    {
        private MainViewModel viewModel;
        private List<string> PropertiesChanged;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            viewModel = new MainViewModel();

            PropertiesChanged = new List<string>();
            viewModel.PropertyChanged += (sender, e) => PropertiesChanged.Add(e.PropertyName);
        }

        [Test()]
        public void InputProperty_HasChanged_NewInputValue()
        {
            viewModel.Input = "Test";

            Assert.Contains("Input", PropertiesChanged);
            Assert.AreEqual("Test", viewModel.Input);
        }

        [Test]
        public void MaxLineLenghProperty_HasChanged_NewMaxLineValue()
        {
            viewModel.MaxLineLength = 1;

            Assert.Contains("MaxLineLength", PropertiesChanged);
            Assert.AreEqual(1, viewModel.MaxLineLength);
        }

        // TODO: ResultText testing??
    }
}