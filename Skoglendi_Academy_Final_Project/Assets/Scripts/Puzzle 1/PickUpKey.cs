﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{

    private bool nearKey = false;
    private AudioSource audio;
    public int keyID;

    private void Start() {
        audio = GetComponentInChildren<AudioSource>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && nearKey == true)
        {
            Destroy(gameObject);
            PlayerController.haveKey = true;
            audio.Play(0);
        }

    }





    private void OnTriggerEnter(Collider other)
    {
        nearKey = true;
    }

    private void OnTriggerExit(Collider other)
    {
        nearKey = false;
    }







}
