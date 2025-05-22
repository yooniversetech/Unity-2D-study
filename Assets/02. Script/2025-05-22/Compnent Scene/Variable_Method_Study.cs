using UnityEngine;

public class Variable_Method_Study : MonoBehaviour
{
    public int AddResult;
    void Start()
    {
        Debug.Log(AddReturn(10, 20));
        AddNoReturn(100, 200);
        Debug.Log(AddResult);
    }

    public int AddReturn(int a, int b) // 반환 타입이 int인 함수 ()내부에 있는 변수 a, b는 매개변수
    {
        AddResult = a + b;
        return AddResult;
    }

    public void AddNoReturn(int a, int b) // 반환 타입이 (void이기때문)없는 함수
    {
        AddResult = a + b; // 반환타입이 없더라도 매개변수는 선언해서 사용가능함
    }

    public int AddReturn(int a)
    {
        return a;
    }

    public void OnMethod(int a)
    {
        
    }

    public void OnMethod(string a)
    {

    }

    public void OnMethod(float a)
    {

    }
}
