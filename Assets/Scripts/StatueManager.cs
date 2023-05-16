using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueManager : MonoBehaviour
{

    OracleManager oraclemanager;
    PlayerController Pc;
    DestroyOracle DO;
    EnemyHealth em;
 
   
  
 

   public GameObject oracle, oracle2, oracle3, oracle4, oracle5;

    public Animator Anim;
  
 
   public Vector3[] Oraclepos = new Vector3[4];

   public bool spawned;

   bool DestroyedAllowed;

   public bool fullyspawned;
    
  public bool secondwavespawned = false;


  public bool wrongone = false;
 

  public bool dontdestroy = false;

  
  public bool takingdamage = false;

  public bool takingdamage2 = false;

  public bool takingdamage3 = false;

  public bool takingdamage4 = false;




   

// Start is called before the first frame update
void Start()
{
   oraclemanager = GameObject.Find("OracleManager").GetComponent<OracleManager>();
   Pc = GameObject.Find("Player").GetComponent<PlayerController>();
   DO = GameObject.Find("Player").GetComponent<DestroyOracle>();
   em = GameObject.Find("Player").GetComponent<EnemyHealth>();
  
   Anim = GameObject.Find("DestroyerOracle").GetComponent<Animator>();
  
   DestroyedAllowed = false;

  
   spawned = false;

     oracle  = Instantiate(oracle, Oraclepos[0], Quaternion.identity);
     oracle2 = Instantiate(oracle2, Oraclepos[1], Quaternion.identity);
     oracle3 = Instantiate(oracle3, Oraclepos[2], Quaternion.identity);
     oracle4 = Instantiate(oracle4, Oraclepos[3], Quaternion.identity);
     oracle5 = Instantiate(oracle5, Oraclepos[3], Quaternion.identity);
   
     oracle.SetActive(false);
     oracle2.SetActive(false);
     oracle3.SetActive(false);
     oracle4.SetActive(false);
     oracle5.SetActive(false);

    

     
     StartCoroutine(Spawn());

     
   }

    
  


  


void Update()
{

if(!spawned)

{


    
  if(oraclemanager.nextcyclecomplete)
  
  {

    StartCoroutine(Spawn2());
    
  

  
  }


  
}

 if(takingdamage)
      {

        em.damagetick(3);
      
      }



}


    

   public IEnumerator Spawn()
   {
        yield return new WaitForSeconds(18f);
     

         oracle.SetActive(true);
         oracle2.SetActive(true);
         oracle3.SetActive(true);
         oracle4.SetActive(true);
    
        




    }


   public IEnumerator Spawn2()
  
   {
        yield return new WaitForSeconds(1f);
     

         oracle.SetActive(true);
         oracle2.SetActive(true);
         oracle3.SetActive(true);
         oracle5.SetActive(true);

      
        spawned = true;
    
    }


  
  
  public void Destroy()
  {

     if(Pc.oracle4touched && Pc.isKeyPressed)
       {
            em.damagetick(10);
            oracle5.SetActive(false);
            takingdamage = true;
        
             
       }

        if(Pc.rayistouchingOracle && Pc.isKeyPressed)
       {
        
        dontdestroy = false;
        //em.damagetick(70);
      
        
        
       }

       if(Pc.oracle2touched && Pc.isKeyPressed)
       {
          //em.damagetick(10);
          dontdestroy = false;
          
       }  

       if(Pc.oracle1touched && Pc.isKeyPressed)
       {
        // em.damagetick(10);
         dontdestroy = false;
       }

       if(oracle5.activeSelf == false)
       {
       
        dontdestroy = true;
       
       }

       if(dontdestroy == true)
       {

         if(Pc.rayistouchingOracle && Pc.isKeyPressed)
       {
        
          oracle.SetActive(false);
        //em.damagetick(70);
        takingdamage2 = true;
      
       }

       if(Pc.oracle1touched && Pc.isKeyPressed)
       {
        // em.damagetick(10);
         dontdestroy = false;
       }

       if(Pc.oracle2touched && Pc.isKeyPressed)
       {
          //em.damagetick(10);
          dontdestroy = false;
          
       } 
        
      }

      if(oracle.activeSelf == false)
      {
        
       dontdestroy = true;
      
      
      }


      if(dontdestroy == true)
      
      {

         if(Pc.oracle1touched && Pc.isKeyPressed)
       {
        // em.damagetick(10);
        takingdamage3 = true;
        oracle2.SetActive(false);
        
       }


       if(Pc.oracle2touched && Pc.isKeyPressed)
       {
          //em.damagetick(10);
          dontdestroy = false;
          
       } 

       
      
      
      }

      if(oracle2.activeSelf == false)
      {
        dontdestroy = true;



         if(Pc.oracle2touched && Pc.isKeyPressed)
       {
           oracle3.SetActive(false);
           takingdamage4 = true;
          
       } 
      
      }


    

 
 
  }



     

   

     
      
    }





   










