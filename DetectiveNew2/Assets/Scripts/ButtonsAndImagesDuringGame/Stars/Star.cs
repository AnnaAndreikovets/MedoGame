using UnityEngine; using UnityEngine.Events;
[CreateAssetMenu(fileName = "Star", menuName = "My Stars/ Star")]
[System.Serializable]
public class Star : ScriptableObject{ public string nameOfItem; public Sprite itemImage; }