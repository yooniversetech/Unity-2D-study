using UnityEngine;

public class TransformMovementStudy : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = -70f;

    void Update()
    {
        // 월드기준 Z방향(앞, 뒤)으로 이동하는 기능
        // 1. transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬기준 Z방향으로 이동
        // 2. transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 3. transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, angleZ);

        // 4. transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); //로컬 방향 회전 (Space.Self 생략된거임)

        // 5. transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World); // 월드 방향 회전

        // 6. transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime); // 월드 (0, 1, 0) 축주위로 회전

        transform.LookAt(Vector3.zero); // (0, 0, 0)을 바라보며 회전
    }
}
