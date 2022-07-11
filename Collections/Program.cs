using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<>
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(10);
            //nums.Add(20);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if(nums.Count == 3)
            //{
            //    Console.WriteLine("List count is {0}, add number {1}", nums.Count, 15);
            //}

            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "Sadiq";
            //person1.Id = 5;
            //person1.Email = "sadiq@gmail.com";

            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "Seadet",
            //    Email = "seadet@gamil.com"
            //};

            //people.Add(person1);

            //people.Add(person2);

            //people.Add(new Person { Id = 1, Name = "Orxan", Email = "orxan@gmail.com" });
            //people.Add(new Person { Id = 4, Name = "Orxan", Email = "orxan1@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Cavidan", Email = "cavidan@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Nermin", Email = "nermin@gmail.com" });

            //GetStudents(people);

            //GetNumbers(numbers);

            //var result = GetPeopleByName(people, "Orxan");

            //Console.WriteLine(result.Name + "-" + result.Id + "-" + result.Email);

            //var result = GetPeopleByName(people, "Orxan");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + "-" + item.Id + "-" + item.Email);
            //}
            #endregion

            #region Hashtable
            //Hashtable datas = new Hashtable();

            //datas.Add(1, "Togrul");
            //datas.Add(2, "Fidan");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            #endregion

            #region SortedList
            //SortedList datas = new SortedList();

            //datas.Add(2, "Emil");
            //datas.Add(3, "Orxan");
            //datas.Add(1, "Seadet");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            #endregion

            #region SortedList<>
            //SortedList<int, string> datas = new SortedList<int, string>();

            //datas.Add(6, "Azer");
            //datas.Add(4, "Huseyn");

            //foreach (KeyValuePair<int, string> item in datas) 
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            #endregion

            #region ArrayList
            //ArrayList datas = new ArrayList();

            //datas.Add("Salam");
            //datas.Add(5);
            //datas.Add(true);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Hashset<>
            //HashSet<int> datas = new HashSet<int>();

            //datas.Add(1);
            //datas.Add(3);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack<>
            //Stack<int> datas = new Stack<int>();

            //datas.Push(1);
            //datas.Push(22);
            //datas.Push(18);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Queue<>
            //Queue<int> datas = new Queue<int>();

            //datas.Enqueue(1);
            //datas.Enqueue(22);
            //datas.Enqueue(18);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary<>
            //Dictionary<string, string> datas = new Dictionary<string, string>();

            //datas.Add("Admin", "Orxan");
            //datas.Add("Member", "Mirsamir");
            //datas.Add("Superadmin", "Cavid");
            //datas.Add("Test", "Cavid");

            //foreach (KeyValuePair<string, string> item in datas)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine($"Name : {item.Value}, Role : {item.Key}");
            //        break;
            //    }
            //}
            #endregion
        }

        #region List<>
        //public static Person GetPersonByName(List<Person> people, string name)
        //{
        //    var person = people.Find(m => m.Name == name);

        //    return person;
        //}

        //public static List<Person> GetPeopleByName(List<Person> people, string name)
        //{
        //    var persons = people.FindAll(m => m.Name == name);

        //    return persons;
        //}

        //public static void GetStudents(List<Person> students)
        //{
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine("Students : Id - {0}, Name - {1}, Email - {2} ", item.Id, item.Name, item.Email);
        //    }
        //}

        //public static void GetNumbers(List<int> numbers)
        //{
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion
    }

    #region List<>
    //public class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //}
    #endregion
}
