using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_rb_old : MonoBehaviour
{
    // Variables
    // RIGID BODY IS WHAT TELLS THE COMPUTER HOW OBJECT IS AFFECTED BY PHYSICS
    // rb is our specific rigidbody | RigidBody2D is the global component one
    public Rigidbody2D rb;
    public float forceAmount = 1.236f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    // u gotta Script the rigid body from game object onto this script file.
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {   
         // input system has getkey getkey has all ur keyboard keys
        
        // Up input
        if(Input.GetKey(KeyCode.W)) {
            rb.AddForce(Vector2.up * forceAmount);         
  }
        // Down input
   if(Input.GetKey(KeyCode.S)) {
            rb.AddForce(Vector2.down * forceAmount);
        }  
         // Right input
   if(Input.GetKey(KeyCode.D)) {
            rb.AddForce(Vector2.right * forceAmount);
        }  
         // Left input
   if(Input.GetKey(KeyCode.A)) {
            rb.AddForce(Vector2.left * forceAmount);
        }  




}

}
