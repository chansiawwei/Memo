using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace memo.Models
{
    public class Memo
    {
        public int MemoId { get; set; }
        public string OwnerId { get; set; }

        public string  Message { get; set; }
    }
}
