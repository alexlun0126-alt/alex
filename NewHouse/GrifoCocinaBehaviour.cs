using System;
using System.Collections;
using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class GrifoCocinaBehaviour : MonoBehaviour
{
	private GameObject grifococinaon;

	private GameObject grifococinaoff;

	private Collider grifococina;

	private AudioSource audiomanetacocina;

	private AudioSource audiogrifococina;

	private TriggerCallback grifococinacol;

	private GameObject Player;

	private FsmBool m_guiUseBool;

	private PlayMakerFSM[] playm;

	private bool grifoRunning;

	private bool cuboRunning;

	public bool grifoabiertococina;

	private void Start()
	{
		audiogrifococina = ((Component)((Component)this).transform).GetComponent<AudioSource>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		grifococinaon = ((Component)((Component)this).transform.FindChild("manetacocinaabierta")).gameObject;
		grifococinaoff = ((Component)((Component)this).transform.FindChild("manetacocinacerrada")).gameObject;
		audiomanetacocina = ((Component)((Component)this).transform.FindChild("grifococina")).GetComponent<AudioSource>();
		grifococina = ((Component)audiomanetacocina).GetComponent<Collider>();
		grifococinacol = ((Component)((Component)this).transform.FindChild("triggerbebercocina")).gameObject.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback = grifococinacol;
		triggerCallback.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerStay, new Action<Collider>(OnGrifoCocinaTriggerStay));
	}

	private void OnGrifoCocinaTriggerStay(Collider collider)
	{
		if (((Object)collider).name == ((Object)Player).name && grifoabiertococina)
		{
			playm = Player.GetComponents<PlayMakerFSM>();
			PlayMakerFSM[] array = playm;
			foreach (PlayMakerFSM val in array)
			{
				if (val.FsmName == "Reach" && val.FsmVariables.FindFsmBool("Button").Value)
				{
					if (!grifoRunning) ((MonoBehaviour)this).StartCoroutine(Grifo());
				}
			}
		}
		if (((Object)collider).name == "bucket(itemx)" && grifoabiertococina)
		{
			if (!cuboRunning) ((MonoBehaviour)this).StartCoroutine(LLenaCubo(collider));
		}
	}

	private IEnumerator Grifo()
	{
		grifoRunning = true;
		yield return (object)new WaitForSeconds(0.2f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerThirst");
		val.Value -= 0.4f;
		FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerUrine");
		val2.Value += 0.1f;
		grifoRunning = false;
	}

	private IEnumerator LLenaCubo(Collider collider)
	{
		cuboRunning = true;
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat fsmFloat = ((Component)collider).GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("Water");
		fsmFloat.Value += 0.01f;
		cuboRunning = false;
	}

	private void RayGrifo(RaycastHit hit)
	{
		if (!((Object)(object)hit.collider == (Object)(object)grifococina))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (!Input.GetMouseButtonDown(0))
		{
			return;
		}
		grifoabiertococina = !grifoabiertococina;
		if (!grifoabiertococina)
		{
			if (!audiomanetacocina.isPlaying)
			{
				audiomanetacocina.Play();
			}
			if (audiogrifococina.isPlaying)
			{
				audiogrifococina.Stop();
			}
		}
		if (grifoabiertococina && !audiogrifococina.isPlaying)
		{
			audiogrifococina.Play();
		}
	}

	private void Update()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameObject.Find("PLAYER") != (Object)null && !((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>()._playerInMenu.Value)
		{
			if (!Object.op_Implicit((Object)(object)Player))
			{
				Player = GameObject.Find("PLAYER").gameObject;
			}
			if (Vector3.Distance(((Component)GameObject.Find("PLAYER")).transform.position, transform.root.position) <= 60f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
			foreach (RaycastHit hit in array)
			{
				RayGrifo(hit);
			}
		}
			if (grifoabiertococina)
			{
				grifococinaon.SetActive(true);
				grifococinaoff.SetActive(false);
			}
			if (!grifoabiertococina)
			{
				grifococinaon.SetActive(false);
				grifococinaoff.SetActive(true);
			}
		}
	}
}
