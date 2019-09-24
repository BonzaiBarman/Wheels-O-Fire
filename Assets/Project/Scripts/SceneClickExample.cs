using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SceneClickExample : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log("hi");
		SceneManager.LoadScene("Main");
	}



	//public void OnPointerDown(PointerEve)
	//{
	//	Debug.Log("hi");
	//	SceneManager.LoadScene("Main");
	//}
}
