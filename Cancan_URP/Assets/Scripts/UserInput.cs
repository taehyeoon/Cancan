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
    public float mouseDX {get; private set;}
    public float mouseDY {get; private set;}

    private void Update() {
        btnHorizontal = Input.GetAxisRaw("Horizontal");
        btnVertical = Input.GetAxisRaw("Vertical");
        btnSpace = Input.GetButtonDown("Jump");

        mouseDX = Input.GetAxis("Mouse X");
        mouseDY = Input.GetAxis("Mouse Y");
    }
}
