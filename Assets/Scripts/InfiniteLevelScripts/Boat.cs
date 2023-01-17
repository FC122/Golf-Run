using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : Obstacle
{
    float x;
    public void Start()
    {
         x = UnityEngine.Random.Range(-2f, 2f);
    }
    public override void Move()
    {
        
        transform.Translate(new Vector3(x, 0, 0)*Time.deltaTime,Space.World);
        if (transform.position.x < -2)
        {
            x = 1;
        }

        if(transform.position.x>2)
        {
            x = -1;
        }
    }
}
