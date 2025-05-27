using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    // public Material mat;

    public string hexCode;
    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material을 바꾸는 방식 X

        // 1. this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer에 접근해서 바꾸는 방식

        // 2. this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer에 접근해서 바꾸는 방식

        // 3. this.GetComponent<MeshRenderer>().material.color = Color.green; // MeshRenderer에 

        // 4. this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        // this.GetComponent<MeshRenderer>().materials // materials는 material배열이다.

        // this.GetComponent<MeshRenderer>().material.color = new Color(150f/255f, 0f, 150f/255f, 1f);

        Material mat = this.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }
    }
}
