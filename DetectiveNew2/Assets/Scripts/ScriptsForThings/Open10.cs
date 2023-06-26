using UnityEngine;

public class Open10 : MonoBehaviour {
    public static bool IsOpen = false; public GameObject ImageUI;
    private void Update() { if (Input.GetKeyDown(KeyCode.Escape)) { if (IsOpen) { Resume(); } else { Open(); } } }
    public void Resume() { ImageUI.SetActive(false); IsOpen = false; }
    public void Open() { ImageUI.SetActive(true); IsOpen = true; }
}
