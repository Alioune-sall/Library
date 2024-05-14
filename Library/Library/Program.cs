namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var annaKarenina = new BookBase();
            annaKarenina.Borrow();
            annaKarenina.Borrow();
            annaKarenina.Borrow();
            annaKarenina.Borrow();
            annaKarenina.Borrow();
            Console.WriteLine(string.Empty);

            annaKarenina.GiveBack();
            Console.WriteLine(string.Empty);

            var book2 = new ExtendDateDecorator(annaKarenina);
            Console.WriteLine("Your book's deadline has been successfully extended to "+ book2.ExtendDate());
            Console.WriteLine(string.Empty);

            var book3 = new SendMailDecorator(annaKarenina);
            if (DateTime.Now > book3.ExpirationDate)
                Console.WriteLine (book3.SendMail());
            
        }
    }
}
