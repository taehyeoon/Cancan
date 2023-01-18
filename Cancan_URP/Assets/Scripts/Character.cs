using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected float _minHealth;
    protected float _maxHealth;
    public float _health {get; private set;}

    protected float _minSpeed;
    protected float _maxSpeed;
    public float _speed {get; private set;}

    public float _horizontalrotSpeed {get; set;}
    public float _verticalrotSpeed {get; set;}


    public Character(float minHealth, float maxHealth, float health, 
        float minSpeed, float maxSpeed, float speed, float horizontalrotSpeed, float verticalrotSpeed)
    {
        _minHealth = minHealth;
        _maxHealth = maxHealth;
        _health = health;
        
        _minSpeed = minSpeed;
        _maxSpeed = maxSpeed;
        _speed = speed;

        _horizontalrotSpeed = horizontalrotSpeed;
        _verticalrotSpeed = verticalrotSpeed;
    }

    /* if character dead after attack, return false */
    public bool ApplyDamage(float damage) 
    {
        if(_health - damage <= 0)
        {
            return false;
        }
        else
        {
            _health = _health - damage;
            return true;
        }
    }
    /* if current helth is less than zero, return false */
    public bool ApplyHeal(float heal)
    {
        if (_health <= 0)
            return false;
        else
        {
            _health = Mathf.Clamp(_health + heal, _minHealth, _maxHealth);
            return true;
        }
    }

    public void SetSpeed(float changeSpeed)
    {
        _speed = Mathf.Clamp(_minSpeed, _maxSpeed, changeSpeed);
    }
}
