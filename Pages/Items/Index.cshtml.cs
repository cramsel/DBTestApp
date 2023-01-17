using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBTestAppRound2.Data;
using DBTestAppRound2.Models;

namespace DBTestAppRound2.Items
{
    public class IndexModel : PageModel
    {
        private readonly DBTestAppRound2.Data.DBTestAppRound2Context _context;

        public IndexModel(DBTestAppRound2.Data.DBTestAppRound2Context context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Items != null)
            {
                Item = await _context.Items.ToListAsync();
            }
        }
    }
}
