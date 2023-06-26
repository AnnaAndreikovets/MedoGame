using UnityEngine;
public class PlayerController1 : MonoBehaviour { public Rigidbody2D rb; public Animator anim; public VectorValue pos; public Joystick Joystick;
    public Vector2 moveVector; public Corr corr; public float speed = 3f; public float fastSpeed = 8f; private float realSpeed; public SpriteRenderer sr;
    private void Start() {  corr = GetComponent<Corr>(); pos = corr.pos; transform.position = pos.initialValue; rb = 
        GetComponent<Rigidbody2D>(); anim = GetComponent<Animator>();  sr = GetComponent<SpriteRenderer>(); realSpeed = speed; }
    public void ChangePosition(VectorValue pos_) { pos = pos_; transform.position = pos.initialValue; }
    public void ChooseClothes () { anim = GetComponent<Animator>(); }
    private void Update() { Walk(); /*Run();*/ Flip(); }
    private void FixedUpdate() { Walk(); /*Run(); */Flip(); } 
    public void Walk() { moveVector.x = Joystick.Horizontal; anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * realSpeed, rb.velocity.y); }
    void Flip() { if (moveVector.x > 0) { sr.flipX = false; } else if (moveVector.x < 0) { sr.flipX = true; } }
    public void Run() { anim.SetBool("run", true); realSpeed = fastSpeed; }
    public void StopRun() { anim.SetBool("run", false); realSpeed = speed; }
    public void SavePlayer() { SavePosition.SavePlayer(this); }
    public void LoadPlayer() { PlayerData data = SavePosition.LoadPlayer();
        Vector3 position; position.x = data.pos[0]; position.y = data.pos[1]; position.z = data.pos[2]; transform.position = position; }
}