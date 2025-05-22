using UnityEngine;

public class CreateCubeStudy : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        CreatCube();
        CreatCube("Hello World!");
    }

    public void CreatCube(string name = "Cube")
    {
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.GetComponent<BoxCollider>();
    }
}
