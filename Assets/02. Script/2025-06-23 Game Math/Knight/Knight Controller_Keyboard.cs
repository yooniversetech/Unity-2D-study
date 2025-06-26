using UnityEngine;

public class KnightController_Keyboard : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 7f;

    private float atkDamage = 3f;
    private float monHp = 9f;

    private bool isGround;
    private bool isAttack;
    private bool isCombo;

    private void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();

    }
    private void Update() // 
    {
        InputKeyboard();
        Jump();
        Attack();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            Debug.Log($"{atkDamage}로 공격");
        }
    }

    private void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);
    }

    void Move()
    {
        if (inputDir.x != 0)
        {
            knightRb.linearVelocityX = inputDir.x * moveSpeed;

            var scaleX = inputDir.x >= 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

            if (!isAttack)
            {
                isAttack = true;
                atkDamage = 3f;
                animator.SetTrigger("Attack");
            }
            else
            {
                isCombo = true;
            }
        }
    }

    public void CheckCombo()
    {
        Debug.Log("Combo Check");

        if (isCombo == true)
        {
            animator.SetBool("isCombo", true);
            atkDamage = 5f;

        }
        else
        {
            animator.SetBool("isCombo", false);
            isAttack = false;
        }
    }

    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
    }
}
