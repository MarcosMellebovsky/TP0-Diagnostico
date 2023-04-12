//1
Console.WriteLine("Traer Mayor:");
            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine(num1);
                }
            }
            else if (num2 > num1)
            {
                if (num2 >= num3)
                {
                    Console.WriteLine(num2);
                }
                else if(num2 < num3)
                {
                    Console.WriteLine(num3);
                }
            }
// punto 2
int Num1, Num2, Num3;
string final, posicion;
final = "";
Console.WriteLine("Ingrese un numero: ");
Num1 =int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero: ");
Num2 =int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero: ");
Num3 =int.Parse(Console.ReadLine());
posicion = PosicionMayor( Num1,  Num2,  Num3, final);

string PosicionMayor(int Num1, int Num2, int Num3, string final) 
{
    final = "";
if (Num1 >= Num2 && Num1 >= Num3)
{
  final = "1";
}
if(Num2 >= Num1 && Num2 >= Num3)
{
 if(final == ""){
    final = "2";
 }
 else if(final != ""){
    final = final + ":2";
 }
}

if(Num3 >= Num1 && Num3 >= Num2)
{
 if(final == ""){
    final = "3";
 }
 else if(final != ""){
    final = final + ":3";
 }
}
System.Console.WriteLine("Mayor: " + final);
return final;

}

//3
int[] diasMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int año;
            int mes = 0;
            int dia = 0;
            int checkearDia = 0;
            int final = 0;
            año = validarAño(diasMes);
            mes = validarDiaYMes(diasMes, meses, mes, ref dia, ref checkearDia);
            final = calcularDia(checkearDia, diasMes, dia, final);
            System.Console.WriteLine("los dias que psaron durante el año son: " + final);


            int validarDiaYMes(int[] diasMes, int[] meses, int mes, ref int dia, ref int checkearDia)
            {


                Console.WriteLine("Ingrese un mes (en numero) ");
                mes = int.Parse(Console.ReadLine());

                while (mes > meses[11] || mes < 0)
                {
                    System.Console.WriteLine("No hay mas de 12 meses, volve a escribirlo");
                    mes = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese un dia de cualquier mes: ");
                dia = int.Parse(Console.ReadLine());
                checkearDia = mes - 1;
                while (dia > diasMes[checkearDia] || dia < 0)
                {
                    System.Console.WriteLine("No hay dia mayor de " + dia + " en el mes: " + mes + " volvelo a escribir ");
                    dia = int.Parse(Console.ReadLine());
                }

                return mes;
                
            }
            int validarAño(int[] añosMes)
            {
                int año;
                Console.WriteLine("Ingrese un año: ");
                año = int.Parse(Console.ReadLine());
                while (año < 0)
                {
                    Console.WriteLine("No hay años negativos, ingrese un año positivo! ");
                    año = int.Parse(Console.ReadLine());
                }
                int verificarAño = año;
                do
                {
                    verificarAño = verificarAño - 4;
                } while (verificarAño > 0);
                if (verificarAño == 0)
                {
                    añosMes[1]++;
                }
                return año;
            }
            int calcularDia(int checkearDia, int[] diasMes, int dia, int final)
            {
                int checkearCant = checkearDia - 1;
                final = 0;

                for (int i = 0; i < checkearDia; i++)
                {
                    final = final + diasMes[i];
                }
                
                final = final + dia;

                return final;
            }

//4
int num1 = 0;
int num2 = 0;
num1= validarDivisoresComunes( num1, ref  num2);
divisoresComunes(num1, num2);
numMenor( num1, num2);

 int validarDivisoresComunes(int num1, ref int num2)
        {
            
            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            while (num1 < 0)
            {
                Console.WriteLine("No es numero negativo!, ingrese uno positivo: ");
                num1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());
            while (num2 < 0)
            {
                Console.WriteLine("No es numero negativo!, ingrese uno positivo: ");
                num2 = int.Parse(Console.ReadLine());
            }
            return num1;
            
        }


void divisoresComunes(int num1, int num2) {
    bool valido = num1 != num2 && num1 >= 1 && num2 >= 1;
    if(valido){
        string mostrar;
        mostrar = "1,";
        for (int i = 2; i <= numMenor(num1,num2); i++){
            if (num1 % i == 0) {
                if (num2 % i == 0){
                    mostrar = mostrar +' '+i+',';
                }
            }
        }
        
        mostrar = mostrar.Substring(0,mostrar.Length - 1);
        Console.WriteLine(mostrar); 
    }
    else Console.WriteLine("Error, no se procesarán los valores");

}
int numMenor(int num1, int num2)
{
    if(num1> num2)
    {
        return num2;
        
    }
    else{
        return num1;
    }
   


}
          

//5    
    string palabra;
            string final = "";
            Console.WriteLine("escribe una palabra");
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                char verificardor1;
                verificardor1 = palabra[i];
                string a;
                string b;
                b = "" + verificardor1;
                a = "" +verificardor1;
                a = a.ToUpper();
                
                if(a == b)
                {
                    final = final + a.ToLower();
                }
                if (a != b)
                {
                    final = final + a.ToUpper();
                }
            }
            Console.WriteLine(final);

----------------------------------------------------------------
//6
string ingresar;
            int contadorComas = 0;
            int aprobado = 0;
            Console.WriteLine("ingresa:");
            ingresar = Console.ReadLine();

            for (int i = 0; i < ingresar.Length; i++)
            {
                string a;
                a = "" + ingresar[i];

                if (a == ",")
                {
                    contadorComas++;
                }
                if (a != "1" && a != "2" && a != "3" && a != "4" && a != "5" && a != "6" && a != "7" && a != "8" && a != "9" && a != "0" && a != ",")
                {
                    aprobado++;
                }
            }
            if (contadorComas >= 2)
            {
                aprobado++;
            }
            if (aprobado == 0)
            {
                Console.WriteLine("TRUE");
            }
            if (aprobado > 0)
            {
                Console.WriteLine("FALSE");
            } 

