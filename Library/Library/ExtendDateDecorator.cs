using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class ExtendDateDecorator : BookBase
    {
        public DateOnly ExpirationDate; 

        public ExtendDateDecorator(Books book) : base() 
        {
            ExpirationDate = new DateOnly(2025, 01, 11);  
        }

        public DateOnly ExtendDate()
        {
           return ExpirationDate.AddMonths(1);
        }
    }
}
