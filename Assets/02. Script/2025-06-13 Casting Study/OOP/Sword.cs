using JetBrains.Annotations;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float damage = 10f;
    private void OnTriggerEnter(Collider other)
    {
        // 감지된 대상에게 IDamageable이 있다면
        if (other.GetComponent<IDamageable>() != null)
        {
            other.GetComponent<IDamageable>().TakeDamage(10f);
        }
    }
}
