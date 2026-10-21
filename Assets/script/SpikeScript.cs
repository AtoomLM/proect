using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class SpikeScript : MonoBehaviour
{
    public GameObject fantom;
    
    
    
    
    
    void Start()
    {
        Invoke("Move",2);
        var phantom = Instantiate(fantom).GetComponent<des>();
        phantom.transform.position = this.transform.position;
        phantom.transform.Translate(Vector3.forward*17.5f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
    }
    private void Move()
    {
        this.transform.Translate(Vector3.forward * 17.5f);
        
    }


}
