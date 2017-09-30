using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggered : MonoBehaviour {
    public Light light;
    public Camera camera;
    public GameObject doorCarcas;
    private bool doorCarcasIsOpen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Cast();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            light.intensity = 1;
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Cast();
        
        if ((Cast().collider.gameObject.name.ToString() == "DoorCarcas")&&(Input.GetKey("e"))&&(doorCarcasIsOpen == false))
        {
            
            doorCarcasIsOpen = true;
            transform.Rotate(0, 90, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            transform.Rotate(0, -90, 0);
            doorCarcasIsOpen = false;
            light.intensity = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject) != (null))
        {
            Destroy(gameObject);
            Debug.Log("Взорвалось");
        }
    }

    private RaycastHit Cast()
    {
        Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
        Ray ray = camera.ScreenPointToRay(point);
        RaycastHit hit;
       /* if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point.ToString() + " " + hit.collider.gameObject.name.ToString());
        }*/
        Physics.Raycast(ray, out hit);
        return hit;
    }
}
