namespace PageCounterApp.Services
{
    public interface IPageCounterService
    {
        int IncrementPageCount(string pageName);
    }
}