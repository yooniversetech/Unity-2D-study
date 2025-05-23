using UnityEngine;

public class Create_Amongus : MonoBehaviour
{
    public GameObject prefab;

    void Awake()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;
    }
}