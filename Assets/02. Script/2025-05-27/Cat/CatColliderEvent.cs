using UnityEngine;

public class CatColliderEvent : MonoBehaviour
{
    public GameObject fadeUI;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            fadeUI.SetActive(true);
        }
    }
}
