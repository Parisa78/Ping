using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer spriteRenderer;
    public bool isMovingSameDirection;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Move(Vector3 vec, bool isDirRight)
    {

        int factor = 1;
        if (isDirRight)
        {
            if (isMovingSameDirection)
            {
                spriteRenderer.flipX = false;
                factor = 1;
            }
            else
            {
                spriteRenderer.flipX = true;
                factor = -1;
            }
        }
        else
        {

            if (isMovingSameDirection)
            {
                spriteRenderer.flipX = true;
                factor = -1;
            }
            else
            {
                spriteRenderer.flipX = false;
                factor = 1;

            }
        }

        transform.position += vec * factor;
    }
}
