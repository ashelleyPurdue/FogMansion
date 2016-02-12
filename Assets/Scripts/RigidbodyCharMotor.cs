using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class RigidbodyCharMotor : MonoBehaviour
{
    public Vector3 inputDirection;
    public float jumpForce;

    private Rigidbody rigid;
    private CapsuleCollider my_collider;

    private bool isGrounded = false;
    private float groundCheckDist = 0.1f;


    //Events

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        my_collider = GetComponent<CapsuleCollider>();
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
        Vector3 startPos = transform.position;
        startPos -= Vector3.up * my_collider.height / 2;

        isGrounded = Physics.Raycast(startPos, Vector3.up * -1, groundCheckDist);
    }
}
