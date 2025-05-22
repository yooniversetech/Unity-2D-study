using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float destroyTime = 3f;
    void Start()
    {
        Destroy(GameObject.Find("Cube"), destroyTime); // this는 자기자신을 가리키므로 3초위 자기자신을 파괴하는 기능

        Destroy(GameObject.Find("Capsule"), (destroyTime * 2)); // this는 자기자신을 가리키므로 3초위 자기자신을 파괴하는 기능

        Destroy(GameObject.Find("Sphere"), (destroyTime * 3)); // this는 자기자신을 가리키므로 3초위 자기자신을 파괴하는 기능
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다");
    }
}
