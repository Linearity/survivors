using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarUpdate : MonoBehaviour
{
    public GameObject avatar;
    public GameObject healthbarTotal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var damageObj = avatar.GetComponent<Damage>();
        var healthRatio = damageObj.currentHealth / damageObj.totalHealth;
        var pos = transform.position;
        var scale = transform.localScale;
        var totalHealth = healthbarTotal.transform.localScale.x;
        transform.localScale = new Vector3((float)healthRatio, scale.y, scale.z);
        transform.position = new Vector3((float) (-0.5 * (1 - healthRatio) * totalHealth), pos.y, pos.z);
    }
}
