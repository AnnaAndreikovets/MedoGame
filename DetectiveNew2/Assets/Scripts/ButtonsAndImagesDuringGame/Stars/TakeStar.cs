using UnityEngine;
public class TakeStar : MonoBehaviour { [SerializeField] private Star thisStar;
    public StarsManager inventory; public PlayerInventory playerInventory;
    private void Start() { if(inventory) inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<StarsManager>(); }
    public void TakeAStar() { if (inventory) { for (int p = 0; p < inventory.cells.Length; p++) {
        if (inventory.isFull[p] == false) { playerInventory.myStars.Add(thisStar); 
        inventory.isFull[p] = true; StarCell newCell = inventory.cells[p].GetComponent<StarCell>();
        if (newCell) { newCell.Setup(thisStar); break; } } } } else { playerInventory.myStars.Add(thisStar); } }
}