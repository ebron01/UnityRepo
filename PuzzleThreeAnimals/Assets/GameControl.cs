using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject winText;

    void Start()
    {
        winText.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Bear.locked && Owl.locked && Rabbit.locked)
        {
            winText.SetActive(true);    
        }
    }
}
