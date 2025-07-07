using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public GameObject inventoryUI;
    public Button InventoryButton;

    [SerializeField] private GameObject[] items;

    [SerializeField] private Transform slotGroup;
    public Slot[] slots;

    private void Start()
    {
        slots = slotGroup.GetComponentsInChildren<Slot>(true); // true로 주면 setActive(false)도 전부 가져오는 기능

        InventoryButton.onClick.AddListener(OnInventory);
    }
    public void OnInventory()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }

    public void DropItem(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);

        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        itemRb.AddForceY(3f, ForceMode2D.Impulse);
        itemRb.AddForceX(Random.Range(-2f, 2), ForceMode2D.Impulse);

        float ranPower = Random.Range(-1.5f, 1.5f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }

    public void GetItem(IItemObject item)
    {
        foreach (var slot in slots)
        {
            if (slot.isEmpty)
            {
                slot.AddItem(item);
                break; // break를 안걸어 주면 아이템 하나만 먹어도 모든 슬롯에 전부 그 아이템으로 다 채워지는 버그 발생
            }
        }
    }
}
