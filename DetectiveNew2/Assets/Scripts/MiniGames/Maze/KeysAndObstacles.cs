using UnityEngine;
public class KeysAndObstacles : MonoBehaviour { public GameObject key; public GameObject Obstacle; public AudioSource audioSource;
    public Animator animationDO; public GameObject imageOfKey; public GameObject imageOfObstacle;
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Player2"))  { imageOfKey.SetActive(false); animationDO.SetTrigger("isTriggered"); 
        audioSource.Play(); } }
    private void OnTriggerExit2D(Collider2D other) { Destroy(imageOfObstacle); key.SetActive(false); } 
}