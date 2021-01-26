namespace BlazorUI.Data
{
    public interface ICounterService
    {
        int CounterValue { get; }

        void IncreamentCounter();
    }
}