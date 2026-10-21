using NUnit.Framework.Constraints;
using System;
using UnityEngine;

public class settings : MonoBehaviour
{   
    public int a = 0;
    public GameObject setbut;
    public GameObject ostalnoe = null;
    public GameObject ostalnoe1 = null;
    public GameObject ostalnoe2 = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick()
    {
        if (a == 0)
        {
            a++;
            
            ostalnoe.SetActive(false);
            ostalnoe1.SetActive(false);
            ostalnoe2.SetActive(false);
        }
        if (a == 1)
        {
            a--;
            ostalnoe.SetActive(true);
            ostalnoe1.SetActive(true);
            ostalnoe2.SetActive(true);
        }
        
    }
    
}
