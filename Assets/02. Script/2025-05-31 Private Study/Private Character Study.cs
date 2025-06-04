using JetBrains.Annotations;
using UnityEngine;

public class PrivateCharacterStudy : MonoBehaviour
{
    private Rigidbody2D characterRb;
    private SpriteRenderer[] characterSR;

    public float moveSpeed = 3f; // 이동속력 조정을 위한 변수
    public float jumpPower;
    private float horizontalMove; // Input.GetAxis("Horizontal")를 담기위한 변수

    private bool groundCheck;



    public void Start( )
    {
        characterRb = GetComponent<Rigidbody2D>(); // Rigidbody2D로 평면상에서의 물리간섭을 위함.

        characterSR = GetComponentsInChildren<SpriteRenderer>(true);
    }

    public void Update()
    {
        Jump();
    }

    public void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        groundCheck = true;

        characterSR[0].gameObject.SetActive(true);
        characterSR[1].gameObject.SetActive(false);
        characterSR[2].gameObject.SetActive(false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        groundCheck = false;

        characterSR[0].gameObject.SetActive(false);
        characterSR[1].gameObject.SetActive(false);
        characterSR[2].gameObject.SetActive(true);
    }


    public void Move()
    {
        horizontalMove = Input.GetAxis("Horizontal"); // 의 x축의 방향을 ad키로 조작하기 위해서 대입
        characterRb.linearVelocityX = moveSpeed * horizontalMove; // 이제 방향 * 속력 을 하여 직접적으로 물리적인 힘인 속도를 적용시킴

        if (horizontalMove != 0) // 움직일 때
        {
            if (!groundCheck) // 점프 하고 달릴 때
            {
                characterSR[0].gameObject.SetActive(false);
                characterSR[1].gameObject.SetActive(false);
                characterSR[2].gameObject.SetActive(true);
            }
            else // 점프 안하고 달릴때
            {
                characterSR[0].gameObject.SetActive(false);
                characterSR[1].gameObject.SetActive(true);
                characterSR[2].gameObject.SetActive(false);
            }

            if (horizontalMove > 0)
            {
                for (int i = 0; i < characterSR.Length; i++)
                {
                    characterSR[i].flipX = false;
                }
            }
            else
            {
                for (int i = 0; i < characterSR.Length; i++)
                {
                    characterSR[i].flipX = true;
                }
            }
        }
        else // 가만히 있을 때
        {
            if (groundCheck) // 점프 안하고 가만히 있을 때
            {
                characterSR[0].gameObject.SetActive(true);
                characterSR[1].gameObject.SetActive(false);
                characterSR[2].gameObject.SetActive(false);
            }
            //if (!groundCheck) // 점프 하고 가만히 있을 때
            //{
            //    characterSR[0].gameObject.SetActive(true);
            //    characterSR[1].gameObject.SetActive(false);
            //    characterSR[2].gameObject.SetActive(false);
            //}
        }
    }
    public void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            characterRb.AddForceY(jumpPower,ForceMode2D.Impulse);
        }
    }
}
