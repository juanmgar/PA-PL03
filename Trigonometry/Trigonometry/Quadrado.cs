using System;

public class Quadrado
{
	private double _lado = 1;

    public double Lado {
		get { return _lado; }
		set {
			if (value > 0)
				_lado = value;
		}
	}
    public Quadrado(){} //  Constructor vacio

	public Quadrado(double l): base() { Lado = l; } // Constructor por parámetros. Con base te aseguras que si el valor es negativo al menos te construirá con valor 1.

	public Quadrado(Quadrado q) { Lado = q.Lado; } // Constructor copia

	public double Perimeter()
	{
		return Lado + Lado + Lado + Lado;
	}

	public double Area()
	{
		return Lado * Lado;
	}

	public double Diagonal()
	{
		return Math.Sqrt(2 * Math.Pow(Lado, 2));

	}

}
