using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Character _character;
    private Movement _movement;
    private UserInput _input;

    private bool _isMoving;
    private bool _isJumping;

    private void Awake()
    {
        if(!TryGetComponent(out _character)) Debug.Log("[Player script]  misssing Character script");
        if(!TryGetComponent(out _movement)) Debug.Log("[Player script]  misssing movement script");
        if(!TryGetComponent(out _input)) Debug.Log("[Player script]  misssing UserInput script");
    }
    void Update()
    {
        if(_input.btnHorizontal != 0 || _input.btnVertical != 0) _isMoving = true; else _isMoving = false;
        if(_input.btnSpace && !_isJumping) _isJumping = true; else _isJumping = false;
    }

    private void FixedUpdate() {
        if(_isMoving)
            _movement.Move(new Vector3(_input.btnHorizontal, 0, _input.btnVertical));

        _movement.Rotate(new Vector3(0,_input.mouseDX * _character._horizontalrotSpeed, 0));
        // if(_isJumping)



    }
}
