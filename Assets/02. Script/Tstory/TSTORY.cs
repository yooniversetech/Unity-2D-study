using UnityEngine;

public class StudyUnityEventCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}