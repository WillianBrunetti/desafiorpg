using static System.Console;
using will;

Knight Arus = new Knight("Arus", "Knight", 42, 469, 749, 72, 72);
Ninja Wedge = new Ninja("Wedge", "Ninja", 42, 292, 574, 89, 89);
WhiteWizzard Jenica = new WhiteWizzard("Jenica", "WhiteWizard", 42, 325, 601, 474, 482);
BlackWizzard Topapa = new BlackWizzard("Topapa", "BlackWizard", 42, 106, 385, 611, 641);


//Caso o usuario queira inserir o valor atribuindo-o ao metodo
//WriteLine("Insira o valor lançado pelo Dado. ");
//var bunus = int.Parse(ReadLine());
//WriteLine(Jenica.Attack(bunus));

WriteLine(Arus);
WriteLine(Wedge);
WriteLine(Jenica);
WriteLine(Topapa);
WriteLine();
WriteLine(Arus.Attack());
WriteLine(Wedge.Attack(3));
WriteLine(Jenica.Attack(5));
WriteLine(Topapa.Attack(8));

