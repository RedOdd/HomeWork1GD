using UnityEngine;

public class GrenadeThrowing : MonoBehaviour {
    private  GameObject sphere;
    private GameObject player;
    public Camera _camera;
    public float Speed = 0.1f;
    private bool isThrowing;
    
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        sphere = GameObject.Find("Sphere");
        _camera = player.GetComponentInChildren<Camera>();
        

    }
	
	// Update is called once per frame
	void Update () {
        GrenadeThrow();
        if (isThrowing)
        {
            if (sphere != null)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

                sphere.transform.SetParent(null);
                sphere = GameObject.Find("Sphere");


                sphere.transform.Translate(ray.direction * Speed * Time.deltaTime, Space.World);
                sphere.GetComponent<Rigidbody>().useGravity = true;
            }
            
            
        }

        
	}

    private void GrenadeThrow()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isThrowing = true;
        }
    }
}
