

using System.Reflection;
using System.Runtime.CompilerServices;

enum ClassLevel{
    Freshman,
    Sophomore,
    Junior,
    Senior
}

struct Student{
    public string Name{get; set;}
    public int Age{get; set;}
    public ClassLevel ClassLevel{get; set;}
}

class Ogrenci{
    static void Main(){
        var student = new Student{
            Name = "Hikmet",
            Age = 19,
            ClassLevel = ClassLevel.Junior
        };

    }
    static void PrintStudentInfo(Student student){
        switch(student.ClassLevel){
            case ClassLevel.Freshman:
                Console.WriteLine("Freshman");
                break;
            case ClassLevel.Sophomore:
                Console.WriteLine("Sophomore");
                break;
            case ClassLevel.Junior:
                Console.WriteLine("Junior");
                break;
            case ClassLevel.Senior:
                Console.WriteLine("Senior");
                break;
        }
        
        if (student.Age < 18){
            Console.WriteLine("Reşit değil");
        }
        else{
            Console.WriteLine("Reşit");
        }
    }
}

