using EjercicioInterfaces;

Console.WriteLine("******************BIENVENIDO******************");
string? radio, angulo;
Calculos calculos = new Calculos();
Console.WriteLine("Ingrese el Radio del Circulo");
radio =Console.ReadLine();
Console.WriteLine("Ingrese el Angulo del circulo");
angulo = Console.ReadLine();
if (radio is null || radio == ""){
    Console.WriteLine("Debe Ingredar un Radio Valido");
    radio = Console.ReadLine(); 
}else if (angulo is null || angulo == "")
{
    Console.WriteLine("Debe ingresar un angulo valido");
    angulo = Console.ReadLine();

}

bool valRadio, valAngulo;
valRadio = double.TryParse(radio, out calculos.radio);
valAngulo = double.TryParse(angulo, out calculos.angulo);

if (valRadio && valAngulo)
{
    calculos.Imprimir();
}else if(valRadio is not true)
{
    Console.WriteLine("El Radio NO es Valido");
    Console.WriteLine("No se pudo completar las operaciones");
}
else if(!valAngulo)
{
    Console.WriteLine("El Angulo NO es valido");
    Console.WriteLine("No se pudo completar las operaciones");

}
else
{
    Console.WriteLine("No se pudo completar las operaciones");
}


Console.WriteLine("******************ES TODO******************");