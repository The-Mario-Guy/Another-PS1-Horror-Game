using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clue1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(14.5f);
        SceneManager.LoadScene(10);
    }
}
