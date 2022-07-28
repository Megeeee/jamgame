using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float counter=30;
    private void Update()
    {
        counter -= 1 * Time.deltaTime;
        if (counter<0)
        {
            Application.LoadLevel("NotEnoughTime");
        }
    }
   
}
