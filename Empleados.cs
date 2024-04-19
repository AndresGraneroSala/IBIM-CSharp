using System;

public class Empleado
{
    private string nombre;
    private double salario;


    //CREACION DE PROPIEDAD

    /*public double SALARIO
    {
        get { return salario; }
        set { this.salario = EvaluarSalario(value); }
    }*/
    
    public double SALARIO
    {
        get=> salario;
        set => this.salario = EvaluarSalario(value);
    }

    //get lectura
    //set escritura


    public Empleado(string nombre) {
        
        this.nombre = nombre;
    }

    public void SetSalario(double salario)
    {
        if (salario < 0)
        {
            Console.WriteLine("El salario no puede ser negativo, pasa a ser 0");
            salario = 0;
        }else
        {
            this.salario = salario;
        }
    }

    public double GetSalario()
    {
        return salario;
    }

    private double EvaluarSalario(double salario)
    {
        if (salario < 0)
        {
            return 0;
        }
        return salario;
    }

}
