using UnityEngine;
public class AddState : MonoBehaviour { [SerializeField] private InventoryItem thisState; public PlayerInventory List;
    public void TakeState() { List.ListForLoading.Add(thisState); }
} 