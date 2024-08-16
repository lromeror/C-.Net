using System.Security.Cryptography;
using Models;

int x = 0;
Console.WriteLine("Learn variables: " + x);//Concatena no usa la coma 
Console.WriteLine($"El valor de la X con interpolacion: {x}");//Esto es con interpolacion

//Ojo tambien son inmutables como python
string nombres = "Luis";
string apellidos = "Romero";

Console.WriteLine($"Nombre Completo: {nombres} {apellidos}");

nombres = "Fernando";
Console.WriteLine($"Nombre Completo: {nombres.ToUpper()} {apellidos.ToUpper()}");

bool IsBolan = false;
if (!false)
{
    Console.WriteLine("Entro en el condicional");
}

if (x == 2)
{
    Console.WriteLine($"El numero 2 es igual al {x}");
}
else if (x > 2)
{
    Console.WriteLine($"El numero {x} es mayor que 2");
}
else
{
    Console.WriteLine($"El numero {x} es menot que 2");
}
Console.WriteLine(IsBolan);

//Ternarios
int Edad=19;
Console.WriteLine((Edad>=18)?"Es mayor de Edad":"Es Menor de Edad");

int kilom=100;
ConvertidorUnidad kimToMetros=new ConvertidorUnidad(kilom);
Console.WriteLine($"{kilom} Kilomtros son {kimToMetros.convertir(kilom)} metros");

Punto p1=new Punto();
p1.x=7;
p1.y=0;

Punto p2=p1;//Hazme una copia de lo que tiene p1 a p2
Console.WriteLine($"Punto 1:{p1.x} {p1.y}");
Console.WriteLine($"Punto 2:{p2.x} {p2.y}");
Console.WriteLine();
p1.x=8;
Console.WriteLine($"Punto 1:{p1.x} {p1.y}");
Console.WriteLine($"Punto 2:{p2.x} {p2.y}");

Console.WriteLine();
//Array, deben ser todos de un mismo tipo de dato
//string[] personas=new string[5];
//personas[0]="Carlos";
//personas[1]="Luis";
//personas[2]="Fernando";
//personas[3]="Romero";
//personas[4]="Rodriguez";

string[] personas=new string[]{"Luis","Fernando","Romero","Rodriguez","Jose"};

for (int i = 0; i < personas.Length; i++)
    Console.WriteLine("nombre: "+personas[i]);

/*switch (Char.ToLower(letra))
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':

    default:
}*/
/*
string letra = Console.ReadLine();
resultado=letra switch //se evalua la letra
{
    'a'=>"La letra es una vocal",
    'i'=>"La letra es una vocal",
    'e'=>"La letra es una vocal",
    'u'=>"La letra es una vocal",
    'o'=>"La letra es una vocal",
    _=>"La letra no es una vocal",
};
Console.WriteLine(resultado);*/
Persona per1=new Persona(){ 
    Id=1,
    Nombres="Luis Fernando",
    Apellidos="Romero Rodriguez",
    genero=Genero.Masculino

};
per1.direccion.numero="125";
per1.direccion.provincia="Guayas";
per1.direccion.nombreCalle="Calle CH";
per1.direccion.ciudad="Guayaquil";
per1.direccion.pais="Ecuador";


Console.WriteLine($"La persona: {per1.nombreComleto} de genero {per1.genero}");