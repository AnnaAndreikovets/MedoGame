using UnityEngine; using UnityEngine.UI;
public class TImerScript : MonoBehaviour { Image timerBar; public float maxTime = 10; float timeLeft; public ChangeTextOfConversation changeTextOfConversation;
    public AudioSource audioSource;
    void Start() { timerBar = GetComponent<Image>(); timeLeft = maxTime; }
    void Update() { if (timeLeft > 0) { timeLeft -= Time.deltaTime; timerBar.fillAmount = timeLeft / maxTime; } 
        else { Time.timeScale = 1f; if (changeTextOfConversation.valueOfChoice == 0) { changeTextOfConversation.num2 = 1; 
                changeTextOfConversation.objectsForAnimations[1].SetActive(false); 
            changeTextOfConversation.valueOfChoice = 4; changeTextOfConversation.anim[2].SetTrigger("isTriggered"); 
                changeTextOfConversation.anim[0].SetTrigger("Push"); changeTextOfConversation.anim[5].SetTrigger("isTriggered");
                changeTextOfConversation.anim[3].SetTrigger("isTriggered" + changeTextOfConversation.chooseClothes.numberClothes); 
                changeTextOfConversation.OnPanel(); } } }
}