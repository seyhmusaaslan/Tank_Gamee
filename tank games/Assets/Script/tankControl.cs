using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankControl : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float rotationSpeed = 90f;

    private Rigidbody tankRigidbody;

    private void Start()
    {
        tankRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Y�r�me ve d�nme giri�ini al
        float moveInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        // Y�r�me ve d�nme kuvvetlerini hesapla
        Vector3 moveVelocity = transform.forward * moveInput * moveSpeed;
        Vector3 rotationTorque = Vector3.up * rotationInput * rotationSpeed;

        // RigidBody'ye kuvvetleri uygula
        tankRigidbody.velocity = moveVelocity;
        tankRigidbody.angularVelocity = rotationTorque;
    }
}

    

