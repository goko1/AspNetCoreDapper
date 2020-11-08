using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public virtual Author  Author { get; set; }
    }
}
