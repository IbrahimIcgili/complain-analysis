using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainAnalysis
{
    class Service
    {
        private readonly Context _context;
        public Service()
        {
            _context = new Context();
        }
    }
}