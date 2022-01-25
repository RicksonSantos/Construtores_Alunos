using static System.Console;


namespace ExemploConstrutores.Models
{
    public class Pessoas
    {
        private string name;
        private string sobrenome;

        public Pessoas()
        {
            name = string.Empty;
            sobrenome = String.Empty;
        }

        public Pessoas(string name, string sobrenome)
        {
            this.name = name;
            this.sobrenome = sobrenome;
        
        }

        public void Apresentar (){
            
            WriteLine("Nome do aluno: " +name +sobrenome);



        }



    }
}