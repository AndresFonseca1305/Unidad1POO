namespace Actividad1;

public class NewClass
{
    public List<string> Names()
    {
        Console.WriteLine("Este metodo solicita los nombres de los alumnos asi que primero se debe ingresar la cantidad de alumnos");
        Console.WriteLine("Cuantos alumnos son?");
        int cantEstudents = int.Parse(Console.ReadLine());
        List<string> names= new List<string>();

        for (int i = 0; i < cantEstudents; i++)
        {
            Console.WriteLine("Escribe el nombre del alumno");
            names.Add(Console.ReadLine());
        }

        return names;
    }
}