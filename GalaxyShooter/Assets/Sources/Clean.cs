﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    public float timer = 2f;
        
    void Update(){
        timer -= Time.deltaTime;
        if (timer <= 0){
            Destroy(gameObject);
        }
        
    }
}
