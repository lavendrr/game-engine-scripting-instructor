using TMPro;
using UnityEngine;

public class CalculatorGUI2 : MonoBehaviour
{
    private Calculator2 calculator = new Calculator2();

    [SerializeField]
    TextMeshProUGUI text;

    private void Start()
    {
        SetDisplayToInput();
    }

    public void AddInput(string input)
    {
        //
        calculator.AddInput(input);
        SetDisplayToInput();
    }

    public void Add()
    {
        calculator.SetEquationType(Calculator2.EquationType.ADD);
        calculator.StoreInput();
    }

    public void Subtract()
    {
        //TODO: Set calculate equation type to SUBTRACT
        //TODO: Store the current input
    }

    //TODO: Add a function called Multiply that sets the calculator state to multiply and stores the current input
    //      Similar to the Add and Subtract functions

    //TODO: Add a function called Divide that sets the calculator state to multiply and stores the current input
    //      Similar to the Add and Subtract functions

    public void Calculate()
    {
        calculator.Calculate();
        SetDisplayToValue();
    }

    public void Clear()
    {
        calculator.Clear();
        SetDisplayToInput();
    }


    void SetDisplayToValue()
    {
        //TODO: Set the text value of the text object to be the current value of the calculator
        //      Hint: Google how to convert a float to a string
        //text.text = REPLACE_ME_WITH_THE_CORRECT_CODE
    }

    void SetDisplayToInput()
    {
        //TODO: Set the text value of the text object to be the current input of the calculator
        //text.text = REPLACE_ME_WITH_THE_CORRECT_CODE
    }
}
