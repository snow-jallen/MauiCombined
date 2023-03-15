using RazorClassLib;

namespace MauiRegular;

public partial class MauiRegularDataService : IDataService
{
    public Task<IEnumerable<string>> GetDataAsync()
    {
        return Task.FromResult<IEnumerable<string>>(new[] { "This is on windows" });
    }
}
