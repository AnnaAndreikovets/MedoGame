using UnityEngine;
public class StarsThirdDay : MonoBehaviour { public PlayerInventory pi; int[] nums = new int[11]; public TakeStar takeStar, takeStar2; 
    private void Update() { Checking(); }     
    public void Checking() { for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "MurderAnzela2") { nums[0] = 1; }
        if (pi.myInventory[i].itemName == "MurderAlbert2") { nums[1] = 1; } if (pi.myInventory[i].itemName == "MurderAlex2") { nums[2] = 1; }
        if (pi.myInventory[i].itemName == "MurderSmit2") { nums[3] = 1; } if (pi.myInventory[i].itemName == "2MurderSofia&Elizabet") { nums[4] = 1; }
        if (nums[2] == 1 && nums[1] == 1 && nums[0] == 1 && nums[3] == 1 && nums[4] == 1) { for (int p = 0; p < pi.myStars.Count; p++) { 
            if (pi.myStars != null && pi.myStars[p].nameOfItem == "Star3") { goto Path1; } } takeStar.TakeAStar(); Path1:; }
        if (pi.myInventory[i].itemName == "Alex4") { nums[5] = 1; } if (pi.myInventory[i].itemName == "OpenSafe") { nums[6] = 1; }
        if (pi.myInventory[i].itemName == "Level2") { nums[7] = 1; } if (pi.myInventory[i].itemName == "FuseOnScene") { nums[8] = 1; }
        if (pi.myInventory[i].itemName == "PutFuse2") { nums[9] = 1; } if (pi.myInventory[i].itemName == "PutFuse3") { nums[10] = 1; }
        if (nums[2] == 1 && nums[1] == 1 && nums[0] == 1 && nums[3] == 1 && nums[4] == 1 && nums[5] == 1 && nums[6] == 1 && nums[7] == 1 &&
            nums[8] == 1 && nums[9] == 1 && nums[10] == 1 ) { for (int p = 0; p < pi.myStars.Count; p++) {
        if (pi.myStars != null && pi.myStars[p].nameOfItem == "Star2") { goto Path2; } } takeStar2.TakeAStar(); Path2:; } } }
}