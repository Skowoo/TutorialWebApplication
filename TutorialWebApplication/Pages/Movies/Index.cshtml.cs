using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TutorialWebApplication.Data;
using TutorialWebApplication.Models;

namespace TutorialWebApplication.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TutorialWebApplication.Data.TutorialWebApplicationContext _context;

        public IndexModel(TutorialWebApplication.Data.TutorialWebApplicationContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
