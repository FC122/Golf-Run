using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    public CircleCollider2D hole;
    CircleCollider2D ballColl;
    BallControler ball;
    public Ball prefab;
    public GameObject canvas;
    View view;
    public int hits;

    public List<GameObject> walls;

    public AudioSource audioSource;

    public AudioSource winSound;

    public SoundFXPlayer player;

    public List<Obstacle> obstacles;
    // Start is called before the first frame update
    void Start()
    {
        ball = Instantiate(prefab, new Vector3(0, -4.5f, 0), Quaternion.identity);
        ballColl = ball.GetComponent<CircleCollider2D>();
        view = canvas.GetComponent<View>();
        ball.SetHits(hits);
        foreach(Obstacle o in obstacles)
        {
            player.colliders.Add(o.GetComponent<Collider2D>());
        }
        foreach(GameObject gameObject in walls)
        {
            player.colliders.Add(gameObject.GetComponent<Collider2D>());
        }

        player.ball = ballColl;

        player.audioSource = audioSource;
      
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacles();
        HoleHit();
        ball.MoveBall();
        view.UpdateHits(ball.GetHits());
        player.PlaySound();
    }

    private void MoveObstacles()
    {
        foreach(Obstacle o in obstacles)
        {
            o.Move();
        }
    }

    private void HoleHit()
    {
        if(hole.IsTouching(ballColl))
        {
            view.ShowYouWonPanel(true);
            //view.ShowGameOverPanel(false);
            winSound.Play();
            player.play = false;
        }
        if(ball.GetHits() == 0)
        {
            player.play = false;
            //view.ShowGameOverPanel(true);
            //view.ShowYouWonPanel(false);
        }
    }
}
