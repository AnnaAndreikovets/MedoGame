using UnityEngine.SceneManagement; using UnityEngine;
public class ContinueButton : MonoBehaviour { private int sceneToContinue; public int numberOfScene;
    public void loadChamberMH() { SceneManager.LoadScene(1); }
    public void loadSecondDay() { SceneManager.LoadScene(6); }
    public void loadCorridorFloor2() { SceneManager.LoadScene(8); }
    public void loadChamber() { SceneManager.LoadScene(9); }
    public void loadRoom1() { SceneManager.LoadScene(12); }
    public void loadRoom3SecondDay_2() { SceneManager.LoadScene(13); }
    public void loadSPA() { SceneManager.LoadScene(10); }
    public void loadRecretionRoom() { SceneManager.LoadScene(11); }
    public void LoadSceneWhichChoosen() { SceneManager.LoadScene(numberOfScene); }
    public void ContinueGame() { sceneToContinue = PlayerPrefs.GetInt("SavedScene"); if (sceneToContinue != 0) 
            SceneManager.LoadScene(sceneToContinue); else return; }
}