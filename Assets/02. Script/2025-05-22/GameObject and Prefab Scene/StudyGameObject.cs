using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    void Start()
    {
        Debug.Log("생성되었습니다");
        CreateAmongus();

        Destroy(destroyObj, 3f); // Plane이라는 땅 오브젝트를 3초뒤에 파괴되는 기능(destroyObj는 현제 코드에서는 아무것도 참조하지 않았으나 유니티엔진의 인스펙터창의 컴포넌트로 Plane오브젝트를 참조하도록 설정하였음) (뒤에 오는 3f가 3초를 나타냄)
    }

    public void OnDestroy()
    {
        Debug.Log("파괴되었습니다");
    }

    /// <summary>
    /// 빨간색 어몽어스 캐릭터 생성 및 이름 변경 기능
    /// </summary>
    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "어몽어스 캐릭터";
    }
}
