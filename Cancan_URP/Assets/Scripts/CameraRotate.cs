using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // Using Player(Parent's) UserInput Script
    UserInput _input;
    // Using Player(Parent's) Character Script
    Character _character;

    public float cameraRotationLimit = 70f;
    private bool _isVerticalMove;
    public float currentCameraRotationX = 0;


    private void Awake(){
        if(!transform.parent.TryGetComponent(out _input)) Debug.Log("[CameraRotate] misssing UserInput component");
        if(!transform.parent.TryGetComponent(out _character)) Debug.Log("[CameraRotate] misssing Character component");

        transform.localRotation = Quaternion.Euler(currentCameraRotationX, 0, 0);
    }

    private void FixedUpdate(){
        if(_input.mouseDX != 0)
            RotateVertical(_input.mouseDY, _character._verticalrotSpeed * Time.deltaTime);
    }

    private void RotateVertical(float mouseY, float speed){
        currentCameraRotationX -= mouseY * speed;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);
        transform.localRotation = Quaternion.Euler(currentCameraRotationX, 0, 0);
    }

}
