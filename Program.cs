using System;
using System.Collections.Generic;

namespace chk
{
    class Program
    {
        public int getAge(int year)
        {
            int age = DateTime.Now.Year - year;
            return age;
        }
        static void Main(string[] args)
        {
            List<intern> internList = new List<intern>();

            intern kyNguyen = new intern("Ky", "Nguyen Khac", "Male", new DateTime(1999, 11, 12), "0222.222.222", "Ha Noi", 18, false);
            intern trangHuyen = new intern("Trang", "Nguyen Huyen", "Female", new DateTime(2002, 05, 21), "0222.222.222", "Hai Phong", 18, false);
            intern tuanDat = new intern("Tuan", "Trinh Dat", "Male", new DateTime(1994, 01, 15), "0222.222.222", "Bac Ninh", 18, false);
            intern congVan = new intern("Cong", "Nguyen Van", "Male", new DateTime(1996, 08, 12), "0222.222.222", "Ha Noi", 18, false);
            intern nhatHoang = new intern("Phuoc", "Hoang Nhat", "Male", new DateTime(1998, 06, 18), "0222.222.222", "Bac Ninh", 18, false);
            intern baoLong = new intern("Long", "Thang Bao", "Male", new DateTime(2000, 07, 12), "0222.222.222", "Binh Duong", 18, false);

            internList.Add(kyNguyen);
            internList.Add(trangHuyen);
            internList.Add(tuanDat);
            internList.Add(congVan);
            internList.Add(nhatHoang);
            internList.Add(baoLong);

            //1. Return a list of members who is Male
            Console.WriteLine("1.List of members who is Male: ");
            foreach (intern i in internList)
            {
                if (i.gender == "Male")
                {
                    Console.WriteLine(i.fName + " " + i.lName + "(" + i.age + ")");
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            //2. Return the oldest intern.
            int oldest = internList[0].age;
            for (int i = 1; i < internList.Count; i++)
            {
                if (oldest < internList[i].age)
                {
                    oldest = internList[i].age;
                }
            }

            for (int i = 0; i < internList.Count; i++)
            {
                if (internList[i].age == oldest)
                {
                    Console.WriteLine("2.The oldest intern (the frist record) is: " + internList[i].fName + " " +
                    internList[i].lName + " (" + internList[i].age + ") years old.");
                    break;
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");

            //3. Return a new list that contains FullName only.
            List<string> nameList = new List<string>();
            foreach (intern i in internList)
            {
                nameList.Add(i.fullName());
            }
            Console.WriteLine("3.List of name: ");
            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }
            Console.WriteLine("---------------------------------------------------------------------");

            //4. Return 3 lists birth year (== 2000) (> 2000) (<2000)
            List<intern> l1 = new List<intern>();
            List<intern> l2 = new List<intern>();
            List<intern> l3 = new List<intern>();

            for (int i = 0; i < internList.Count; i++)
            {
                switch (internList[i].dateOfBirth.Year)
                {
                    case 2000:
                        l1.Add(internList[i]);
                        break;
                    default:
                        if ((internList[i].dateOfBirth.Year - 2000) > 0)
                        {
                            l2.Add(internList[i]);
                        }
                        else
                        {
                            l3.Add(internList[i]);
                        }
                        break;
                }
            }
            Console.WriteLine("4.");
            Console.Write("Members who has birth year is 2000: ");
            foreach (intern i in l1)
            {

                Console.Write(i.lName + " " + i.fName);

            }
            Console.WriteLine();
            Console.Write("Members who has birth year greater than 2000: ");
            foreach (intern i in l2)
            {

                Console.Write(i.lName + " " + i.fName + ",");
            }
            Console.WriteLine();
            Console.Write("Members who has birth year lesser than 2000: ");
            foreach (intern i in l3)
            {

                Console.Write(i.lName + " " + i.fName + ",");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");

            //5.Return the first person who was born in Ha Noi.
            int index = 0;
            while (true)
            {
                if (index == (internList.Count + 1))
                {
                    break;
                }
                if (internList[index].birthPlace == "Ha Noi")
                {
                    Console.WriteLine("5.The frist one born in Ha Noi is: " + internList[index].lName + " " + internList[index].fName);
                    break;
                }
                index++;
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
