using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is for the projectile/bullets to move 
public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,3 * Time.deltaTime, 0));
    }
}
