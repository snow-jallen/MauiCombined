namespace RazorClassLib;

public interface IDataService
{
    public Task<IEnumerable<string>> GetDataAsync();
}
