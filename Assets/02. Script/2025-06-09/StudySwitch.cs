using JetBrains.Annotations;
using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum Calculationtype { Plus, Minus, Multiplay, Devide}
    public Calculationtype calculationtype = Calculationtype.Plus;

    public int input1, input2, result;

    private void Start()
    {
        Debug.Log($"계산 결과 : {Calculation()}");
    }

    private int Calculation()
    {
        switch (calculationtype)
        {
            case Calculationtype.Plus:
                result = input1 + input2;
                break;
            case Calculationtype.Minus:
                result = input1 - input2;
                break;
            case Calculationtype.Multiplay:
                result = input1 * input2;
                break;
            case Calculationtype.Devide:
                result = input1 / input2;
                break;
        }
        return result;
    }
}
