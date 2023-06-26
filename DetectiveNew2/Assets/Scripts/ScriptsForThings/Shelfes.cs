using UnityEngine;

public class Shelfes : MonoBehaviour {
    public static bool IsOpen = false; public GameObject ImageUI;
    private void Update() { if (Input.GetKeyDown(KeyCode.Escape)) { if (IsOpen) { Resume(); } else { Open(); } } }
    public void Resume() { ImageUI.SetActive(false); Time.timeScale = 1f; IsOpen = false; }
    public void Open() { ImageUI.SetActive(true); Time.timeScale = 0f; IsOpen = true; }
}