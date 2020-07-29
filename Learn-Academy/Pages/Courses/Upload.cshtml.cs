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

        private readonly string[] _permittedExtensionsV = { ".mp4" };
        private readonly string[] _permittedExtensionsI = { ".jpeg", ".jpg", ".png" };

    [BindProperty]
        public IFormFile UploadV { get; set; }

        [BindProperty]
        public IFormFile UploadI { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string untrustedFileNameV = Path.GetFileName(UploadV.FileName);
            var fornmfilecontent = await FileHelpers.ProcessFormFile<IFormFile>(UploadV, ModelState, _permittedExtensionsV, 10000000);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var fileV = Path.Combine(_environment.ContentRootPath, "uploads", "videos", untrustedFileNameV);
            using (var fileStream = new FileStream(fileV, FileMode.Create))
            {
                await UploadV.CopyToAsync(fileStream);
            }

            string untrustedFileNameI = Path.GetFileName(UploadI.FileName);
            var fornmfilecontentI = await FileHelpers.ProcessFormFile<IFormFile>(UploadI, ModelState, _permittedExtensionsI, 10000000);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var fileI = Path.Combine(_environment.ContentRootPath, "uploads", "image", untrustedFileNameI);
            using (var fileStream = new FileStream(fileI, FileMode.Create))
            {
                await UploadI.CopyToAsync(fileStream);
            }

            return RedirectToPage("/Courses/My-Courses/Index");
        }
        public void OnGet()
        {

        }
    }
}