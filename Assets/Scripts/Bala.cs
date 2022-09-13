using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Rigidbody ctr;
    public float Speed = 50f;
    Vector3 movimento;
    GameObject Inimigo;
    

    
    // Start is called before the first frame update
    void Start()
    {

        ctr = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        ctr.velocity = transform.forward * Speed;
        
    }
	private void OnTriggerEnter(Collider other)
	
	{
        if (other.gameObject.tag == "Inimigo")
        {
            Destroy(Inimigo);


        }
        if (other.gameObject.tag != null)
        {
            Destroy(gameObject);
        }
    }
}
