using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : Obstacle
{
    public override void RandomlyRotate()
    {
        //transform.eulerAngles = new Vector3
    }

    public override void Move()
    {
        transform.Rotate(new Vector3(0, 0, 1));
    }
}
