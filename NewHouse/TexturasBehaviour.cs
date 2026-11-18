using System;
using System.Collections;
using UnityEngine;

namespace NewHouse;

public class TexturasBehaviour : MonoBehaviour
{
	private GameObject bandera;

	private GameObject banderaclone;

	private GameObject posirevista;

	private GameObject picture1;

	private GameObject picture2;

	private GameObject picture3;

	private GameObject picture4;

	private PlayMakerFSM flag;

	private PlayMakerFSM flag2;

	public string path;

	public string path2;

	public string pic1;

	public string pic2;

	public string pic3;

	public string pic4;

	private void Start()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		posirevista = GameObject.Find("sitiorevista").gameObject;
		bandera = GameObject.Find("YARD/LOD/flag").gameObject;
		flag = bandera.GetComponent<PlayMakerFSM>();
		banderaclone = Object.Instantiate<GameObject>(bandera);
		flag2 = banderaclone.GetComponent<PlayMakerFSM>();
		banderaclone.transform.SetParent(posirevista.transform);
		banderaclone.transform.localPosition = new Vector3(-0.35f, 0f, 0.6335406f);
		banderaclone.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		picture1 = GameObject.Find("picture").gameObject;
		picture2 = GameObject.Find("picture 1").gameObject;
		picture3 = GameObject.Find("picture 2").gameObject;
		picture4 = GameObject.Find("picture 3").gameObject;
		((MonoBehaviour)this).StartCoroutine(Loadimage());
	}

	private IEnumerator Loadimage()
	{
		path = flag.FsmVariables.GetFsmString("Address").Value;
		path2 = flag2.FsmVariables.GetFsmString("Address").Value;
		string text = path2.Replace("flag_garage.png", "flag_garage-newhouse.png");
		WWW www5 = new WWW(text);
		try
		{
			yield return www5;
			banderaclone.GetComponent<Renderer>().material.mainTexture = (Texture)(object)www5.texture;
		}
		finally
		{
			((IDisposable)www5)?.Dispose();
		}
		pic1 = path.Replace("flag_garage.png", "kitchen-newhouse.png");
		www5 = new WWW(pic1);
		try
		{
			yield return www5;
			picture1.GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)www5.texture;
		}
		finally
		{
			((IDisposable)www5)?.Dispose();
		}
		pic2 = path.Replace("flag_garage.png", "livingroom-newhouse.png");
		pic3 = path.Replace("flag_garage.png", "livingroom-radio-newhouse.png");
		pic4 = path.Replace("flag_garage.png", "entrance-newhouse.png");
		www5 = new WWW(pic2);
		try
		{
			yield return www5;
			picture2.GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)www5.texture;
		}
		finally
		{
			((IDisposable)www5)?.Dispose();
		}
		www5 = new WWW(pic3);
		try
		{
			yield return www5;
			picture3.GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)www5.texture;
		}
		finally
		{
			((IDisposable)www5)?.Dispose();
		}
		www5 = new WWW(pic4);
		try
		{
			yield return www5;
			picture4.GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)www5.texture;
		}
		finally
		{
			((IDisposable)www5)?.Dispose();
		}
	}

	private void Update()
	{
	}
}
