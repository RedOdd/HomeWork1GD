using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    
    //private GameObject floor;
	// Use this for initialization
	void Start () {
        
        //floor = GameObject.Find("Floor");
	}

    // Update is called once per frame
    void Update()
    {
     // OnTriggerEnter(sphere.GetComponent<SphereCollider>());
    }

    private void OnTriggerEnter(Collider other )
    {
        Debug.Log(other.gameObject.name);
        Debug.Log(other.gameObject);
        if ((other.gameObject.name) != (null))
        {
            Destroy(other.gameObject);
        }
        Debug.Log(other.gameObject);
        Debug.Log(other.gameObject.name);
    }

    

}
