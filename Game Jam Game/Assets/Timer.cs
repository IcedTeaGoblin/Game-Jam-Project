﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    public Rigidbody2D Collectable;
    // Start is called before the first frame update
    void Start()
    {
        timer = mainTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
        }
        
        else if(timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            timer = 0.0f;

            ///Create an Object
            Instantiate(Collectable, new Vector3(Random.Range(-14.0f, 14.0f), 6.0f, 0.0f), Quaternion.identity);

            timerReset();
        }
    }

    public void timerReset()
    {
        canCount = true;
        doOnce = false;
        timer = Random.Range(1.00f, 4.00f);
    }
}
