using UnityEngine; using UnityEngine.UI; // по 4 нажатия на: 4,1,2,3,4,1,3,4
public class Candles : MonoBehaviour { public AddThing addThing; public GameObject panelSolved, panelStartGame, shelfOnSceneImage, buttonFuse, 
        candlesOnScene, imageFuse, audioSource; public PlayerInventory pi; public Image[] images; public int[] number; public Sprite[] sprites;
    public void FirstCandle() { try {
        images[4].sprite = sprites[number[4] + 1]; number[4]++;
        images[2].sprite = sprites[number[2] - 1]; number[2]--; SetRightNum(); CheckRight(); } catch { } }
    public void SecongCandle() { try {
        images[2].sprite = sprites[number[2] + 1]; number[2]++;
        images[0].sprite = sprites[number[0] - 1]; number[0]--; SetRightNum(); CheckRight(); } catch { } }
    public void Third() { try {
        images[1].sprite = sprites[number[1] + 1]; number[1]++;
        images[3].sprite = sprites[number[3] + 1]; number[3]++; SetRightNum(); CheckRight(); } catch { } }
    public void Four() { try {
        images[1].sprite = sprites[number[1] - 1]; number[1]--;
        images[3].sprite = sprites[number[3] - 1]; number[3]--;
        images[4].sprite = sprites[number[4] - 1]; number[4]--; SetRightNum(); CheckRight(); } catch { } }
    public void Five() { try { images[0].sprite = sprites[number[0] + 1]; number[0]++; SetRightNum(); CheckRight(); } catch { }}
    public void SetRightNum() { for (int i = 0; i < number.Length; i++) {
            if (number[i] >= 4) { number[i] = 4; } else if (number[i] <= 0) { number[i] = 0; } } }
    //короче, лучше отключат все свечи(они же кнопки и включать отдельный объект с новыми зажжёными свечами)
    public void CheckRight() { if (number[0] == 0 && number[1] == 0 && number[2] == 0 && number[3] == 0 && number[4] == 0) { 
        addThing.TakeAThinhg2(); panelSolved.SetActive(true); panelStartGame.SetActive(false); imageFuse.SetActive(true);
        shelfOnSceneImage.SetActive(true); buttonFuse.SetActive(true); candlesOnScene.SetActive(true); audioSource.SetActive(true); } }
}