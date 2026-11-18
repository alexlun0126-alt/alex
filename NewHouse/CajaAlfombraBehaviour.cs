using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class CajaAlfombraBehaviour : MonoBehaviour
{
	private FsmBool m_guiUseBool;

	private AudioSource audi;

	private AudioClip audiclip;

	public FsmBool _playerInMenu;

	public bool showGUI;

	private readonly Rect _guiBox = new Rect((float)(Screen.width / 2 - 190), (float)(Screen.height / 2 - 200), 280f, 180f);

	public bool naranja;

	public bool rojo;

	public bool azul;

	public bool verde;

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
		naranja = GUI.Toggle(new Rect(10f, 30f, 300f, 30f), naranja, "Orange.");
		verde = GUI.Toggle(new Rect(10f, 60f, 300f, 30f), verde, "Green.");
		azul = GUI.Toggle(new Rect(10f, 90f, 300f, 30f), azul, "Blue.");
		rojo = GUI.Toggle(new Rect(10f, 120f, 300f, 30f), rojo, "Red.");
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
		if (naranja && confirmado)
		{
			AlfombraBehaviour alfombraBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraNaranjaPrefab")).AddComponent<AlfombraBehaviour>();
			((Component)alfombraBehaviour).transform.position = ((Component)this).transform.position;
			alfombraBehaviour.naranja = true;
			alfombraBehaviour.verde = false;
			alfombraBehaviour.azul = false;
			alfombraBehaviour.rojo = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (verde && confirmado)
		{
			AlfombraBehaviour alfombraBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraVerdePrefab")).AddComponent<AlfombraBehaviour>();
			((Component)alfombraBehaviour2).transform.position = ((Component)this).transform.position;
			alfombraBehaviour2.naranja = false;
			alfombraBehaviour2.verde = true;
			alfombraBehaviour2.azul = false;
			alfombraBehaviour2.rojo = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (azul && confirmado)
		{
			AlfombraBehaviour alfombraBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraAzulPrefab")).AddComponent<AlfombraBehaviour>();
			((Component)alfombraBehaviour3).transform.position = ((Component)this).transform.position;
			alfombraBehaviour3.naranja = false;
			alfombraBehaviour3.verde = false;
			alfombraBehaviour3.azul = true;
			alfombraBehaviour3.rojo = false;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (rojo && confirmado)
		{
			AlfombraBehaviour alfombraBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraRojaPrefab")).AddComponent<AlfombraBehaviour>();
			((Component)alfombraBehaviour4).transform.position = ((Component)this).transform.position;
			alfombraBehaviour4.naranja = false;
			alfombraBehaviour4.verde = false;
			alfombraBehaviour4.azul = false;
			alfombraBehaviour4.rojo = true;
			AudioSource.PlayClipAtPoint(audiclip, ((Component)this).transform.position, 1f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Vector3.Distance(GameObject.Find("PLAYER").transform.position, transform.position) <= 10f)
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

	public CajaAlfombraBehaviour()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
	}
}
