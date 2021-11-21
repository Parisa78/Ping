using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D RG;
    [Range(100f, 250f)] public float moveAmount;
    private UiManager ui;
    public Vector3 startp;

    private void Awake()
    {
        RG = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        startp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        ui = FindObjectOfType<UiManager>();
        StartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void StartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f,-0.5f) : Random.Range(0.5f, 1.0f);
        RG.AddForce(new Vector3(x,y,0) * moveAmount);
    
    }
    private void StartingForce2()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f,-0.5f) : Random.Range(0.5f, 1.0f);
        RG.AddForce(new Vector3(x,y,0) * -1);
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag(TagNames.rightWall.ToString()))
        {
            Debug.Log("left waalll");
            ui.ScoreCount();
            transform.position = startp;
            if (!ui.endgame)
            {
                StartingForce2();
            }
        }

        if (collision.gameObject.CompareTag(TagNames.leftWall.ToString()))
        {
            Debug.Log("rigght waalll");
            ui.ComScoreCount();
            transform.position = startp;
            if (!ui.endgame)
            {
                StartingForce2();
            }
            
        }

    }

}
