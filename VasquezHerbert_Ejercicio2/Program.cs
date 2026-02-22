//Nuevo proyecto
//ver si funciona el github
Console.WriteLine("Ingrese su rol");
Console.WriteLine("1 Estudiante\r\n2 Docente\r\n3 Técnico IT\r\n4 Visitante");
int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el horario");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el dia (1-7)");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Carnet vigente? S/N");
String carnet = Console.ReadLine();
Console.WriteLine("Autorizacion Escrita S/N");
string autorizacion  = Console.ReadLine();
Console.WriteLine("Trae USB S/N");
string usb = Console.ReadLine();
if (hora > 0 && dia > 0 && dia <8 && carnet == "S" || carnet == "N" && autorizacion == "S" || autorizacion == "N")
{
    switch (opcion)
    {
        case 1://Estudiante
            break;
        case 2://Docente
            break;
        case 3://Tecnico IT
            break;
        case 4://Visitante
            break;
        default:
            break;
    }
}
else
{
    Console.WriteLine("Datos erroneos");
}
