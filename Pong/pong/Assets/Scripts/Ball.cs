using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D RG;
    [Range(100f, 250f)] public float moveAmount;

    private void Awake()
    {
        RG = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
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

}
