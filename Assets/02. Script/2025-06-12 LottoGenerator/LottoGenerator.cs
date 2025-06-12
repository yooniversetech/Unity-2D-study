using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LottoGenerator : MonoBehaviour
{
    //public int[] intArray = new int[10];

    public List<int> intList = new List<int>();

    public int shackCount = 10000;

    private void Awake()
    {
        for (int i = 1; i <= 45; i++)
        {
            intList.Add(i);
        }
    }

    IEnumerator Start()
    {
        for (int i = 0; i < shackCount; i++)
        {
            int ranIndex1 = Random.Range(0, intList.Count);
            int ranIndex2 = Random.Range(0, intList.Count);

            var temp = intList[ranIndex1];
            intList[ranIndex1] = intList[ranIndex2];
            intList[ranIndex2] = temp;

            yield return new WaitForSeconds(0.001f);
        }

        List<int> resultGroup = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            resultGroup.Add(intList[i]);
        }
        resultGroup.Sort();

        string resultNumber = $"이번 주 로또 번호 : {resultGroup[0]} / {resultGroup[1]} / {resultGroup[2]} / {resultGroup[3]} / {resultGroup[4]} / {resultGroup[5]} / 보너스 넘버 : {intList[6]}";

        Debug.Log(resultNumber);
    }
}

