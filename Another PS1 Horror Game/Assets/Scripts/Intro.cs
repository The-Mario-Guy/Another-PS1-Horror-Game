using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer _Intro;
    void Start()
    {
        _Intro = GetComponent<MeshRenderer>();
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(17);
        _Intro.enabled = false;
    }
}
