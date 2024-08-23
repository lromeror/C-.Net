using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using Data;
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
//public delegate int Calcular(int a,int b);



//TestDelegate test= new TestDelegate();
//Calcular c1=new Calcular(test.Sumar);

// Func Delegate, primero es lo que se retorna, despues los parametros de input
Func<int,int,int> sumaFunc=(a,b)=> a+b;
int result=sumaFunc(5,4);
Console.WriteLine($"Resultado es igual a:{result}");

//Action delegate, solo necesita hacer la accion no se retorna nada
Action<string> saludoAction=nombre=>Console.WriteLine($"Hola,{nombre}");
saludoAction("Luis Romero");


Persona per2=new Persona(){ 
    Id=2,
    Nombres="Jose Luis",
    Apellidos="Romero",
    genero=Genero.Masculino

};
per2.direccion.numero="125csdcd";
per2.direccion.provincia="Guayas";
per2.direccion.nombreCalle="Calle C";
per2.direccion.ciudad="Guayaquil";
per2.direccion.pais="Ecuador";

ImplementarPersona imp=new ImplementarPersona();
imp.Agregar(per1);
imp.Agregar(per2);

Console.WriteLine($"La cantidad de Personas ingresadas es:{imp.Total()}");

Persona personaId=imp.Obtener(2);
Console.WriteLine($"La persona de id 2 es:{personaId.nombreComleto}");

IEnumerable<Persona> listaPersonas=imp.obtenerTodos();
foreach (var item in listaPersonas)
{
    Console.WriteLine("--------");
    Console.WriteLine($"Persona {item.Id}");
    Console.WriteLine($"Nombre: {item.nombreComleto}");
}

Empleado empl = new Empleado()
{
    Id = 3,
    Apellidos = "Rodriguez",
    Nombres = "Yuri",
    direccion = new Direccion()
    {
        numero = "29",
        ciudad = "Guayaquil",
        nombreCalle = "via Samborondon",
    },
    numeroEmpleado = Guid.NewGuid(),
    salario = 200,
    fechaIngreso = new DateOnly(2023, 1, 10) // Corregir el año a uno válido
};

Console.WriteLine($"Empleado #: {empl.numeroEmpleado}");
Console.WriteLine($"Nombres : {empl.nombreComleto}");
Console.WriteLine($"Dierccion : {empl.direccion.DireccionCompleta}");

