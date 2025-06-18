using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    public SpawnManager spawnManager;

    private SpriteRenderer sRenderer;
    private Animator animator;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;

    private int dir = 1;
    private bool isMove = true;
    private bool isHit = false;

    public abstract void Init();

    private void Start()
    {
        spawnManager = FindFirstObjectByType<SpawnManager>();

        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        Init();
    }
    private void OnMouseDown()
    {
        //Hit(1);
        StartCoroutine(Hit(1));
    }
    private void Update()
    {
        Move();
    }

    void Move()
    {
        if (!isMove)
            return;

        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            sRenderer.flipX = true;
            dir = -1;
        }
        else if (transform.position.x < -8f)
        {
            sRenderer.flipX = false;
            dir = 1;
        }

    }

    IEnumerator Hit(float damage)
    {
        if (isHit)
            yield break;

        isHit = true;
        isMove = false;


        hp -= damage;

        if (hp == 0)
        {
            animator.SetTrigger("Death");
            spawnManager.DropCoin(transform.position); // 죽을 때 코인이 생성되는 기능

            yield return new WaitForSeconds(3f);
            gameObject.SetActive(false);

            yield break;
        }

        animator.SetTrigger("Hit");

        yield return new WaitForSeconds(0.7f);

        isMove = true;
        isHit = false; 
    }
}
