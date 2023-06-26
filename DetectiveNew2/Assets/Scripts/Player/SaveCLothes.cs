using UnityEngine; using System.IO; using System.Runtime.Serialization.Formatters.Binary;
public static class SaveClothes {
    public static void SaveClothes_(ChooseClothes clothes) { BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/clothes.number";
        FileStream stream = new FileStream(path, FileMode.Create);
        ClothesData data = new ClothesData(clothes); formatter.Serialize(stream, data); stream.Close(); }
    public static ClothesData LoadClothes() { string path = Application.persistentDataPath + "/clothes.number";
        if (File.Exists(path)) { BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            ClothesData data = formatter.Deserialize(stream) as ClothesData; stream.Close(); return data;}
        else { Debug.LogError("Save file not found in" + path); return null; } }
}
