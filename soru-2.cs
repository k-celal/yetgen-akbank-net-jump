using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public decimal Balance { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 - Ogrenci Ekle");
            Console.WriteLine("2 - Bakiye Ekle");
            Console.WriteLine("3 - Bakiye Cikar");
			Console.WriteLine("4 - Ogrenci bilgisi goster");
            Console.WriteLine("5 - Ogrenciler ve bilgileri goster");
            Console.WriteLine("6 - Cikis");
            Console.Write("Seciminizi yapiniz: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    UpdateBalance(true);
                    break;
                case 3:
                    UpdateBalance(false);
                    break;
				case 4:
                    ;
                    break;
                case 5:
                    ShowStudents();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Gecersiz secim. Tekrar deneyin.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("ogrenci adi: ");
        string name = Console.ReadLine();

        Student student = new Student
        {
            Name = name,
            Balance = 0
        };

        students.Add(student);
        Console.WriteLine($"{name} ogrencisi basariyla eklendi.");
    }

    static void UpdateBalance(bool isAdding)
    {
        Console.Write("ogrenci adi: ");
        string name = Console.ReadLine();

        Student student = students.Find(s => s.Name == name);

        if (student != null)
        {
            Console.Write("Miktar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (isAdding)
            {
                student.Balance += amount;
                Console.WriteLine($"{name} ogrencisinin bakiyesi {amount} TL artirildi.");
            }
            else
            {
                if (student.Balance >= amount)
                {
                    student.Balance -= amount;
                    Console.WriteLine($"{name} ogrencisinin bakiyesinden {amount} TL cikarildi.");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                }
            }
        }
        else
        {
            Console.WriteLine($"{name} ogrencisi bulunamadi.");
        }
    }
	static void ShowStudentBalance()
    {
        Console.Write("ogrenci adi: ");
        string name = Console.ReadLine();

        Student student = students.Find(s => s.Name == name);

        if (student != null)
        {
            Console.WriteLine($"{student.Name} - Bakiye: {student.Balance} TL");
        }
        else
        {
            Console.WriteLine($"{name} ogrencisi bulunamadi.");
        }
    }
	static void ShowStudents()
    {
        Console.WriteLine("ogrenci Bilgileri ve Bakiyeleri:");
        foreach (var student in students)
        {
            Console.WriteLine($"ogrenci Adi: {student.Name}, Bakiye: {student.Balance} TL\n");
        }
    }
}

