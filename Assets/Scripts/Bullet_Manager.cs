using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bullet_Manager : MonoBehaviour
{
    public GameObject Bullets;

    public int BulletNumber;
    public float BulleteSpeed;

    private void Start()
    {
        BulletNumber = 1;
    }

    void Update()
    {
        //shooting mechanics
        if (Input.GetKeyDown(KeyCode.Space) && BulletNumber >= 1)
        {
            GameObject shot = Instantiate(Bullets, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            shot.GetComponent<Rigidbody2D>().AddForce(new Vector2(BulleteSpeed, 0));
            BulletNumber--;
        }

        //Reloading
        if (Input.GetKeyDown(KeyCode.R) && BulletNumber < 1)
        {
            BulletNumber++;
        }
    }
}
