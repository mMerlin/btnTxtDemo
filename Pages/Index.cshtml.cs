using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buttonTextDemo.Pages
{
    public class IndexModel : PageModel
    {
        // Make some of the settings into constants here, instead of hard-coding
        // in the cshtml file.  Might want to localize it.
        public const int StartingRows = 5;
        public const int StartingCols = 40;
        public const string ButtonText = "Process";
        public const string LabelText = "Enter some text";
        public const string InputExplain = "enter some text to be manipulated here";
        public void OnGet()
        {

        }
    }
}
