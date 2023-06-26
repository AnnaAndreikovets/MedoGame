using UnityEngine.SceneManagement; using UnityEngine;

public class StartButton : MonoBehaviour { public void StartGame() { SceneManager.LoadScene(1); } }
//public void LoadGame() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0); }}
