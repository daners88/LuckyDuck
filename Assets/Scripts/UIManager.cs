using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject creditScreen;
    public bool canMove = false;
    // Start is called before the first frame update

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else if (Instance != this)
            Destroy(gameObject);

        //DontDestroyOnLoad(gameObject);
        GameObject.FindGameObjectWithTag("Music").GetComponent<PersistentMusic>().PlayMusic();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
        canMove = true;
    }

    public void Continue()
    {
        creditScreen.SetActive(false);
        titleScreen.SetActive(true);
    }
}
