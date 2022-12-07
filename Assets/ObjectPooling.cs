using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject objectToPool;
    public int amountToPool = 30;
    public List<GameObject> objectPoolList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amountToPool; i++)
        {
            GameObject _ghost = Instantiate(objectToPool);
            objectPoolList.Add(_ghost);
            _ghost.transform.position = new Vector2(Random.Range(-11, 11), Random.Range(-5, 5));
        }
    }

    
}
