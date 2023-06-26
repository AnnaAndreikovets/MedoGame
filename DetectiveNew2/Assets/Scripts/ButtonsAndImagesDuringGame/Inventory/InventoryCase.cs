using UnityEngine; using UnityEngine.UI;
[System.Serializable] public class InventoryCase : MonoBehaviour { public bool[] isFull; public GameObject[] slots; public PlayerInventory playerInventory;
    [SerializeField] private Text descriptionText;[SerializeField] private GameObject useButton; public MyItem currentItem, newItem; 
    [SerializeField] private GameObject imageOfDescription;    
    public void LoadAPlayerInventory() { if (playerInventory) {
            for (int i = 0; i < playerInventory.myInventory2.Count; i++)
                for (int p = 0; p < slots.Length; p++) { if (isFull[p] == false) {
                                isFull[p] = true; MyInventorySlot newSlot =
                                    slots[p].GetComponent<MyInventorySlot>();
                                if (newSlot) { newSlot.Setup(playerInventory.myInventory2[i]); break; } } } } }
    public void ResetImages() { if (playerInventory) { for (int p = 0; p < slots.Length; p++) { isFull[p] = false; MyInventorySlot newSlot = 
        slots[p].GetComponent<MyInventorySlot>(); if (newSlot) { newSlot.Setup(newItem); } } } }
    private void Start() { LoadAPlayerInventory(); imageOfDescription.SetActive(false);
        SetTextAndButton("", false); }
    public void ShowImageOfDescription() { imageOfDescription.SetActive(true); }
    public void ResumeImageOfDescription() { imageOfDescription.SetActive(false); }
    public void SetTextAndButton(string description, bool buttonActive)
    { descriptionText.text = description; if (buttonActive) 
        { useButton.SetActive(true); imageOfDescription.SetActive(true); } 
        else { useButton.SetActive(false); imageOfDescription.SetActive(false); } }
    public void SetupDescriptionAndButton(string newDescriptionString, bool isButtonUsable, MyItem newItem)
    { currentItem = newItem; descriptionText.text = newDescriptionString; useButton.SetActive(isButtonUsable);}
}