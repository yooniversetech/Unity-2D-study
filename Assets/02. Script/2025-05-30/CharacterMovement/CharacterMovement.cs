using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D characterRb;
    public SpriteRenderer[] renderers;

    public float moveSpeed;
    public float jumpPower = 5f;
    private float hori;

    private bool isJump;
    private bool isGround;
    


    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }
    private void Update()
    {
        hori = Input.GetAxis("Horizontal"); // 키 입력(Horizontal이므로 좌우 3차원에서는 오른쪽 왼쪽의 값인 x축을 조작하는 것)


        Jump();
    }


    private void FixedUpdate()
    {
        Move();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;

        renderers[2].gameObject.SetActive(false);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;

        renderers[0].gameObject.SetActive(false);
        renderers[1].gameObject.SetActive(false);
        renderers[2].gameObject.SetActive(true);

    }
    /// <summary>
    /// 캐릭터가 움직임에 따라 이미지의 flip(보는 방향)의 상태가 변하는 기능
    /// </summary>
    private void Move()
    {
        if (hori != 0) // 입력 키를 누를 때
        {
            if (isGround)
            {
                renderers[0].gameObject.SetActive(false);
                renderers[1].gameObject.SetActive(true);
            }
            else
            {
                renderers[0].gameObject.SetActive(false);
                renderers[1].gameObject.SetActive(false);
            }

            characterRb.linearVelocityX = hori * moveSpeed; // 물리적인 이동

            if (hori > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
            else if (hori < 0)
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }
        }
        else if (hori == 0)// 입력 키를 누르지 않을 때
        {
            if (isGround)
            {
                renderers[0].gameObject.SetActive(true);
                renderers[1].gameObject.SetActive(false);
            }
            else
            {
                renderers[0].gameObject.SetActive(false); // Idle
                renderers[1].gameObject.SetActive(false); // Run
            }
        }
    }

    /// <summary>
    /// Space바를 누르면 캐릭터가 Y축으로 점프하는 기능
    /// </summary>
    private void Jump()
    {
        if (Input.GetButtonDown("Jump")) // Input.GetKeyDown(KeyCode.Space);와 같음
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
}
