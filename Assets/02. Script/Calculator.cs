using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;

    void Start()
    {
        Debug.Log(AddMethod(5, 5));
        Debug.Log(MinusMethod(10, 5));
    }

    public int AddMethod(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    public int MinusMethod(int number1, int number2)
    {
        int result = number1 - number2;
        return result;
    }
}
