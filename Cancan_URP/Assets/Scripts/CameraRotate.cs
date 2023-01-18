using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // Using Player(Parent's) UserInput Script
    UserInput _input;
    // Using Player(Parent's) Character Script
    Character _character;

    private bool _isVerticalMove;
    private void Awake(){
        if(!transform.parent.TryGetComponent(out _input)) Debug.Log("[CameraRotate] misssing UserInput component");
        if(!transform.parent.TryGetComponent(out _character)) Debug.Log("[CameraRotate] misssing Character component");
    }

    private void Update(){
        if(_input.mouseDX != 0) _isVerticalMove = true; else _isVerticalMove = false;
    }
    
    private void FixedUpdate(){
        if(_isVerticalMove)
            RotateVertical(new Vector3(-_input.mouseDY * _character._verticalrotSpeed,0,0));
    }

    private void RotateVertical(Vector3 dir){
        transform.Rotate(dir);
    }

}
