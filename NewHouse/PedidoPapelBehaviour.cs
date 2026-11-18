using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class PedidoPapelBehaviour : MonoBehaviour
{
	private TextMesh texto;

	public float precio;

	private Collider pedido;

	private FsmBool m_guiUseBool;

	private CompraObjetosBehaviour compras;

	public bool compramesa;

	public bool compramesa2;

	public bool comprasilla;

	public bool comprasilla2;

	public bool comprasofa;

	public bool comprapouf;

	public bool compraalfombra;

	public bool compranightstand;

	private void Start()
	{
		pedido = ((Component)((Component)this).transform.FindChild("pedido")).GetComponent<Collider>();
		texto = ((Component)((Component)this).transform.FindChild("precio")).GetComponent<TextMesh>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		compras = Object.FindObjectOfType<CompraObjetosBehaviour>();
	}

	private void Update()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		texto.text = precio.ToString();
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			if ((Object)(object)val.collider == (Object)(object)pedido && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= precio)
			{
				m_guiUseBool.Value = true;
				if (Input.GetMouseButtonDown(0))
				{
					FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
					val2.Value -= precio;
					compras.PedidoPagado(this);
					Object.Destroy((Object)(object)((Component)this).gameObject);
				}
			}
		}
	}
}
