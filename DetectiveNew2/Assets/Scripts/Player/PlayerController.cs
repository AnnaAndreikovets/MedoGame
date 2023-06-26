/*using UnityEngine;

public class PlayerController : MonoBehaviour { public Joystick Joystick;
    public Rigidbody2D rb; public Animator anim; public VectorValue pos; public Vector2 moveVector;
    public float speed = 3f; public float fastSpeed = 4.5f; private float realSpeed; public SpriteRenderer sr;
    private void Start() { transform.position = pos.initialValue; rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); sr = GetComponent<SpriteRenderer>(); realSpeed = speed; }
    private void Update() { Walk(); Run(); Flip(); }
    private void FixedUpdate() { Walk(); Run(); Flip();  }
    public void Walk() { moveVector.x = Input.GetAxis("Horizontal");
        // для телефона
        //moveVector.x = Joystick.Horizontal;
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * realSpeed, rb.velocity.y); }
    void Flip() { if (moveVector.x > 0) { sr.flipX = false; } else if (moveVector.x < 0) { sr.flipX = true; } }
    public void Run() { if (Input.GetKey(KeyCode.LeftShift)) { anim.SetBool("run", true);
            realSpeed = fastSpeed; } else { anim.SetBool("run", false); realSpeed = speed; } } }*/
using UnityEngine;
public class PlayerController : MonoBehaviour { public Joystick Joystick; public Rigidbody2D rb; public Animator anim; public VectorValue pos; 
    public Vector2 moveVector; public float speed = 3f; public float fastSpeed = 4.5f; private float realSpeed; public SpriteRenderer sr;
    private void Start() { transform.position = pos.initialValue; rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); sr = GetComponent<SpriteRenderer>(); realSpeed = speed; }
    private void Update() { Walk(); Flip(); }
    private void FixedUpdate() { Walk(); Flip(); }
    public void Walk() { moveVector.x = Joystick.Horizontal; anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * realSpeed, rb.velocity.y); }
    void Flip() { if (moveVector.x > 0) { sr.flipX = false; } else if (moveVector.x < 0) { sr.flipX = true; } }
    public void Run() { anim.SetBool("run", true); realSpeed = fastSpeed; }
    public void StopRun() { anim.SetBool("run", false); realSpeed = speed; }
}