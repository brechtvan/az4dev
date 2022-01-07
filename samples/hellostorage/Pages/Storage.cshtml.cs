using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az4dev.Pages;
public class StorageModel : PageModel
{
    private readonly ILogger<StorageModel> _logger;

    public StorageModel(ILogger<StorageModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
