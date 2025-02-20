using System;

abstract class Poligono {
    public abstract double Area();
}

class Triangulo : Poligono 
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseT, double alturaT)
    {
        Base = baseT;
        Altura = alturaT;
    }

    public override double Area()
    {
        return (Base * Altura) / 2;
    }
}

class Cuadrado : Poligono 
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        Lado = lado;
    }

    public override double Area()
    {
        return Math.Pow(Lado, 2);
    }
}

class Rectangulo : Poligono
{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }

    public Rectangulo(double lado1, double lado2)
    {
        Lado1 = lado1;
        Lado2 = lado2;
    }

    public override double Area()
    {
        return Lado1 * Lado2;
    }
}

void ImprimirArea(Poligono poligono)
{
    Console.WriteLine(poligono.Area());
}

Triangulo poligono1 = new Triangulo(4, 5);
Cuadrado poligono2 = new Cuadrado(3);
Rectangulo poligono3 = new Rectangulo(5, 9);

ImprimirArea(poligono1);
ImprimirArea(poligono2);
ImprimirArea(poligono3);

