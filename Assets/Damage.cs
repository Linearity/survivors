using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public double currentHealth = 3.0;
    public double totalHealth = 3.0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator GameOver() {
        yield return SceneManager.UnloadSceneAsync("SampleScene");
        SceneManager.LoadScene("GameOver");
    }

    public void TestOnTriggerEnter2D() {
        Collider2D col = new Collider2D();
        this.OnTriggerEnter2D(col);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // if (isEnemy(col.gameObject)) {
        currentHealth -= 1.0;
        // }
        if (currentHealth <= 0) {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            // var coroutine = GameOver();
            // StartCoroutine(coroutine);
        }
    }
}
