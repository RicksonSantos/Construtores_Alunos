using static System.Console;


namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoas
    {

        private string Disciplina;

        
        public Aluno(string name, string sobrenome, String Disciplina ) : base (name, sobrenome)
        {
            this.Disciplina = Disciplina;
        }
    
     public void Apresentar2 (){
            
            WriteLine("Disciplina em curso:" +Disciplina);



        }

    
    }

}