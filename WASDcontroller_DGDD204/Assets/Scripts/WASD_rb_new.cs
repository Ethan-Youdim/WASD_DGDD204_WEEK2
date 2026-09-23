using UnityEngine;
using UnityEngine.InputSystem;


public class WASD_rb_new : MonoBehaviour
{
    //variables
    public Rigidbody2D rb;

    public float movespeed;

    private Vector2 movedirection;

    public InputActionReference move;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // add the rigid body from the object when the game starts
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // add the direction of our movement from mthe refrence of the new input manager we made
        movedirection = move.action.ReadValue<Vector2>();
    }

    // fixed update is calleed once every physicics frame
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:movedirection.x * movespeed, y:movedirection.y * movespeed);


    
    }

}
