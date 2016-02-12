using UnityEngine;
using System.Collections;

public class BillboardBehaviour : MonoBehaviour
{
    private Transform camera;

	void Awake ()
    {
        //Get the camera
        camera = GameObject.FindObjectOfType<Camera>().transform;
	}
	
	void Update ()
    {
        //Rotate twoard the camera
        transform.LookAt(camera);
        transform.forward = transform.forward * -1;
	}
}
