using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallControler : MonoBehaviour
{
    int hits = 11;
    public virtual void MoveBall()
    {

    }
    public void SetHits(int n)
    {
        hits = n;
    }
    public int GetHits()
    {
        return hits;
    }

    public void SubstractHit()
    {
        hits--;
    }
}
