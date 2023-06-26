using UnityEngine;
public class NotificationBox : MonoBehaviour {public Animator[] notifications; public bool active;
    private void Start() { active = true;}
    private void OnTriggerEnter2D(Collider2D other) { if (active == true) { if (other.CompareTag("Player"))
            { foreach (Animator anim in notifications) { anim.SetTrigger("isTriggered"); } } } }
    private void OnTriggerExit2D(Collider2D other) { if (active == true) { if (other.CompareTag("Player"))
            { foreach (Animator anim in notifications) { anim.SetTrigger("isTriggered"); } } } }
}