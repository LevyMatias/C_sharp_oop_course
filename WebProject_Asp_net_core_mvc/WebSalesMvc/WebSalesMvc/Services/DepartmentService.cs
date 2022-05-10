using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMvc.Data;
using WebSalesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSalesMvc.Services
{
    public class DepartmentService
    {
        private readonly WebSalesMvcContext _context;

        public DepartmentService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
