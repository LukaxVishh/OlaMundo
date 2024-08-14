// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Ola, mundo!");



Console.WriteLine("Digite um numero para A ");
var a = Console.ReadLine();
Console.WriteLine("Digite um Valor para B");
var b = Console.ReadLine();

var soma = (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2;


Console.WriteLine("A media dos valores é " + soma);

if (soma > 60){
    Console.WriteLine("Aprovado");
}
else{
    Console.WriteLine("Reprovado");
}