using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0f, 1f)] public float moveAmount;

    public GameObject Complayer;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) )
        {
            transform.position += new Vector3(0, moveAmount, 0);
            Complayer.GetComponent<enemy>().Move(new Vector3(0, moveAmount, 0), true);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -moveAmount, 0);
            Complayer.GetComponent<enemy>().Move(new Vector3(0, -moveAmount, 0), true);
        }
        else
        {
            transform.position += new Vector3(0, 0, 0);//??vector2.zero
            Complayer.GetComponent<enemy>().Move(new Vector3(0, 0, 0), true);
        }
    }

 
}
