using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_transform_new : MonoBehaviour
{
    // vairables:

    public float speed;

    private Vector3 position;

    public InputActionReference movement;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //read the value of our movement to find the position we are in
        position = movement.action.ReadValue<Vector2>() * speed * Time.deltaTime;

        // tell the square to move
        transform.position += position;
    }
}
