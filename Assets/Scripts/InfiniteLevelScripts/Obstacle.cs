using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle:MonoBehaviour
{
    

    public virtual void Move()
    {

    }
    public virtual void SetPosition(float x,float y)
    {
        transform.position = new Vector3(x, y, 0);
    }
    public virtual void SetColor()
    {

    }

    public virtual void RandomlyRotate()
    {

    }

    public virtual void SetRandomColor()
    {
        GetComponent<SpriteRenderer>().color = new Color((float)UnityEngine.Random.Range(0f, 1f), 
                                                         (float)UnityEngine.Random.Range(0f, 1f), 
                                                         (float)UnityEngine.Random.Range(0f, 1f), 
                                                         (float)UnityEngine.Random.Range(0.5f, 1f));
    }
}
