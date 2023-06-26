using UnityEngine;
public class ShowArrowInTheAnotherScene : MonoBehaviour { public GameObject arrow;
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player")) arrow.SetActive(true); }
    private void OnTriggerExit2D(Collider2D other) { if (other.CompareTag("Player")) arrow.SetActive(false); }
}