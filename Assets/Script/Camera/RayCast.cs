﻿using UnityEngine;

public class RayCast : MonoBehaviour {
    private Camera _camera;
	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0))
        {
            Cast();
        }
    }

        private void Cast()
        {
            Vector3 point = new Vector3(_camera.pixelWidth/2,_camera.pixelHeight/2,0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point.ToString() + " " + hit.collider.gameObject.name.ToString());
        }
        }
}
