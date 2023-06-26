using UnityEngine;

public class Chest2 : MonoBehaviour {
    public static bool IsOpen = false; public GameObject ImageUI; 
    public void Resume() { ImageUI.SetActive(false); IsOpen = false; }
    public void Open() { ImageUI.SetActive(true); IsOpen = true; }
}
