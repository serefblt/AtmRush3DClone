using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atm : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {
            Destroy(other.gameObject);
          
        }
        if (other.gameObject.CompareTag("GoldMoney2"))
        {
            Destroy(other.gameObject);
         
        }
        if (other.gameObject.CompareTag("GoldMoney"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("ElmasMoney"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.AddComponent<CollectController>();
        }
    }
}
