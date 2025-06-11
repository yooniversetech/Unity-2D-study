using System.Collections;
using UnityEngine;

public class StudyUnityEventCycle : MonoBehaviour
{
    IEnumerator Wait_A_Second()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("1초 대기");

        yield return new WaitForSeconds(2f);
        Debug.Log("2초 대기");

        yield return new WaitForSeconds(3f);
        Debug.Log("3초 대기");
    }
}