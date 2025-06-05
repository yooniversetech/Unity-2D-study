using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    private void Update()
    {
        MouseClickEvent();
    }

    /// <summary>
    /// 마우스 클릭 이벤트 Down, up, 눌렸을 때 3가지의 예시
    /// </summary>
    private void MouseClickEvent()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button Down");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse Button");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Button Up");
        }
    }
}
