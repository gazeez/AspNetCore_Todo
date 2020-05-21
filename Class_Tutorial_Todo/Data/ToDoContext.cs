using Class_Tutorial_Todo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Class_Tutorial_Todo.Data
{
    public class ToDoContext: DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options) : base( options )
        {

        }
        public DbSet<Class_Tutorial_Todo.Models.ToDoItem> ToDoItem { get; set; }
    }
}
