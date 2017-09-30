using UnityEngine;

public class GrenadeThrowing : MonoBehaviour {
    public  GameObject sphere;
    private GameObject player;
    public Camera _camera;
    public float Speed = 10f;
    private bool isThrowing;
    
    
    void Start () {
       
        

    }
	
	void Update () {
        GrenadeThrow();
        if (isThrowing)
        {
            if (sphere != null)
            {
                Debug.Log(sphere);
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                
                sphere.transform.SetParent(null);
                sphere.AddComponent<Rigidbody>();
               
                sphere.GetComponent<Rigidbody>().AddForce(ray.direction * 500 );
                isThrowing = false;
                
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
