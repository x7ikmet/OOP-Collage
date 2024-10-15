namespace OOP.Hafta3
{
    
    public class Main(){

        public void carp(){
            for(int j=1; j <=10; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{j}X{i} = {(i*j).ToString().PadLeft(2,'0')}     ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n");
            for(int j=1; j <=10; j++)
            {
                for (int i = 6; i <= 10; i++)
                {
                    Console.Write($"{j}X{i} = {i*j}   ");
                }
                Console.Write("\n");
            }
        }
        
        public void While(){
            int i = 0;
            while(i<5){
                Console.WriteLine(i);
                i++;
            }
        }

        public void doWhile(){

            int i = 0;
            do{
                Console.WriteLine(i);
                i++;
            }while(i<5);
        }

        public void top(){
            Console.Write("Enter Num: ");
            string? n =  Console.ReadLine();
            int t = 0;
            int i=0;
            
            while(i < n?.Length){

                t += Convert.ToInt32( Convert.ToString( n[i]));
                 
                i++;
            }
            Console.WriteLine(t);
        }   

        public void dizi(){
            int [][] dizi = {
                new int[] {1},
                new int[] {1,2,3},
                new int[] {1,2},
            };

            foreach(var i in dizi){
                foreach(var j in i){
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }

    }
}