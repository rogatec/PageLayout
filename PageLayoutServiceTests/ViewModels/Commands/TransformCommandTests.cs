using NUnit.Framework;
using PageLayoutService.ViewModels;

namespace PageLayoutServiceTests.ViewModels.Commands {
    [TestFixture()]
    public class TransformCommandTests {
        private MainViewModel _viewModel;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
            _viewModel = new MainViewModel();
        }

        [Test()]
        public void Execute() {
            _viewModel.Transform.Execute(null);
        }

        [Test()]
        public void CanExecute() {
            Assert.That(_viewModel.Transform.CanExecute(null), Is.EqualTo(true));
        }
    }
}