using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed , _speed;
    float _sinir;
    [SerializeField] GameObject _cam1, _cam2;
    [SerializeField] GameObject _scorPanel;
    [SerializeField] Animator _animator;
    bool _startGame;
    [SerializeField] Text _tapToPlayText;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _tapToPlayText.gameObject.SetActive(false);
            _animator.SetBool("__isRun", true);
            _startGame = true;
            _cam1.gameObject.SetActive(true);
            _cam2.gameObject.SetActive(false);
            _scorPanel.SetActive(true);
        }
    }
    private void FixedUpdate()
    {
        if (_startGame == true)
        {
            
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime, 0, _speed * Time.deltaTime));
            _sinir = transform.position.x;
            _sinir = Mathf.Clamp(_sinir, -4, +4);
            transform.position = new Vector3(_sinir, transform.position.y, transform.position.z);

        }
        
    }
}
