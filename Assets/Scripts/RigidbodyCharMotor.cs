using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyCharMotor : MonoBehaviour
{
    public Vector3 inputDirection;
    public float jumpForce;

    private Rigidbody rigid;

    private bool isGrounded = false;
    private float groundCheckDist = 0.1f;


    //Events

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Update the grounded.
        UpdateGrounded();
    }

    //Misc methods

    public void Jump()
    {
        //Jump if grounded
        if (isGrounded)
        {
            rigid.AddForce(Vector3.up * jumpForce);
        }
    }

    private void UpdateGrounded()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.up * -1, groundCheckDist);
    }
}
