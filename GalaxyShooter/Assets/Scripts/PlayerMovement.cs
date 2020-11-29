using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is script is for the players movement and for the player to fire bullets at enemies

public class PlayerMovement : MonoBehaviour
{

    public GameObject projectile;
    public GameObject projectileClone;
    public GameObject player;
 
    void Update()
    {
        ArrowKeys();
        FireBullet();
    }

        void ArrowKeys()
        {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(4 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-4 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0,4 * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -4 * Time.deltaTime, 0));
        }
     }

    void FireBullet()
     {
          if (Input.GetKey(KeyCode.Space)) { 
           projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x,player.transform.position.y +0.7f,0),player.transform.rotation)as GameObject; 
        }
    }
}