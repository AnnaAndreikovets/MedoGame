/* короче, надо будет добавить на кнопки в подвале и на кнопку выйти из коридора получение значения финала
 *я много раз прожимаю кнопку погреба и поэтому он попросту может начать играть музыку, которая не относится к сцене погреба 
 */
using UnityEngine; using UnityEngine.UI;
public class MadeChoice : MonoBehaviour { public Corr corr; public int num; public GameObject Arrow1, Arrow2;
    public PlayerInventory pi; public GameObject[] Things; public Text textOfDescription; public string[] descriptions; 
    public void PlayFinal() { for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "OpenBag") { num = 1; }
        if (pi.myInventory[i].itemName == "PlayFinal") { Things[6].SetActive(true);
        int agreementShare = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("agreementShare")).value; if (agreementShare != 0) {
            Things[0].SetActive(false); Things[1].SetActive(true); Things[2].SetActive(false); Things[3].SetActive(true); 
                    Things[4].SetActive(false); Things[5].SetActive(true); } } } }
    private void Start() { for (int i = 0; i < pi.myInventory.Count; i++) {  if (pi.myInventory[i].itemName == "OpenBag") { num = 1; }
            if (pi.myInventory[i].itemName == "PlayFinal") { PlayFinal(); } if (pi.myInventory[i].itemName == "Final") { Things[6].SetActive(false); } } }
    public void ChangeDescription(int num) { textOfDescription.text = descriptions[num]; if (num == 5 || num == 6) { Arrow1.SetActive(false); Arrow2.SetActive(true); } }
    public void SetElizabet() { if (num == 0) { Things[7].SetActive(true); } else if (num == 1) { Things[8].SetActive(true); } }
    public void LoadFinalAA() { corr.number = 4; corr.SavePos(); }
}