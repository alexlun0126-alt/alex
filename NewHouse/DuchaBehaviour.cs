using System;
using System.Collections;
using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class DuchaBehaviour : MonoBehaviour
{
	private GameObject puntoducha;

	private GameObject puntogrifo;

	private GameObject mododucha;

	private GameObject modogrifo;

	private GameObject modo;

	private Collider duchaboton;

	private bool cambiamodo;

	private bool abierto;

	private BoxCollider duchacol;

	private BoxCollider grifocol;

	private GameObject Player;

	private FsmBool m_guiUseBool;

	private bool duchaRunning;

	private bool grifoRunning;

	private bool cuboRunning;

	private AudioSource audioboton;

	private AudioSource audioducha;

	private AudioSource audiogrifo;

	private void Start()
	{
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		duchaboton = ((Component)((Component)this).transform.FindChild("duchaboton")).GetComponent<Collider>();
		puntoducha = ((Component)((Component)this).transform.FindChild("puntoducha")).gameObject;
		puntogrifo = ((Component)((Component)this).transform.FindChild("puntogrifo")).gameObject;
		mododucha = ((Component)((Component)this).transform.FindChild("cambiamodo/mododucha")).gameObject;
		modogrifo = ((Component)((Component)this).transform.FindChild("cambiamodo/modogrifo")).gameObject;
		modo = ((Component)((Component)this).transform.FindChild("cambiamodo")).gameObject;
		duchacol = puntoducha.GetComponent<BoxCollider>();
		grifocol = puntogrifo.GetComponent<BoxCollider>();
		audioboton = ((Component)duchaboton).GetComponent<AudioSource>();
		audioducha = modo.GetComponent<AudioSource>();
		audiogrifo = ((Component)((Component)this).transform.FindChild("duchametal")).GetComponent<AudioSource>();
		TriggerCallback triggerCallback = ((Component)duchacol).gameObject.AddComponent<TriggerCallback>();
		triggerCallback.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerStay, new Action<Collider>(OnDuchaTriggerStay));
		TriggerCallback triggerCallback2 = ((Component)grifocol).gameObject.AddComponent<TriggerCallback>();
		triggerCallback2.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback2.onTriggerStay, new Action<Collider>(OnGrifoTriggerStay));
		puntoducha.SetActive(false);
		puntogrifo.SetActive(false);
		mododucha.SetActive(false);
		modogrifo.SetActive(true);
	}

	private void OnDuchaTriggerStay(Collider collider)
	{
		if (((Object)collider).name == ((Object)Player).name && abierto && cambiamodo && !duchaRunning)
		{
			((MonoBehaviour)this).StartCoroutine(Ducha());
		}
	}

	private IEnumerator Ducha()
	{
		duchaRunning = true;
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerDirtiness");
		val.Value -= 0.1f;
		duchaRunning = false;
	}

	private IEnumerator LLenaCubo(Collider collider)
	{
		cuboRunning = true;
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat fsmFloat = ((Component)collider).GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("Water");
		fsmFloat.Value += 0.01f;
		cuboRunning = false;
	}

	private void OnGrifoTriggerStay(Collider collider)
	{
		if (((Object)collider).name == ((Object)Player).name && abierto && !cambiamodo)
		{
			PlayMakerFSM[] components = Player.GetComponents<PlayMakerFSM>();
			foreach (PlayMakerFSM val in components)
			{
				if (val.FsmName == "Crouch" && val.FsmVariables.FindFsmFloat("Position").Value == 0.3f)
				{
					if (!grifoRunning) ((MonoBehaviour)this).StartCoroutine(Grifo());
				}
			}
		}
		if (((Object)collider).name == "bucket(itemx)" && abierto && !cambiamodo)
		{
			if (!cuboRunning) ((MonoBehaviour)this).StartCoroutine(LLenaCubo(collider));
		}
	}

	private IEnumerator Grifo()
	{
		grifoRunning = true;
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerThirst");
		val.Value -= 0.3f;
		FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerUrine");
		val2.Value += 0.1f;
		grifoRunning = false;
	}

	private void Update()
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null) || ((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>()._playerInMenu.Value)
		{
			return;
		}
		if (!Object.op_Implicit((Object)(object)Player))
		{
			Player = GameObject.Find("PLAYER").gameObject;
		}
		if (abierto)
		{
			if (cambiamodo)
			{
				puntoducha.SetActive(true);
				puntogrifo.SetActive(false);
				mododucha.SetActive(true);
				modogrifo.SetActive(false);
			}
			if (!cambiamodo)
			{
				puntoducha.SetActive(false);
				puntogrifo.SetActive(true);
				mododucha.SetActive(false);
				modogrifo.SetActive(true);
			}
		}
		if (!abierto)
		{
			if (cambiamodo)
			{
				puntoducha.SetActive(false);
				puntogrifo.SetActive(false);
				mododucha.SetActive(true);
				modogrifo.SetActive(false);
			}
			if (!cambiamodo)
			{
				puntoducha.SetActive(false);
				puntogrifo.SetActive(false);
				mododucha.SetActive(false);
				modogrifo.SetActive(true);
			}
		}
		if (Vector3.Distance(GameObject.Find("PLAYER").transform.position, transform.root.position) <= 60f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		foreach (RaycastHit hit in array)
		{
			RayDucha(hit);
		}
		}
	}

	private void RayDucha(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)duchaboton)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierto = !abierto;
				if (!abierto)
				{
					if (!audioboton.isPlaying)
					{
						audioboton.Play();
					}
					if (audioducha.isPlaying)
					{
						audioducha.Stop();
					}
					if (audiogrifo.isPlaying)
					{
						audiogrifo.Stop();
					}
				}
				if (abierto)
				{
					if (cambiamodo)
					{
						if (!audioducha.isPlaying)
						{
							audioducha.Play();
						}
						if (audiogrifo.isPlaying)
						{
							audiogrifo.Stop();
						}
					}
					if (!cambiamodo)
					{
						if (audioducha.isPlaying)
						{
							audioducha.Stop();
						}
						if (!audiogrifo.isPlaying)
						{
							audiogrifo.Play();
						}
					}
				}
			}
		}
		if (!((Object)(object)((Component)hit.collider).gameObject == (Object)(object)modo))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (!Input.GetMouseButtonDown(0))
		{
			return;
		}
		cambiamodo = !cambiamodo;
		if (!abierto)
		{
			return;
		}
		if (cambiamodo)
		{
			if (!audioducha.isPlaying)
			{
				audioducha.Play();
			}
			if (audiogrifo.isPlaying)
			{
				audiogrifo.Stop();
			}
		}
		if (!cambiamodo)
		{
			if (audioducha.isPlaying)
			{
				audioducha.Stop();
			}
			if (!audiogrifo.isPlaying)
			{
				audiogrifo.Play();
			}
		}
	}
}
