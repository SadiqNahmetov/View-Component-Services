using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
         public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();

            return await Task.FromResult(View(await GetAllBlogs()));
        }

        private async Task<IEnumerable<Blog>> GetAllBlogs()
        {
            return await _context.Blogs.ToListAsync();
        }
    }
}
