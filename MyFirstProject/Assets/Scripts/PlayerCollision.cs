using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // player's movement
 
    public MeshRenderer mr;
    public ParticleSystem particle;
    
    

    public void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        
        mr = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // If player hits an obstacle, disable players movement.
            StartCoroutine(Break());
            FindObjectOfType<GameManager>().EndGame();

        }
    }

    private IEnumerator Break()
    {
     
        particle.Play();
        mr.enabled = false;
        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);

        Destroy(gameObject);
    }
}
