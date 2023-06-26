using UnityEngine.SceneManagement; using UnityEngine;
public class LoadSecondDay : MonoBehaviour {
    public void LoadCorridorFloor1() { SceneManager.LoadSceneAsync(7); }
    public void LoadRoom3() { SceneManager.LoadSceneAsync(6); }
}