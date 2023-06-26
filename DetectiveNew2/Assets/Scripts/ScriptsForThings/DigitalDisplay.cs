using UnityEngine.UI; using UnityEngine;
public class DigitalDisplay : MonoBehaviour {  [SerializeField] private Sprite[] digits; [SerializeField] private Image[] characters;
    public static bool IsOpenW = false; public GameObject ImageUIWrong;  public static bool IsOpen = false; public GameObject ImageUIChestIn; int num;
    public static bool IsOpenC = false; public GameObject ImageUICorrect; public TakeAnItemOnce take; public string CorrectCode;
    public CheckFourthDay checkFourthDay; public Animator anim; public GameObject panelWithLock; public AudioSource audioSourceCorrect ,audioSourceWrong; 
    private void OpenChest() { if(ImageUIChestIn)ImageUIChestIn.SetActive(true); IsOpen = true; } 
    private void OpenW() { if(ImageUIWrong)ImageUIWrong.SetActive(true); IsOpenW = true; }
    private void OpenC() { if (ImageUICorrect)ImageUICorrect.SetActive(true); IsOpenC = true; }
    private void ResumeW() { if (ImageUIWrong)ImageUIWrong.SetActive(false); IsOpenW = false; }
    private void ResumeC() { if (ImageUICorrect)ImageUICorrect.SetActive(false); IsOpenC = false; } 
    private string codeSequence;
    private void Start() { codeSequence = ""; for (int i = 0; i <= characters.Length - 1; i++) { characters[i].sprite = digits[10]; }
        PushTheButton.ButtonPressed += AddDigitToCodeSequence; }
    private void AddDigitToCodeSequence(string digitEntered) {
        if (codeSequence.Length < 4) {
            switch (digitEntered) {
                case "Zero": codeSequence += "0"; DisplayCodeSequence(0); break;
                case "One": codeSequence += "1"; DisplayCodeSequence(1); break;
                case "Two": codeSequence += "2"; DisplayCodeSequence(2); break;
                case "Three": codeSequence += "3"; DisplayCodeSequence(3); break;
                case "Four": codeSequence += "4"; DisplayCodeSequence(4); break;
                case "Five": codeSequence += "5"; DisplayCodeSequence(5); break;
                case "Six": codeSequence += "6"; DisplayCodeSequence(6); break;
                case "Seven": codeSequence += "7"; DisplayCodeSequence(7); break;
                case "Eight": codeSequence += "8"; DisplayCodeSequence(8); break;
                case "Nine": codeSequence += "9"; DisplayCodeSequence(9); break; } }
        switch (digitEntered) { case "Star": ResetDisplay(); break; case "Hash": if (codeSequence.Length > 0) CheckResults(); PlaySound(); break; }
    }
    private void DisplayCodeSequence(int digitJustEntered) { switch (codeSequence.Length) {
            case 1: characters[0].sprite = digits[10]; characters[1].sprite = digits[10]; characters[2].sprite = digits[10];
                characters[3].sprite = digits[digitJustEntered]; break;
            case 2: characters[0].sprite = digits[10]; characters[1].sprite = digits[10];
                characters[2].sprite = characters[3].sprite; characters[3].sprite = digits[digitJustEntered]; break;
            case 3: characters[0].sprite = digits[10]; characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite; characters[3].sprite = digits[digitJustEntered]; break;
            case 4: characters[0].sprite = characters[1].sprite; characters[1].sprite = characters[2].sprite;
                characters[2].sprite = characters[3].sprite; characters[3].sprite = digits[digitJustEntered]; break; } }
    public float timeW; public float timeC;
    void PlaySound() { if (codeSequence != CorrectCode) { audioSourceWrong.Play(); } else { audioSourceCorrect.Play(); } }
    private void CheckResults() { if (codeSequence == CorrectCode) { OpenC(); } else { ResetDisplay(); OpenW(); } }
    private void Update() { if (codeSequence != CorrectCode) { timeW -= Time.deltaTime; if (timeW <= 0) { ResumeW(); timeW = 2; } }
        if (codeSequence == CorrectCode) { if (panelWithLock) panelWithLock.SetActive(false);
            take.CheckIfTook2(); timeC -= Time.deltaTime; if (timeC <= 0) { ResumeC(); OpenChest(); timeC = 2; 
            if(CorrectCode == "9423") { checkFourthDay.Checking(); anim.SetTrigger("isTriggered"); }}}}
    private void ResetDisplay() { for (int i = 0; i <= characters.Length - 1; i++) { characters[i].sprite = digits[10]; } codeSequence = ""; }
    private void OnDestroy() => PushTheButton.ButtonPressed -= AddDigitToCodeSequence;
}