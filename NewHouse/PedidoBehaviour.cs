using UnityEngine;

namespace NewHouse;

public class PedidoBehaviour : MonoBehaviour
{
	public bool compramesa;

	public bool compramesa2;

	public bool comprasilla;

	public bool comprasilla2;

	public bool comprasofa;

	public bool comprapouf;

	public bool compraalfombra;

	public bool compranightstand;

	public float precio;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "ORDER(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
	}

	private void Update()
	{
	}
}
