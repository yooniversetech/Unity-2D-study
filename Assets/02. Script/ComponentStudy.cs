using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    GameObject obj;

    public string changeName;


    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}
