using System;
using System.Collections.Generic;

namespace WebAPI.BookStore.Models
{
    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsValuable { get; set; }
        public string CreatedOn { get; set; }
        public List<string> AdditionalValues { get; set; }
    }
}
