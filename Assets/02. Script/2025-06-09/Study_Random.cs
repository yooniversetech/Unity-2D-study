using UnityEngine;

public class Study_Random : MonoBehaviour
{
    private void OnEnable()
    {
        int ranNumber = Random.Range(0, 100);

        Debug.Log(ranNumber);
    }
}
