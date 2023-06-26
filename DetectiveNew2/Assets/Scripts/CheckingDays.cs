using UnityEngine;
public class CheckingDays : MonoBehaviour { public PlayerInventory pi; public GameObject[] Buttons, Fade; public ChooseSceneNumber csn;
    public DialogueManager dialogueManager; public StarsNextDay starsNextDay;
    private void Checking() { if (pi.ListForLoading.Count == 0) { Buttons[0].SetActive(true); Fade[0].SetActive(false); }
        for (int i = 0; i < pi.ListForLoading.Count; i++) {
        if (pi.ListForLoading[i].itemName == "StartSecondDay") { Buttons[1].SetActive(true); Fade[1].SetActive(false); }
        else if (pi.ListForLoading[i].itemName == "StartThirdDay") { Buttons[2].SetActive(true); Fade[2].SetActive(false);
            Fade[1].SetActive(true); Buttons[1].SetActive(false); }
        else if (pi.ListForLoading[i].itemName == "StartFourthDay") { Buttons[3].SetActive(true); Fade[3].SetActive(false); 
            Fade[2].SetActive(true); Buttons[2].SetActive(false); } 
        else if (pi.ListForLoading[i].itemName == "Final") { for (int k = 0; k < Buttons.Length; k++) { Buttons[k].SetActive(false); }
                for (int j = 0; j < Fade.Length; j++) { Fade[j].SetActive(true); Debug.Log("Set"); } } } }
    public void ResetProgress() { pi.ListForLoading.Clear(); csn.numberScene = 1; csn.SaveCl(); starsNextDay.ResetScriptables(); 
        starsNextDay.ResetScriptables2(); starsNextDay.ResetScriptables3(); Checking(); pi.myInventory.Clear(); pi.myInventory2.Clear(); pi.myStars.Clear();
        Buttons[3].SetActive(false); Fade[3].SetActive(true);}
    public void ResetProgressTheLastDay(){ csn.numberScene = 26; csn.SaveCl(); starsNextDay.ResetScriptables();
        starsNextDay.ResetScriptables2(); starsNextDay.ResetScriptables3(); pi.myInventory.Clear(); pi.myInventory2.Clear(); pi.myStars.Clear();
        for (int i = 0; i < pi.ListForLoading.Count; i++) { if (pi.ListForLoading[i].itemName == "Final") { pi.ListForLoading.RemoveAt(i); } } Checking(); }
    private void Start() => Checking();
}