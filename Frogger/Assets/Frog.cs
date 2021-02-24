
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public Dropdown dd;
    public static int NumberofLives;
    public static string Name = "Frog";
    public static int Score = 0;
    public GameObject CanvasLose;
    public GameObject CanvasScore;
    

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6f, 6f), Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
    }
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            NumberofLives = NumberofLives - 1;
            if (NumberofLives <= 0)
            {
                CanvasScore.SetActive(false);
                Time.timeScale = 0;
                Debug.Log("We Lose!");
                CanvasLose.SetActive(true);
            }
            else
            {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }
    }
}
