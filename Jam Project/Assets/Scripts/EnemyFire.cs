using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bullet;
    public float speed;
    public bool attacking;
    public float a1, b1,a2,b2;
    private void Update()
    {
        if (attacking==true)
        {
            //bullet.transform.position += new Vector3(a2,b2);
            bullet.transform.position += bullet.transform.right * Time.deltaTime * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            bullet.SetActive(true);
            //Instantiate(bullet, this.transform.position + new Vector3(a1, b1), Quaternion.identity);
            //enemyTransform.position=collision.transform.position;
            attacking = true;
        }
    }
   
}
