using UnityEngine;
public class MoveCar : MonoBehaviour { public TakeAnItemOnce TakeAnItemOnce;  float time_ = 0.1f; int num = 0;
    void Start() => num = 1;
    private void Update() { if (num == 1) { time_ -= Time.deltaTime; if (time_ <= 0) TakeAnItemOnce.CheckIfTook2(); } } }