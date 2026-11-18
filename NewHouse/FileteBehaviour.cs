using System;
using System.Collections;
using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class FileteBehaviour : MonoBehaviour
{
	public bool spawned;

	public bool enbuenestado = true;

	public bool crudo = true;

	public bool hecho;

	public bool quemado;

	public bool podrido;

	public bool ennevera;

	public float tiempopodrir;

	public float timermaxpodrir = 900f;

	public Color toshow;

	private FsmBool m_guiUseBool;

	public bool comiendo;

	private Renderer[] renderers;

	private GameObject triggernevera;

	private TriggerCallback triggerneveracol;

	private void Start()
	{
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "ITEM";
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		triggernevera = GameObject.Find("caseron(Clone)/utiles/neverilla/triggernevera").gameObject;
		triggerneveracol = triggernevera.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback = triggerneveracol;
		triggerCallback.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerStay, new Action<Collider>(OnBagTriggerEnter));
		TriggerCallback triggerCallback2 = triggerneveracol;
		triggerCallback2.onTriggerExit = (Action<Collider>)Delegate.Combine(triggerCallback2.onTriggerExit, new Action<Collider>(OnBagTriggerExit));
	}

	private void OnBagTriggerEnter(Collider collider)
	{
		if ((Object)(object)((Component)collider).gameObject == (Object)(object)((Component)this).gameObject)
		{
			if (!GameObject.Find("caseron(Clone)").GetComponent<CasaBehaviour>().neveraabierta)
			{
				ennevera = true;
			}
			if (GameObject.Find("caseron(Clone)").GetComponent<CasaBehaviour>().neveraabierta)
			{
				ennevera = false;
			}
		}
	}

	private void OnBagTriggerExit(Collider collider)
	{
		if ((Object)(object)((Component)collider).gameObject == (Object)(object)((Component)this).gameObject)
		{
			ennevera = false;
		}
	}

	private void RayBistec(RaycastHit hit)
	{
		if ((Object)(object)((Component)hit.collider).gameObject == (Object)(object)((Component)this).gameObject && hecho)
		{
			m_guiUseBool.Value = true;
			if (cInput.GetButtonDown("Use"))
			{
				((MonoBehaviour)this).StartCoroutine(Comer());
				Renderer[] array = renderers;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].enabled = false;
				}
			}
		}
		if (!quemado || !((Object)(object)((Component)hit.collider).gameObject == (Object)(object)((Component)this).gameObject))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (cInput.GetButtonDown("Use"))
		{
			((MonoBehaviour)this).StartCoroutine(Comer());
			Renderer[] array = renderers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].enabled = false;
			}
		}
	}

	private IEnumerator Comer()
	{
		comiendo = true;
		yield return (object)new WaitForSeconds(1f);
		comiendo = false;
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	private IEnumerator Comervalue()
	{
		yield return (object)new WaitForSeconds(0.1f);
		if (hecho)
		{
			FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerHunger");
			val.Value -= 1.5f;
			FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerThirst");
			val2.Value += 0.1f;
			FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerUrine");
			val3.Value += 0.01f;
		}
		if (quemado)
		{
			FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerHunger");
			val4.Value -= 0.4f;
			FsmFloat val5 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerThirst");
			val5.Value += 0.2f;
			FsmFloat val6 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerUrine");
			val6.Value += 0.03f;
			FsmFloat val7 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerStress");
			val7.Value += 0.1f;
		}
	}

	private void Update()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)NewHouseRuntime.Player != (Object)null))
		{
			return;
		}
		renderers = ((Component)this).gameObject.GetComponentsInChildren<Renderer>();
		if (comiendo)
		{
			((MonoBehaviour)this).StartCoroutine(Comervalue());
		}
		if (!comiendo)
		{
			((MonoBehaviour)this).StopCoroutine(Comervalue());
		}
		if (Vector3.Distance(NewHouseRuntime.Player.transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = NewHouseRuntime.GetMouseHits(1.5f);
		foreach (RaycastHit hit in array)
		{
			RayBistec(hit);
		}
		}
		toshow = ((Component)((Component)this).transform.FindChild("Raw_meat")).GetComponent<Renderer>().material.color;
		if (podrido)
		{
			((Object)((Component)this).gameObject).name = "putred steak(itemx)";
			((Component)((Component)this).transform.FindChild("Raw_meat")).GetComponent<Renderer>().material.color = Color.green;
		}
		if (!enbuenestado)
		{
			return;
		}
		if (!podrido && !ennevera)
		{
			tiempopodrir += Time.deltaTime;
			if (tiempopodrir > timermaxpodrir)
			{
				podrido = true;
				enbuenestado = false;
				tiempopodrir = 0f;
			}
		}
		if (ennevera)
		{
			tiempopodrir = 0f;
		}
		if (toshow.b > 0.5f && toshow.b <= 1f)
		{
			crudo = true;
			hecho = false;
			quemado = false;
		}
		if (toshow.b > 0.3f && toshow.b <= 0.5f)
		{
			hecho = true;
			crudo = false;
			quemado = false;
		}
		if (toshow.b >= 0f && toshow.b <= 0.3f)
		{
			quemado = true;
			crudo = false;
			hecho = false;
		}
		if (crudo && !hecho && !quemado && !podrido)
		{
			((Object)((Component)this).gameObject).name = "raw steak(itemx)";
		}
		if (!crudo && hecho && !quemado && !podrido)
		{
			((Object)((Component)this).gameObject).name = "cooked steak(itemx)";
		}
		if (!crudo && !hecho && quemado && !podrido)
		{
			((Object)((Component)this).gameObject).name = "burnt steak(itemx)";
		}
	}
}
