using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RepasoListas
{
    #region ejemplo
    /*
    //METODO NO ESTATICO
    public void EjecutarMetodoNoEstatico()
    {
        Console.WriteLine("Metodo NO estatico ejecutado");
    }

    //METODO ESTATICO
    public static void EjecutarMetodoEstatico()
    {
        Console.WriteLine("Metodo estatico ejecutado");
    }

    */

    #endregion

    //o hacemos estatico porque solo va a haber 1 lista 
    private static List<string> colores = new List<string>();

    private static List<string> coloresPermitidos = new List<string>()
    {
        "rojo",
        "amarillo",
        "verde",
        "azul",
        "blanco",
        "gris",
        "negro",
        "añil",
        "marron",
        "rosa",
        "casa",
        "plata",
        "naranja"
    };

    #region Funciones
    //IMPRIMIR LISTAS
    private static void ImprimeLista(List<string> lista)
    {
        //para comprobar que imprime s
        foreach (string s in lista)
        {
            Console.WriteLine(s);
        }
    }

    //PARA QUE SE CREE UNA LISTA CON DATOS INTRODUCIDOS
    private static void CrearDatosPrueba()
    {
        List<string> coloresPrueba = new List<string>()
    {
        "rojo",
        "amarillo",
        "verde",
        "azul",
        "blanco",
        "gris",
        "negro",
        "añil",
        "marron",
        "rosa",
        "casa",
        "plata",
        "naranja"
    };

        //ADDRANGE mete un array de un tipo en otro array del mismo tipo
        colores.AddRange(coloresPrueba);

    }

    //PARA QUE SE CREE UNA LISTA CON VALORES ALEATORIOS
    public static void DatosRandomPrueba(int cantidad)
    {
        List<string> coloresRandom = new List<string>();
        //Objeto tipo aleatorio
        Random random = new Random();
        //random.Next(0, 10);
        for (int i = 0; i < cantidad; i++)
        {
            //el ultimo elemento de la lista siempre es .Count-1 ya que los indices empiezan en 0
            int indiceAleatorio = random.Next(0, coloresPermitidos.Count - 1);

            string colorElegido = coloresPermitidos[indiceAleatorio];

            //para añadir a la lista aux coloresRandom los colores elegidos aleatorios
            coloresRandom.Add(colorElegido);
        }
        //volcamos la lista con aleatorios en la lista de colores
        colores.AddRange(coloresRandom);
    }

    //PARA ELIMINAR TODOS LOS COLORES CON UN NOMBRE DETERMINADO
    public static void EliminarTodosLosColoresPorNombre(string colorAEliminar)
    {
        while (colores.Contains(colorAEliminar))
        {
            colores.Remove(colorAEliminar);
        }
        //expresion landa para hacer lo mismo 
        //colores.RemoveAll(x => x == colorAEliminar);
    }

    //PARA CONTAR COINCIDENCIAS
    private static void ContarCoincidencias()
    {
        //Creo un diccionario string-int 
        Dictionary<string, int> coincidencias = new Dictionary<string, int>();

        //recorremos los colores de la lista colores
        foreach (string color in colores)
        {
            //ContainsKey (si lo contiene como CLAVE unica)
            if (coincidencias.ContainsKey(color))
            {
                //No es la primera vez que encuentra este color
                int numeroDeVeces = coincidencias[color];
                numeroDeVeces++;
                coincidencias[color] = numeroDeVeces;
            }
            else
            {
                //es la primera vez que lo encuentra
                coincidencias.Add(color, 1);
            }


        }

        //Imprimir diccionario      
        foreach (string color in coincidencias.Keys)
        {
            string s = string.Format("{0} -> {1}", color, coincidencias.Keys);

        }

    }



    #endregion

    //PARA HACER PRUEBAS CON DATOS REALES
    public static void RealizarTest()
    {

        //para llamar a la funcion de GenerarDatosAleatorios
        //RepasoListas.DatosRandomPrueba(24);
        
        while (true)
        {
            #region ejemploColores
            /*
            Console.Write("Introduce un color: ");
            string color = Console.ReadLine();
            //para añadir a la lista un color
            colores.Add(color);
            ImprimeLista(colores);
            */
            #endregion

            #region ejemploComando
            /*
            Console.Write("Introduce un comando: ");
            string frase = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase = frase.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear =frase.Split(' ');
            string comando = arrayParaTrocear[0];
            string valor = arrayParaTrocear[1];
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    colores.Add(valor);
                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    colores.Remove(valor);
                    break;
                default:
                    break;
            }

            ImprimeLista(colores);
            */
            #endregion

            #region ejemploComandoConPrint
            /*
            Console.Write("Introduce un comando: ");
            string frase = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase = frase.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear = frase.Split(' ');
            string comando = arrayParaTrocear[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear.Length > 1)
            {
                valor = arrayParaTrocear[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    colores.Add(valor);
                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    colores.Remove(valor);
                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                default:
                    break;
            }

            ImprimeLista(colores);

    */
            #endregion

            #region ejemploPermitidos
            /*
            Console.Write("Introduce un comando: ");
            string frase2 = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase2 = frase2.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear2 = frase2.Split(' ');
            string comando2 = arrayParaTrocear2[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor2 = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear2.Length > 1)
            {
                valor2 = arrayParaTrocear2[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando2)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    //SI EL VALOR ESTA CONTENIDO EN LA LISTA DE COLORES PERMITIDOS
                    if (coloresPermitidos.Contains(valor2))
                    {
                        colores.Add(valor2);

                    }
                    else
                    {
                        Console.WriteLine("\nColor no permitido\n");
                    }

                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    colores.Remove(valor2);
                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                default:
                    break;
            }

            ImprimeLista(colores);
            */
            #endregion

            #region ejemploRemoveSoloContenidos
            /*
            Console.Write("Introduce un comando: ");
            string frase3= Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase3 = frase3.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear3 = frase3.Split(' ');
            string comando3= arrayParaTrocear3[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor3 = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear3.Length > 1)
            {
                valor3 = arrayParaTrocear3[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando3)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    //SI EL VALOR ESTA CONTENIDO EN LA LISTA DE COLORES PERMITIDOS
                    if (coloresPermitidos.Contains(valor3))
                    {
                        colores.Add(valor3);

                    }
                    else
                    {
                        Console.WriteLine("\nColor no permitido\n");
                    }

                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    if (colores.Contains(valor3))
                    {
                        colores.Remove(valor3);
                    }
                    else
                    {
                        Console.WriteLine("El color no se encuentra en la ista");
                    }
                    
                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                default:
                    break;
            }

            ImprimeLista(colores);
            */
            #endregion

            #region NoRepetidos
            /*

            Console.Write("Introduce un comando: ");
            string frase4 = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase4 = frase4.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear4 = frase4.Split(' ');
            string comando4 = arrayParaTrocear4[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor4 = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear4.Length > 1)
            {
                valor4 = arrayParaTrocear4[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando4)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    //SI EL VALOR ESTA CONTENIDO EN LA LISTA DE COLORES PERMITIDOS
                    //
                    if (coloresPermitidos.Contains(valor4))
                    {
                        //SI LA LISTA COLORES NO CONTIENE EL VALOR LO METE 
                        if (!colores.Contains(valor4))
                        {
                            colores.Add(valor4);
                        }
                        else
                        {
                            //SI LO CONTIENE
                            Console.WriteLine("Color Repedito");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nColor no permitido\n");
                    }

                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    if (colores.Contains(valor4))
                    {
                        colores.Remove(valor4);
                    }
                    else
                    {
                        Console.WriteLine("El color no se encuentra en la ista");
                    }

                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                default:
                    break;
            }

            ImprimeLista(colores);
            */
            #endregion

            #region ejemploDatosPrueba
            /*

            Console.Write("Introduce un comando: ");
            string frase4 = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase4 = frase4.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear4 = frase4.Split(' ');
            string comando4 = arrayParaTrocear4[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor4 = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear4.Length > 1)
            {
                valor4 = arrayParaTrocear4[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando4)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    //SI EL VALOR ESTA CONTENIDO EN LA LISTA DE COLORES PERMITIDOS
                    //
                    if (coloresPermitidos.Contains(valor4))
                    {
                        //SI LA LISTA COLORES NO CONTIENE EL VALOR LO METE 
                        if (!colores.Contains(valor4))
                        {
                            colores.Add(valor4);
                        }
                        else
                        {
                            //SI LO CONTIENE
                            Console.WriteLine("Color Repedito");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nColor no permitido\n");
                    }

                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    if (colores.Contains(valor4))
                    {
                        colores.Remove(valor4);
                    }
                    else
                    {
                        Console.WriteLine("El color no se encuentra en la ista");
                    }

                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                    //  CASO PARA RELLENAR UNA LISTA 
                case "generate":
                    CrearDatosPrueba();
                    break;
                default:
                    break;
            }

            ImprimeLista(colores);
            */
            #endregion

            #region comandoGenerarAleatorios


            /*
            Console.Write("Introduce un comando: ");
            string frase4 = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase4 = frase4.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear4 = frase4.Split(' ');
            string comando4 = arrayParaTrocear4[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor4 = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear4.Length > 1)
            {
                valor4 = arrayParaTrocear4[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando4)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    //SI EL VALOR ESTA CONTENIDO EN LA LISTA DE COLORES PERMITIDOS
                    //
                    if (coloresPermitidos.Contains(valor4))
                    {
                        //SI LA LISTA COLORES NO CONTIENE EL VALOR LO METE 
                        if (!colores.Contains(valor4))
                        {
                            colores.Add(valor4);
                        }
                        else
                        {
                            //SI LO CONTIENE
                            Console.WriteLine("Color Repedito");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nColor no permitido\n");
                    }

                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    if (colores.Contains(valor4))
                    {
                        colores.Remove(valor4);
                    }
                    else
                    {
                        Console.WriteLine("El color no se encuentra en la ista");
                    }

                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                //  CASO PARA RELLENAR UNA LISTA 
                case "generate":
                    CrearDatosPrueba();
                    break;
                    //CASO PARA GENERAR LISTA CON VALORES ALEATORIOS
                case "generandom":
                    //CREO VARIABLE EN LA CUAL GUARDO CONVIRTIENDOLO EN INT CON PARSE LA CANTIDAD QUE LE PASARE AL METODO RANDOM
                    int cantidad = int.Parse(comando4);
                    DatosRandomPrueba(cantidad);
                    break;

                default:
                    break;
            }

            ImprimeLista(colores);
            */
            #endregion

            #region removerTodosPorNombre

            Console.Write("Introduce un comando: ");
            string frase4 = Console.ReadLine();
            //Add{color}
            //Remove{color}

            //1ºPasar a minuscuas el comando
            frase4 = frase4.ToLower();
            //2ºTrocear ara averiguar el comando y el valor
            string[] arrayParaTrocear4 = frase4.Split(' ');
            string comando4 = arrayParaTrocear4[0];
            //LA INICIAMOS VACIA PARA COMPROBAR SI LLEGA 1 O 2 ELEMENTOS AL ARRAY   
            string valor4 = "";
            //PARA COMPROBAR QUE EL ARRAY TIENE MAS DE 1 VALOR
            if (arrayParaTrocear4.Length > 1)
            {
                valor4 = arrayParaTrocear4[1];
            }
            //3ºAveriguar con un switch el comando ntroducido
            switch (comando4)
            {
                case "add":
                    //4ºHAcer lo que tenga que hacerse
                    //SI EL VALOR ESTA CONTENIDO EN LA LISTA DE COLORES PERMITIDOS
                    //
                    if (coloresPermitidos.Contains(valor4))
                    {
                        //SI LA LISTA COLORES NO CONTIENE EL VALOR LO METE 
                        if (!colores.Contains(valor4))
                        {
                            colores.Add(valor4);
                        }
                        else
                        {
                            //SI LO CONTIENE
                            Console.WriteLine("Color Repedito");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nColor no permitido\n");
                    }

                    break;
                case "remove":
                    //4ºHAcer lo que tenga que hacerse
                    if (colores.Contains(valor4))
                    {
                        colores.Remove(valor4);
                    }
                    else
                    {
                        Console.WriteLine("El color no se encuentra en la ista");
                    }

                    break;
                //CASO DONDE SOLO LLEGA 1 ELEMENTO AL ARRAY
                case "print":
                    ImprimeLista(colores);
                    break;
                //  CASO PARA RELLENAR UNA LISTA 
                case "generate":
                    CrearDatosPrueba();
                    break;
                //CASO PARA GENERAR LISTA CON VALORES ALEATORIOS
                case "generandom":
                    //CREO VARIABLE EN LA CUAL GUARDO CONVIRTIENDOLO EN INT CON PARSE LA CANTIDAD QUE LE PASARE AL METODO RANDOM
                    int cantidad = int.Parse(valor4);
                    DatosRandomPrueba(cantidad);
                    break;
                    //CASO PARA BORRAR TODOS LOS DEL NOMBRE INTRODUCIDO
                case "removeall":
                    EliminarTodosLosColoresPorNombre(valor4);
                    break;
                case "countsame":
                    ContarCoincidencias();
                    break;

                default:
                    break;
            }

           
          
            #endregion

        }



    }



}

