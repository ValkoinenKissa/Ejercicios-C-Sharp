﻿namespace Interfaces;

public class Circulo : IFigura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
    
}