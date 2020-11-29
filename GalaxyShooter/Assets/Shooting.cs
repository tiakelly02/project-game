using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireDelay = 0.20f;
    float cooldownTimer = 0;

    // Update is called once per frame
    void Update(){
      cooldownTimer = Time.deltaTime;
       if(Input.GetButton("Fire1") && cooldownTimer <= 0) {
         Debug.Log("FIRE!!");
           cooldownTimer = fireDelay;
        }
    }
}
