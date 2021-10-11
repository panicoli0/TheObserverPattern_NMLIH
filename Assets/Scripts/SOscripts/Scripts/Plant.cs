using System;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    [SerializeField] private PlantData info;

    private SetPlantInfo spi;

    private void Start()
    {
        spi = GameObject.FindWithTag("PlantInfo").GetComponent<SetPlantInfo>();
    }

    private void OnMouseDown()
    {
        spi.OpenPlantPanel();
        spi.plantName.text = info.Name;
        spi.threatLevel.text = info.Threat.ToString();
        spi.plantDescription.text = info.Description;
        spi.plantIcon.GetComponent<RawImage>().texture = info.Icon;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && info.Threat == PlantData.THREAT.High)
        {
            // We can call it like that because dead is a static variable
            PlayerController.dead = true;
            FindObjectOfType<PlayerHealth>().PlayerHP = 0;
        }
    }
}
