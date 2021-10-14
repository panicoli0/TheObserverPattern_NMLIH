﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateryHandler : MonoBehaviour
{
    [SerializeField] float lightAngle;
    [SerializeField] float lightIntensity;
    //[SerializeField] AudioClip pickupSounds;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //GetComponent<AudioSource>().PlayOneShot(pickupSounds);
            collision.gameObject.GetComponentInChildren<FlashlightLifetime>().RestoreAngle(lightAngle);
            collision.gameObject.GetComponentInChildren<FlashlightLifetime>().AddLightIntensity(lightIntensity);
            Destroy(gameObject);
        }
    }
}
