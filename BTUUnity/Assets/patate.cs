using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patate : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Hit1", true);

            //on d�sactive le comportement du coup de poing
            enabled = false;
            //d�sactiver les mouvement
            gameObject.GetComponent<move>().enabled = false;
        }       
    }
}
