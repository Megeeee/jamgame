using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float shootSpeed;
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * shootSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            Application.LoadLevel("Shooted");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
