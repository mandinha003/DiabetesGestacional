double glicemia;
 
Console.Write("Digite o Valor de sua Glicemia: ");
glicemia = Convert.ToDouble(Console.ReadLine());
 
if( glicemia < 92 )
{
    Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
else
{
    if( glicemia >= Convert.ToDouble(92) && glicemia < Convert.ToDouble(126) )
    {
        Console.WriteLine("Compatível com Diabetes Gestacional");
    }
    else if( glicemia >= Convert.ToDouble(126))
    {
        Console.WriteLine("Diabetes Mellitus na Gravidez");
    }
}