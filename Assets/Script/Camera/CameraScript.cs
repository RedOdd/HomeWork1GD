using UnityEngine;

public class CameraScript : MonoBehaviour {

    public float RotationSpeed = 45.0f;
    public float mouseYView=0;


    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	void Update () {
        mouseYView -= Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime;
        mouseYView = Mathf.Clamp(mouseYView, -45.0f, 45.0f);
        //var rotationY = transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(mouseYView, 0, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}
}
