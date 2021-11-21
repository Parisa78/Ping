﻿using System.Collections;
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

    private void OnCollisionEnter(Collision collision)
    {

        //if (collision.gameObject.CompareTag(TagNames.leftWall.ToString()))
        //{
        //    Debug.Log("left waalll");
        //    left_wall = false;

        //}

        //if (collision.gameObject.CompareTag(TagNames.rightWall.ToString()))
        //{
        //    Debug.Log("rigght waalll");
        //    right_wall = false;
        //}

        //if (collision.gameObject.CompareTag(TagNames.roof.ToString()))
        //{
        //    roof = false;
        //}

        //if (collision.gameObject.CompareTag(TagNames.ground.ToString()))
        //{
        //    Debug.Log("groound");
        //    ground = false;
        //}

        //if (collision.gameObject.CompareTag(TagNames.fuel.ToString()))
        //{
        //    Debug.Log("fuel");
        //    uimanager.FuelCount(10);
        //    Destroy(collision.gameObject);
        //}

        //if (collision.gameObject.CompareTag(TagNames.heart.ToString()))
        //{
        //    Debug.Log("heeeaart");
        //    uimanager.UpdateHeartCountText(1);
        //    Destroy(collision.gameObject);
        //}

        //if (collision.gameObject.CompareTag(TagNames.enemy.ToString()))
        //{
        //    Debug.Log("heeeaart");
        //    uimanager.UpdateHeartCountText(-1);
        //    Destroy(collision.gameObject);
        //}

        //if (collision.gameObject.CompareTag(TagNames.Hbullet.ToString()))
        //{
        //    uimanager.UpdateHeartCountText(-1);
        //    Destroy(collision.gameObject);
        //}
    }
}
