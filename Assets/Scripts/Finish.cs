using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] PlayerController _playerController;
    [SerializeField] Animator _anim;
    [SerializeField] GameObject _camera1, _camera2 , _ScorePanel , _finishPanel;
    [SerializeField] GameObject _partical1, _partical2, _partical3;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerController.enabled = false;
            _anim.SetBool("__isFinish", true);
            _camera1.gameObject.SetActive(false);
            _camera2.gameObject.SetActive(true);
            _ScorePanel.gameObject.SetActive(false);
            _finishPanel.gameObject.SetActive(true);
            _partical1.gameObject.SetActive(true);
            _partical2.gameObject.SetActive(true);
            _partical3.gameObject.SetActive(true);

        }
    }
}
