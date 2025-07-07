using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private IItemObject item;
    private Image itemImage;
    private Button slotButton;

    public bool isEmpty = true;

    private void Awake()
    {
        slotButton = GetComponent<Button>();
        slotButton.onClick.AddListener(UseItem);

        itemImage = transform.GetChild(0).GetComponent<Image>();
    }

    private void OnEnable() // 오브젝트가 On이 될때마다 실행되는 기능
    {
        //if (isEmpty) // 슬롯 비어있을 때
        //{
        //    slotButton.interactable = false;
        //    itemIcon.gameObject.SetActive(false);
        //}
        //else// 슬롯 차있을 때
        //{
        //    slotButton.interactable = true;
        //    itemIcon.gameObject.SetActive(true);
        //}

        //위 if문을 줄여쓴 코드
        slotButton.interactable = !isEmpty;
        itemImage.gameObject.SetActive(!isEmpty);
    }
       
    public void AddItem(IItemObject newItem)
    {
        item = newItem;
        isEmpty = false;
        itemImage.sprite = newItem.Icon;
        itemImage.SetNativeSize(); // SetNativeSize()
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
            ClearSlot();
        }
    }

    public void ClearSlot()
    {
        item = null;
        isEmpty = true;
        slotButton.interactable = !isEmpty;
        itemImage.gameObject.SetActive(!isEmpty);
    }
}
