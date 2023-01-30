﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHW1.Models;
public class Author : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public List<Book> Books { get; set; }
}
