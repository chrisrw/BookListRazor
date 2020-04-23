using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        // automatically add id as an identity column. creates value automatically   
        [Key]
        public int Id { get; set; }
        // make a name required
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
