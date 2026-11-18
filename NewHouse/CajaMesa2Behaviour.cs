using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class CajaMesa2Behaviour : MonoBehaviour
{
	private FsmBool m_guiUseBool;

	private AudioSource audi;

	private AudioClip audiclip;

	public FsmBool _playerInMenu;

	public bool showGUI;

	private readonly Rect _guiBox = new Rect((float)(Screen.width / 2 - 190), (float)(Screen.height / 2 - 200), 280f, 180f);

	public bool color1;

	public bool color2;

	public bool color3;

	public bool confirmado;

	private void OnGUI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		GUIStyle val = new GUIStyle
		{
			alignment = (TextAnchor)1
		};
		val.normal.textColor = Color.red;
		val.fontSize = 20;
		if (showGUI)
		{
			GUI.ModalWindow(241, _guiBox, (WindowFunction)GuiSettingsWindow, "Purchase Furniture Options");
		}
	}

	private void GuiSettingsWindow(int windowId)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.GetStyle("Label").alignment = (TextAnchor)1;
		if (GUI.Button(new Rect(30f, 150f, 100f, 30f), "Exit"))
		{
			_playerInMenu.Value = false;
			showGUI = false;
		}
		if (GUI.Button(new Rect(150f, 150f, 100f, 30f), "Confirm"))
		{
			confirmado = true;
			_playerInMenu.Value = false;
			showGUI = false;
		}
		color1 = GUI.Toggle(new Rect(10f, 30f, 300f, 30f), color1, "Light Wood.");
		color2 = GUI.Toggle(new Rect(10f, 60f, 300f, 30f), color2, "Medium Clear Wood.");
		color3 = GUI.Toggle(new Rect(10f, 90f, 300f, 30f), color3, "Dark Wood.");
	}

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "CARDBOARD(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		audi = ((Component)this).GetComponent<AudioSource>();
		audiclip = audi.clip;
		_playerInMenu = PlayMakerGlobals.Instance.Variables.GetFsmBool("PlayerInMenu");
	}

	private void Update()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)NewHouseRuntime.Player != (Object)null))
		{
			return;
		}
		if (showGUI)
		{
			_playerInMenu.Value = true;
		}
		if (color1 && confirmado)
		{
			Mesa2Behaviour mesa2Behaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa21Prefab")).AddComponent<Mesa2Behaviour>();
			((Component)mesa2Behaviour).transform.position = ((Component)this).transform.position;
			mesa2Behaviour.color1 = true;
			mesa2Behaviour.color2 = false;
			mesa2Behaviour.color3 = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (color2 && confirmado)
		{
			Mesa2Behaviour mesa2Behaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa22Prefab")).AddComponent<Mesa2Behaviour>();
			((Component)mesa2Behaviour2).transform.position = ((Component)this).transform.position;
			mesa2Behaviour2.color1 = false;
			mesa2Behaviour2.color2 = true;
			mesa2Behaviour2.color3 = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (color3 && confirmado)
		{
			Mesa2Behaviour mesa2Behaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa23Prefab")).AddComponent<Mesa2Behaviour>();
			((Component)mesa2Behaviour3).transform.position = ((Component)this).transform.position;
			mesa2Behaviour3.color1 = false;
			mesa2Behaviour3.color2 = false;
			mesa2Behaviour3.color3 = true;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Vector3.Distance(NewHouseRuntime.Player.transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = NewHouseRuntime.GetMouseHits(1f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)((Component)this).gameObject)
			{
				m_guiUseBool.Value = true;
				if (cInput.GetButtonDown("Use"))
				{
					showGUI = true;
				}
			}
		}
		}
	}

	public CajaMesa2Behaviour()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
	}
}
