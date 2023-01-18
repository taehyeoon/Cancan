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

    public float _rotSpeed {get; set;}


    public Character(float minHealth, float maxHealth, float health, 
        float minSpeed, float maxSpeed, float speed, float rotSpeed)
    {
        _minHealth = minHealth;
        _maxHealth = maxHealth;
        _health = health;
        
        _minSpeed = minSpeed;
        _maxSpeed = maxSpeed;
        _speed = speed;

        _rotSpeed = rotSpeed;
    }

    /* �������� �԰� ü���� 0������ ���, return false */
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
    /* ���� ü���� 0������ ���, return false */
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
