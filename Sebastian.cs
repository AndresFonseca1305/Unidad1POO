//librerioas que se usan en el programa
using System;


namespace Actividad1//esto es el nombre del proyecto
{
    public class Sebastian//clase 
    {
        public static void Start() //metodo principal del programa
        {
            const int numberEstudents = 5;// indica el numero de los estudiantes
            string[] studentNames = IngresarNombresEstudiantes(numberEstudents);//arreglo de nombres de los estudiantes
            double[] studentGrades = IngresarNotasEstudiantes(numberEstudents);//arreglo de notas de los estudiantes

            double averageGrade = CalcularPromedio(studentGrades);//variable que almacena el promedio de las notas

            Console.WriteLine($"El promedio de las notas es: {averageGrade:F2}");//imprime el promedio de las notas
            
            Console.WriteLine("Estudiantes por debajo del promedio: "); //imprime el mensaje estudiantes por debajo del promedio
            

            for(int i = 0; i < numberEstudents; i++)// recorrido de array de estudiantes y calificaciones 
            {
                if (studentGrades[i] < averageGrade)// verifica si la calificacion es menor al promedio
                {
                    Console.WriteLine($"{studentNames[i]}: {studentGrades[i]:F2}");//imprime el nombre del estudiante y su calificacion
                }

            }
            Console.ReadKey();//espera a que el usuario presione una tecla

        }          
        static string[] IngresarNombresEstudiantes(int cantidadEstudiantes)// funcion para ingresar los nombres de los estudiantes
        {
            string[] names = new string[cantidadEstudiantes];//array para almacenar los nombres de los estudiantes

            for (int i = 0; i < cantidadEstudiantes; i++) //recorrido de los estudiantes 
            {
                bool validName = false;//variable para verificar si el nombre es valido
                do
                {
                    Console.WriteLine($"Ingrese el nombre del estudiante --{i + 1}--: ");
                    string input = Console.ReadLine().Trim();//almacena el nombre del estudiante
                    if (!string.IsNullOrWhiteSpace(input))//verifica si el nombre no esta vacio
                    {
                        names[i] = input;//almacena el nombre del estudiante
                        validName = true;//el nombre es valido
                    }
                    else
                    {
                        Console.WriteLine("El nombre ingresado no es válido. Intente de nuevo.");//mensaje de error
                    }
                } while (!validName);
            }
            return names;
        }
        
        //metodo para obtener las calificaciones de los estudiantes
        static double[] IngresarNotasEstudiantes(int cantidadEstudiantes)//Funcion para ingresar las calificaciones de los estudiantes
        {
            double[] notas = new double[cantidadEstudiantes];//arraya para almacenar las calificaciones de los estudiantes
            
            for(int i = 0; i < cantidadEstudiantes; i++)// recorrido de las calificaciones de los estudiantes
            {
                bool notaValida = false; //variable para verificar si la calificacion es valida
                do
                {
                    Console.WriteLine($"Ingrese la nota del estudiante {i + 1} (entre 1.0 y 10.0): "); //mensaje para ingresar la calificacion del estudiante
                    double notaIngresada = double.Parse(Console.ReadLine());//convertir a un numero decimal la calificacion ingresada

                    if (notaIngresada >= 1 && notaIngresada <= 10.0)
                    {
                        notas[i] = notaIngresada;//almacena la calificacion del estudiante
                        notaValida = true;//la calificacion es valida
                    }
                    else 
                    {
                        Console.WriteLine("La nota ingresada no es válida. Intente de nuevo.");//mensaje de error
                    }
                }while (!notaValida);
            }
            return notas;
        }
        static double CalcularPromedio(double[] notas) 
        {
            double suma = 0.0;//variable para almacenar la suma de las calificaciones
            foreach (double nota in notas)
            {
                suma += nota;
            }
            return suma / notas.Length;
            
        }
    }

}