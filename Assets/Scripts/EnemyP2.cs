using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyP2 : MonoBehaviour
{
    public Transform player;
    public Transform player2;
    public NavMeshAgent navMeshAgent;

    void Start (){
        navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    void Update (){
        
            navMeshAgent.SetDestination(player2.position);    

    }

    private void OnCollisionEnter(Collision other){
        if(other.collider.tag == "Player"){
            Debug.Log ("Colidiu");
        }
    }
}
