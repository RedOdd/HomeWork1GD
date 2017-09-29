using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taker : MonoBehaviour {
    
    void Start()
    { }
    void Update() { }
        private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.name == "Player") {

            GetComponent<Light>().intensity = 0;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.name == "Player")
        {

            GetComponent<Light>().intensity = 1;
        }
    }
}
