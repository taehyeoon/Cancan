using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rb;

    private void Awake() {
        if(!TryGetComponent(out _rb)) Debug.Log("[Movement script] misssing RigidBody component");
    }

    // move in first person view
    public void Move(Vector3 dirInLocal, float speed){
        Vector3 dirInWorld = transform.TransformDirection(dirInLocal);
        _rb.MovePosition(transform.position + dirInWorld * speed * Time.deltaTime);
    }

    // Rotation based on mouse input
    public void Rotate(float mouseX, float speed){
        Vector3 _charRotY = new Vector3(0f, mouseX, 0f) * speed * Time.deltaTime;
        _rb.MoveRotation(_rb.rotation * Quaternion.Euler(_charRotY));
    }

    public void Jump(float power){
        _rb.AddForce(Vector3.up * power, ForceMode.VelocityChange);
    }
}
