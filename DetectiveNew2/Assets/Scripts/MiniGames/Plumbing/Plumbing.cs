using UnityEngine;
public class Plumbing : MonoBehaviour { public ClickOnTheTube[] position_; public AddThing addThing; public GameObject PanelSolved;
    public PlayerInventory pi;
    public void CheckRightPosition() { for (int i = 0; i < position_.Length; i++) {
        if (position_[0].num == 2 && position_[1].num == 1 && position_[2].num == 2 && position_[3].num == 0 && position_[4].num == 1
        && position_[5].num == 1 && position_[6].num == 3 && position_[7].num == 1 && position_[8].num == 1 && position_[9].num == 3

        && position_[10].num == 1 && position_[11].num == 0 && position_[12].num ==2 && position_[13].num == 0 && position_[14].num == 0
        && position_[15].num == 0 && position_[16].num == 0 && position_[17].num == 2 && position_[18].num == 0 && position_[19].num == 3

        && position_[20].num == 2 && position_[21].num == 1 && position_[22].num == 3 && position_[23].num == 0 && position_[24].num == 3
        && position_[25].num == 1 && position_[26].num == 3 && position_[27].num == 0 && position_[28].num == 1 && position_[29].num == 2

        && position_[30].num == 0 && position_[31].num == 1 && position_[32].num == 3 && position_[33].num == 1 && position_[34].num == 1
        && position_[35].num == 1 && position_[36].num == 2) { for (int p = 0; p < pi.myInventory.Count; p++) {
                    if (pi.myInventory[p].itemName == "Level1") { return; } }
                addThing.TakeAThinhg2(); PanelSolved.SetActive(true); } } }
    public void CheckRightPosition2() { for (int i = 0; i < position_.Length; i++) { if ( position_[0].num == 0 
            && position_[1].num == 0 && position_[2].num == 3 && position_[3].num == 0 && position_[4].num == 0 
            && position_[5].num == 0 && position_[6].num == 0 && position_[7].num == 3 && position_[8].num == 1 
            && position_[9].num == 3 && position_[10].num == 0 && position_[11].num == 0 && position_[12].num == 3 
            && position_[13].num == 1 && position_[14].num == 0 && position_[15].num == 3 && position_[16].num == 2 
            && position_[17].num == 1 && position_[18].num == 0 && position_[19].num == 3 && position_[20].num == 1 
            && position_[21].num == 1 && position_[22].num == 1 && position_[23].num == 0 && position_[25].num == 1 
            && position_[26].num == 3 && position_[27].num == 0 && position_[28].num == 1 && position_[29].num == 0 
            && position_[30].num == 2 && position_[31].num == 0 && position_[32].num == 2 && position_[33].num == 0
            && position_[34].num == 3 && position_[35].num == 2 && position_[36].num == 0 && position_[38].num == 2 
            && position_[39].num == 0 && position_[40].num == 0 && position_[41].num == 0 && position_[42].num == 3 
            && position_[43].num == 0 && position_[44].num == 0 && position_[45].num == 1 && position_[46].num == 0
            && position_[47].num == 0 && position_[48].num == 2 && position_[49].num == 0 && position_[50].num == 1
            && position_[51].num == 0 && position_[52].num == 2 && position_[53].num == 0 && position_[54].num == 2
            && position_[55].num == 1 && position_[56].num == 3 && position_[57].num == 0 && position_[58].num == 2
            && position_[59].num == 2 && position_[60].num == 1 && position_[61].num == 1 && position_[62].num == 0
            && position_[63].num == 3 && position_[64].num == 0 && position_[65].num == 0 && position_[66].num == 3
            && position_[67].num == 2 && position_[68].num == 1 && position_[69].num == 1 && position_[70].num == 1
            && position_[71].num == 0 && position_[72].num == 0 && position_[73].num == 2 && position_[74].num == 1
            && position_[75].num == 0 && position_[76].num == 2 && position_[77].num == 1 && position_[78].num == 0
            && position_[79].num == 0 && position_[80].num == 0 && position_[81].num == 1 && position_[82].num == 0
            ) {for (int p = 0; p < pi.myInventory.Count; p++) { if (pi.myInventory[p].itemName == "Level2") { return; } }
                addThing.TakeAThinhg2(); PanelSolved.SetActive(true); } } }
}