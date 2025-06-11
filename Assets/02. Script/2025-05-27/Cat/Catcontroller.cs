using UnityEngine;
using Cat;
using UnityEngine.Rendering.Universal;

public class Catcontroller : MonoBehaviour
{
    public SoundManager soundManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    public GameObject happyVideo; // 성공 영상을 담을 변수
    public GameObject sadVideo; // 실패 영상을 담을 변수

    private Rigidbody2D catRb;
    private Animator catAnim;

    public float jumpPower = 10f;
    public float limitJumpPower = 10f;

    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 5) // 스페이스 키 입력 //isGround가 true일 때 점프하도록 했기때문에 점프가 한번밖에 안됨
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;

            if (GameManager.score == 10) // 성공 페이드
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white);

                this.GetComponent<CircleCollider2D>().enabled = false;

                Invoke("HappyVideo", 5f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipe")) // 실패 페이드
        {
            soundManager.OnColliderSound();

            gameOverUI.SetActive(true); // 게임 오버 켜기
            fadeUI.SetActive(true); // 페이드 켜기
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black); // 페이드 실행

            this.GetComponent<CircleCollider2D>().enabled = false;

            Invoke("SadVideo", 5f);

        }

        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("IsGround", true);
            jumpCount = 0;
        }
    }

    public void HapppyVideo()
    {
        happyVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    public void SadVideo()
    {
        happyVideo.SetActive(false);
        fadeUI.SetActive(true);
        gameOverUI.SetActive(true);

        soundManager.audioSource.mute = false;
    }
}
