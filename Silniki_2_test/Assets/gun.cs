﻿
using UnityEngine;

public class gun : MonoBehaviour
{
    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot ()
    {
        RaycastHit hit;
         if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit));
        {
            Debug.Log(hit.transform.name);
        }
    }
}

