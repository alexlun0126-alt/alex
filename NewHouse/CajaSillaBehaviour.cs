using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class CajaSillaBehaviour : MonoBehaviour
{
	private FsmBool m_guiUseBool;

	private AudioSource audi;

	private AudioClip audiclip;

	public FsmBool _playerInMenu;

	public bool showGUI;

	private readonly Rect _guiBox = new Rect((float)(Screen.width / 2 - 190), (float)(Screen.height / 2 - 200), 280f, 180f);

	public bool blanco;

	public bool verde;

	public bool azul;

	public bool raro;

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
			GUI.ModalWindow(298, _guiBox, (WindowFunction)GuiSettingsWindow, "Purchase Furniture Options");
		}
	}

	private void GuiSettingsWindow(int windowId)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
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
		blanco = GUI.Toggle(new Rect(10f, 30f, 300f, 30f), blanco, "White.");
		verde = GUI.Toggle(new Rect(10f, 60f, 300f, 30f), verde, "Green.");
		azul = GUI.Toggle(new Rect(10f, 90f, 300f, 30f), azul, "Blue.");
		raro = GUI.Toggle(new Rect(10f, 120f, 300f, 30f), raro, "Strange");
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
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (showGUI)
		{
			_playerInMenu.Value = true;
		}
		if (blanco && confirmado)
		{
			SillaBehaviour sillaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaBlancaPrefab")).AddComponent<SillaBehaviour>();
			((Component)sillaBehaviour).transform.position = ((Component)this).transform.position;
			sillaBehaviour.blanco = true;
			sillaBehaviour.verde = false;
			sillaBehaviour.azul = false;
			sillaBehaviour.raro = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (verde && confirmado)
		{
			SillaBehaviour sillaBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaVerdePrefab")).AddComponent<SillaBehaviour>();
			((Component)sillaBehaviour2).transform.position = ((Component)this).transform.position;
			sillaBehaviour2.blanco = false;
			sillaBehaviour2.verde = true;
			sillaBehaviour2.azul = false;
			sillaBehaviour2.raro = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (azul && confirmado)
		{
			SillaBehaviour sillaBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaAzulPrefab")).AddComponent<SillaBehaviour>();
			((Component)sillaBehaviour3).transform.position = ((Component)this).transform.position;
			sillaBehaviour3.blanco = false;
			sillaBehaviour3.verde = false;
			sillaBehaviour3.azul = true;
			sillaBehaviour3.raro = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (raro && confirmado)
		{
			SillaBehaviour sillaBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaRaraPrefab")).AddComponent<SillaBehaviour>();
			((Component)sillaBehaviour4).transform.position = ((Component)this).transform.position;
			sillaBehaviour4.blanco = false;
			sillaBehaviour4.verde = false;
			sillaBehaviour4.azul = false;
			sillaBehaviour4.raro = true;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Vector3.Distance(((Component)GameObject.Find("PLAYER")).transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1f);
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

	public CajaSillaBehaviour()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
	}
}
