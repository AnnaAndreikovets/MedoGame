using UnityEngine; using System.IO; using System.Runtime.Serialization.Formatters.Binary;
public class SaveScene : MonoBehaviour {
    public static void SaveScene_(ChooseSceneNumber scenes) { BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/scene.number"; FileStream stream = new FileStream(path, FileMode.Create);
        ScenesDate data = new ScenesDate(scenes); formatter.Serialize(stream, data); stream.Close(); }
    public static ScenesDate LoadScene() { string path = Application.persistentDataPath + "/scene.number";
        if (File.Exists(path)) { BinaryFormatter formatter = new BinaryFormatter(); FileStream stream = new FileStream(path, FileMode.Open);
            ScenesDate data = formatter.Deserialize(stream) as ScenesDate; stream.Close(); return data; }
        else { Debug.LogError("Save file not found in" + path); return null; } }
}