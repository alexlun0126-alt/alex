using UnityEngine;

namespace NewHouse;

public class NightStandBehaviour : MonoBehaviour
{
	private void Start()
	{
		((Object)((Component)this).gameObject).name = "NIGHTSTAND(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
	}

	private void Update()
	{
	}
}
