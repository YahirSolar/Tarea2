namespace Tarea2;

class Apartamento : Casa {

    public Apartamento(): base(50) {
    }

    public override void MostrarDatos() {
        Console.WriteLine("Soy un Apartamento, mi area es " + this.area + " m2");
    }
}