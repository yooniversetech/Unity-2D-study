using UnityEngine;

public class Gun : MonoBehaviour, IDropItem
{
    public void Drop()
    {
        Debug.Log("라이트 버림");
    }

    public void Grab()
    {
        Debug.Log("라이트 습득");
    }

    public void Use()
    {
        Debug.Log("총 발사!");
    }
}