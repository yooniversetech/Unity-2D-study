using System.Runtime.CompilerServices;
using UnityEngine;

public class MathLerp : MonoBehaviour
{
    public Vector3 targetPos;
    public float smootValue;

    private Vector3 startPos;
    private float timer, percent;
    public float lerpTime;

    private void Start()
    {
        startPos = transform.position;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        percent = timer / lerpTime;

        transform.position = Vector3.Lerp(startPos, targetPos, percent);
    }
}

