using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroPlayer : MonoBehaviour
{
    public GameObject tiro;
    public Transform Tiroposicao;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Fire3"))
        {
            Instantiate(tiro, Tiroposicao.position, transform.rotation);
            Destroy(tiro.gameObject, 10f);
        }
    }
}
