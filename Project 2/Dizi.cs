using System.Collections;

namespace Project2{

    class Dizi{
        public static void Run(){
            ArrayList array = new ArrayList {"Hikmet", 8, 54.5,"Ali",2,"Ahmet",1.5};
            
            Console.WriteLine($"Lenght: {array.Count}");            
            Console.WriteLine($"Capacity: {array.Capacity}");            
            Console.WriteLine(array[1]);
            Console.WriteLine("array elements (non-sort):");
            foreach(var i in array){
                Console.WriteLine(i);
            }   
            
            Console.WriteLine($"index of Hikmet: {array.IndexOf("Hikmet")}");
            array.Reverse();
            Console.WriteLine("array elements (Reverse):");
            foreach(var i in array){
                Console.WriteLine(i);
            }  

            Console.WriteLine("array elements (1,3):");
            foreach(var i in array.GetRange(0,3)){
                Console.WriteLine(i);
            }
        }
    }

}