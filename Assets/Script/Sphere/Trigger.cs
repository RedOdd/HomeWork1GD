using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject sphere;

    void Start()
    {

    }

    
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject) != (null))
        {
            Destroy(gameObject);
            Debug.Log("Взорвалось");
        }
    }
}
