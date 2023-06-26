using UnityEngine;
public class DIalogTrigger_ : MonoBehaviour { [SerializeField] private GameObject visualCue;
    private bool playerInRange; [SerializeField] private TextAsset inkJSON; public DialogueManager dialogueManager;
    private void Awake() { playerInRange = false; visualCue.SetActive(false); }
    private void OnTriggerEnter2D(Collider2D collider) { if (collider.gameObject.tag == "Player") { playerInRange = true; visualCue.SetActive(true); } }
    private void OnTriggerExit2D(Collider2D collider) { if (collider.gameObject.tag == "Player") { playerInRange = false; visualCue.SetActive(false); } }
    public void OnDialogue() { playerInRange = true; visualCue.SetActive(true); }
    public void OffDialogue() { playerInRange = false; visualCue.SetActive(false); }
    private void Update() { if (playerInRange) { visualCue.SetActive(true); } else { visualCue.SetActive(false); } }
    public void StartStory() { DialogueManager.GetInstance().EnterDialogueMode(inkJSON); Time.timeScale = 0f; dialogueManager.DisplayChoices();}
}