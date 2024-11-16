namespace Project2{

    class Students{
        public static void Run(){
            Dictionary<string,List<int>> students = new Dictionary<string,List<int>>{
                {"Ahmet",new List<int>{80,54,60,89,90}},
                {"Hikmet",new List<int>{80,64,80,98,100}},
                {"Ali",new List<int>{50,10,0,60,55}},
                {"Osama",new List<int>{50,30,55,80,45}},
                {"Mohamed",new List<int>{82,74,94,80,75}},
            };

            Dictionary<string,double> gecen = new Dictionary<string, double>();
            Dictionary<string,double> kalan = new Dictionary<string, double>();
            foreach(var student in students){
                double gpa = GPAHesapla(student.Value);
                Console.WriteLine($"{student.Key}, GPA: {gpa}");
                if (gpa>=50){
                    gecen.Add(student.Key,gpa);
                }
                else{
                    kalan.Add(student.Key,gpa);
                }
            }
            // var gecen = students.Where(s => GPAHesapla(s.Value) >= 50)
            //         .ToDictionary(s => s.Key, s => GPAHesapla(s.Value));

            // var kalan = students.Where(s => GPAHesapla(s.Value) < 50)
            //         .ToDictionary(s => s.Key, s => GPAHesapla(s.Value));
            var enIyiOgrenci = gecen.OrderByDescending(s => s.Value).First();
            Console.WriteLine($"En iyi öğrenci: {enIyiOgrenci.Key}, GPA: {enIyiOgrenci.Value}");
        }

        static double GPAHesapla(List<int>grades){
            return grades.Average();
        }

    }

}