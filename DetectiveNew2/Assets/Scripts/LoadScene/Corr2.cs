using UnityEngine; using UnityEngine.SceneManagement;
public class Corr2 : MonoBehaviour { private LoadSecondDay loadSecondDay;
    private void Start() { loadSecondDay =  GetComponent<LoadSecondDay>(); }
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player"))
        { SceneManager.LoadSceneAsync(7); } }
    private void OnTriggerExit2D(Collider2D other)
    { if (other.CompareTag("Player")) { SceneManager.LoadSceneAsync(7); } }
}