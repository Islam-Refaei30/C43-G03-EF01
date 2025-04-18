using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
        // poco class
        // POCO: Plain Old CLR Object

        // EF core Suport 4 ways for mapping class to table => (Table, view, function, sp)
        // 1. By convention (Default Behaviour) بالاتفاق
        // 2. Data Annotations (Attributes) (Data Annotations)
        // 3. Fluent API (Fluent API)
        // 4. Data Seeding (Data Seeding)

    internal class Empolyee
    {
        public int ID { get; set; } // public numeric named as ID or EmployeeID => [PK] by convention (1,1)
        public string EmpName { get; set; } // referance type : doesn't Allow Null [nvarchar(MAX)]
        public double Salary { get; set; } // Value Type : not Null [required]
        public int? Age { get; set; } // Nullable<int> : Allow null [Optional]
        public string? Address { get; set; } // Nullable<int> : Allow null [Optional]
    }
}
