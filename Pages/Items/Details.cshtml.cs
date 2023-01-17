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
    public class DetailsModel : PageModel
    {
        private readonly DBTestAppRound2.Data.DBTestAppRound2Context _context;

        public DetailsModel(DBTestAppRound2.Data.DBTestAppRound2Context context)
        {
            _context = context;
        }

      public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            else 
            {
                Item = item;
            }
            return Page();
        }
    }
}
