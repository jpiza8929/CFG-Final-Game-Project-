using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOracle : MonoBehaviour
{
    StatueManager sm;

    OracleManager OM;
    public bool playerdetect;

    PlayerController PC;

    EnemyHealth enemyhealth;
 
    public bool complete;

    public Animator myanimator;


    public GameObject oracle1, oracle2, oracle3, oracle4;


 

    bool firstdelete = false;
    
   bool AbletoDestroy = true;

   public bool incorrect = false;

   bool gotright = false;
   
  bool seconddestroyed = false;

  bool Greencorrect = false;

  public bool nextcycle = false;

  bool startdestroy = false;

  bool secondcycle = false;

  public bool dontrepewat = false;

public bool stop = false;

public bool damage = false;

public bool damage2 = false;

public bool damage3 = false;

public bool damage4 = false;



  
   
    // Start is called before the first frame update
    
    void Start()
    {
        sm = GameObject.Find("StatueManager").GetComponent<StatueManager>();
        OM = GameObject.Find("OracleManager").GetComponent<OracleManager>();
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
        enemyhealth = GameObject.Find("Player").GetComponent<EnemyHealth>();

        myanimator = GetComponent<Animator>();
        complete = false;

        


        
    }

    // Update is called once per frame
    void Update()
    {
      
  
   
           if(OM.cycleComplete)
        {
      
       
        
          checkRightOracletoDestroy();
    
        }


        if(damage && damage2 && damage3 && damage4)
        {
          enemyhealth.damagetick(2);

          if(enemyhealth.Health <= 405)
          {
            enemyhealth.Health = 45;
          }
        
        }

       


       }
       
      
    //order goes from blue, orange, green, yellow//

     //code for 1st phase//

     //this code makes sure if player is pressing wrong oracle it plays the wrong animation to show that's the wrong oracle in order//
    
    
    public void checkRightOracletoDestroy()
    {

 
    
      //first orcale//
         if(PC.rayistouchingOracle && PC.isKeyPressed)
       {
        
        sm.oracle.SetActive(false);
        //enemyhealth.damagetick(10);
        damage = true;
       }

       if(PC.oracle1touched && PC.isKeyPressed)
       {
         incorrect = true;
         myanimator.SetBool("wrong", true);

        
        
       }

       if(PC.oracle2touched && PC.isKeyPressed)
       {
        incorrect = true;
         myanimator.SetBool("wrong", true);
       }  

       if(PC.oracle3touched && PC.isKeyPressed)
       {
             incorrect = true;
             myanimator.SetBool("wrong", true);
       }

        if(sm.oracle.activeSelf == false)
         {
            incorrect = false;
            myanimator.SetBool("wrong", false);
         }

        
         if(myanimator.GetBool("wrong") == false && incorrect == false)
         {
           
            
       if(PC.oracle2touched && PC.isKeyPressed)
       {
          damage2 = true;
           sm.oracle3.SetActive(false);
           Greencorrect = true;
       }

        
       if(PC.oracle1touched && PC.isKeyPressed)
       {
             incorrect = true;
             myanimator.SetBool("wrong", true);
       }

       if(PC.oracle3touched && PC.isKeyPressed)
       {
             incorrect = true;
             myanimator.SetBool("wrong", true);
       }

       if(Greencorrect)
       {

       if(PC.oracle3touched && PC.isKeyPressed)
       {
             incorrect = true;
             myanimator.SetBool("wrong", true);
       }

         
       if(PC.oracle1touched && PC.isKeyPressed)
       {
            damage3 = true;
            sm.oracle2.SetActive(false);
       }
       }

       if(sm.oracle2.activeSelf == false)
       {
        myanimator.SetBool("wrong",false);


       if(PC.oracle3touched && PC.isKeyPressed)
       {
               damage4 = true;
               sm.oracle4.SetActive(false);
               nextcycle = true;
               

       }

       
      }


    }
       
    }

    }
     
    
      
       

    

        
       

  
       
        
       
      
       


      

        
         
    



 








   

     
    
    
    


 
    
    
 
 
 

  



        
       
    


        



