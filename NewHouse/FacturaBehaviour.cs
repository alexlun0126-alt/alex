using System;
using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class FacturaBehaviour : MonoBehaviour
{
	private TextMesh titular;

	private TextMesh consumo1;

	private TextMesh consumo2;

	private TextMesh consumo3;

	private TextMesh totalenergy;

	private TextMesh totalfuel;

	private TextMesh totalpower;

	private TextMesh totaldemand;

	private TextMesh totalstate;

	private TextMesh totalspecial;

	private TextMesh total;

	private Collider pagar;

	private float consumo;

	private GameObject player;

	public bool checkplayer;

	private void Start()
	{
		titular = ((Component)((Component)this).transform.FindChild("titular")).GetComponent<TextMesh>();
		consumo1 = ((Component)((Component)this).transform.FindChild("consumo1")).GetComponent<TextMesh>();
		consumo2 = ((Component)((Component)this).transform.FindChild("consumo2")).GetComponent<TextMesh>();
		consumo3 = ((Component)((Component)this).transform.FindChild("consumo3")).GetComponent<TextMesh>();
		totalenergy = ((Component)((Component)this).transform.FindChild("totalenergy")).GetComponent<TextMesh>();
		totalfuel = ((Component)((Component)this).transform.FindChild("totalfuel")).GetComponent<TextMesh>();
		totalpower = ((Component)((Component)this).transform.FindChild("totalpower")).GetComponent<TextMesh>();
		totaldemand = ((Component)((Component)this).transform.FindChild("totaldemand")).GetComponent<TextMesh>();
		totalstate = ((Component)((Component)this).transform.FindChild("totalstate")).GetComponent<TextMesh>();
		totalspecial = ((Component)((Component)this).transform.FindChild("totalspecial")).GetComponent<TextMesh>();
		total = ((Component)((Component)this).transform.FindChild("total")).GetComponent<TextMesh>();
		pagar = ((Component)((Component)this).transform.FindChild("pagar")).GetComponent<Collider>();
	}

	public void GetConsumo(float cantidad)
	{
		consumo = cantidad;
	}

	private void Update()
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)player == (Object)null)
		{
			player = GameObject.Find("PLAYER").gameObject;
		}
		else
		{
			if (checkplayer)
			{
				return;
			}
			float num = (float)Math.Round(consumo, 2);
			titular.text = FsmVariables.GlobalVariables.FindFsmString("PlayerFirstName").Value;
			consumo1.text = num.ToString();
			consumo2.text = num.ToString();
			consumo3.text = num.ToString();
			float num2 = num * 0.005f;
			totalenergy.text = num2.ToString();
			totalfuel.text = num2.ToString();
			int num3 = 20;
			totalpower.text = num3.ToString();
			totaldemand.text = num3.ToString();
			float num4 = 0.4f / num * 100f;
			totalstate.text = num4.ToString();
			float num5 = 0.1f / num * 100f;
			totalspecial.text = num5.ToString();
			float factura = num2 * 2f + (float)(num3 * 2) + num4 + num5 + num;
			total.text = factura.ToString();
			RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
			for (int i = 0; i < array.Length; i++)
			{
				RaycastHit val = array[i];
				if ((Object)(object)val.collider == (Object)(object)pagar && Input.GetMouseButtonDown(0))
				{
					Object.FindObjectOfType<CartaBehaviour>().Loapagado(factura);
				}
			}
		}
	}
}
