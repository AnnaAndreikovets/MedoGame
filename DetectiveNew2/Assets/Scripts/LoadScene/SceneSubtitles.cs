using UnityEngine;
public class SceneSubtitles : MonoBehaviour { public PlayerInventory pi; public TakeAnItemOnce take; public GameObject buttonReset;
    private void Start() { for (int i = 0; i < pi.ListForLoading.Count; i++) { if (pi.ListForLoading[i].itemName == "Final") { buttonReset.SetActive(true); }
            for (int p = 0; p < pi.myInventory.Count; p++) { if (pi.myInventory[p].itemName == "Final") { buttonReset.SetActive(true); } } } }
}