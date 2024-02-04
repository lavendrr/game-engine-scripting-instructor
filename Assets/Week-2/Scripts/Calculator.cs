public class Calculator
{
    public string input { get; private set; }
    public float value { get; private set; }

    private float tempValue;

    private EquationType equationType = EquationType.None;

    public Calculator() 
    {
        Clear();
    }

    public string AddInput(string c)
    {
        if (input == "0")   input = c;
        else                input += c;

        return input;
    }

    public void SetEquationType(EquationType equationType)
    {
        this.equationType = equationType;
    }

    public void StoreInput()
    {
        value = float.Parse(input);
        input = "0";
    }

    public float Calculate()
    {
        float inputVal = float.Parse(input);
        float returnVal = 0;
        input = "0";

        switch (equationType)
        {
            case EquationType.ADD:      returnVal = Add(inputVal);      break;
            case EquationType.SUBTRACT: returnVal = Subtract(inputVal); break;
            case EquationType.MULTIPLY: returnVal = Multiply(inputVal); break;
            case EquationType.DIVIDE:   returnVal = Divide(inputVal);   break;
            case EquationType.None:
            default:                    returnVal = inputVal;           break;
        }

        equationType = EquationType.None;
        return returnVal;
    }

   public float Add(float val)
   {
        value += val;
        return value;
   }

    public float Subtract(float val)
    {
        value -= val;
        return value;
    }

    public float Multiply(float val)
    {
        value *= val;
        return value;
    }

    public float Divide(float val)
    {
        value /= val;
        return value;
    }

    public void FlipSignage()
    {
        if(input == "0")       return;

        //If first character is - then current input is negative
        //Simply remove the - character to change to positive
        if (input[0] == '-')    input = input.Substring(0, 1);
        else                    input = input.Insert(0, "-");
    }

    public void Clear()
    {
        input = "0";
        value = 0;
        equationType = EquationType.None;
    }

    public enum EquationType
    { 
        None        = 0,
        ADD         = 1,
        SUBTRACT    = 2,
        MULTIPLY    = 3,
        DIVIDE      = 4        
    }
}
