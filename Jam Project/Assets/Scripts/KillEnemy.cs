using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public float shootSpeed;
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * shootSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
