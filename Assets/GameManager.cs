using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject winScreen;
    public GameObject loseScreen;
    public int health = 3;
    public List<GameObject> hearts = new List<GameObject>();

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public int pelletsCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(pelletsCollected == 10)
        {
            Win();
        }

        if (health == 0)
        {
            Lose();
        }

    }

    public void Win()
    {
        winScreen.SetActive(true);
    }

    public void Lose()
    {
        loseScreen.SetActive(true);
    }

    public void LoseHealth()
    {
        hearts[health - 1].gameObject.SetActive(false);
        health--;
    }
}
