// Menu



/*
Condiciones:
 
- Crear menu de un restarurante para poder despachar pedidos
- Items: Hamburguesas, Aguas, Papas, Helado, Pizza, Pastas y Postres
- Mostrar el menu
- Ordenar
- Pago
*/



// Variables

using System.Xml.Schema;

bool _continuar = false;
int _opcionMenu = 0;
int _menu1 = 0, _menu2 = 0, _menu3 = 0, _menu4 = 0, _menu5 = 0, _menu6 = 0, _menu7 = 0;
int _pmenu1 = 35, _pmenu2 = 30, _pmenu3 = 25, _pmenu4 = 20, _pmenu5 = 15, _pmenu6 = 10, _pmenu7 = 5;


//Intro

Console.WriteLine("Bienvenidos al Restaurante KrustyBurger");

// Lista de menus

Console.WriteLine("El menu es:");

Console.WriteLine("1. Hamburguesas de Lomito");
Console.WriteLine("2. Pastas al Pesto");
Console.WriteLine("3. Pizza de Pepperoni");
Console.WriteLine("4. Postres - Pastel de Triple Chocolate");
Console.WriteLine("5. Papas Fritas con Queso");
Console.WriteLine("6. Helado - Galleta");
Console.WriteLine("7. Bebidas");

// Seleccion de items

Console.WriteLine("Seleccione los items del menu que desea ordenar");

try

{

    do

    {

        _opcionMenu = int.Parse(Console.ReadLine());

        switch (_opcionMenu)

        {

            case 1:
                _menu1 = _menu1 + _pmenu1;
                break;

            case 2:
                _menu2 = _menu2 + _pmenu2;
                break;

            case 3:
                _menu3 = _menu3 + _pmenu3;
                break;

            case 4:
                _menu4 = _menu4 + _pmenu4;
                break;

            case 5:
                _menu5 = _menu5 + _pmenu5;
                break;

            case 6:
                _menu6 = _menu6 + _pmenu6;
                break;

            case 7:
                _menu7 = _menu7 + _pmenu7;
                break;

            default:
                {

                    Console.WriteLine("< ERROR > Solo se tomara encuenta el primer digito dadó, porfavor ingresa un numero valido.");

                }
                
                break;

        }

        // Continuar seleccion

        int _total = _menu1 + _menu2 + _menu3 + _menu4 + _menu5 + _menu6 + _menu7;

        Console.WriteLine("Desea continuar? si/no");
        string _respuesta = Console.ReadLine().ToLower();

        if (_respuesta == "si")

        {

            _continuar = true;
            Console.WriteLine("Ingrese el siguiente item del menu que desea ordenar");

        }

        else

        {

            Console.WriteLine("Tu total a pagar es: ");

              if (_menu1 > 0)
            {
                Console.WriteLine(_total);
            }

             else if (_menu2 > 0)
            {
                Console.WriteLine(_total);
            }

             else if (_menu3 > 0)
            {
                Console.WriteLine(_total);
            }

            else if (_menu4 > 0)
            {
                Console.WriteLine(_total);
            }

            else if (_menu5 > 0)
            {
                Console.WriteLine(_total);
            }

            else if (_menu6 > 0)
            {
                Console.WriteLine(_total);
            }

            else if ( _menu7 > 0)
            {
                Console.WriteLine(_total);
            }
           
            else

                _continuar = false;
            

            // Contar precios 

       
        }

    } 
    
    while (_continuar == true);

}

// Caso Error

catch (Exception)

{
    Console.WriteLine("Ha existido un error. Vuelva a ejecutar el programa");

};

Console.ReadKey();