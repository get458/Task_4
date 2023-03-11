using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public static bool CountBiggest(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else if (b > a)
            {
                return false;
            }

            return false;
        }

        public static float ReturnMetr(int a)
        {
            float res = (a % 100);
            return res;
        }

        public static bool IsDateValid(int year, int month, int day) 
        {
            return day <= DateTime.DaysInMonth(year, month);
        }

        public static bool Reg(string login, string password, string mail, DateOnly birthday)
        {
            using (Gr601BokvaContext db = new Gr601BokvaContext())
            {
                Usertable usertable = new Usertable()
                {
                    Login = login,
                    Password = password,
                    Mail = mail,
                    Birthday = birthday
                };
                db.Usertables.Add(usertable);
                db.SaveChanges();
            }

            return true;
        }

        public static bool Auth(string login, string password)
        {
            using (Gr601BokvaContext db = new Gr601BokvaContext())
            {
                var user = db.Usertables.Where(u => u.Login == login).Where(u => u.Password == password).Select(u => new
                {
                    Id = u.Id,
                    Login = u.Login,
                    Mail = u.Mail,
                    Birthday = u.Birthday
                }).ToList();

                if (user.Count == 1)
                {
                    return true;
                }
            }

            return false;
        }

    }
}