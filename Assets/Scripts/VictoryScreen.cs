using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    public GameObject victoryScreenObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            victoryScreenObj.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
