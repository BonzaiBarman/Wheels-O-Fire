using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    
	public GameObject Horse1;
	public GameObject Horse2;
	public GameObject Horse3;
	public GameObject Horse4;
	// Start is called before the first frame update
	void Start()
    {

	    Horse1.GetComponent<Animator>().speed = 0.87f;
	    Horse2.GetComponent<Animator>().Play("Horse_Snooze", 0, 0f);
	    Horse2.GetComponent<Animator>().speed = 0.92f;
	    Horse3.GetComponent<Animator>().Play("Horse_ScratchChew", -1, 0.5f);
	    Horse2.GetComponent<Animator>().speed = 0.89f;
	    Horse4.GetComponent<Animator>().Play("Horse_Paw", -1, 0.5f);
	    Horse2.GetComponent<Animator>().speed = 0.9f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void HomePlaceButton()
	{
		SceneManager.LoadScene("Intro");
	}
}
	
