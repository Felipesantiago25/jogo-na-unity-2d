using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Apple : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public GameObject collected;
    public int Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
{
if(collider.gameObject.tag =="Player")
{
    sr.enabled = false;
    circle.enabled = false;
    collected.SetActive(true);

GameController.instance.totalScore += Score;
GameController.instance.UpdateScoreText();

    Destroy(gameObject, 0.3f);
}
}
}


