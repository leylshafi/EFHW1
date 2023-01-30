using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHW1.Models;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public int PageCount { get; set; }
    public int BookTypeId { get; set; }
    public int? StudentId { get; set; }


    public Student Student { get; set; }
    public List<Author> Authors { get; set; }
    public BookType Type { get; set; }
}
