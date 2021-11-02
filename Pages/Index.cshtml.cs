using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestJenkinsApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        RulesApp objru = new RulesApp();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            int a = objru.Addlogic(5, 5);
        }

        public void OnGet()
        {

        }
    }
}
