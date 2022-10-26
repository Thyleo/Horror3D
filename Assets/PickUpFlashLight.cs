using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashLight : MonoBehaviour
{
    public GameObject interagir, Lampe_Table, Lampe_Main;
    public AudioSource pickUp;
    public bool interactable;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interagir.SetActive(true);
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interagir.SetActive(false);
            interactable = false;
        }
    }

    private void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interagir.SetActive(false);
                interactable = false;
                //pickUp.Play();
                Lampe_Main.SetActive(true);
                Lampe_Table.SetActive(false);
            }
        }
    }
}
