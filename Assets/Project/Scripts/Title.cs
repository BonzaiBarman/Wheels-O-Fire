using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Title : MonoBehaviour
{
	public GameObject txtWheels;
	public GameObject txtO;
	public GameObject txtFire;
	public GameObject txtDash;
	public GameObject txtContinue;
	
	// Start is called before the first frame update
	IEnumerator Start()
	{
		txtContinue.SetActive(false);
		txtFire.SetActive(false);
		txtDash.SetActive(false);
		txtWheels.transform.DOMoveX(-7f, 1, false);
		
		txtO.transform.DOMoveX(0.15f, 1, false);

		
		txtO.transform.DOLocalRotate(new Vector3(0f, 0f, -359f), 1,DG.Tweening.RotateMode.FastBeyond360).SetEase(Ease.Linear);
		yield return new WaitForSeconds(1f);
		txtO.transform.DORotate(new Vector3(0f, 0f, 0f),0);

		yield return new WaitForSeconds(1.5f);
		txtDash.SetActive(true);
		txtFire.SetActive(true);
		txtFire.transform.DOMoveZ(0f, 2, false);
		yield return new WaitForSeconds(3.5f);
		txtContinue.SetActive(true);

	}

	public void OnMouseDown()
	{

		SceneManager.LoadScene("Intro");
	}


}
