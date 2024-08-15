bool seguir = true;
do{
Console.WriteLine("1 valor absoluto");
Console.WriteLine("2 cuadrado");
Console.WriteLine("3 raiz cuadrada");
Console.WriteLine("4 seno");
Console.WriteLine("5 coseno");
Console.WriteLine("6 parte entera");
Console.WriteLine("7 salir");
Console.WriteLine("eliga una opcion:");
string elegirCadena = Console.ReadLine();
int elegir;
if(int.TryParse(elegirCadena,out elegir)){
    if(elegir >= 1 && elegir <= 6){
        Console.WriteLine("ingrese un numero");
        string numeroCadena = Console.ReadLine();
        double numero = 0,resultadoDecimal = 0;
        int resultadoEntero = 0;
        if(double.TryParse(numeroCadena, out numero)){
            switch(elegir){
                case 1: resultadoDecimal = Math.Abs(numero); break;
                case 2: resultadoDecimal = Math.Pow(numero,2); break;
                case 3: resultadoDecimal = Math.Sqrt(numero); break;
                case 4: resultadoDecimal = Math.Sin(numero); break;
                case 5: resultadoDecimal = Math.Cos(numero); break;
                case 6: resultadoEntero = (int)numero; break;
            }
            if(elegir >= 1 && elegir <= 5){
                Console.WriteLine("resultado: "+resultadoDecimal);
            }else{
                Console.WriteLine("resultado: "+resultadoEntero);
            }
        }
        else{
            Console.WriteLine("no se indico un numero valido");
        }
    }
    else if(elegir == 7){
        seguir = false;
        Console.WriteLine("saliendo...");
    }
    else{
        Console.WriteLine("no se indico una opcion valida");
    }
}
}while(seguir);