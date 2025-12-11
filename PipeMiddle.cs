using UnityEngine;

public class Pipemiddle : MonoBehaviour
{
    public logicscript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<logicscript>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.gameObject.layer == 3)
     {
         logic.addscore(1);
     }
    
    }
}
