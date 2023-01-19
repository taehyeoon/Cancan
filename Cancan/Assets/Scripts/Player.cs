using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Character _character;
    private Movement _movement;
    private UserInput _input;
    
    [SerializeField] private bool _isMoving;
    [SerializeField] private bool _isJumping;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (!TryGetComponent(out _character)) Debug.Log("[Player script]  misssing Character script");
        if(!TryGetComponent(out _movement)) Debug.Log("[Player script]  misssing movement script");
        if(!TryGetComponent(out _input)) Debug.Log("[Player script]  misssing UserInput script");
    }
    void Update()
    {
        if(_input.btnHorizontal != 0 || _input.btnVertical != 0) _isMoving = true; else _isMoving = false;

    }

    private void FixedUpdate() {
        // Move
        if(_isMoving)
            _movement.Move(new Vector3(_input.btnHorizontal, 0, _input.btnVertical), _character.speed);
        // Rotate
        _movement.Rotate(_input.mouseDX, _character._horizontalrotSpeed);

        // Jump
        if(_input.btnSpace && !_isJumping){
            _isJumping = true;
            _movement.Jump(_character.jumpPower);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Floor")){
            Debug.Log("impact with floor");
            _isJumping = false;
        }
    }
}
