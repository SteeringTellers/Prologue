using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinMove : MonoBehaviour
{
    public float velocidade = 0f;
    Vector2 direcao;
    [SerializeField]
    private Rigidbody2D rb;

    private void Start()
    {
        
    }
    void Update()
    {
        direcao.x = Input.GetAxis("Horizontal");
        direcao.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        rb.MovePosition(rb.position +  direcao * velocidade * Time.fixedDeltaTime);
    }
}
