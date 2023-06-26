using UnityEngine; //короче, заходим на сцену и надо поговорить, а после этого можно обследовать    
public class InspectTheCrimeScene2 : MonoBehaviour { public PlayerInventory pi; public GameObject[] itemsForInspection;
    int num1 = 0, num2 = 0, num3 = 0, num4; public GameObject triggerVc, arrowExit, justAnArrow;
    public void CheckConv() {  for (int i = 0; i < pi.myInventory.Count; i++) { if (pi.myInventory[i].itemName == "MurderMaks2") {
        for (int p = 0; p < itemsForInspection.Length; p++) { itemsForInspection[p].SetActive(true); } }
            if (pi.myInventory[i].itemName == "InspectTheCrimeScene2") { arrowExit.SetActive(true); justAnArrow.SetActive(false); num4 = 1; }}} 
    public void ClickOnTheFlowerBeds() { num1++; CheckOnConv(); }
    public void ClickOnTheBody() { num2++; CheckOnConv(); }
    public void ClickOnTheTrees() { num3++; CheckOnConv(); }
    public void CheckOnConv() { if (num1 >= 1 && num2 >= 1 && num3 >= 1 && num4 != 1) { triggerVc.SetActive(true); } }
    private void Update() => CheckConv();
}