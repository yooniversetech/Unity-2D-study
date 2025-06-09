using UnityEngine;
using Cat;

public class Catcontroller : MonoBehaviour
{
    public SoundManager soundManager;

    private Rigidbody2D catRb;
    private Animator catAnim;
    public float jumpPower = 10f;
    public float limitJumpPower = 10f;

    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 3) // 스페이스 키 입력 //isGround가 true일 때 점프하도록 했기때문에 점프가 한번밖에 안됨
        {
            catAnim.SetTrigger("Jump");
            catAnim.SetBool("IsGround", false);

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
            soundManager.OnJumpSound();

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);

            if (catRb.linearVelocityY > limitJumpPower)
            {
                catRb.linearVelocityY = limitJumpPower;
            }

            var catRotation = transform.eulerAngles;
            catRotation.z = catRb.linearVelocityY * 5f;
            transform.eulerAngles = catRotation;


        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("IsGround", true);
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
