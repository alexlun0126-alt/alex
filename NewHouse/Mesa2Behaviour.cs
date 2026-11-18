using UnityEngine;

namespace NewHouse;

public class Mesa2Behaviour : MonoBehaviour
{
	public bool color1;

	public bool color2;

	public bool color3;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "TABLE(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
	}

	private void Update()
	{
	}
}
