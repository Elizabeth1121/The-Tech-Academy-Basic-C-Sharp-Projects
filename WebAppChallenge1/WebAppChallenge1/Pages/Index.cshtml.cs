using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppChallenge1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    // write a method to return SeverTime
    public string GetServerTime()
    {
        // create a varibale to store the current time
        var ServerTime = DateTime.Now;
        
        // return the current time
        return ServerTime.ToString();
    }
}
