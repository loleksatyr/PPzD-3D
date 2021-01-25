using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enter_lab : MonoBehaviour
{
   
           private void OnTriggerEnter(Collider other)
    {
        Door.ifin = true;
    }
}
