using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected float _minHealth;
    protected float _maxHealth;
    public float health;

    protected float _minSpeed;
    protected float _maxSpeed;
    public float speed;

    public float _horizontalrotSpeed;
    public float _verticalrotSpeed;
    public float jumpPower;

    public Character(float minHealth, float maxHealth, float health_set, 
        float minSpeed, float maxSpeed, float speed_set, float horizontalrotSpeed, float verticalrotSpeed, float jumpPower_set)
    {
        _minHealth = minHealth;
        _maxHealth = maxHealth;
        health = health_set;
        
        _minSpeed = minSpeed;
        _maxSpeed = maxSpeed;
        speed = speed_set;

        _horizontalrotSpeed = horizontalrotSpeed;
        _verticalrotSpeed = verticalrotSpeed;

        jumpPower = jumpPower_set;
    }

    /* if character dead after attack, return false */
    public bool ApplyDamage(float damage) 
    {
        if(health - damage <= 0)
        {
            return false;
        }
        else
        {
            health = health - damage;
            return true;
        }
    }
    /* if current helth is less than zero, return false */
    public bool ApplyHeal(float heal)
    {
        if (health <= 0)
            return false;
        else
        {
            health = Mathf.Clamp(health + heal, _minHealth, _maxHealth);
            return true;
        }
    }

    public void SetSpeed(float changeSpeed)
    {
        speed = Mathf.Clamp(_minSpeed, _maxSpeed, changeSpeed);
    }
}
