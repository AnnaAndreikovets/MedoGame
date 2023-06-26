using UnityEngine; using UnityEngine.Events;
[CreateAssetMenu(fileName = "New ListOgThings", menuName = "ListOfThings/ListOfThings")]
[System.Serializable] // скрипт, отвечающий за создание предметв
public class InventoryItem : ScriptableObject {// public bool usable; public bool Unique; public int numberHeld;
    public string itemName;/* public string itemDescription; public Sprite itemImage;
    public UnityEvent thisEvent;
    public void Use() { if (numberHeld > 0) { Debug.Log("Using Item"); thisEvent.Invoke(); } }
    public void DecreaseAmount(int amountToDecrease)
        { numberHeld -= amountToDecrease; if (numberHeld < 0) { numberHeld = 0; } } */
}