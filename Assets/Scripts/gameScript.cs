using UnityEngine;
using UnityEngine.SceneManagement;

public class gameScript : MonoBehaviour
{
    public static bool pause = false;
    private readonly int _indexMenu = 0;

    // Start is called before the first frame update
    void Start()
    {
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseOrUnPause();
        
    }

    private void PauseOrUnPause()
    {
        if (pause)
            UnPause();
        else
            Pause();
        pause = !pause;
    }

    private void Pause()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(_indexMenu, LoadSceneMode.Additive);
    }

    private void UnPause()
    {
        Time.timeScale = 1.0f;
        SceneManager.UnloadSceneAsync(_indexMenu);
    }
}
