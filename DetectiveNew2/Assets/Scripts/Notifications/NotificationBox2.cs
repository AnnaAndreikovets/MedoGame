using UnityEngine;
// 0 è 2
public class NotificationBox2 : MonoBehaviour { public Animator[] notifications; public bool active; //public bool n;
    private void Start() { active = false; /*n = false; */}
    private void OnTriggerEnter2D(Collider2D other) { if (active == true)
    { if (other.CompareTag("Player")) { foreach (Animator anim in notifications) { anim.SetTrigger("isTriggered");/* n = true; */} } } }
    private void OnTriggerExit2D(Collider2D other) { if (active == true)
    { if (other.CompareTag("Player")) { foreach (Animator anim in notifications) { anim.SetTrigger("isTriggered"); /*n = false; */} } } }
}