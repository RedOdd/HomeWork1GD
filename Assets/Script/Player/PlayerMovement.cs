using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float MovementSpeed = 3;
    public float RotationSpeed = 45.0F;

	void Update () {
        transform.Rotate(0, Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime,0);
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement.y = -9.8f;
        movement *= Time.deltaTime * MovementSpeed;
        movement = Vector3.ClampMagnitude(movement, MovementSpeed);
        movement = transform.TransformDirection(movement);
        

        GetComponent<CharacterController>().Move(movement);
	}
}
