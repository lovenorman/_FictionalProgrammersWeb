using FictionalProgrammers.DataAccess;
using FictionalProgrammers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _FictionalProgrammers.Pages.Programmers
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public IEnumerable<Programmer> Programmers { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;   
        }

        public void OnGet()
        {
            Programmers = _db.Programmer;
        }

        //public class IndexModel : PageModel
        //{
        //    public readonly ApplicationDbContext _db;

        //    public IEnumerable<Project> Projects { get; set; }

        //    public IndexModel(ApplicationDbContext db)
        //    {
        //        _db = db;
        //    }
        //    public void OnGet()
        //    {
        //        Projects = _db.Project;
        //    }
        //}
    }
}
