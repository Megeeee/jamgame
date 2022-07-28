using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    Vector3 velocity;
    public float speed;
    public float jump;
    public GameObject bullet;
    
    public Transform shootPosition;
    public float shootTimer;
    private bool isShooting;

    public Animator animator;
    private void Awake()
    {
        isShooting = false;
    }
    private void Update()
    {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"),0f);
        if (velocity.x>0.1 || velocity.x < -0.1)
        {
            animator.SetBool("Run",true);
        }
        else 
        {
            animator.SetBool("Run", false);
        }
        transform.position += velocity * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && Mathf.Approximately(rigidbody.velocity.y, 0))
        {
            rigidbody.velocity = Vector2.up * jump;
            animator.SetBool("Jump",true);
            StartCoroutine(Jump());
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetButtonDown("Fire1") && isShooting == false)
        {
            StartCoroutine(spamStopper());
        }
    }
    IEnumerator spamStopper()
    {
        isShooting = true;
        Instantiate(bullet, shootPosition.position, transform.rotation);
        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
    IEnumerator Jump()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("Jump", false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag=="Lava")
        {
            Application.LoadLevel("Shooted");
        }
        if (collision.collider.tag=="Finish")
        {
            Application.LoadLevel("Finish");
        }
    }
}
