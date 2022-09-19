using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private float movementSpeed = 1f;
    private Rigidbody rb;
    private int points;
    private Text pointsText;
    public GameObject youWon;
    public Text playerText;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        pointsText = GameObject.Find("Points Text").GetComponent<Text>();
        points = 0;
        youWon.SetActive(false);
        if(MenuManager.Instance != null){
            playerText.text = "Player: " + MenuManager.Instance.GetPlayerName();
        }
    }

    // ABSTRACTION
    void Update()
    {
        Move();
        UpdatePoints();
    }

    private void Move(){
        rb.AddForce(Vector3.forward * movementSpeed);
        if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.right * 3);
        else if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.left * 3);

    }

    public void UpdatePoints(){
        pointsText.text = "Points: " + points;
    }

    public void SetPoints(int change){
        points += change;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Wall")){
            other.GetComponent<WallController>().ChangePoints();
            Debug.Log(other.name);
        }
        else{
            youWon.SetActive(true);
            movementSpeed = 0;
        }
    }

    public void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
