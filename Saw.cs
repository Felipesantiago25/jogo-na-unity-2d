using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Saw : MonoBehaviour
{
    public float speed;
    public float moveTime;
    private bool dirRight;
    private float timer;
    
    // Update is called once per frame
    void Update()
    {
        if(dirRight)
        {

transform.Translate(Vector2.right * speed * Time.deltaTime); 
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    
         timer += Time.deltaTime;
         if(timer >= moveTime)
    {
        dirRight = !dirRight;
        timer = 0f;
    }
    }
}
