using UnityEngine;
public class ActiveCaseAndList : MonoBehaviour { public PlayerInventory myList; public GameObject[] case_; public GameObject mainTasks; public Animator anim;
    private void Start() { CheckingCase(); CheckingListMainTasks(); CheckingButtons(); }
    public void CheckingCase() { if (myList.ValueOfSound[1].itemName == "off") { case_[0].SetActive(false); case_[1].SetActive(false);
        case_[2].SetActive(true); } else { case_[0].SetActive(true); case_[1].SetActive(true); case_[2].SetActive(false); } }
    public void CheckingButtons() { if (myList.ValueOfSound[3].itemName == "off") { anim.SetTrigger("Resume"); } else { anim.SetTrigger("isTriggered"); } }
    public void CheckingListMainTasks() { if (myList.ValueOfSound[2].itemName == "off") { mainTasks.SetActive(false); } else { mainTasks.SetActive(true); } }
    public void ChangeActiveListOfTasks() { if(myList.ValueOfSound[2].itemName == "off") { myList.ValueOfSound[2].itemName = "on"; }
    else { myList.ValueOfSound[2].itemName = "off"; } CheckingListMainTasks(); }
    public void ChangeActiveCase() { if(myList.ValueOfSound[1].itemName == "off") { myList.ValueOfSound[1].itemName = "on"; }
    else { myList.ValueOfSound[1].itemName = "off"; } CheckingCase(); }
    public void ChangeActiveButtons() { if(myList.ValueOfSound[3].itemName == "off") { myList.ValueOfSound[3].itemName = "on"; }
    else { myList.ValueOfSound[3].itemName = "off"; } }
}