using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaCharacter : Character
{
    public ColaCharacter() : base(0, 100, 90, 1, 10, 5)
    {

    }
    private void Awake()
    {
        
    }
    void Update()
    {
        GetHealth();
        GetSpeed();
    }
}
