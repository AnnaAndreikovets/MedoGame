using UnityEngine;
public class ActiveDossier : MonoBehaviour { public GameObject[] dossiers; public PlayerInventory pi;
    public void CheckActive() { for (int i = 0; i < pi.myInventory.Count; i++) {
        if (pi.myInventory[i].itemName == "MuderKetrin") { dossiers[0].SetActive(true); }
        if (pi.myInventory[i].itemName == "MurderMaks") { dossiers[1].SetActive(true); }
        if (pi.myInventory[i].itemName == "MurderSofia") { dossiers[2].SetActive(true); }
        if (pi.myInventory[i].itemName == "MurderElizabet") { dossiers[3].SetActive(true); }
        if (pi.myInventory[i].itemName == "murderAdam") { dossiers[4].SetActive(true); }
        if (pi.myInventory[i].itemName == "murderAlex") { dossiers[5].SetActive(true); }
        if (pi.myInventory[i].itemName == "MuderAlbert") { dossiers[6].SetActive(true); }
        if (pi.myInventory[i].itemName == "MurderAnzela") { dossiers[7].SetActive(true); }
        if (pi.myInventory[i].itemName == "murderWilson") { dossiers[8].SetActive(true); }
        if (pi.myInventory[i].itemName == "murderSmit") { dossiers[9].SetActive(true); } } }
    private void Start() => CheckActive();
}