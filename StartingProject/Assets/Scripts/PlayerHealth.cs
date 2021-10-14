using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float playerHealth = 100f;

    public float PlayerHP { get => playerHealth; set => playerHealth = value; }

    private void DrainDamage()
    {
        //todo: continue drainig player HP like he is infected
    }
}