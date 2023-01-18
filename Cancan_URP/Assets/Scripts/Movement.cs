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
    public void Move(Vector3 dirInLocal){
        Vector3 dirInWorld = transform.TransformDirection(dirInLocal);
        _rb.MovePosition(transform.position + dirInWorld * Time.fixedDeltaTime);
    }
}
