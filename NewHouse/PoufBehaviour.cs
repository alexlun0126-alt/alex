using UnityEngine;

namespace NewHouse;

public class PoufBehaviour : MonoBehaviour
{
	public bool blanco;

	public bool verde;

	public bool azul;

	public bool raro;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "POUF(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
	}

	private void Update()
	{
	}
}
