using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Transform player2;
    public NavMeshAgent navMeshAgent;

    void Start (){
        navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    void Update (){
        
            navMeshAgent.SetDestination(player.position);    

    }

    private void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Player"){
            Debug.Log ("Colidiu");
        }
    }
}
