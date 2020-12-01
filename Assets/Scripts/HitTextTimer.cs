using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitTextTimer : MonoBehaviour
{
	public static HitTextTimer htt;

	public float timeOut = 1.0f;
	private Text hitText;

	// Use this for initialization
	void Start()
	{
		// invote the DestroyNow funtion to run after timeOut seconds
		htt = gameObject.GetComponent<HitTextTimer>();
		hitText = gameObject.GetComponent<Text>();
		hitText.text = "";
	}

	void EmptyNow()
	{
		// destory the game Object
		hitText.text = "";
	}

	public void SetText(string text)
	{
		hitText.text = text;
		Invoke("EmptyNow", timeOut);
	}
}
