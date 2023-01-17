using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteLevelModel : MonoBehaviour
{
    //program here all interaction and spawning of obstacles ball and hole
    InfiniteLevelGenerator generator = new InfiniteLevelGenerator();
    InfiniteLevelView view;
    BallControler controler;
    Touch touch;
    public Obstacle beam;
    public Obstacle wheel;
    public Obstacle boat;
   
    CircleCollider2D ballColider;//to Model
    public CircleCollider2D holeColider;//to Model
    public Ball ballPrefab;//ToModel

    int score=0;
  
    // Start is called before the first frame update
    void Start()
    {
        generator.SpawnObstacles(0,3,(float)1.5,(float)0.75,beam);
        SpawnBall();
        view = GameObject.Find("Canvas").GetComponent<InfiniteLevelView>();
    }
    // Update is called once per frame
    void Update()
    {
        view.UpdateHits(controler.GetHits()-1);
        controler.MoveBall();
        MoveObjects();
        if (holeColider.IsTouching(ballColider))
        {
            score += 100 + controler.GetHits();
            view.UpdateScore(score);
            generator.RemoveObstacles();
            GenerateLevel();

            PlaceBall();
            controler.SetHits(11);
        }
        if(controler.GetHits()==0)
        {
            view.ShowGameOverPanel(true);
        }
    }
   
    private void MoveObjects()
    {
      //calls Move() on every obstacle so when called in update it would make a moveing animation on screen
      foreach(Obstacle o in generator.obstacles)
        {
            o.Move();
        }
    }

    private void SpawnBall()//To Model
    {
        float y = (float)-4.5;
        controler = Instantiate(ballPrefab, new Vector3(0, y, 0), Quaternion.identity);
        ballColider = controler.GetComponent<CircleCollider2D>();
    }

    private void PlaceBall()//To Model
    {
        float y = (float)-4.5;
        controler.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        controler.GetComponent<Rigidbody2D>().transform.position = new Vector3(0, y, 0);
    }

    public void GenerateLevel()
    {
        if (score < 1000)
        {
            generator.SpawnObstacles(score / 100, 3, 2, 1, beam);
        }
        else if(score<2000)
        {
            generator.SpawnObstacles(((score/100))-10,3,2,1,wheel);
        }
        else if (score<3000)
        {
            generator.SpawnObstacles(((score / 100)) - 20, 3, 2, 1, boat);
        }else
        {
            for(int i=0;i<10;i++)
            {
                int rand = UnityEngine.Random.Range(0, 3);
                if (rand == 0)
                {
                    generator.SpawnObstacles(1, 3, -3, 0, beam);
                }
                else if (rand == 1)
                {
                    generator.SpawnObstacles(1, 3, -3, 0, wheel);
                }
                else if(rand==2)
                {
                    generator.SpawnObstacles(1, 3, -3, 0, boat);
                }
            }
           
         
        }
        //make an algorithm that generates more and more complex levels
    }
    


}
