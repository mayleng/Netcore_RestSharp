using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;

namespace RestSharpClient.Pages
{
    public class PostPageModel : PageModel
    {
        public string PagesCont { get; private set; } = " ";
        public void OnGet()
        {
            string posturl = "http://localhost:9005/Home/Test";
               
            RestClient client = new RestClient(posturl);
            client.Timeout = 60000;
            RestRequest request = new RestRequest(Method.POST);
            string ss = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
            request.AddHeader("User-Agent", ss);
            request.AddParameter("name", "test_name");
            string result = client.Execute(request).Content;
            PagesCont =result;
          
        }
    }
}