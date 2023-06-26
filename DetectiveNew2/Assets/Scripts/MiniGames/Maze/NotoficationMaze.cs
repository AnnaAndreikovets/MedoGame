using UnityEngine;
public class NotoficationMaze : MonoBehaviour { public GameObject notification;
    private void OnTriggerEnter2D(Collider2D other)
    { if (other.CompareTag("Player2")) { notification.SetActive(true); } }
    private void OnTriggerExit2D(Collider2D other)
    { if (other.CompareTag("Player2")) { notification.SetActive(false); } }
} 