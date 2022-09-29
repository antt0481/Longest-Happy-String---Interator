IFunAggregate fun = new Fun(1, 1, 7);
var funIterator = fun.CreateIterator();

var result = "";
while (!funIterator.IsDone())
{
    result += funIterator.Next();
}

Console.WriteLine("Result: " + result);

fun = new Fun(7, 1, 0);
funIterator = fun.CreateIterator();

result = "";
while (!funIterator.IsDone())
{
    result += funIterator.Next();
}

Console.WriteLine("Result: " + result);