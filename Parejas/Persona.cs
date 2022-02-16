namespace Parejas
{
    public class Persona
    {
       string nombre {get; set; }
       int edad {get; set;}

       char sexo{get; set;}


        public Persona(string nombre,int edad,char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public override string ToString() => $"{this.GetType()} {this.nombre} {this.edad} {this.sexo}";
    }
}