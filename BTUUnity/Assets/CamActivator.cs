using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamActivator : MonoBehaviour
{

    public GameObject CamToActivate;
    public GameObject CamToDesactivate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //on rentre par la gauche
        CamToDesactivate.SetActive(false);
        CamToActivate.SetActive(true);

        GameObject tmp = CamToActivate;

        CamToActivate = CamToDesactivate;
        CamToDesactivate = tmp;
    }
}
