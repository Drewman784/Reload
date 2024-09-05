using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float DestroyTimerCur;
    private bool Destroy2;

    private void Start()
    {
        Destroy2 = true;
    }

    //Sets timer for destroy after spawn
    void FixedUpdate()
    {
        if (Destroy2)
        {
            DestroyTimerCur -= .1f;
            if (DestroyTimerCur <= 0)
            {
                Destroy(gameObject);

            }
        }
    }
}
