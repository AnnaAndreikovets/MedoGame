using UnityEngine; 
public class ChangeTextOfConversation : MonoBehaviour {int num = 1; public int num2 = 0; public GameObject[] dialogBoxes, objectsForAnimations, panels; public Animator[] anim;
    public int valueOfChoice = 0; public PlayerInventory pi; public ChooseClothes chooseClothes; public AudioSource audioSource; float time_ = 0.00000001f;
    public void ChangeDescription() { if (num == 8) { dialogBoxes[7].SetActive(false); anim[0].SetTrigger("isTriggered");
            objectsForAnimations[0].SetActive(false); objectsForAnimations[1].SetActive(true); objectsForAnimations[2].SetActive(false); } else {
        dialogBoxes[num - 1].SetActive(false); dialogBoxes[num].SetActive(true); num++; 
// анимации: 0 - поднятие оружия алекс, а так же выстрел алекса, 1 - выстрел гг, 2 - выключение гг 3 - наша смерть 4 - смерть алекса 5 - затемнение
    //objectForAnim // 0 - алекс // 1 - конвас с отсчётом // 2 - кнопка диалоговая // 3 - алекс с аниматором поднятия оружия
        } }
    public void MakeChoice1() { num2 = 1; for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "Gun") { valueOfChoice = 1;
        anim[2].SetTrigger("isTriggered"); anim[1].SetTrigger("isTriggered" + chooseClothes.numberClothes); objectsForAnimations[1].SetActive(false);
            anim[4].SetTrigger("isTriggered"); objectsForAnimations[3].SetActive(false);anim[5].SetTrigger("isTriggered");/* OnPanel(); */time_ = 0.04f;
            int relationshipAnzela = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("relationshipAnzela")).value;
            if (relationshipAnzela >= 7) { valueOfChoice = 6; } OnPanel(); return; } }  valueOfChoice = 5; objectsForAnimations[1].SetActive(false); 
        anim[3].SetTrigger("isTriggered" + chooseClothes.numberClothes); anim[2].SetTrigger("isTriggered"); anim[0].SetTrigger("Push");
        anim[5].SetTrigger("isTriggered"); OnPanel(); audioSource.Play(); }
    public void MakeChoice2() { num2 = 1;valueOfChoice = 2; objectsForAnimations[1].SetActive(false); anim[5].SetTrigger("isTriggered");
        anim[2].SetTrigger("isTriggered");  anim[0].SetTrigger("Push"); anim[3].SetTrigger("isTriggered" + chooseClothes.numberClothes); OnPanel(); }
    public void MakeChoice3() { num2 = 1;valueOfChoice = 3; objectsForAnimations[1].SetActive(false); anim[5].SetTrigger("isTriggered");
        anim[2].SetTrigger("isTriggered"); anim[0].SetTrigger("Push"); anim[3].SetTrigger("isTriggered" + chooseClothes.numberClothes); OnPanel(); }
    public void OnPanel() { panels[valueOfChoice - 1].SetActive(true); }
    private void Update() { if (num2 == 1) { time_ -= Time.deltaTime; if (time_ <= 0) { audioSource.Play(); num2 = 0; } } }
    public void ResetInvenotory() => pi.myInventory2.Clear();
}