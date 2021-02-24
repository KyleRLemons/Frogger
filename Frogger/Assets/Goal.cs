
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{

    public GameObject canvas;
    public bool isShowing = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        canvas.SetActive(true);
        Debug.Log("YOU WON!");
        /*SceneManager.LoadScene(SceneManager.GetActiveScene().name);*/
    }

    public void RestartLevel()
    {

        Time.timeScale = 1;
        canvas.SetActive(false);
        SceneManager.LoadScene("Intro");
    }
}
