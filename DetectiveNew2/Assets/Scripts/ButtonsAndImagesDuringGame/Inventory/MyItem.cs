using UnityEngine; using UnityEngine.Events; [CreateAssetMenu(fileName = "New My Item", menuName = "My Inventory/ My Items")] [System.Serializable]
public class MyItem : ScriptableObject { public bool usable; public string nameOfItem; public string itemDescription; public Sprite itemImage; 
    public UnityEvent thisEvent; public void Use() {thisEvent.Invoke(); } }