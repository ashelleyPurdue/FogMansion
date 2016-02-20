using UnityEngine;
using System.Collections;

public class EightAngleBehaviour : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[8];    //Backward, BackwardRight, Right, ForwardRight, Forward, ForwardLeft, Left, BackwardLeft

    private Transform camera;
    private EightAngleRotator rotator;

    void Awake()
    {
        //Error if there are less than eight sprites
        if (sprites.Length != 8)
        {
            Debug.LogError("EightAngleBehaviour must have 8 sprites");
        }

        //Get the camera
        camera = GameObject.FindObjectOfType<Camera>().transform;

        //Create the child
        GameObject child = new GameObject();
        child.transform.SetParent(transform);

        child.transform.localPosition = Vector2.zero;

        //Create rotator
        rotator = child.AddComponent<EightAngleRotator>();

        //Create sprite renderer
        SpriteRenderer rend = child.AddComponent<SpriteRenderer>();
        rend.sprite = sprites[0];
    }

    void Update()
    {
        //Change the sprite based on the direciton towards the camera.

        //Find the difference vector toward the player
        Vector3 diff = transform.position - camera.position;
        float angle = Mathf.Atan2(diff.z, diff.x) * Mathf.Rad2Deg - 90;

        if (angle < 0)
        {
            angle += 360;
        }

        //Convert the angle to a sprite number
        int index = (int)(8 * angle / 360);
        Debug.Log(angle);
        rotator.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    //Misc methods
}
