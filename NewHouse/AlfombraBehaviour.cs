using UnityEngine;

namespace NewHouse;

public class AlfombraBehaviour : MonoBehaviour
{
	public bool naranja;

	public bool verde;

	public bool azul;

	public bool rojo;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "CARPET(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
	}

	private void Update()
	{
	}
}
