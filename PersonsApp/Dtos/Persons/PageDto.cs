using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsApp.Dtos.Persons
{
    public class PageDto<T>
    {
        public int CurrentPage { get; set; }
        public bool HasnextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public int pageSize {get; set;}
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public T Items {get;set;}
    }
}