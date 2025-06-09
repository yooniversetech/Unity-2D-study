using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Study_Coroutine : MonoBehaviour
{
    private bool isStop = false;
    private void Start()
    {
        StartCoroutine(BombRoutine());
    }

    IEnumerator BombRoutine()
    {
        int t = 10;
        while (t > 0)
        {
            Debug.Log($"{t}초 남았습니다.");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop == true)
            {
                Debug.Log("폭탄이 해제되었습니다");
                yield break;
            }
        }

        Debug.Log("폭탄이 터졌습니다.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
    }


































    //private Coroutine runningCoroutine;

    //private IEnumerator Start()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1f); // 1초마다 실행되는 루틴 Update메서드를 사용하면 컴퓨터에 부하가 심할 수 있는데 Update메서드로 확인하는 방법이 싫다면 코루틴으로 마치 Update메서드 대신에 사용하면 더 효율적이다

    //        Debug.Log("코루틴 실행");
    //    }
    //}
    //private void Update() // 매 프레임마다 실행되는 메서드
    //{
    //    Debug.Log("업데이트 실행");
    //}

    //private IEnumerator Start() // IEnumerator변수로 Start 를 사용하면 Start메서드에서 실행되는 코루틴을 한번에 할 수 있도록 만들어 두었음
    //{
    //    yield return new WaitForSeconds(2f);
    //    Debug.Log("1");
    //}
    //private void Start()
    //{
    //    StartCoroutine("RoutineA");
    //    StartCoroutine(RoutineA(10, 20, 30));
    //    runningCoroutine = StartCoroutine(RoutineB());

    //    StopCoroutine("RoutineA"); // O
    //    StopCoroutine(RoutineB()); // X
    //    StopCoroutine(runningCoroutine); // O
    //    StopAllCoroutines(); // 코드상에 있는 모든 코루틴 정지

    //    StartCoroutine()
    //}

    //IEnumerator RoutineA(int num1, int num2, int num3) // 대기를 할 수 있는 기능
    //{
    //    yield return new WaitForSeconds(2f); // 한 프레임 대기
    //    Debug.Log(num1);

    //    yield return new WaitForSeconds(2f); // 한 프레임 대기
    //    Debug.Log(num2);

    //    yield return new WaitForSeconds(2f); // 한 프레임 대기
    //    Debug.Log(num3);
    //}

    //IEnumerator RoutineB() // 대기를 할 수 있는 기능
    //{
    //    yield return new WaitForSeconds(2f); // 한 프레임 대기
    //    Debug.Log("코루틴 실행");

    //    yield return new WaitForSeconds(2f); // 한 프레임 대기
    //    Debug.Log("강상윤");

    //    yield return new WaitForSeconds(2f); // 한 프레임 대기
    //    Debug.Log("코루틴");
    //}
}
