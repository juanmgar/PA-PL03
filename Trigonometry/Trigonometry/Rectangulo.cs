using System;

public class Rectangulo
{

	private double _base = 1;

	public double Base
	{
		get { return _base; }
		set
		{
			if (value > 0)
				_base = value;
		}
	}

	private double _altura = 1;

	public double Altura
	{
		get { return _altura; }
		set
		{
			if (value > 0)
				_altura = value;
		}
	}

	public Rectangulo() { } //  Constructor vacio

	public Rectangulo(double b, double a) : base() { Base = b; Altura = a; } // Constructor por parámetros. Con base te aseguras que si el valor es negativo al menos te construirá con valor 1.

	public Rectangulo(Rectangulo r) { Base = r.Base; Altura = r.Altura; } // Constructor copia

	public double Perimeter()
	{
		return (Base + Altura) * 2;
	}

	public double Area()
	{
		return Base * Altura;
	}
}
