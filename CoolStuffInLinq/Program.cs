using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolStuffInLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Mauro", "G",1, 191, 34,Gender.Male),
                new Person("Kenan", "Kurda",2, 183, 54,Gender.Male),
                new Person("Eva", "Velickova",3, 191, 24,Gender.Female),
                new Person("Saif", "pAl Adilee", 191,4, 64,Gender.Male),
                new Person("Toon", "Penen",5, 191, 22,Gender.Male),
                new Person("Sadki", "Khadija",6, 161, 27,Gender.Female)
            };

            #region Number of elements in the list
            //int count = people.Count();
            //Console.WriteLine("total people " + count);
            #endregion

            #region Sum by Age
            //int age= people.Sum(p => p.Age);
            // Console.WriteLine(age);
            #endregion

            #region Average
            //int avarageAge = people.Sum(p => p.Age) / people.Count();
            //Console.WriteLine(avarageAge);
            #endregion

            #region OrderBy people's collection
            //var peopleYoungerThen55 = people.Where(p => p.Age < 55).OrderBy(p => p.Age);

            //var sorterdAged = people.OrderBy(p => p.Age);

            //foreach (var item in sorterdAged)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.Age);
            //}
            //Console.WriteLine();
            //foreach (var item in peopleYoungerThen55)
            //{
            //    Console.WriteLine(item.FirstName + " " +item.Age);

            //}
            #endregion

            #region Show people that start whit letter...
            //Console.WriteLine();
            //Console.WriteLine("Sort by people start with letter");
            //var peopleWithStartWithLetterP = people.Where(p => p.LastName.ToUpper().StartsWith("P"));
            //foreach (var item in peopleWithStartWithLetterP)
            //{
            //    Console.WriteLine(item.LastName);
            //}
            #endregion

            #region Contains letter
            //var peopleWithLetterOInName = people.Where(p => p.LastName.ToUpper().Contains("O"));
            //foreach (var item in peopleWithLetterOInName)
            //{
            //    Console.WriteLine(item.LastName);
            //}
            #endregion
            Console.WriteLine();

            #region Minimum age / max age
            //int minAge = people.Min(p => p.Age);
            //Console.WriteLine(minAge); 
            //int MaxAge = people.Max(p => p.Age);
            //Console.WriteLine(MaxAge);
            #endregion
        }
        static void Show(List<Person> item)
        {
            Console.WriteLine($"  {item.LastName} {item.Age}{item.Height} {item.Gender}");
        }

    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int id, int height, int age, Gender gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Height = height;
            Age = age;
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
