using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{    
    const string horizontalStr = "Horizontal";
    const string verticalStr = "Vertical";
    const string jumpStr = "Jump";
    public float btnHorizontal {get; private set;} = 0;
    public float btnVertical {get; private set;} = 0;
    public bool btnSpace {get; private set;} = false;
    // public Vector3 dir {get; private set;} = Vector3.zero;


    private void Update() {
        btnHorizontal = Input.GetAxisRaw(horizontalStr);
        btnVertical = Input.GetAxisRaw(verticalStr);
        // dir = new Vector3(btnHorizontal,0,btnVertical);
        btnSpace = Input.GetButtonDown(jumpStr);
    }
}
