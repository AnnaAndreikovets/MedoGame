using UnityEngine; using System.IO; using System.Runtime.Serialization.Formatters.Binary;
public class MyInventorySave : MonoBehaviour { [SerializeField] public PlayerInventory pi;
    private void OnEnable() {  LoadScriptables(); LoadScriptables2(); }
    private void OnDisable() { SaveScriptables();  SaveScriptables2(); }
    private void Awake() { LoadScriptables();  LoadScriptables2();  LoadScriptables3(); }
    private void Start() {SaveScriptables();  SaveScriptables2(); SaveScriptables3(); }

    public void ResetScriptables() {int i = 0;
        while (File.Exists(Application.persistentDataPath + string.Format("/{0}.inv", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.inv", i)); i++; }
        pi.myInventory2.Clear(); Debug.Log("wrt");
    }
    public void SaveScriptables() { ResetScriptables();
        for (int i = 0; i < pi.myInventory2.Count; i++) {
            FileStream file = File.Create(Application.persistentDataPath + string.Format("/{0}.inv", i));
            // сохраняем каждый предмет отдельно, это имя 
            BinaryFormatter binary = new BinaryFormatter(); var json =
                JsonUtility.ToJson(pi.myInventory2[i]); binary.Serialize(file, json); file.Close(); } }
    public void LoadScriptables() { for (int i = 0; i < pi.myInventory2.Count; i++)
        { if (File.Exists(Application.persistentDataPath + string.Format("/{0}.inv", i)))
            {FileStream file = File.Open(Application.persistentDataPath +
                string.Format("/{0}.inv", i), FileMode.Open); BinaryFormatter binary = new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file), pi.myInventory2[i]);
                file.Close(); } } }

    public void ResetScriptables2() { int i = 0;
        while (File.Exists(Application.persistentDataPath + string.Format("/{0}.thin", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.thin", i)); i++; }
        pi.myInventory.Clear(); }
    public void SaveScriptables2() { ResetScriptables2();
        for (int i = 0; i < pi.myInventory.Count; i++) {
            FileStream file = File.Create(Application.persistentDataPath + string.Format("/{0}.thin", i));
            // сохраняем каждый предмет отдельно, это имя 
            BinaryFormatter binary = new BinaryFormatter(); var json =
                JsonUtility.ToJson(pi.myInventory[i]);
            binary.Serialize(file, json); file.Close(); } }
    public void LoadScriptables2() { for (int i = 0; i < pi.myInventory.Count; i++)
        { if (File.Exists(Application.persistentDataPath + string.Format("/{0}.thin", i))) {
                FileStream file = File.Open(Application.persistentDataPath +
                   string.Format("/{0}.thin", i), FileMode.Open); BinaryFormatter binary = 
                    new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file),
                    pi.myInventory[i]); file.Close(); } } }

    public void ResetScriptables3() { int i = 0;
        while (File.Exists(Application.persistentDataPath + string.Format("/{0}.star", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.star", i)); i++; }
        pi.myStars.Clear(); }
    public void SaveScriptables3() { ResetScriptables3();
        for (int i = 0; i < pi.myStars.Count; i++)
        { FileStream file = File.Create(Application.persistentDataPath + string.Format("/{0}.star", i));
            // сохраняем каждый предмет отдельно, это имя 
            BinaryFormatter binary = new BinaryFormatter(); var json =
                JsonUtility.ToJson(pi.myStars[i]);
            binary.Serialize(file, json); file.Close(); } }
    public void LoadScriptables3() { for (int i = 0; i < pi.myStars.Count; i++)
        { if (File.Exists(Application.persistentDataPath + string.Format("/{0}.star", i))) {
                FileStream file = File.Open(Application.persistentDataPath +
                   string.Format("/{0}.star", i), FileMode.Open); BinaryFormatter binary =
                    new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file),
                    pi.myStars[i]); file.Close(); } } }

    public void ResetScriptables4() { int i = 0; while (File.Exists(Application.persistentDataPath + string.Format("/{0}.lfl", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.lfl", i)); i++; } pi.ListForLoading.Clear(); }
    public void SaveScriptables4() { ResetScriptables4(); for (int i = 0; i < pi.ListForLoading.Count; i++) {
            FileStream file = File.Create(Application.persistentDataPath + string.Format("/{0}.lfl", i));
            BinaryFormatter binary = new BinaryFormatter(); var json = JsonUtility.ToJson(pi.ListForLoading[i]);
            binary.Serialize(file, json); file.Close(); } }
    public void LoadScriptables4() { for (int i = 0; i < pi.ListForLoading.Count; i++) {
            if (File.Exists(Application.persistentDataPath + string.Format("/{0}.lfl", i))) { FileStream file = File.Open(Application.persistentDataPath +
                   string.Format("/{0}.lfl", i), FileMode.Open); BinaryFormatter binary = new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file), pi.ListForLoading[i]); file.Close(); } } }

    public void ResetScriptables5() { int i = 0; while (File.Exists(Application.persistentDataPath + string.Format("/{0}.val", i)))
        { File.Delete(Application.persistentDataPath + string.Format("/{0}.val", i)); i++; } pi.ValueOfSound.Clear(); }
    public void SaveScriptables5() { ResetScriptables5(); for (int i = 0; i < pi.ValueOfSound.Count; i++) {
            FileStream file = File.Create(Application.persistentDataPath + string.Format("/{0}.val", i));
            BinaryFormatter binary = new BinaryFormatter(); var json = JsonUtility.ToJson(pi.ValueOfSound[i]);
            binary.Serialize(file, json); file.Close(); } }
    public void LoadScriptables5() { for (int i = 0; i < pi.ValueOfSound.Count; i++) {
            if (File.Exists(Application.persistentDataPath + string.Format("/{0}.val", i))) { FileStream file = File.Open(Application.persistentDataPath +
                   string.Format("/{0}.val", i), FileMode.Open); BinaryFormatter binary = new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file), pi.ValueOfSound[i]); file.Close(); } } }
}