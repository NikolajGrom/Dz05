using System;

namespace Dz05
{
    public class Student
    {
        public string FirstName { get; set; }   //имя
        public string LastName { get; set; }    //фамилия
        public string MiddlName { get; set; }   //отчество
        string Group { get; set; }              //группа
        int adg { get; set; }                   //возраст
        int[][] ArrMark { get; set; }           //массив (зубчатый) оценок 

        public Student() 
        { 
        }
        public Student(string FirstName, string LastName, string MiddlName, string Group, int adg, int[][] ArrMark)

    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.MiddlName = MiddlName;
        this.Group = Group;
        this.adg = adg;
        this.ArrMark = ArrMark;
    }

    //метод
        public void Print()
        {
            Console.WriteLine( $"Студент Имя: {FirstName }" +
                $"\nФамилия:{ LastName}" +
                $"\nОтчество:{MiddlName}" +
                $"\nГруппа:{Group}" +
                $"\nВозраст{adg}" +
                $"\nОценки{ArrMark}\n"
            );
        }
        //метод
        public void ShowName()
        {
            Console.WriteLine(FirstName);
        }
    
        //метод возвращать Получить оценку
        public int GetMark()
        {
            return new Random().Next(1, 12);
        }
    }
    

    
}
