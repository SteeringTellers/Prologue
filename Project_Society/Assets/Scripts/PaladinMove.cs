using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinMove : MonoBehaviour
{
    public float velocidade = 0f;
    Vector2 direcao;
    [SerializeField]
    private Rigidbody2D rb;
    public Animator anim;

    private void Start()
    {
        
    }
    void Update()
    {
        direcao.x = Input.GetAxis("Horizontal");
        direcao.y = Input.GetAxis("Vertical");
        anim.SetFloat("walk", direcao.x);
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    private void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        rb.MovePosition(rb.position +  direcao * velocidade * Time.fixedDeltaTime);
    }
    private void Attack()
    {
        anim.Play("Paladin_attack");
    }
}
