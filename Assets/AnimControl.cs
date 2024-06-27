using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
        public Animator animator;

        void Update()
        {
            // Walking  
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("Walking", true);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                animator.SetBool("Walking", true);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("Walking", true);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                animator.SetBool("Walking", true);
            }
            else
            {
                animator.SetBool("Walking", false);
            }

           
        }
}
