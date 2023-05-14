// See https://aka.ms/new-console-template for more information

using Asignacion_Pelotas;

Console.WriteLine("Este programa permite añadir bolas y verificar su disponibilidad");

Console.WriteLine("Cuantas pelotas desea añadir?");
int cant = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < cant; i++) {
    Pelota pelotas = new Pelota();
    Console.WriteLine("Escribe el nombre de la bola");
    pelotas.nombre = Console.ReadLine();

    Console.WriteLine("Digite la longitud de la bola");
    pelotas.longitud = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite la forma de la pelota");
    pelotas.forma = Console.ReadLine();

    Console.WriteLine("Ingrese su respuesta Y/N");
    char dispo = char.ToLower(Console.ReadKey().KeyChar);

    if (dispo == 'y')
    {
        pelotas.disponible = true;
    }
    else if (dispo == 'n')
    {
        pelotas.disponible = false;
    }
    else {
        Console.WriteLine("\nCarácter ingresado no válido. Se asumirá como respuesta falsa.");
        pelotas.disponible = false;
    }
    Console.Clear();
    Console.WriteLine($"{pelotas.nombre} tiene una forma {pelotas.forma} con una longitud de {pelotas.longitud}cm");
    pelotas.Disponibilidad();
    Console.ReadLine();
    Console.Clear();
}

