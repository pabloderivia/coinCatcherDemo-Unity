using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxtTime = 60f;

    private float countdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = maxtTime;

    }

    // Update is called once per frame
    void Update()
    {

        //deltatime = tiempo que transcurre entre el renderizado de frame y frame
        countdown -= Time.deltaTime;
        Debug.Log("tiempo restante: " + countdown);

        if (countdown <= 0)
        {
            resetGame();
        }

    }


    void resetGame()
    {

        Debug.Log("Te has quedado sin tiempo... HAS PERDIDO");
        coin.coinsCount = 0;
        SceneManager.LoadScene("MainScene");

    }

    void winGame()
    {

    }
}
