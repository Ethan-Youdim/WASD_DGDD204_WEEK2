using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_transform : MonoBehaviour
{
    // Variables:
    public float speed;

    private Vector2 position;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {     
    }

    
    // Update is called once per frame
    void Update()
    {
        // finding where we are located (every frame) and adding it to the vector we made

        position = transform.position;

        // If I press W key I go up up up and awayyyyyyyyyyyyyyyyyyyyyyyyyyyy

        if (Input.GetKey(KeyCode.W)) {
            position.y += speed * Time.deltaTime;
        }

        // If I press D key I go down

        if (Input.GetKey(KeyCode.S)) {
            position.y -= speed * Time.deltaTime;
        }

        // if I press A key I go left

        if (Input.GetKey(KeyCode.A)) {
            position.x -= speed * Time.deltaTime;
        }

        // If I press D key I go right
        if (Input.GetKey(KeyCode.D)) {
            position.x += speed * Time.deltaTime;
        }


        // moving it to desired location  
        transform.position = position;
    }




}