using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public static MenuManager Instance;
    public InputField input;

    private string playerName;

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null){
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        playerName = input.text;
        SetPlayerName(playerName);
    }

    public void LoadMain(){
        SceneManager.LoadScene(1);
    }

    //ENCAPSULATION
    public string GetPlayerName(){
        return playerName;
    }

    public void SetPlayerName(string name){
        playerName = name;
    }
}
