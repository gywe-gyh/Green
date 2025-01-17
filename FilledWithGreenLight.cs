using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FilledWithGreenLight : MonoBehaviour
{
    public Transform ImJustKiddingGreenIsAllINeed;
    // Start is called before the first frame update
    void LateUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.green);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            ImJustKiddingGreenIsAllINeed.position = hit.point;
            hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;

        }
    }
    
    
      
    
    

    // Update is called once per frame

}
