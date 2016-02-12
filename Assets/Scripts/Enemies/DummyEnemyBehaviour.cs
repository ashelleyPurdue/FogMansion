using UnityEngine;
using System.Collections;

[RequireComponent(typeof(RigidbodyCharMotor))]
public class DummyEnemyBehaviour : MonoBehaviour
{
    private RigidbodyCharMotor motor;

    //Events

	void Awake()
    {
        motor = GetComponent<RigidbodyCharMotor>();
	}
	
	void FixedUpdate()
    {
        motor.Jump();
	}
}
