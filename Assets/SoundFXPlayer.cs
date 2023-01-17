using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public List<Collider2D> colliders;
    public CircleCollider2D ball;

    public bool play=true;
    // Start is called before the first frame update
   public void PlaySound()
   {
        if (play)
        {
            foreach (Collider2D col in colliders)
            {
                if (col.IsTouching(ball))
                {
                    audioSource.Play();
                }
            }
        }
   }
}
