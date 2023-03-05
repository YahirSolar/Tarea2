namespace Tarea2;

class Casa {
    public int area;
    public Puerta puerta = new Puerta();

    public Casa(int area) {
        this.area = area;
        this.puerta = new Puerta();
    }

    public void SetArea(int area) {
        this.area = area;
    }

    public void SetPuerta(Puerta puerta) {
        this.puerta = puerta;
    }

    public virtual void MostrarDatos() { 
        Console.WriteLine("Soy una casa, mi area es " + this.area + " m2");
    }
}