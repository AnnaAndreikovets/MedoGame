using UnityEngine;
public class CheckRIghtPicture : MonoBehaviour { public Transform[] Paths; public AddThing addThing; public int num;
    public PlayerInventory pi; public GameObject panelSolved; public GameObject[] unactive;
    public void CheckWin() { if ((Paths[0].rotation.z == 0 || Paths[0].rotation.z == 360) && ( Paths[1].rotation.z == 0 || Paths[1].rotation.z == 360 )&& 
        (Paths[2].rotation.z == 0 || Paths[2].rotation.z == 360 )&& (Paths[3].rotation.z == 0 || Paths[3].rotation.z == 360 )&&
        (Paths[4].rotation.z == 0 || Paths[4].rotation.z == 360 )&& (Paths[5].rotation.z == 0 || Paths[5].rotation.z == 360 )&& 
        (Paths[6].rotation.z == 0 || Paths[6].rotation.z == 360 )&& (Paths[7].rotation.z == 0 || Paths[7].rotation.z == 360 )&&
        (Paths[8].rotation.z == 0 || Paths[8].rotation.z == 360) && (Paths[9].rotation.z == 0 || Paths[9].rotation.z == 360) && 
        (Paths[10].rotation.z == 0 || Paths[10].rotation.z == 360) && (Paths[11].rotation.z == 0 || Paths[11].rotation.z == 360 )&&
        (Paths[12].rotation.z == 0 || Paths[12].rotation.z == 360 )&& (Paths[13].rotation.z == 0 || Paths[13].rotation.z == 360 )&& 
        (Paths[14].rotation.z == 0 || Paths[14].rotation.z == 360 )&& (Paths[15].rotation.z == 0 || Paths[15].rotation.z == 360 )&&
        (Paths[16].rotation.z == 0 || Paths[16].rotation.z == 360 )&& (Paths[17].rotation.z == 0 || Paths[17].rotation.z == 360 )&&
        (Paths[18].rotation.z == 0 || Paths[18].rotation.z == 360 )&& (Paths[19].rotation.z == 0 || Paths[19].rotation.z == 360 )&&
        (Paths[20].rotation.z == 0 || Paths[20].rotation.z == 360 )&& (Paths[21].rotation.z == 0 || Paths[21].rotation.z == 360 )&&
        (Paths[22].rotation.z == 0 || Paths[22].rotation.z == 360 )&& (Paths[23].rotation.z == 0 || Paths[23].rotation.z == 360 )&&
        (Paths[24].rotation.z == 0 || Paths[24].rotation.z == 360)) { for (int i = 0; i < pi.myInventory.Count; i++) { 
            if (pi.myInventory[i].itemName == "SolvedPicture") { num++; } } if (num == 0) { addThing.TakeAThinhg2(); panelSolved.SetActive(true); } } }
    public void SetUnactive() { for (int p = 0; p < unactive.Length; p++) { unactive[p].SetActive(false); } }
}