using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Study_Invoke : MonoBehaviour
{
    public int count = 10;
    private void Start()
    {
        //Invoke("Method1", timer);

        //CancelInvoke("Method1");

        // 반복 Invoke ("함수명", 처음지연시간, 몇초마다 실행할지의 시간)  
        InvokeRepeating("Bomb", 0f, 2f);
    }

    private void Bomb()
    {
        Debug.Log($"현제 남은 시간 : {count}");
        count--;

        if (count == 0)
        {
            Debug.Log("폭탄이 터졌습니다.");
            CancelInvoke("InvokeRepeating");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Bomb");
            Debug.Log("폭탄이 해제되었습니다");
        }
    }
}
