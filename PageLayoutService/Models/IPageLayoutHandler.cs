namespace PageLayoutService.Models {
    public interface IPageLayoutHandler {
        string ResultText { get; }
        void Umbrechen(string text, int maxZeichenLaenge);
    }
}