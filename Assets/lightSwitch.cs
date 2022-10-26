using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public GameObject interagir, light;
    public bool toggle = true, interactable;
    public Renderer Lampe;
    public Material offlight, onlight;
    public AudioSource lightwitchSound;
    public Animator switchAnim;

    void OnTriggerStay(Collider other)
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
                toggle = !toggle;
                //lightwitchSound.Play();
                switchAnim.ResetTrigger("Press");
                switchAnim.SetTrigger("Press");
            }
        }

        if (toggle == false)
        {
            light.SetActive(false);
            Lampe.material = offlight;
        }

        if (toggle == true)
        {
            light.SetActive(true);
            Lampe.material = onlight;
        }
    }
}
