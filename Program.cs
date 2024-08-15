bool seguir = true;
while(seguir){
    Console.WriteLine("1 sumar");
    Console.WriteLine("2 restar");
    Console.WriteLine("3 multiplicar");
    Console.WriteLine("4 dividir");
    Console.WriteLine("5 salir");
    string elegirCadena = Console.ReadLine();
    int elegir = 0;
    if(int.TryParse(elegirCadena,out elegir)){
        if(elegir >=1 && elegir <= 4){

            double numero1 = 0,numero2 = 0;
            Console.WriteLine("ingrese el primer numero:");
            string numero1Cadena = Console.ReadLine();
            while(!double.TryParse(numero1Cadena,out numero1)){
                Console.WriteLine("no se ingreso un numero valido");
                Console.WriteLine("ingrese el primer numero:");
                numero1Cadena = Console.ReadLine();
            }

            Console.WriteLine("ingres el segundo numero:");
            string numero2Cadena = Console.ReadLine();
            while(!double.TryParse(numero2Cadena,out numero2) || numero2Cadena == "0"){
                if(numero2Cadena == "0"){
                    Console.WriteLine("no se puede dividir en 0");
                    Console.WriteLine("ingrese el segundo numero:");
                    numero2Cadena = Console.ReadLine();
                }else{
                    Console.WriteLine("no se ingreso un numero valido");
                    Console.WriteLine("ingrese el segundo numero:");
                    numero2Cadena = Console.ReadLine();
                }
            }
            double resultado = 0;
            switch(elegir){
                case 1: resultado = numero1+numero2; break;
                case 2: resultado = numero1-numero2; break;
                case 3: resultado = numero1*numero2; break;
                case 4: resultado = numero1/numero2; break;
            }
            Console.WriteLine("resultado: "+resultado);
        }
        else{
            if(elegir == 5){
                seguir = false;
                Console.WriteLine("saliendo...");
            }
            else{
                Console.WriteLine("no se eligio una opcion valida");
            }
        }
    }
    else{
        Console.WriteLine("no se indico un numero");
    }
}