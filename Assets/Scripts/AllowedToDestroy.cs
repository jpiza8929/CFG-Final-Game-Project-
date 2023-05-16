using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowedToDestroy : MonoBehaviour
{
  OracleManager oraclemanager;
  PlayerController Pc;
  DestroyOracle DO;
  StatueManager sm;

  public bool rightoracle = false;
  
    // Start is called before the first frame update
    void Start()
    {
   oraclemanager = GameObject.Find("OracleManager").GetComponent<OracleManager>();
   Pc = GameObject.Find("Player").GetComponent<PlayerController>();
   DO = GameObject.Find("Player").GetComponent<DestroyOracle>();
   sm = GameObject.Find("StatueManager").GetComponent<StatueManager>();
    }

    // Update is called once per frame
    void Update()
    {

       if(rightoracle && oraclemanager.nextcyclecomplete)
       {
        sm.Destroy();
       } 
    }



    public void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.CompareTag("Player"))
        {

            Debug.Log("enter");
            rightoracle = true;
        
        
        }
    
    
    }
}
