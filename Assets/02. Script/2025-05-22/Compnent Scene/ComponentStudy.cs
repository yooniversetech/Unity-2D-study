using UnityEditor;
using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    public GameObject obj; // GameObject는 class타입이므로 obj는 참조형 타입임.

    public Transform objTf;


    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;

        obj.GetComponent<MeshRenderer>().enabled = false;
        obj.SetActive(false);
    }
}