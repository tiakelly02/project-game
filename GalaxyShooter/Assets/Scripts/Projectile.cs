using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is for the projectile/bullets to move

public class Projectile : MonoBehaviour{

    void Update(){

       transform.Translate(new Vector3(0,3 * Time.deltaTime, 0));
    }
}
