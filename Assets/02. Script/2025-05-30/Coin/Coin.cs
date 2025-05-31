using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("코인 획득!!");
            Vector3Movement.coinCount++;
            Debug.Log($"현제 점수 : {Vector3Movement.coinCount}");

            Destroy(gameObject);

        }
    }
}
