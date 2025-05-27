using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    public bool Stop = false;

    private void Start()
    {
        rotSpeed = 0f;
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime); // Z축 기준으로 회전하는 기능

        if (Input.GetMouseButtonDown(0))  // 마우스 왼쪽 버튼을 눌렀을 때 룰렛이 돌아가기 시작하는 기능
        {
            rotSpeed = 500f; // 마우스 왼쪽 버튼을 눌렀을 때 룰렛이 돌아가는 속도
        }
        if (Input.GetKeyDown(KeyCode.Space)) // 스페이스바를 한번만 눌러도 계속해서 누르는 기능
        {
            Stop = true;
        }
        if (Stop == true) // 스페이스바가 눌렸다면 0.98씩 곱해져서 서서히 감속하는 기능
        {
            rotSpeed *= 0.098f;
        }
        if (rotSpeed < 0.1f) // 돌아가는 속도가 0.1보다 작다면 0으로 확실히 멈추게 하는기능
        {
            rotSpeed = 0;
        }
    }
}
