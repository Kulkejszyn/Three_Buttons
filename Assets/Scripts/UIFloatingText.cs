using System.Collections;
using UnityEngine;

public class UIFloatingText : MonoBehaviour
{
	[SerializeField] float lifetime;
	void OnEnable()
	{
		StartCoroutine(HideAfter(lifetime));
	}

	IEnumerator HideAfter(float time)
	{
		yield return new WaitForSeconds(time);
		gameObject.SetActive(false);
	}
}