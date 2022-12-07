using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float currentTime =0f;
    public float direction = 1f;
    public float switchTime = 3f;
    public float speed = 3;
    public Color _color = Color.red;
    public string _name = "Blinky";
    public int ghostColour;
    // Start is called before the first frame update
    void Start()
    {
        ghostColour = Random.Range(1, 5);
        if(ghostColour == 1)
        {
            _color = Color.red;
            _name = "Blinky";
        }
        else if (ghostColour == 2)
        {
            _color = Color.magenta;
            _name = "Pinky";
        }
        else if (ghostColour == 3)
        {
            _color = Color.cyan;
            _name = "Inky";
        }
        else if (ghostColour == 4)
        {
            _color = Color.green;
            _name = "Clyde";
        }
        GetComponent<SpriteRenderer>().color = _color;
        this.gameObject.name = _name;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime <= switchTime)
        {
            currentTime += Time.deltaTime;
            transform.position += Vector3.up * direction * speed * Time.deltaTime;
        }
        else
        {
            direction *= -1;
            currentTime = 0f;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PacMan")
        {
            GameManager.instance.LoseHealth();
        }
    }
    
}
