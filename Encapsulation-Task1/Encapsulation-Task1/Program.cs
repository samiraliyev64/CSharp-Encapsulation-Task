using System;

namespace Encapsulation_Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student telebe1 = new Student();
            telebe1.Ad = "Samir";
            telebe1.Soyad = "Aliyev";
            telebe1.ID = 424;
            telebe1.Ixtisas = "Komputer Elmleri";

            Student telebe2 = new Student();
            telebe2.Ad = "Ferrux";
            telebe2.Soyad = "Aliyev";
            telebe2.ID = 344;
            telebe2.Ixtisas = "Komputer Elmler";

            Student telebe3 = new Student();
            telebe3.Ad = "Mehemmed";
            telebe3.Soyad = "Ceferzade";
            telebe3.ID = 666;
            telebe3.Ixtisas = "Informatika muellimliyi";

            Group group = new Group();
            group.Ad = "BP201";
            group.maxStuCount = 16;
  
            group.addStudent(telebe1);
            group.addStudent(telebe2);
            group.addStudent(telebe3);
            
            Console.WriteLine(group.students[0].Ad);
            Console.WriteLine(group.students[1].Ad);
            Console.WriteLine(group.students[2].Ixtisas);
            Console.WriteLine(group.students[2].Ad);

            //group.removeStudent(666); //Remove methodunda exception verir :/




        }
    }
}
