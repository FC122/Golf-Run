using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteLevelGenerator : MonoBehaviour
{
  
    public List<Obstacle> obstacles = new List<Obstacle>();//here
    public void SpawnObstacles(int N,float upperLimmit,float lowerLimmit,float increment,Obstacle prefab)
    {   
        for (int i = 0; i < N; i++)
        {
            float x = UnityEngine.Random.Range(-2,2);
            float y = UnityEngine.Random.Range(upperLimmit, lowerLimmit);
            SpawnObstacle(x, y, prefab);
            upperLimmit -= increment;
            lowerLimmit -= increment;
        }
    }
   

    public void SpawnObstacle(float x,float y, Obstacle prefab)
    {
        Obstacle obstacle = Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity) as Obstacle;
        obstacle.RandomlyRotate();
        obstacles.Add(obstacle);
        obstacle.SetRandomColor();
    }

    public void RemoveObstacles()
    {
        foreach (Obstacle obstacle in obstacles)
        {
            obstacle.SetPosition(0, 20);
        }
    }


}
