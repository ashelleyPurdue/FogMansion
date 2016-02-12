using UnityEngine;
using System.Collections;

public class BillboardBehaviour : MonoBehaviour
{
    public bool billboardX = false;

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

        //If billboardX is false, get rid of x-rotation
        if (!billboardX)
        {
            Vector3 euler = transform.localEulerAngles;
            euler.x = 0;
            transform.localEulerAngles = euler;
        }
	}
}
