using UnityEngine;

public class ObjectMouseEvent : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
    }
    private void OnMouseOver()
    {
        Debug.Log("Mouse Over");
    }
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
    }
    private void OnMouseDrag()
    {
        Debug.Log(Input.mousePosition);

        Debug.Log("Mouse Drag");
    }
    private void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("Mouse UpAsButton");
    }
    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }
}
