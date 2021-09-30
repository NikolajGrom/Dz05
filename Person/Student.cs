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
    //метод возвращать Получить оценку
        public void GetMark()
        {
             for (int i = 0; i < ArrMark.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < ArrMark[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", ArrMark[i][j], j == (ArrMark[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }
    //метод
        public void Print()
        {
            Console.WriteLine( $"Студент Имя: {FirstName }" +
                $"\nФамилия:{ LastName}" +
                $"\nОтчество:{MiddlName}" +
                $"\nГруппа:{Group}" +
                $"\nВозраст:{adg}" +
                $"\nОценки: {ArrMark}"
            );
        }
        //метод
        public void ShowName()
        {
            Console.WriteLine(FirstName);
        }
    
        
    }
    

    
}
