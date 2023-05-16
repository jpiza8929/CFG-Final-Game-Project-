using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   Vector3 Vel;

   public float speed;
  
   public float upRotation;
   public float downRotation;

   CharacterController Cc;

   public float lookSensitivity;

   float xRotation;

   public Transform playerCam;

   //gravity variables//

   public float gravityinf = 2.8f;

   private float gravity = 9.81f;


   //Payer Cam//

   public Camera mainCam;

   //Ray cast distance//

   public float CastDist;

   //bool that tells if the player was able to hit something//

   public bool successfulhit;


   Vector3 pointHit;

   //bool for ray touching the oracle statues//

   public bool rayistouchingOracle, oracle1touched, oracle2touched, oracle3touched, oracle4touched;

   public bool isKeyPressed;


   
   StatueManager Sm;
   
   DestroyOracle DO;

   Phase2 p2;

   OracleManager om;
    // Start is called before the first frame update
    void Start()
    {
          Cc = GetComponent<CharacterController>();
          Sm = GameObject.Find("StatueManager").GetComponent<StatueManager>();
          
          p2 = GameObject.Find("Oracle Podium 2").GetComponent<Phase2>();

          om = GameObject.Find("OracleManager").GetComponent<OracleManager>();
         
        
    }

   
   
    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
        playerCam.localRotation = Quaternion.Euler(xRotation,0,0);

        Vel.x = Input.GetAxis("Vertical") * speed;
        Vel.z = Input.GetAxis("Horizontal") * speed;
        

        Vel = transform.TransformDirection(Vel);
        Cc.Move(Vel * Time.deltaTime);

        //this code prevents the player from floating in air and keeps the player grounded//
        if(Cc.isGrounded == false)
        {
            Vel.y -= gravity * Time.deltaTime * gravityinf;
        }

       if(Input.GetKeyDown(KeyCode.E))
      {

        isKeyPressed = true;


        //Debug.Log("Pressing E");
        
      }
      else
      {
        if(Input.GetKeyUp(KeyCode.E))
        {
          isKeyPressed = false;
        }
      

      
            
        }
        

        

       
        
      
      }

      void FixedUpdate()
    {

     RaycastHit Hit;
     Vector3 StartingPosofRay = mainCam.ViewportToWorldPoint(Input.mousePosition);
     if(Physics.Raycast(StartingPosofRay, playerCam.forward, out Hit, CastDist))
     {
      
    
      
      Debug.Log(Hit.transform.name);
      successfulhit = true;

     
     //accessing the vector 3 location of wherever the player hits//
      pointHit = Hit.point;

      if(Hit.transform.tag == "Oracles")
      {
        rayistouchingOracle = true;
        //accessing the keyline string from the iteminfo script//
        
      }
        
        else
        {
          rayistouchingOracle = false;
        }

       
        if(Hit.transform.tag == "Oracles 1")
        {
          oracle1touched = true;
        }

        else
        {
          oracle1touched = false;
        }


        if(Hit.transform.tag == "Oracles 2")
        {
          oracle2touched = true;
        }

        else
        {
          oracle2touched = false;
        }


        if(Hit.transform.tag == "Oracles 3")
        {
          oracle3touched = true;
        }

        else
        {
          oracle3touched = false;
        }


        if(Hit.transform.tag == "SecondWave")
        {
          oracle4touched = true;
        }

        else
        {
          oracle4touched = false;
        }


      }

     //this else statement is for if the player wasn't able to hit something, the code above is for when the player hits something//
     else
     {
      successfulhit = false;
     }

     Debug.DrawRay(StartingPosofRay, playerCam.forward, Color.red);
   }
   

}
      

    

