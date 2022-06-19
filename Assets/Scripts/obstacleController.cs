using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleController : MonoBehaviour
{
    [SerializeField] Rigidbody _rig;
     float _speed = 1000f;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _rig.velocity = -Vector3.forward * _speed * Time.deltaTime;
            other.gameObject.AddComponent<CollectController>();
        }
        if (other.gameObject.CompareTag("money"))
        {
            Destroy(other.gameObject);
            ConvertMoney._score--;
        }
        if (other.gameObject.CompareTag("GoldMoney"))
        {
            Destroy(other.gameObject);
            ConvertMoney._score--;
        }
        if (other.gameObject.CompareTag("GoldMoney2"))
        {
            Destroy(other.gameObject);
            ConvertMoney._score--;
        }
        if (other.gameObject.CompareTag("ElmasMoney"))
        {
            Destroy(other.gameObject);
            ConvertMoney._score--;
        }
    }
}
