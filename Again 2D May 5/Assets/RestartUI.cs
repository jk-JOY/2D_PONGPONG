using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RestartUI : MonoBehaviour
{
    public Image fadePlane;
    public GameObject RestartUI1;


    void OnGameOver()
    {
        StartCoroutine(Fade(Color.clear, Color.black, 1));
        RestartUI1.SetActive(true);
    }

    IEnumerator Fade(Color from, Color to, float time)
    {
        float speed = 1; // time;
        float percent = 0;

        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            fadePlane.color = Color.Lerp(from, to, percent);
            yield return null;
        }
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene("Main");
    }
}
