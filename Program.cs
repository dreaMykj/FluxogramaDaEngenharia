bool deveria,estaSeMovendo;
string mensagem;

Console.WriteLine("--- Fluxograma Da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)? ");
estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria? ");
deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

if (!estaSeMovendo)
{
    if (!deveria)
    {
        mensagem = "Ótimo";
    }
    else
    {
        mensagem = "Use WD-40";
    }
}
else
{
    if (deveria)
    {
        mensagem = "Ótimo";
    }
    else
    {
        mensagem = "Use Silver Tape";
    }
}
Console.WriteLine(mensagem);