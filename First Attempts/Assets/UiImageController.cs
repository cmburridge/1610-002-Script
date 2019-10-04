using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UiImageController : MonoBehaviour
{

	private Image img;
	// Use this for initialization
	void Awake ()
	{
		img = GetComponent<Image>();
	}

	public void UpdateImage(Powerups data)
	{
		img.fillAmount = data.HealthAmount;
	}

}
