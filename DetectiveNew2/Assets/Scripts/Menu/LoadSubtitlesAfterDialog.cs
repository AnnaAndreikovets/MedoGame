using UnityEngine; 
public class LoadSubtitlesAfterDialog : MonoBehaviour { public GameObject visualCue, finalyPanels; public PlayerInventory pi;
    private void Update() { for (int i = 0; i < pi.myInventory.Count; i++) {
        if (visualCue.active == false && pi.myInventory[i].itemName == "CheckBG") { finalyPanels.SetActive(true); } } }
}