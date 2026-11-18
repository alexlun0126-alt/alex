using System;
using System.Collections;
using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class GrifoSaunaBehaviour : MonoBehaviour
{
	private GameObject grifosaunaon;

	private GameObject grifosaunaoff;

	private Collider grifosauna;

	private AudioSource audiomanetasauna;

	private AudioSource audiogrifosauna;

	private TriggerCallback grifosaunacol;

	private Transform alturaagua;

	private GameObject Player;

	private TriggerCallback trigger;

	private FsmBool m_guiUseBool;

	private bool drink3Running;

	private bool drink4Running;

	public bool grifoabiertosauna;

	public bool lleno;

	public int intensidad;

	private void Start()
	{
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		alturaagua = ((Component)((Component)this).transform.FindChild("nivelagua")).transform;
		audiogrifosauna = ((Component)((Component)this).transform.FindChild("posigrifosauna")).GetComponent<AudioSource>();
		trigger = ((Component)((Component)this).transform.FindChild("triggeragua")).gameObject.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback = trigger;
		triggerCallback.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerStay, new Action<Collider>(OnBagTriggerStay));
		grifosaunaon = ((Component)((Component)audiogrifosauna).transform.FindChild("manetasaunaabierta")).gameObject;
		grifosaunaoff = ((Component)((Component)audiogrifosauna).transform.FindChild("manetasaunacerrada")).gameObject;
		audiomanetasauna = ((Component)((Component)audiogrifosauna).transform.FindChild("grifosauna")).GetComponent<AudioSource>();
		grifosauna = ((Component)audiomanetasauna).GetComponent<Collider>();
		grifosaunacol = ((Component)grifosaunaon.transform.FindChild("triggerbebersauna")).gameObject.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback2 = grifosaunacol;
		triggerCallback2.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback2.onTriggerStay, new Action<Collider>(OnGrifoSaunaTriggerStay));
	}

	private void OnBagTriggerStay(Collider collider)
	{
		if (((Object)collider).name == ((Object)Player).name && lleno && ((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>().electricidadon)
		{
			((MonoBehaviour)this).StartCoroutine(Drink2());
		}
	}

	private void OnGrifoSaunaTriggerStay(Collider collider)
	{
		if (((Object)collider).name == ((Object)Player).name && grifoabiertosauna)
		{
			PlayMakerFSM[] components = Player.GetComponents<PlayMakerFSM>();
			foreach (PlayMakerFSM val in components)
			{
				if (val.FsmName == "Crouch" && val.FsmVariables.FindFsmFloat("Position").Value == 0.3f)
				{
					((MonoBehaviour)this).StartCoroutine(Grifo());
				}
			}
		}
		if (((Object)collider).name == "bucket(itemx)" && grifoabiertosauna)
		{
			((MonoBehaviour)this).StartCoroutine(LLenaCubo(collider));
		}
	}

	private IEnumerator Grifo()
	{
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerThirst");
		val.Value -= 0.4f;
		FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerUrine");
		val2.Value += 0.1f;
	}

	private IEnumerator LLenaCubo(Collider collider)
	{
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat fsmFloat = ((Component)collider).GetComponent<PlayMakerFSM>().FsmVariables.GetFsmFloat("Water");
		fsmFloat.Value += 0.01f;
	}

	private IEnumerator Drink2()
	{
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerStress");
		val.Value -= 0.05f;
		FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerDirtiness");
		val2.Value -= 0.09f;
	}

	private void RayGrifo(RaycastHit hit)
	{
		if (!((Object)(object)hit.collider == (Object)(object)grifosauna))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (!Input.GetMouseButtonDown(0))
		{
			return;
		}
		grifoabiertosauna = !grifoabiertosauna;
		if (grifoabiertosauna)
		{
			if (!audiogrifosauna.isPlaying)
			{
				audiogrifosauna.Play();
			}
			intensidad++;
		}
		if (!grifoabiertosauna)
		{
			if (!audiomanetasauna.isPlaying)
			{
				audiomanetasauna.Play();
			}
			if (audiogrifosauna.isPlaying)
			{
				audiogrifosauna.Stop();
			}
			intensidad--;
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
			if (grifoabiertosauna && !drink3Running)
			{
				((MonoBehaviour)this).StartCoroutine(Drink3());
			}
			if (lleno && !drink4Running)
			{
				((MonoBehaviour)this).StartCoroutine(Drink4());
			}
			if (grifoabiertosauna)
			{
				grifosaunaon.SetActive(true);
				grifosaunaoff.SetActive(false);
			}
			if (!grifoabiertosauna)
			{
				grifosaunaon.SetActive(false);
				grifosaunaoff.SetActive(true);
			}
		}
	}

	private IEnumerator Drink3()
	{
		drink3Running = true;
		yield return (object)new WaitForSeconds(0.5f);
		float num = alturaagua.localPosition.z + 0.0001f;
		if (alturaagua.localPosition.z <= 0.1f)
		{
			alturaagua.localPosition = new Vector3(0f, 0f, num);
		}
		if (alturaagua.localPosition.z >= 0.1f)
		{
			alturaagua.localPosition = new Vector3(0f, 0f, 0.1f);
			lleno = true;
		}
		drink3Running = false;
	}

	private IEnumerator Drink4()
	{
		drink4Running = true;
		yield return (object)new WaitForSeconds(0.5f);
		float num = alturaagua.localPosition.z - 1E-05f;
		if (alturaagua.localPosition.z > 0f)
		{
			alturaagua.localPosition = new Vector3(0f, 0f, num);
		}
		if (alturaagua.localPosition.z <= 0f)
		{
			alturaagua.localPosition = new Vector3(0f, 0f, 0f);
			lleno = false;
		}
		drink4Running = false;
	}
}
