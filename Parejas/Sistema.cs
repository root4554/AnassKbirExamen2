using System.Collections.Generic;

using Parejas;
namespace Parejas
{
    public class Sistema
    {
        public List<Persona> Personas { get; } = new()
        {
            new Persona("anass",23,'H'),
            new Persona("maroua",24,'M'),
            new Persona("ahmed",27,'H'),
            new Persona("mariya",30,'M'),
            new Persona("marouan",19,'H'),
            new Persona("amina",18,'M'),
            new Persona("karim",32,'H'),
            new Persona("rachida",30,'M'),
            new Persona("arkaitz",32,'H'),
            new Persona("mayder",30,'M'),
        };

        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            int diferencia = a.edad - b.edad;
            if(diferencia<12){
                if(a.sexo!=b.sexo){
                    return true;
                }
                return false;
            }
            return false;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();
                for (var i = 0; i < parejas.Count - 1; i++)
                    for (var j = i + 1; j < parejas.Count; j++)
                    {
                        //if();        
                    }
           
            return parejas;
        }
        enum RangosdeEdad
        {
            MuyJoven, Joven, Plenitud, Madurez,Vejez
        }
        abstract class rangoPersona
{
        public virtual int edad { get; }

        public RangosdeEdad rango
    {
        get => edad switch
        {
            < 19 => RangosdeEdad.MuyJoven,
            < 29 => RangosdeEdad.Joven,
            < 39 => RangosdeEdad.Plenitud,
            < 49 => RangosdeEdad.Madurez,
            _ => RangosdeEdad.Vejez
        };
        
    }
            public  string Saludo(string nombre) => $" { this.GetType()} {this.edad} {this.rango} ";

}
   /* class Persona : rangoPersona
{
    string rango { get;  }
    public override string rango { get =>  }
    
    public Persona(string rango)
    {
        this.rango = rango;
    }


}*/


    }
}