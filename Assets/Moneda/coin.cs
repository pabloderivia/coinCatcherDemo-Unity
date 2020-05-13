using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    public static int coinsCount;
    // Start is called before the first frame update
    void Start()
    {
        coin.coinsCount++;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            coinsCount--;
            Destroy(this.gameObject);
        }

        if (coin.coinsCount == 0)
        {
            Debug.Log("has ganado!!");

            GameObject gameManager = GameObject.Find("GameManager");
            Destroy(gameManager);

            GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("FireWorks");

            foreach (GameObject firework in fireworksSystem)
            {
                firework.GetComponent<ParticleSystem>().Play();
            }
        }
    }

}
