using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Threading.Tasks;
using Learn_Academy.Utilities;

namespace Learn_Academy.Pages.Courses
{
    public class UploadModel : PageModel
    {
        private IHostingEnvironment _environment;
        public UploadModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        private readonly string[] _permittedExtensions = { ".txt" };

        [BindProperty]
        public IFormFile Upload { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string untrustedFileName = Path.GetFileName(Upload.FileName);
            var fornmfilecontent = await FileHelpers.ProcessFormFile<IFormFile>(Upload, ModelState, _permittedExtensions, 10000000);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var file = Path.Combine(_environment.ContentRootPath, "uploads", untrustedFileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
            return RedirectToPage("/Courses/My-Courses/Index");
        }
        public void OnGet()
        {

        }
    }
}