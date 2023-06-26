using UnityEngine; using UnityEngine.SceneManagement;
public class LoadTriggerScene : MonoBehaviour { public int numberScene;
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player"))
        { SceneManager.LoadSceneAsync(numberScene); } }
    private void OnTriggerExit2D(Collider2D other)
    { if (other.CompareTag("Player")) { SceneManager.LoadSceneAsync(numberScene); } }
}