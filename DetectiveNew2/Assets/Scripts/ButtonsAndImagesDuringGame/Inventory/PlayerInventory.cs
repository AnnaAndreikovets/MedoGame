using System.Collections.Generic; using UnityEngine; [System.Serializable] [CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/Player Inventory")]
// скрипт, отвечающий за создание инвенатрь игрока 
public class PlayerInventory : ScriptableObject { public List<InventoryItem> myInventory = new List<InventoryItem>();
    public List<MyItem> myInventory2 = new List<MyItem>(); public List<Star> myStars = new List<Star>();
    public List<InventoryItem> ListForLoading = new List<InventoryItem>(); public List<InventoryItem> ValueOfSound = new List<InventoryItem>();
}