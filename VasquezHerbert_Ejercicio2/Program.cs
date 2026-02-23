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
            // El estudiante solo puede entrar en horario escolar
            if (dia >= 1 && dia <= 5 && hora >=7 && hora <= 18 && carnet == "S") {
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
               // El docente solo puede entrar en horario escolar
            if (dia >= 1 && dia <= 5 && hora >= 7 && hora <= 18)
            {
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
        case 3://Tecnico IT
               // El tecnico ya tiene mayor libertad y puede entrar en todos los horarios
            if (dia >= 1 && dia <= 7 && hora >= 6 && hora <= 23)
            {
                Console.WriteLine("Bienvenido");

            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            break;
        case 4://Visitante
          //El visitante solo puede entrar en los dias escolores y el horario de 10am a 5pm
            if (dia >= 1 && dia <= 5 && hora >= 10 && hora <= 5)
            {
                if (autorizacion == "S" && Respuesta == "S")
                {
                    Console.WriteLine("Usted puede ingresar");
                }
                else
                {
                    Console.WriteLine("usted no puede ingresar");
                }

            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
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
