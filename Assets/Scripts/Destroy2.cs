using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2 : MonoBehaviour
{
    
  
    

    StatueManager sm;
    
    OracleManager OM;

    PlayerController PC;
   
   
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StatueManager").GetComponent<StatueManager>();
        OM = GameObject.Find("OracleManager").GetComponent<OracleManager>();
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
        



        
    }

    // Update is called once per frame
    void Update()
    {

       
        
    }



     







}
