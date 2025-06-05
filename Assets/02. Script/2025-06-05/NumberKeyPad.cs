using UnityEngine;

public class NumberKeyPad : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject doorLock;

    public string password; // 비밀번호 설정
    public string keyPadNumber; // 패널로 게임상에서 입력한 숫자

    public void OnInputNumber(string numString)
    {
        keyPadNumber += numString;

        Debug.Log($"{numString} 입력 -> 현재 입력 : {keyPadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            doorAnim.SetTrigger("Door Slide Open");
            doorLock.SetActive(false);
        }
        else
        {
            keyPadNumber = "";
            Debug.Log("비밀번호가 틀렸습니다");
        }
    }
}
