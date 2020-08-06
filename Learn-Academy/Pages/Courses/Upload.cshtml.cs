using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Learn_Academy.Utilities;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Learn_Academy.Pages.Courses
{
    [Authorize(Roles = "Admin, Course-Admin, Teacher")]
    public class UploadModel : PageModel
    {
        private IHostingEnvironment _environment;
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;
        public UploadModel(IHostingEnvironment environment, Learn_Academy.Models.Learn_AcademyContext context)
        {
            _environment = environment;
            _context = context;
        }

        private readonly string[] _permittedExtensionsV = { ".mp4" };
        private readonly string[] _permittedExtensionsI = { ".jpeg", ".jpg", ".png" };

        [BindProperty]
        public IFormFile UploadV { get; set; }

        [BindProperty]
        public IFormFile UploadI { get; set; }

        [BindProperty]
        public int id { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string untrustedFileNameV = Path.GetFileName(UploadV.FileName);
            var fornmfilecontent = await FileHelpers.ProcessFormFile<IFormFile>(UploadV, ModelState, _permittedExtensionsV, 10000000);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var fileV = Path.Combine(_environment.WebRootPath, "uploads", "videos", untrustedFileNameV);
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
            var fileI = Path.Combine(_environment.WebRootPath, "uploads", "image", untrustedFileNameI);
            using (var fileStream = new FileStream(fileI, FileMode.Create))
            {
                await UploadI.CopyToAsync(fileStream);
            }

            var chosen_course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);
            chosen_course.image = untrustedFileNameI;
            chosen_course.video = untrustedFileNameV;
            await _context.SaveChangesAsync();
            return RedirectToPage("/Courses/My-Courses/Index");
        }
        public void OnGet()
        {
            var list = new List<Course>();
            foreach(var i in _context.Course)
            {
                list.Add(new Course() { ID = i.ID, Author = i.Author, Category = i.Category, CourseDate = i.CourseDate, Description = i.Description, Name = i.Name });
            }
            ViewData["Course"] = list; 
        }
    }
}