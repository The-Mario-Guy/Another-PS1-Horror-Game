using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HousetoOutside : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isFading;
    private Animator _Fade;
    void Start()
    {
        _Fade = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
