public class Fun : IFunAggregate
{
    private int _numberOfA;
    private int _numberOfB;
    private int _numberOfC;
    public Fun(int numberOfA, int numberOfB, int numberOfC)
    {
        _numberOfA = numberOfA;
        _numberOfB = numberOfB;
        _numberOfC = numberOfC;
    }

    public IFunIterator CreateIterator()
    {
        return new FunIterator(_numberOfA, _numberOfB, _numberOfC);
    }
}