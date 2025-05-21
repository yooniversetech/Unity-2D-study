using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    //public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };

    //public List<int> listNumber = new List<int>();

    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;

    [SerializeField] private int number5 = 5;
    
    void Start()
    {
        //Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        //Debug.Log($"Array의 두번째 값 : {arrayNumber[1]}");
        //Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        //Debug.Log($"Array의 네번째 값 : {arrayNumber[3]}");
        //Debug.Log($"Array의 다섯번째 값 : {arrayNumber[4]}");
        //Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}");

        //listNumber.Add(10);// 첫번째 인덱스에 10이라는 값을 넣음.
        //listNumber.Add(20);
        //listNumber.Add(30);
        //listNumber.Add(40);
        //listNumber.Add(50);

        //Debug.Log($"현제 List에 있는 데이터 수 : {listNumber.Count}");
        //Debug.Log($"현제 List에 있는 마지막 데이터 : {listNumber[listNumber.Count - 1]}");

        //Debug.Log($"List의 첫번째 값 : {listNumber[0]}");
        //Debug.Log($"List의 두번째 값 : {listNumber[1]}");
        //Debug.Log($"List의 세번째 값 : {listNumber[2]}");
        //Debug.Log($"List의 네번째 값 : {listNumber[3]}");
        //Debug.Log($"List의 다섯번째 값 : {listNumber[4]}");
        //Debug.Log($"List의 여섯번째 값 : {listNumber[5]}");
    }
}
