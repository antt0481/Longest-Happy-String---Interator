public class FunIterator : IFunIterator
{
    private List<string> _a;
    private List<string> _b;
    private List<string> _c;
    private string prev2 = "";
    private string prev1 = "";
    private string currentValue = "";


    public FunIterator(int numberOfA, int numberOfB, int numberOfC)
    {
        _a = Enumerable.Repeat("a", numberOfA).ToList();
        _b = Enumerable.Repeat("b", numberOfB).ToList();
        _c = Enumerable.Repeat("c", numberOfC).ToList();
    }

    public bool IsDone()
    {
        CheckNext();

        return string.IsNullOrEmpty(currentValue);
    }

    public string Next()
    {
        return currentValue;
    }

    public void CheckNext()
    {
        if (!string.IsNullOrEmpty(prev1) && prev1.Equals(prev2))
        {
            switch (prev1)
            {
                case "a":
                    getNext(_b, _c);
                    break;
                case "b":
                    getNext(_a, _c);
                    break;
                case "c":
                    getNext(_a, _b);
                    break;
            }
        }
        else if ((string.IsNullOrEmpty(prev1) && string.IsNullOrEmpty(prev2)) || !prev1.Equals(prev2))
        {
            getNext();
        }
    }

    private void getNext(List<string> input1, List<string> input2)
    {
        currentValue = "";

        if (input1.Count > 0 && input1.Count >= input2.Count)
        {
            currentValue = input1[0];
            input1.RemoveAt(0);
        }
        else if (input2.Count > 0 && input2.Count >= input1.Count)
        {
            currentValue = input2[0];
            input2.RemoveAt(0);
        }

        prev2 = prev1;
        prev1 = currentValue;
    }

    private void getNext()
    {
        currentValue = "";

        if (_a.Count > 0 && _a.Count >= _b.Count && _a.Count >= _c.Count)
        {
            currentValue = _a[0];
            _a.RemoveAt(0);
        }


        if (_b.Count > 0 && _b.Count >= _a.Count && _b.Count >= _c.Count)
        {
            currentValue = _b[0];
            _b.RemoveAt(0);
        }

        if (_c.Count > 0 && _c.Count >= _a.Count && _c.Count >= _b.Count)
        {
            currentValue = _c[0];
            _c.RemoveAt(0);
        }


        prev2 = prev1;
        prev1 = currentValue;
    }
}