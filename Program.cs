namespace Tarea2;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("\t");
        Persona persona = new Persona();
        persona.MostrarDatos();
        Console.WriteLine("\t");
        persona.nombre = "Ale malvadilla beshito";
        Apartamento nuevoApartamento = new Apartamento();
        Puerta nuevaPuerta = new Puerta();
        nuevaPuerta.SetColor("Rosita");
        nuevoApartamento.SetPuerta(nuevaPuerta);
        persona.SetCasa(nuevoApartamento);
        persona.MostrarDatos();
        Console.WriteLine("\t");
    }
}