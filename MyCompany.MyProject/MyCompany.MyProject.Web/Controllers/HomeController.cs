using System.Diagnostics;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace MyCompany.MyProject.Web.Controllers;

#pragma warning disable CS1998 // Method lacks 'await' operators

public class HomeController : Controller
{
    /// <summary>
    /// Spa route for vue-based parts of the app
    /// </summary>
    // Prevent caching of this route.
    // The served file will contain the links to compiled js/css that include hashes in the filenames.
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public async Task<IActionResult> Index(
        [FromServices] IWebHostEnvironment hostingEnvironment
    )
    {
        var fileInfo = hostingEnvironment.WebRootFileProvider.GetFileInfo("index.html");
        if (!fileInfo.Exists) return NotFound($"{hostingEnvironment.WebRootPath}/index.html was not found");

        return File(fileInfo.CreateReadStream(), "text/html");

        // If desired, you can inject settings or other variables into index.html here.
        // These will then be available as global variables in your Vue app:
        /*
        using var reader = new StreamReader(fileInfo.CreateReadStream());
        string contents = await reader.ReadToEndAsync();

        contents = contents.Replace("<head>", $"""
            <head>
            <script>
                MY_GLOBAL_VARIABLE="{HttpUtility.JavaScriptStringEncode(myValue)}"
            </script>
            """);

        return Content(contents, "text/html");
        */
    }

    public IActionResult Error()
    {
        ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        return View();
    }
}
