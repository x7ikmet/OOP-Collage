namespace OOP{
    using System.Drawing;

    // using Hafta1;
    using Hafta3;
    using Microsoft.VisualBasic;

    internal class Program{
        public static void Main()
        {
            
            Hafta3.Main a = new Main();
            a.insertArr();
        }

        void RenkDegisitir(Control nesne, string yazi, Boolean bold= false){
            
            if ((nesne) is TextBox){
                nesne.Text = "";
                nesne.Color = Color.Blue;
                if (bold){
                    nesne.Font = new Font(Font,FontStyle.Bold);
                }
            }
            else if((nesne)is Label ){
                nesne.BackColor = Color.Black;
            }
            nesne.Text = yazi;
        }
    }

}