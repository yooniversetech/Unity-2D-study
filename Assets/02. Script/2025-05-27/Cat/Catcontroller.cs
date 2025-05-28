using UnityEngine;

public class Catcontroller : MonoBehaviour
{
    private Rigidbody2D catRb;
    public float jumpPower = 10f;

    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 3) // 스페이스 키 입력 //isGround가 true일 때 점프하도록 했기때문에 점프가 한번밖에 안됨
        {
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

            isGround = false;
        }
    }
}
