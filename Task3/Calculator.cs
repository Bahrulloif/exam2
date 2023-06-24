public class Calculator
{
    private double _firstNum;
    private double _secondNum;
    public Calculator(double a, double b)
    {
        _firstNum = a;
        _secondNum = b;
    }
    public string Sum()
    {
        return $"{_firstNum}+{_secondNum}={_firstNum + _secondNum}";
    }
    public string Subtract()
    {
        return $"{_firstNum}-{_secondNum}={_firstNum - _secondNum}";
    }

    public string Multiplication()
    {
        return $"{_firstNum}*{_secondNum}={_firstNum * _secondNum}";
    }
    public string Division()
    {
        return $"{_firstNum}/{_secondNum}={_firstNum / _secondNum}";
    }
}