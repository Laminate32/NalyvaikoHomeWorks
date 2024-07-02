using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxHealth;
   [SerializeField] private float CurrentHealth;



    void Start()
    {
        CurrentHealth = MaxHealth;
    }


    public void TakeDamage(float Amount)
    {
        CurrentHealth -= Amount;

        if (CurrentHealth <= 0)
        {
            CurrentHealth = MaxHealth;
            GameObject.Destroy(gameObject);
        }
    }
}
