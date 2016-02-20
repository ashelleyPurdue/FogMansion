using UnityEngine;
using System.Collections;

public class EightAngleRotator : MonoBehaviour {

    private Transform camera;

    void Awake()
    {
        //Get the camera
        camera = GameObject.FindObjectOfType<Camera>().transform;
    }

    // Update is called once per frame
    void Update ()
    {
        //Rotate twoard the camera
        transform.LookAt(camera);
        transform.forward = transform.forward * -1;

        Vector3 euler = transform.localEulerAngles;
        euler.x = 0;
        transform.localEulerAngles = euler;
    }
}
