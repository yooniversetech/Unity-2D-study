using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class MonsterObject : MonoBehaviour
{
    public List<int> intList = new List<int>();
    public List<GameObject> objList = new List<GameObject>();
    public List<Vector3> vecList = new List<Vector3>();
    public List<bool> boolList = new List<bool>();
    public List<GameObject> objList = new List<GameObject>();
    private void Start()
    {
        Monster m = new Monster();
        Orc o1 = (Orc)m; // 명시적 형변환 일단 컴파일 오류는 없음
        //Orc o2 = m; // 암시적 형변환 컴파일 오류

        Orc o = m as Orc; // 성공시 형변환이 이뤄짐 / 실패시 null 값 반환
        Debug.Log(o);

        if (o != null) // 예외 처리 / 예외처리를 하면 에러를 나더라도 프로그램이 멈추지 않고 로그만 찍어낸 뒤에 아래 부분을 실행함(보다 안전하게 코드를 사용할 수 있음)
        {
            Debug.Log(o);
        }
        else
        {
            Debug.Log("형변환 실패");
        }

        GetComponent<GameObject>().
    }
}
