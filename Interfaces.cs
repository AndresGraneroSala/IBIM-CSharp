using HelloWord;
using Herencia;
using MongoDB.Driver;
using System;

public class Interfaces
{
    public static void Main(string[] args)
    {
        //Test1();
        Test4();
    }

    public static void Test1()
    {
        Ballena miWally = new Ballena("Wally");
        miWally.Nadar();

        Caballo miBabieca = new Caballo("Babieca");

        IMamiferosTerrestres ImiBabiecaTerrestre = miBabieca;
        ISaltoConPatas ImiBabiecaSalto = miBabieca;

        Console.WriteLine($"Patas de Babieca: {ImiBabiecaTerrestre.NumeroPatas()} y salta con {ImiBabiecaSalto.NumeroPatas()}");


    }

    public static void Test4()
    {
        AvisosTrafico av1 = new AvisosTrafico();
        av1.MostrarAvisos();

        AvisosTrafico av2 = new AvisosTrafico("Jefatura de Valencia","Sancion de velocidad: 300€","02-05-19");

        av2.MostrarAvisos();
    }

}

class Ballena: Mamiferos
{
    public Ballena(string nombreBallena):base(nombreBallena) { }

    public void Nadar()
    {
        Console.WriteLine("Soy capaz de nadar");
    }

}

interface IMamiferosTerrestres
{
    int NumeroPatas();
}

interface IAnimalesYDeportes
{
    string tipoDeporte();
    bool esOlimpico();
}

interface ISaltoConPatas
{
    int NumeroPatas();
}