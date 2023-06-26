[System.Serializable] 
public class PlayerData { public int number; public float[] pos;
    public PlayerData(PlayerController1 player) { pos = new float[3]; pos[0] = player.transform.position.x; 
        pos[1] = player.transform.position.y; pos[2] = player.transform.position.z; }
    public PlayerData(Corr corr) { number = corr.number; }
}