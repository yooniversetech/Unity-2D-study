using System;
using UnityEngine;

public class CastingStudy : MonoBehaviour
{
    private void Start()
    {
        bool isBool1 = true;
        bool isBool2 = false;

        int num1 = Convert.ToInt32(isBool1);
        int num2 = Convert.ToInt32(isBool2);

        Debug.Log(num1);
        Debug.Log(num2);
    }
}
