public class Calculator2
{
    public string input { get; private set; }
    public float value { get; private set; }

    private EquationType equationType = EquationType.None;

    public Calculator2()
    {
        Clear();
    }

    public string AddInput(string c)
    {
        if (input == "0") input = c;
        else input += c;

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
            case EquationType.ADD:          returnVal = Add(inputVal); break;
            case EquationType.SUBTRACT:     returnVal = Subtract(inputVal); break;
            //TODO: Add MULTIPLY Case
            //TODO: ADD DIVIDE Case
            case EquationType.None:
            default: returnVal = inputVal; break;
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
        //TODO: set value to be the difference of 'value' and 'val'
        //TODO: replace 0 with variable called value
        return 0;
    }


    //TODO: Add a function called Multiply that returns the mulitple of 'value' and a passed in argument called 'val'
    //      Similar to the Add and Subtract functions

    //TODO: Add a function called Divide that returns the quotient of 'value' and a passed in argument called 'val'
    //      Similar to the Add and Subtract functions

    public void Clear()
    {
        //TODO: Reset the value of input to 0
        //TODO: Reset the value of value to 0
        //TODO: Reset the equationType to None
        input = "0";
        value = 0;
        equationType = EquationType.None;
    }

    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2
        //TODO: Create a new EquationType called MULTIPLY
        //TODO: Create a new EquationType called DIVIDE
    }
}
