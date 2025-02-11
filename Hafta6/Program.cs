namespace Hafta6{

    class Extantion{
        public static string ToUpper(this string str){
            return str.ToUpper();
        }
    }

    public class Program{

        public static IEnumerable<T> fun<T>(T[] arr){
            foreach(var item in arr){
                yield return item;
            }
        }


        static void Main(string[] args){


            int[] arr = new int[]{1,2,3,4,5,6,7,8,9,10};
            IEnumerable<int> result = fun(arr);
            
            foreach(var item in result){
                Console.WriteLine(item);
            }

            return ;
            string[] diller = {"C#", "Java", "Python", "JavaScript", "Ruby", "PHP"};
            string[] diller1 = {"C#", "Java", "Python", "JavaScript", "Ruby", "PHP"};
            string dil1 = StringYaz1(3, diller1);
            ref string dil = ref StringYaz(3, diller);

            dil = "Go";
            dil1 = "Go";
            Console.WriteLine(diller[3]); 
            Console.WriteLine(diller1[3]); 
            
        }
        public static string StringYaz1(int index, string[] diller){
            foreach(var deger in diller){
                if (diller[index] == deger){
                    return diller[index];
                }
            }
            throw new Exception("Dil bulunamadı");
        }

        public static ref string StringYaz(int index, string[] diller){
            foreach(var deger in diller){
                if (diller[index] == deger){
                    return ref diller[index];
                }
            }
            throw new Exception("Dil bulunamadı");
        }
    }
}