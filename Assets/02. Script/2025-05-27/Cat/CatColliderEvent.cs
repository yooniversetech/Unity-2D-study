using UnityEngine;

public class CatColliderEvent : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            Debug.Log("Game Over!!!");
        }
    }
}
