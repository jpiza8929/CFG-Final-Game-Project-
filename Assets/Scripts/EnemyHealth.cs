using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
   public float Health;

   static float maxHealth = 100f;


   public Slider Healthbar;

   DestroyOracle Do;

   OracleManager OM;

   StatueManager sm;

   bool damagetaken = false;
   
    // Start is called before the first frame update
    private void Start()
    {
        Healthbar.minValue = 0;

        Healthbar.maxValue = maxHealth;

        Health = maxHealth;

        Do = GameObject.Find("DestroyerOracle").GetComponent<DestroyOracle>();

        OM = GameObject.Find("OracleManager").GetComponent<OracleManager>();
        
        sm = GameObject.Find("StatueManager").GetComponent<StatueManager>();
        

    }

    // Update is called once per frame
    void Update()
    {

 
      
     Healthbar.value = Health;   
    
    
      if(sm.takingdamage && sm.takingdamage2 && sm.takingdamage3 && sm.takingdamage4)
      {
       
       GameObject slider = GameObject.Find("HealthSlider");
       slider.SetActive(false);

       GameObject text = GameObject.Find("Boss Text");
       text.SetActive(false);

       GameObject boss = GameObject.Find("Oracle Podium 2");
       boss.SetActive(false);

       GameObject Particles = GameObject.Find("Particle System");
       Particles.SetActive(false);
      
   

       
       
      }
    }


    public void damagetick(int damage)
 
    {

    Health = Health - damage/maxHealth;



     }
   

}
