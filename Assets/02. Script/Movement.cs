using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        }

    }
}
