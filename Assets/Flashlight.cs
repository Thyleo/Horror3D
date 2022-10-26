using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject light;
    public bool toggle;
    public AudioSource toggleSound;

    private void Start()
    {
        if (toggle == false)
        {
            light.SetActive(false);
        }
        else
        {
            light.SetActive(true);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            //toggleSound.Play();
            if(toggle == false)
            {
                light.SetActive(false);
            }
            else
            {
                light.SetActive(true);
            }
        }
    }
}
