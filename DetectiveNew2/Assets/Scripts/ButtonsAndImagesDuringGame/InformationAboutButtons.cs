using UnityEngine; using UnityEngine.UI; using UnityEngine.SceneManagement;
public class InformationAboutButtons : MonoBehaviour { public Image imageOfButton; public Sprite[] ImagesOfButtons; 
    public Text textOfDescription; public int num; public string[] descriptions; public GameObject HelpCanvas;
    public void ChangeImageAndDes() { if (num == 8 && SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1)) { HelpCanvas.SetActive(false); num--;
        return; } else if (num == 8 && SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(38)) { SceneManager.LoadSceneAsync(0); num--;
        } num++; imageOfButton.sprite = ImagesOfButtons[num]; textOfDescription.text = descriptions[num]; }
}