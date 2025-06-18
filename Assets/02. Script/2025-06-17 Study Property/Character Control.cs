using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    private IDropItem currentItem;

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Transform grabPos;

    private void Update()
    {
        Move();
        Interaction();
    }
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v).normalized;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    private void Interaction()
    {
        if (currentItem == null)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentItem.Drop();
            currentItem = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDropItem>() != null)
        {
            var item = other.GetComponent<IDropItem>();
            currentItem = item;

            currentItem.Grab(grabPos);
        }
    }
}
