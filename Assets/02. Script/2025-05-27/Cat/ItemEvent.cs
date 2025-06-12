using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType { Pipe, Apple, Both }
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject apple;
    public GameObject particle;

    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;

    private Vector3 initPos;

    private void Awake()
    {
        initPos = transform.localPosition;

        //randomPosY = Random.Range(-8f, -3.5f);
        //transform.position = new Vector3(transform.position.x, randomPosY, -0.1f);
    }

    private void OnEnable()
    {
        SetRandomSetting(initPos.x);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; // 배경을 왼쪽으로 이동하는 기능


        if (transform.position.x <= -returnPosX)
        {
            SetRandomSetting(returnPosX);

            //randomPosY = Random.Range(-8, -3);
            //transform.position = new Vector3(returnPosX, randomPosY, -0.1f);
        }
    }

    private void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(-8f, -3.5f);
        transform.position = new Vector3(posX, randomPosY, -0.1f);

        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);

        colliderType = (ColliderType)Random.Range(0, 3);

        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                break;
            case ColliderType.Apple:
                apple.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;
        }

        float a = 3.14f;
        int b = 5;

        a = (float)b;
    }
}
