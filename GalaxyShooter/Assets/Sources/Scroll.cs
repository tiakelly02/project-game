using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    public float scroll = 0.2f;
    private SpriteRenderer mesh;
    private float scrolling;
    // Start is called before the first frame update
    void Awake()
    {
        mesh = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        backgroundScroll();
    }

    void backgroundScroll(){
        scrolling = Time.time * scroll;
        Vector2 offset = new Vector2(scroll, 0f);
       

    }
}
