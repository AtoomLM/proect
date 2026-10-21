using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject spike;
    public GameObject canvas;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        InvokeRepeating("spawnspike", Random.Range(0, 10), Random.Range(4, 15));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnspike()
    {
        if (canvas.GetComponent<Canvas>().isActiveAndEnabled == false)
            Instantiate(spike,new Vector3(0,Random.Range(-5f,5f),-20),Quaternion.identity);
            
    }
}
