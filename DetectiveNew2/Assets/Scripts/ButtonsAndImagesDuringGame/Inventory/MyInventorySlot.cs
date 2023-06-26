using UnityEngine; using UnityEngine.UI;
public class MyInventorySlot : MonoBehaviour{ [SerializeField] private Image itemImage; public MyItem thisItem;
    private InventoryCase inventory;
    private void Start() { inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryCase>(); }
    public void Setup(MyItem newItem)
    { thisItem = newItem; if (thisItem) { itemImage.sprite = thisItem.itemImage; } }
    public void ClickedOn() { inventory.ShowImageOfDescription(); if (thisItem)
        { inventory.SetupDescriptionAndButton(thisItem.itemDescription, thisItem.usable, thisItem);}}
}