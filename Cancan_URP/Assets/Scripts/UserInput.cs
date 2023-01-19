using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // keyboard
    public float btnHorizontal {get; private set;} = 0;
    public float btnVertical {get; private set;} = 0;
    public bool btnSpace {get; private set;} = false;

    // mouse
    public float mouseDX;
    public float mouseDY;

    private void Update() {
        btnHorizontal = Input.GetAxisRaw("Horizontal");
        btnVertical = Input.GetAxisRaw("Vertical");
        btnSpace = Input.GetButton("Jump");

        mouseDX = Input.GetAxis("Mouse X");
        mouseDY = Input.GetAxis("Mouse Y");
    }
}
