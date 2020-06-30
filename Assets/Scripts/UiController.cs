using System;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class UiController : MonoBehaviour
{
	[SerializeField] private GameObject popupWindow;
	[SerializeField] private GameObject hiddenText;

	public void ShowText()
	{
		if (hiddenText != null && !hiddenText.activeInHierarchy) hiddenText.SetActive(true);
	}

	public void ShowPopup()
	{
		if (popupWindow != null) Instantiate(popupWindow, transform);
	}
}