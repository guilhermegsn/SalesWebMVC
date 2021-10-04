using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //se existe algum registro na tabela seller/Department... 
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; //Banco já populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(1, "Fashion");
            Department d4 = new Department(2, "Books");

           // Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21),1000.0, d1);



        }


    }
}
