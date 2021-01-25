using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterworld : MonoBehaviour
{
    // Start is called before the first frame update
  
        private void OnTriggerEnter(Collider other)
    {
        Door.ifin = false;
    }
}
