using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalKitHandler : MonoBehaviour
{

    [SerializeField] float hpIncremental;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerHealth>().PlayerHP += hpIncremental;
            //Debug.Log("HP was increased by: " + hpIncremental + " Your current HP is: " + currentHP);
        }
    }
}
