using UnityEngine; using System.IO; using System.Runtime.Serialization.Formatters.Binary;
public static class SavePosition {
    public static void SavePlayer(PlayerController1 player) { BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.pos";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player); formatter.Serialize(stream, data); stream.Close(); }
    public static PlayerData LoadPlayer() { string path = Application.persistentDataPath + "/player.pos";
        if (File.Exists(path)) { BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData; stream.Close(); return data;  }
        else { Debug.LogError("Save file not found in" + path); return null; }
    }

    public static void SavePos(Corr corr) { BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.pos_";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(corr); formatter.Serialize(stream, data); stream.Close(); }
    public static PlayerData LoadPos() { string path = Application.persistentDataPath + "/player.pos_";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData; stream.Close(); return data; }
        else { Debug.LogError("Save file not found in" + path); return null; } }
}
