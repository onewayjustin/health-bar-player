using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealthbar : MonoBehaviour
 {
      
    public int maxHealth =100;
    public int currentHealth;

    public HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
       currentHealth =maxHealth;
       healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Keycode.space)) 
        {
            TakeDamage(20);
        }

    }
     void TakeDamage(int damage)
    {
         currentHealth =damage;

         healthBar.SetHealth(currentHealth);
    }      
}