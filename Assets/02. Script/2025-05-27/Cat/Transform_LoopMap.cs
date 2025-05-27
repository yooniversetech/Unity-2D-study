using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float height;

    public Vector3 returnPos;

    private void Start()
    {
        returnPos = new Vector3(60f, height, 0f);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime; // 배경을 왼쪽으로 이동하는 기능


        if (transform.position.x <= -60f) // 이미지의 x축값이 -60을 넘는 순간
        {
            transform.position = returnPos; // 다시 사용하기 위해서 오른쪽 x = 30으로 초기화
        }
    }
}
