using UnityEngine;

public class Play : MonoBehaviour {
    public static bool PlauShow = false; public GameObject imagesUI;
    private void Update() { if (Input.GetKeyDown(KeyCode.P)) { if (PlauShow) { Resume(); } else { OpenPlay(); } } }
    public void Resume() { imagesUI.SetActive(false); PlauShow = false; }
    public void OpenPlay() { imagesUI.SetActive(true); PlauShow = true; }
}
