using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    float horizontalMovement;
    // void Start()
    // {
    //     
    // }
    //
    // // // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(horizontalMovement * moveSpeed, rb.linearVelocity.y);
    }
    //    void Awake() // on awake this activates ()
    //    {
    //        var rb = GetComponent<Rigidbody2D>();
    //        rb.IsKinematic = true;
    //        //NOTE: Alternative: use rb.AddForce(..) never modify transform of an object with a (non-kinematic) Rigidbody(2D). 
    //    }
    public void movement(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
}
