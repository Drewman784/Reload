using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_New : MonoBehaviour
{
    public float moveSpeed;
 
    void Update()
    {
        //movement mechanics
        float movementInput2 = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position += new Vector3(movementInput2, 0, 0);
    }
}
