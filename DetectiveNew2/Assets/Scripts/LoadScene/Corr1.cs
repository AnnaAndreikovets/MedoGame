using UnityEngine.SceneManagement; using UnityEngine;
public class Corr1 : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {if(other.CompareTag("Player")) { SceneManager.LoadSceneAsync(3); } }
    private void OnTriggerExit2D(Collider2D other) {if(other.CompareTag("Player")) { SceneManager.LoadSceneAsync(3);}} 
}