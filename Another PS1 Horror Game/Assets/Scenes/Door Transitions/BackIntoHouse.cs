using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackIntoHouse : MonoBehaviour
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
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(3);
    }
}
