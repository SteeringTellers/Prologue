using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinMove : MonoBehaviour
{
    public float velocidade;
    Vector2 direcao;

    void Update()
    {
        direcao.x = Input.GetAxis("Horizontal");
        direcao.y = Input.GetAxis("Vertical");
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
}
