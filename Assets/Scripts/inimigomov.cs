using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class inimigomov : MonoBehaviour
{

    [SerializeField]
    private float _velocidade = 3.5f;

    [SerializeField]
    private GameObject _explosãoDoInimigo;

    // Start is called before the firts frame update

    void Start()
    {

    }

    // update is called once per frame

    private void Update()
    {
        transform.Translate(Vector3.left * _velocidade * Time.deltaTime);


        if (transform.position.x < -10.31f)
        {
            transform.position = new Vector3(10.39f, Random.Range(3.74f, -3.85f), 0);
        }
    }
}
