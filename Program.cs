double numero, contador, produto;

   
 Console.Write("Tabuada do numero: ");
 numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0 || numero > 10)
{
    Console.WriteLine("digite numueros de 0 a 10");

}
else
{
    contador = 0;

    while(contador <= 10)
    {
        produto = numero * contador;
        Console.WriteLine($"{numero} x {contador++} = {produto}");
    }
}

        

    
    