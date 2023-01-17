using UnityEngine;

public class Beam : Obstacle
{
    public override void SetPosition(float x, float y)
    {
        GetComponent<Transform>().position = new Vector3(x, y, 0);
    }

    public override void RandomlyRotate()
    {
        GetComponent<Transform>().eulerAngles = new Vector3(UnityEngine.Random.Range(0, 30), UnityEngine.Random.Range(0, 30), UnityEngine.Random.Range(0, 180));
    }
}
