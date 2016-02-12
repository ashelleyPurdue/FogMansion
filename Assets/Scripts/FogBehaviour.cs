using UnityEngine;
using System.Collections;

public class FogBehaviour : MonoBehaviour
{
    public float distance;
    public Camera my_camera;

    public float shrinkTime = 30;

    private float maxDistance = 20;
    private float minDistance = 5;

    private float shrinkSpeed;

	// Use this for initialization

    void Awake()
    {
        //Make fog visible
        GetComponent<MeshRenderer>().enabled = true;

        //TEMPORARY: Set distance to max
        distance = maxDistance;

        //Calculate the shrink speed
        shrinkSpeed = (maxDistance - minDistance) / shrinkTime;
        Debug.Log(shrinkSpeed);
    }

	void Update ()
    {
        //Shrink the fog
        distance -= shrinkSpeed * Time.deltaTime;

        //Make sure the distance is within bounds.
        if (distance > maxDistance)
        {
            distance = maxDistance;
        }

        if (distance < minDistance)
        {
            distance = minDistance;
        }

        //Move the fog to the correct distance
        transform.localPosition = new Vector3(0, 0, distance);

        //Update the camera clip plane
        my_camera.farClipPlane = distance + 1;
	}
}
