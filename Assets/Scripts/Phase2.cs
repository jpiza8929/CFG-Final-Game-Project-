using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2 : MonoBehaviour
{
    DestroyOracle DO;
    OracleManager om;
    PlayerController pc;


    public bool spawnonce = false;

    public bool startready = false;
    
    // Start is called before the first frame update
    void Start()
    {
        DO = GameObject.Find("DestroyerOracle").GetComponent<DestroyOracle>();
        om = GameObject.Find("OracleManager").GetComponent<OracleManager>();
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //Ontrigger runs multiple times//
    
    public void OnTriggerEnter(Collider other)
    {
        
        if(DO.nextcycle)
        {
          
            if(other.gameObject.CompareTag("Player")&& !spawnonce)
            {
                
               
               StartCoroutine(om.SecondPhase());
               spawnonce = true;


             

              
               
            }
            }
            
        }
    
}
    

