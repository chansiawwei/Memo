using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using memo.Models;
using memo.Data;

namespace memo
{
    public static class AddMemo
    {
        
        
        public static void AddData(ApplicationDbContext context)
        {
            var data = new List<Memo>(); 

            Memo memo;
            Console.WriteLine("*******AddData!!!!");
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Adding data {0}",i);
                int start = 300;
                memo = new Memo
                {
                    OwnerId = "3df42071-7b2a-40a6-907f-30bff683e2d2",
                    Date = DateTime.Now.AddHours(i + 5),
                    Title = String.Format("Memo {0}", i + start),
                    Details = String.Format("Details {0}", i + start)
                };
                data.Add(memo);
            };

            context.AddRange(data);
            context.SaveChanges();

        }
      
    }
}
