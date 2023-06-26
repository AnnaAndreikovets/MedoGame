using UnityEngine;
public class CheckOnActiveSafe : MonoBehaviour { public GameObject[] thingsWhishUnactive; public PlayerInventory pi; public GameObject safe, panelForSafe;
    public void isOpen() { for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "OpenSafe") {
        safe.SetActive(true); panelForSafe.SetActive(true);
        for (int p = 0; p < thingsWhishUnactive.Length; p++) { thingsWhishUnactive[p].SetActive(false); } } } }
}