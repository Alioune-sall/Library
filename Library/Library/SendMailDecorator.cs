using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class SendMailDecorator : BookBase
    {
        public DateTime ExpirationDate;

        public SendMailDecorator(Books book) : base()
        {
            ExpirationDate = new DateTime(2025, 01, 11);  //2024, 04, 01 | 2025, 01, 11
        }

        public string SendMail()
        {
            return "Dear user, you are receiving this email because the return of the book is delayed";
        }
    }
}
