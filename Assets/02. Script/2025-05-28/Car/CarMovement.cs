using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;
    private float h;

    // 키입력은 update메서드에서 대입해서 사용해야되는데 그 이유는 update는 프레임이 훨씬 많아서 키를 입력했을 때 틱당 더 많은 걸 소화함
    // FixedUpdate메서드에서는 60플레임 밖에 나오지 않아 더 느리게 체크해서 손해임
    // 그래서 키입력은 update메서드에서 대입해서 물리적인 Rigidbody 연산은 FixedUpdate메서드에서 하는게 효율적임

    void Update() //성능에 따라 다른 프레임으로 실행되는 유니티 기본 함수
    {
        h = Input.GetAxis("Horizontal"); // Horizontal은 X축으로써 수평값(가로값)

        // X축 값으로 1,2,3 식으로 순간이동하면서 움직이므로 벽을 살짝 뚫고 들어가서 떨리는 이슈발생
        // 1. transform.position += h * moveSpeed * Time.deltaTime * Vector3.right; 
    }

    void FixedUpdate() // 고정 프레임으로 실행되는 유니티 기본 함수
    {
        // Rigidbody 이동
        carRb.linearVelocityX = h * moveSpeed * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("Collision Exit");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collider Enter");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Collider Stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Collider Exit");
    }
}
