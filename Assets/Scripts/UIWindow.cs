using UnityEngine;

public class UIWindow : MonoBehaviour
{
	public void Close()
	{
		Destroy(gameObject);
	}
}