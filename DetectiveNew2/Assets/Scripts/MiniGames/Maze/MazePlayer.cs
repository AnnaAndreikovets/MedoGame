using UnityEngine; using UnityEngine.SceneManagement;
public class MazePlayer : MonoBehaviour { public float moveSpeed = 5f; public Rigidbody2D rb;
    Vector2 movement; public VectorValue pos; bool FacingRight, FacingRight_; int directionInput, directionInput_;
    public void ResetPos() { SceneManager.LoadSceneAsync(36); }
    private void Start() { rb = GetComponent<Rigidbody2D>(); }
    //void Update() { movement.x = Input.GetAxisRaw("Horizontal"); movement.y = Input.GetAxisRaw("Vertical");}
    private void FixedUpdate() { //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        rb.velocity = new Vector2(moveSpeed * directionInput, rb.velocity.y); 
        rb.velocity = new Vector2(rb.velocity.x, moveSpeed * directionInput_); }
    public void Move(int InputAxis) { directionInput = InputAxis; }
    public void Move_(int InputAxis) { directionInput_ = InputAxis; }
}