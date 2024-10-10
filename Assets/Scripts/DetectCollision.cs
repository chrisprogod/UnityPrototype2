using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public AudioSource Punchsound;
    public HealthManager healthManager;
    void Start()
    {
        Punchsound = GetComponent<AudioSource>();
        healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnTriggerEnter(Collider other) 
    {
        // Check if the other object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Log a message if the player is hit
            Debug.Log("Player has been hit!");
            Punchsound.Play();
            while(!Punchsound.isPlaying)
            {
                Destroy(gameObject);
            }
            healthManager.TakeDamage();
        }

        if(other.CompareTag("Steak"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
