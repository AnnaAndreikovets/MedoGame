using UnityEngine;
public class CanvasButtons : MonoBehaviour { public void LoadInstagram() => Application.OpenURL("https://www.instagram.com/lepur_gaming/");
    public void QuitGame() {Application.Quit(); }
}