using UnityEngine; [System.Serializable]
public class StarsManager : MonoBehaviour { public bool[] isFull; public GameObject[] cells;
    public PlayerInventory myStars; public Star currentItem;
    public void LoadAPlayerInventory() { if (myStars) { for (int i = 0; i < myStars.myStars.Count; i++)
                for (int p = 0; p < cells.Length; p++) { if (isFull[p] == false) {
                        isFull[p] = true; StarCell newSlot = cells[p].GetComponent<StarCell>();
                        if (newSlot) { newSlot.Setup(myStars.myStars[i]); break; } } } } }
    public void ResetStarsInventory() { if (myStars) { for (int i = 0; i < myStars.myStars.Count; i++)
        for (int p = 0; p < cells.Length; p++) { isFull[p] = false;  StarCell newSlot = cells[p].GetComponent<StarCell>();
            if (newSlot) { newSlot.Setup(currentItem); break; } } } }
    private void Start() { LoadAPlayerInventory(); }
}