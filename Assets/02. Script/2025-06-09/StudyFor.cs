using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class StudyFor : MonoBehaviour
{
    // public int[] arrayInt = new int[5];

    //public List<int> listInt = new List<int>();
    //private void Start()
    //{
    //    for (int i = 0; i < listInt.Count; i++)
    //    {
    //        Debug.Log(listInt[i]);
    //    }
    //}

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"{i} / {j}");
            }
        }
    }
}
