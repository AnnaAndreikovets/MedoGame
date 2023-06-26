using UnityEngine;
public class StarsSecondDay : MonoBehaviour { public PlayerInventory pi; int[] nums = new int[17]; public TakeStar takeStar; 
    private void Update() { Check(); Checking(); }
    public void Check() { for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "MuderKetrin") { nums[0] = 1; }
            else if (pi.myInventory[i].itemName == "MurderMaks") { nums[1] = 1; } else if (pi.myInventory[i].itemName == "murderWilson") { nums[2] = 1; }
            else if (pi.myInventory[i].itemName == "murderSmit") { nums[3] = 1; } else if (pi.myInventory[i].itemName == "murderAdam") { nums[4] = 1; }
            else if (pi.myInventory[i].itemName == "murderAlex") { nums[5] = 1; } else if (pi.myInventory[i].itemName == "MuderAlbert") { nums[6] = 1; }
            else if (pi.myInventory[i].itemName == "MurderAnzela") { nums[7] = 1; } else if (pi.myInventory[i].itemName == "MurderSofia") { nums[8] = 1; }
            else if (pi.myInventory[i].itemName == "MurderElizabet") { nums[9] = 1; } else if (pi.myInventory[i].itemName == "Board") { nums[10] = 1; }
            else if (pi.myInventory[i].itemName == "Star1") { nums[11] = 1; } else if (pi.myInventory[i].itemName == "gold2") { nums[12] = 1; } } }
    public void Checking() { if (nums[0] == 1 && nums[1] == 1 && nums[2] == 1 && nums[3] == 1 && nums[4] == 1 && nums[5] == 1 && nums[6] == 1 && nums[7] == 1
        && nums[8] == 1 && nums[9] == 1 && nums[10] == 1 && nums[11] == 1 && nums[12] == 1) { for (int p = 0; p < pi.myStars.Count; p++) {
            if (pi.myStars != null && pi.myStars[p].nameOfItem == "Star2") { goto Path2; } } takeStar.TakeAStar(); Path2:; }}
}