using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour {

    public static LevelLoader loader;
    public int nextLevel;

    public void loadNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    void OnTriggerEnter(Collider other)
    {
        loadNextLevel();
    }



}
