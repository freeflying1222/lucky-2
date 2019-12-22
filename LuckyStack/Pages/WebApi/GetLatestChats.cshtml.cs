using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LuckyStack.Pages.WebApi
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class GetLatestChatsModel : PageModel
    {
        public JsonResult OnGet()
        {
            //return new JsonResult(new List<Chat>
            //{
            //    new Chat{ Id = 8, Content="", Created = DateTime.Now.AddMinutes(-2)},
            //    new Chat{ Id = 9, Content="", Created = DateTime.Now.AddMinutes(-48)},
            //    new Chat{ Id = 10, Content="", Created = DateTime.Now.AddSeconds(-76)},
            //});

            return new JsonResult(true);
        }


        //public void OnGet()
        //{
        //    throw new Exception("飞哥不帅了？");
        //    //return PartialViewResult();
        //}

        public void OnPost()
        {
            throw new Exception("飞哥不帅了？");
            //return PartialViewResult();
        }
    }

    public class Chat
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}