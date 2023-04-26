using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTimer : MonoBehaviour
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
        yield return new WaitForSeconds(6.5f);
        SceneManager.LoadScene(3);
    }
}
