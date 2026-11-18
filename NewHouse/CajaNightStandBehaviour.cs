using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class CajaNightStandBehaviour : MonoBehaviour
{
	private FsmBool m_guiUseBool;

	private AudioSource audi;

	private AudioClip audiclip;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "CARDBOARD(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		audi = ((Component)this).GetComponent<AudioSource>();
		audiclip = audi.clip;
	}

	private void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)((Component)this).gameObject)
			{
				m_guiUseBool.Value = true;
				if (cInput.GetButtonDown("Use"))
				{
					((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("NightStandPrefab")).AddComponent<NightStandBehaviour>()).transform.position = ((Component)this).transform.position;
					AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
					Object.Destroy((Object)(object)((Component)this).gameObject);
				}
			}
		}
	}
}
