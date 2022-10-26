using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public GameObject interagir;
    public bool interactable, toggle;
    public Animator doorAnim;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interagir.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interagir.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                if (toggle == true)
                {
                    doorAnim.ResetTrigger("Ferme");
                    doorAnim.SetTrigger("Ouvert");
                }
                if (toggle == false)
                {
                    doorAnim.ResetTrigger("Ouvert");
                    doorAnim.SetTrigger("Ferme");
                }
                interagir.SetActive(false);
                interactable = false;
            }
        }
    }
}
