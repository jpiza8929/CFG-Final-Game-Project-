using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OracleManager : MonoBehaviour
{

    //Declaring a list of Gameobjects and an array of vector 3 locations//
   
    public List<GameObject> Oracles;


    public GameObject BlueOracle, YellowOracle, OrangeOracle, GreenOracle;


    public List <GameObject> next;
   
    
    public GameObject Blue2, Yellow2, Green2, Orange2;
   
    //Array of Vector 3 locations//
    public Vector3[] Oraclepos = new Vector3[4];


    public Vector3[] nextwave = new Vector3[4];


    
    public AudioSource Soundplay;

    public AudioClip SecondOracle, Thirdoracle, Fourthoracle;
   
    public float delaytoSecondOracle = 3f;

    public float delay;

    public bool cycleComplete = false;

    public bool nextcyclecomplete = false;

    DestroyOracle Do;

    Phase2 phase2;

    StatueManager sm;

    bool looponce;

    public bool startgame;
   
    
    // Start is called before the first frame update
    void Start()
    
    {
        //Spawn each object at its position//
    

        Soundplay = GetComponent<AudioSource>();

        Oracles = new List<GameObject>(4);

        next = new List<GameObject>(4);

        Do = GameObject.Find("DestroyerOracle").GetComponent<DestroyOracle>();
        phase2 = GameObject.Find("Oracle Podium 2").GetComponent<Phase2>();
    
        sm = GameObject.Find("StatueManager").GetComponent<StatueManager>();
     
       looponce = false;


        
        
        StartCoroutine(OracleSummon());
    
        
            
        
        
    }
      
    // Update is called once per frame
    void Update()
    {
    
    if(Do.nextcycle)
       {

        cycleComplete = false;
       }
    

    }
      
      
      
    //This coroutine starts the order of the oracles in the middle of the level//
    //loops 3 times, plays the order 3 times//
       public IEnumerator OracleSummon()
   
     {
        for(int i = 0; i<2; i++)
        {
         yield return new WaitForSeconds(1);

        GameObject newOracle = Instantiate(BlueOracle, Oraclepos[0], Quaternion.identity);
       
        Oracles.Add(newOracle);

        if(newOracle != null)
        {
            Soundplay.Play();
            
        }
       
         yield return new WaitForSeconds(delaytoSecondOracle);
        
         GameObject newOracle2 = Instantiate(GreenOracle, Oraclepos[1], Quaternion.identity);
       
          Oracles.Add(newOracle2);
        
         if(newOracle2 != null)
        {
           playSecond();
        }

         yield return new WaitForSeconds(delaytoSecondOracle);
         
         GameObject newOracle3 = Instantiate(OrangeOracle, Oraclepos[2], Quaternion.identity);
       
         Oracles.Add(newOracle3);
         
         if(newOracle3 != null)
        {
           playThird();
        }

        yield return new WaitForSeconds(delaytoSecondOracle);

         
         GameObject newOracle4 = Instantiate(YellowOracle, Oraclepos[3], Quaternion.identity);
       
        Oracles.Add(newOracle4);
         if(newOracle4 != null)
        {
           playFourth();
        }

        yield return new WaitForSeconds(2);

         if(newOracle && newOracle2 && newOracle3 && newOracle4 != null)
         
         {
            newOracle.SetActive(false);
            newOracle2.SetActive(false);
            newOracle3.SetActive(false);
            newOracle4.SetActive(false);

            Oracles.Remove(newOracle);
            Oracles.Remove(newOracle2);
            Oracles.Remove(newOracle3);
            Oracles.Remove(newOracle4);

            Destroy(newOracle);
            Destroy(newOracle2);
            Destroy(newOracle3);
            Destroy(newOracle4);
           
           
            Oracles.Clear();


         }
           
         
        
        yield return new WaitForSeconds(2);
        
         }

         cycleComplete = true;

        
        
       
        }
     

    public void playSecond()
    {
        Soundplay.clip = SecondOracle;
        Soundplay.Play();
    }

    public void playThird()
    {
        Soundplay.clip = Thirdoracle;
        Soundplay.Play();
    }

    public void playFourth()
    {
        Soundplay.clip = Fourthoracle;
        Soundplay.Play();
    }

    
    
    //oracle on blue is Oracles tag//

    //oracle on orange is oraces 1 tag//

    //oraces on yellow is oracles 3 tag//

    //oracles on green is oracles 2 tag//



   
   
    public IEnumerator SecondPhase()
    {

         for(int i = 0; i<2; i++)
        {
         yield return new WaitForSeconds(1);

        GameObject newOracle = Instantiate(Yellow2, nextwave[0], Quaternion.identity);
       
        Oracles.Add(newOracle);

        if(newOracle != null)
        {
            Soundplay.Play();
            
        }
       
         yield return new WaitForSeconds(delaytoSecondOracle);
        
         GameObject newOracle2 = Instantiate(Blue2, nextwave[1], Quaternion.identity);
       
          Oracles.Add(newOracle2);
        
         if(newOracle2 != null)
        {
           playSecond();
        }

         yield return new WaitForSeconds(delaytoSecondOracle);
         
         GameObject newOracle3 = Instantiate(Green2, nextwave[2], Quaternion.identity);
       
         Oracles.Add(newOracle3);
         
         if(newOracle3 != null)
        {
           playThird();
        }

        yield return new WaitForSeconds(delaytoSecondOracle);

         
         GameObject newOracle4 = Instantiate(Orange2, nextwave[3], Quaternion.identity);
       
        Oracles.Add(newOracle4);
         if(newOracle4 != null)
        {
           playFourth();
        }

        yield return new WaitForSeconds(2f);

         if(newOracle && newOracle2 && newOracle3 && newOracle4 != null)
         
         {
            newOracle.SetActive(false);
            newOracle2.SetActive(false);
            newOracle3.SetActive(false);
            newOracle4.SetActive(false);

            Oracles.Remove(newOracle);
            Oracles.Remove(newOracle2);
            Oracles.Remove(newOracle3);
            Oracles.Remove(newOracle4);

            Destroy(newOracle);
            Destroy(newOracle2);
            Destroy(newOracle3);
            Destroy(newOracle4);
           
           
            Oracles.Clear();


         }
           
         
        
        yield return new WaitForSeconds(1f);
        
         }

         nextcyclecomplete = true;

        
       
        }
     





    

    }

    



    


       

    
   
   

