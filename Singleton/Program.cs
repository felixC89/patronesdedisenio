using Patrones.Prototype_Shallow;
using Patrones.Prototype_Deep;
using Patrones.FactoryMethod;
using Patrones.Strategy;
using Patrones.InyeccionDependencias;

namespace Patrones
{
    public class Program
    {
        static void Main(string[] args) 
        {
            int valor = 5;

            switch (valor)
            {
                case 0://Singleton
                    Console.WriteLine(Singleton.Instance.mensaje);
                    Singleton.Instance.mensaje = "Hola Singleton2 :(";
                    Console.WriteLine(Singleton.Instance.mensaje);

                    break;
                case 1://Prototype Shallow:Clona un objeto a partir de otro de forma superficial

                    Animal animal = new Animal() { nombre = "Oveja", patas=4 };
                    Animal animalClonado = (Animal)animal.Clone();
                    animalClonado.nombre = "Mono";
                    animalClonado.patas = 2;
                    Console.WriteLine(animal.patas);
                    Console.WriteLine("Animal Clonado:"+animalClonado.patas);

                    break;

                case 2://Prototype Deep:Clona un objeto a partir de otro de forma profunda

                    Animal1 animal1 = new Animal1() { Nombre = "Dolly", Patas = 4 };
                    animal1.Razgos = new Detalles { Color = "Blanco", Raza = "Oveja india" };
                    Animal1 animalClonado1 = (Animal1)animal1.Clone();

                    animalClonado1.Razgos.Color = "Negro";
                    animalClonado1.Razgos.Raza =  "Oveja Negra";

                    Console.WriteLine("Animal Original:" + animal1.Nombre);
                    Console.WriteLine("Animal Original:" + animal1.Patas);
                    Console.WriteLine("Animal Original:" + animal1.Razgos.Raza);
                    Console.WriteLine("Animal Original:" + animal1.Razgos.Color);

                    Console.WriteLine("Animal Clonado:" + animalClonado1.Nombre);
                    Console.WriteLine("Animal Clonado:" + animalClonado1.Patas);
                    Console.WriteLine("Animal Clonado:" + animalClonado1.Razgos.Raza);
                    Console.WriteLine("Animal Clonado:" + animalClonado1.Razgos.Color);

                    break;

                case 3:// Patron Factory Method

                    BebidaEmbriagante oBedida = Creador.CreadorBebida((int)Creador.Bebida.CERVEZA);
                    Console.WriteLine(oBedida.CuantoMeEmbriagaPorHora());
                    break;

                case 4:// Patron Strategy

                    EstrategiasDelBorrachoContexto oBorracho = new EstrategiasDelBorrachoContexto();
                    oBorracho.Conquistar();
                    oBorracho.EstablecerConquistarCerveza();
                    oBorracho.Conquistar();
                    
                    break;

                case 5:// Inyeccion de dependencias

                    IBebida oBebida = new MediasDeCeda("Picante");

                    Cantinero oCantinero = new Cantinero(oBebida);

                    oCantinero.Preparar();

                    break;

                default: 
                    Console.WriteLine(Singleton.Instance.mensaje); 

                    break;
            }

        }
    }
}
