namespace Actividad1;

public class NewClass
{
    public static List<string> Names()
    {
        Console.WriteLine("Este metodo solicita los nombres de los alumnos asi que primero se debe ingresar la cantidad de alumnos");
        Console.WriteLine("Cuantos alumnos son?");
        int cantEstudents = int.Parse(Console.ReadLine());
        List<string> names = new List<string>();

        for (int i = 0; i < cantEstudents; i++)
        {
            Console.WriteLine("Escribe el nombre del alumno");
            names.Add(Console.ReadLine());
        }

        return names;
    }
    
    public static Dictionary<string, double> Grades(List<string> names) 
    {
        Dictionary<string, double> grades = new Dictionary<string, double>();
        foreach (var name in names)
        {
            double grade;
            do
            {
                Console.WriteLine("Escribe la nota del estudiante, " + name);
                grade = double.Parse(Console.ReadLine());
                if (grade < 1.0 || grade > 10.0)
                {
                    Console.WriteLine("La nota debe ser entre 1.0 y 10.0");
                }
            } while (grade < 1.0 || grade > 10.0);
            grades.Add(name, grade);
        }

        return grades;
    }
}