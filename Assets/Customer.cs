using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Customer : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Customer")
        {
            Debug.Log("Package Delivered!");
        }
    }
}
