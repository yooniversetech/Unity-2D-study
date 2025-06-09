using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    public float returnPosX = 15f;

    public float randomPosY;
    //public float height;

    //public Vector3 returnPos;

    //private void Start()
    //{
    //    returnPos = new Vector3(60f, height, 0f);
    //}

    private void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; // 배경을 왼쪽으로 이동하는 기능


        if (transform.position.x <= -returnPosX) 
        {
            randomPosY = Random.Range(-8, -3);

            transform.position = new Vector3(returnPosX, randomPosY, -0.1f); 
        }
    }
}
