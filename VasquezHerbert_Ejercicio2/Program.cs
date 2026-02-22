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
Console.WriteLine("Usted viene acompañado? S/N");
string Respuesta = Console.ReadLine();

if (hora > 0 && dia > 0 && dia <8 && carnet == "S" || carnet == "N" && autorizacion == "S" || autorizacion == "N")
{
    switch (opcion)
    {
        case 1://Estudiante
            if (dia >= 1 && dia <= 5 && hora >=7 && hora <= 18) {
                if (usb == "S")
                {
                    if (Respuesta == "S")
                    {
                        Console.WriteLine("Bienvenido");
                    }
                    else
                    {
                        Console.WriteLine("Se Necesita acompañante");
                    }
                }
                else
                {
                    Console.WriteLine("Bienvenido");
                }
                
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            break;
        case 2://Docente
            break;
        case 3://Tecnico IT
            break;
        case 4://Visitante
            break;
        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
}
else
{
    Console.WriteLine("Datos erroneos");
}
