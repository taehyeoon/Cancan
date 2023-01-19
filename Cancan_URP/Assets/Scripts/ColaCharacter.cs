using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaCharacter : Character
{        
    public ColaCharacter() : base(
        0, 100, 90, //float minHealth, float maxHealth, float health_set, 
        1, 10, 10,  // float minSpeed, float maxSpeed, float speed_set,
        600, 5, 5)   // float horizontalrotSpeed, float verticalrotSpeed, float jumpPower_set
    {

    }
    private void Awake()
    {
        
    }
    void Update()
    {

    }
}
