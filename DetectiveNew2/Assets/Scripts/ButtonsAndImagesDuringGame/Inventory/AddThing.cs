using UnityEngine;
public class AddThing : MonoBehaviour { [SerializeField] private InventoryItem thisThing; public GameObject Thing; public PlayerInventory deletedList;
    public void TakeAThinhg() { deletedList.myInventory.Add(thisThing); Thing.SetActive(false); }
    public void TakeAThinhg2() { deletedList.myInventory.Add(thisThing); }
} 