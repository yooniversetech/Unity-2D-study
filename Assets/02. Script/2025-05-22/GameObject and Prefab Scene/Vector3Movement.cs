using UnityEngine;

public class Vector3Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Update()
    {
        /// Input System (Old - Legacy방식이라 지칭함)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        // 아래는 방향이 전환될 때 부드럽게 움직임
        float h = Input.GetAxis("Horizontal"); // X축의 값 (Horizontal = 가로 = 왼쪽,오른쪽)
        float v = Input.GetAxis("Vertical");   // Z축의 값 (Vertical = 세로 = 앞, 뒤)

        // 아래는 방향이 전환될 때 딱딱 끊기면서 이동
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log(dir);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
