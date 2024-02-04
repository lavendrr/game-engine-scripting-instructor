using TMPro;
using UnityEngine;

public class CalculatorGUI : MonoBehaviour
{
    private Calculator calculator = new Calculator();

    [SerializeField]
    TextMeshProUGUI text;

    private void Start()
    {
        SetDisplayToInput();
    }

    public void AddInput(string input)
    {
        calculator.AddInput(input);
        SetDisplayToInput();
    }

    public void Add()
    {
        calculator.SetEquationType(Calculator.EquationType.ADD);
        calculator.StoreInput();
    }

    public void Subtract()
    {
        calculator.SetEquationType(Calculator.EquationType.SUBTRACT);
        calculator.StoreInput();
    }

    public void Multiply()
    {
        calculator.SetEquationType(Calculator.EquationType.MULTIPLY);
        calculator.StoreInput();
    }

    public void Divide()
    {
        calculator.SetEquationType(Calculator.EquationType.DIVIDE);
        calculator.StoreInput();
    }    

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

    public void FlipSignage()
    {
        calculator.FlipSignage();
        SetDisplayToInput();
    }

    void SetDisplayToValue()
    {
        text.text = calculator.value.ToString();
    }

    void SetDisplayToInput()
    {
        text.text = calculator.input;
    }
}
