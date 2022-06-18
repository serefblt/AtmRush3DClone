using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertMoney : MonoBehaviour
{

    [SerializeField] Material _gold , _elmas;
    public static float _score = 0;
    [SerializeField] Text _scoreText;

    private void Update()
    {
        _scoreText.text = _score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gate"))
        {
            gameObject.tag = "GoldMoney";
            Gold();
          

        }

        if (other.gameObject.CompareTag("Gate2"))
        {
            if (gameObject.tag == "Player")
            {
                gameObject.tag = "GoldMoney2";
                Gold();
            }
            if (gameObject.tag == "GoldMoney")
            {
                gameObject.tag = "ElmasMoney";
                Elmas();
            }
           
        }
        if (other.gameObject.CompareTag("Player"))
        {
            _score++;
            _scoreText.text = _score.ToString();
        }
    

    }
    void Gold()
    {
        GetComponent<MeshRenderer>().material = _gold;
        _score++;
    }
    void Elmas()
    {
        GetComponent<MeshRenderer>().material = _elmas;
        _score += 2;
    }
}
