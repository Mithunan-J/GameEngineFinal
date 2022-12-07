using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //playerRb.AddForce(Vector2.up * speed * Time.deltaTime);
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //playerRb.AddForce(Vector2.up * speed * Time.deltaTime);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //playerRb.AddForce(Vector2.up * speed * Time.deltaTime);
            transform.position += -Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //playerRb.AddForce(Vector2.up * speed * Time.deltaTime);
            transform.position += -Vector3.right * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.U))
        {
            CommandManager.commandManager.Reverse();
        }
    }
}
