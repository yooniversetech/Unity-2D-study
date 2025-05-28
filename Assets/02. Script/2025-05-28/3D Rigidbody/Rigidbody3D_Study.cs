using UnityEngine;

public class Rigidbody3D_Study : MonoBehaviour
{

    /// <summary>
    ///  상호작용하는 두개의 객체중 둘 다 isTrigger = false일 경우 호줄됨
    /// </summary>
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Enter");
    }
    /// <summary>
    /// 상호작용하는 두개의 객체중 둘 중 하나라도 isTrigger = true일 경우 호출됨
    /// </summary>
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }
}
