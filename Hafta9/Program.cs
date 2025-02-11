using System.IO;
using System.Text;


namespace Hafta9
{
    class Program
    {

        static void Create(string path){
            FileStream fs = File.Create(path);
            fs.Close();

        }

        public void Read(string path){

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            for (int i = 0; i < fs.Length; i++)
            {
                Console.Write((char)fs.ReadByte());
            }
            fs.Close();
        }

        public void Write(string path,string text){
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            fs.Write(info,0,info.Length);
            fs.Close();
        }

        static void Main(string[] args)
        {
            // FileStream fs = File.Create("test.txt");
            // byte[] text = new UTF8Encoding(true).GetBytes("Hikmet\n");
            // fs.Write(text, 0, text.Length);
            // fs.Close();
            

            // string text;
            // Console.WriteLine("Enter text: ");
            // text = Console.ReadLine();
            // byte[] info = new UTF8Encoding(true).GetBytes(text);
            // fs.Write(info,0,info.Length);
            // fs.Close();
            Create("test.txt");
            Write("test.txt","Hikmet\n");
            Read("test.txt");


        }
    }
}
