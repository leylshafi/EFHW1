using EFHW1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHW1.Models;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short Grade { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public double Score { get; set; }

    public List<Book> Books { get; set; }
}