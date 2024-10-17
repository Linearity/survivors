using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public double currentHealth = 100.0;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Damage start"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestOnTriggerEnter2D() {
        Collider2D col = new Collider2D();
        this.OnTriggerEnter2D(col);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        // if (isEnemy(col.gameObject)) {
        currentHealth -= 1.0;
        // }
    }
}
