using UnityEngine;
// 1 è 3
public class NotificationBox3 : MonoBehaviour { public Animator[] notifications; public bool active; //public bool n;
    private void Start() { active = false; /*n = false; */}
    private void OnTriggerEnter2D(Collider2D other) { if (active == true)
    { if (other.CompareTag("Player")) { foreach (Animator anim in notifications) { anim.SetTrigger("isTriggered");/* n = true; */} } } }
    private void OnTriggerExit2D(Collider2D other) { if (active == true)
    { if (other.CompareTag("Player")) { foreach (Animator anim in notifications) { anim.SetTrigger("isTriggered"); /*n = false; */} } } }
}