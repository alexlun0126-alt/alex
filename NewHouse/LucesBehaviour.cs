using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class LucesBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public bool luz1;

		public bool luz2;

		public bool luz3;

		public bool luz4;

		public bool luz5;

		public bool luz6;

		public bool luz7;

		public bool luz8;

		public bool luz9;

		public bool luz10;

		public bool luz11;

		public int intensidad;
	}

	private GameObject pivoteluz1;

	private GameObject luzon1;

	private GameObject luzoff1;

	private GameObject pivoteluz2;

	private GameObject luzon21;

	private GameObject luzoff21;

	private GameObject luzon22;

	private GameObject luzoff22;

	private GameObject pivoteluz3;

	private GameObject luzon3;

	private GameObject luzoff3;

	private GameObject pivoteluz4;

	private GameObject luzon4;

	private GameObject luzoff4;

	private GameObject pivoteluz5;

	private GameObject luzon5;

	private GameObject luzoff5;

	private GameObject pivoteluz6;

	private GameObject luzon6;

	private GameObject luzoff6;

	private GameObject pivoteluz7;

	private GameObject luzon7;

	private GameObject luzoff7;

	private GameObject luzon72;

	private GameObject luzoff72;

	private GameObject pivoteluz8;

	private GameObject luzon81;

	private GameObject luzoff81;

	private GameObject luzon82;

	private GameObject luzoff82;

	private GameObject pivoteluz9;

	private GameObject luzon91;

	private GameObject luzoff91;

	private GameObject luzon92;

	private GameObject luzoff92;

	private GameObject luzon93;

	private GameObject luzoff93;

	private GameObject luzon94;

	private GameObject luzoff94;

	private GameObject luzon95;

	private GameObject luzoff95;

	private GameObject luzon96;

	private GameObject luzoff96;

	private GameObject pivoteluz10;

	private GameObject luzon101;

	private GameObject luzoff101;

	private GameObject luzon102;

	private GameObject luzoff102;

	private GameObject luzon103;

	private GameObject luzoff103;

	private GameObject luzon104;

	private GameObject luzoff104;

	private GameObject pivoteluz11;

	private GameObject luzon11;

	private GameObject luzoff11;

	private Transform pivoteluz1cerrado;

	private Transform pivoteluz1abierto;

	private Transform pivoteluz2cerrado;

	private Transform pivoteluz2abierto;

	private Transform pivoteluz3cerrado;

	private Transform pivoteluz3abierto;

	private Transform pivoteluz4cerrado;

	private Transform pivoteluz4abierto;

	private Transform pivoteluz5cerrado;

	private Transform pivoteluz5abierto;

	private Transform pivoteluz6cerrado;

	private Transform pivoteluz6abierto;

	private Transform pivoteluz7cerrado;

	private Transform pivoteluz7abierto;

	private Transform pivoteluz8cerrado;

	private Transform pivoteluz8abierto;

	private Transform pivoteluz9cerrado;

	private Transform pivoteluz9abierto;

	private Transform pivoteluz10cerrado;

	private Transform pivoteluz10abierto;

	private Transform pivoteluz11cerrado;

	private Transform pivoteluz11abierto;

	private Collider luz1;

	private Collider luz2;

	private Collider luz3;

	private Collider luz4;

	private Collider luz5;

	private Collider luz6;

	private Collider luz7;

	private Collider luz8;

	private Collider luz9;

	private Collider luz10;

	private Collider luz11;

	private FsmBool m_guiUseBool;

	public bool luzz1;

	public bool luzz2;

	public bool luzz3;

	public bool luzz4;

	public bool luzz5;

	public bool luzz6;

	public bool luzz7;

	public bool luzz8;

	public bool luzz9;

	public bool luzz10;

	public bool luzz11;

	public bool storeluzz1;

	public bool storeluzz2;

	public bool storeluzz3;

	public bool storeluzz4;

	public bool storeluzz5;

	public bool storeluzz6;

	public bool storeluzz7;

	public bool storeluzz8;

	public bool storeluzz9;

	public bool storeluzz10;

	public bool storeluzz11;

	private AudioSource pivluz1;

	private AudioSource pivluz2;

	private AudioSource pivluz3;

	private AudioSource pivluz4;

	private AudioSource pivluz5;

	private AudioSource pivluz6;

	private AudioSource pivluz7;

	private AudioSource pivluz8;

	private AudioSource pivluz9;

	private AudioSource pivluz10;

	private AudioSource pivluz11;

	private GameObject luces1;

	private GameObject luces2;

	private GameObject luces3;

	private GameObject luces4;

	private GameObject luces5;

	private GameObject luces6;

	private GameObject luces7;

	private GameObject luces8;

	private CasaBehaviour root;

	public int intensidad;

	private GameObject luzpiscina1;

	private void Start()
	{
		root = ((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>();
		luces1 = ((Component)((Component)this).transform.FindChild("lampara1")).gameObject;
		luces2 = ((Component)((Component)this).transform.FindChild("lampara2")).gameObject;
		luces3 = ((Component)((Component)this).transform.FindChild("lampara3")).gameObject;
		luces4 = ((Component)((Component)this).transform.FindChild("lampara4")).gameObject;
		luces5 = ((Component)((Component)this).transform.FindChild("lampara5")).gameObject;
		luces6 = ((Component)((Component)this).transform.FindChild("lampara6")).gameObject;
		luces7 = ((Component)((Component)this).transform.FindChild("lampara7")).gameObject;
		luces8 = ((Component)((Component)this).transform.FindChild("lampara8")).gameObject;
		luzon1 = ((Component)luces1.transform.FindChild("lamparaon1")).gameObject;
		luzoff1 = ((Component)luces1.transform.FindChild("lamparaoff1")).gameObject;
		pivoteluz1 = ((Component)luces1.transform.FindChild("pivoteluz/botonlampara")).gameObject;
		pivluz1 = pivoteluz1.GetComponent<AudioSource>();
		luzon21 = ((Component)luces2.transform.FindChild("lamparaon1")).gameObject;
		luzoff21 = ((Component)luces2.transform.FindChild("lamparaoff1")).gameObject;
		luzon22 = ((Component)luces2.transform.FindChild("lamparaon2")).gameObject;
		luzoff22 = ((Component)luces2.transform.FindChild("lamparaoff2")).gameObject;
		pivoteluz2 = ((Component)luces2.transform.FindChild("pivoteluz2/botonlampara2")).gameObject;
		pivluz2 = pivoteluz2.GetComponent<AudioSource>();
		luzon3 = ((Component)luces3.transform.FindChild("lamparaon1")).gameObject;
		luzoff3 = ((Component)luces3.transform.FindChild("lamparaoff1")).gameObject;
		pivoteluz3 = ((Component)luces3.transform.FindChild("pivoteluz3/botonlampara3")).gameObject;
		pivluz3 = pivoteluz3.GetComponent<AudioSource>();
		luzon4 = ((Component)luces4.transform.FindChild("lamparaon1")).gameObject;
		luzoff4 = ((Component)luces4.transform.FindChild("lamparaoff1")).gameObject;
		pivoteluz4 = ((Component)luces4.transform.FindChild("pivoteluz4/botonlampara4")).gameObject;
		pivluz4 = pivoteluz4.GetComponent<AudioSource>();
		luzon5 = ((Component)luces5.transform.FindChild("lamparaon1")).gameObject;
		luzoff5 = ((Component)luces5.transform.FindChild("lamparaoff1")).gameObject;
		pivoteluz5 = ((Component)luces5.transform.FindChild("pivoteluz5/botonlampara5")).gameObject;
		pivluz5 = pivoteluz5.GetComponent<AudioSource>();
		luzon6 = ((Component)luces6.transform.FindChild("lamparaon1")).gameObject;
		luzoff6 = ((Component)luces6.transform.FindChild("lamparaoff1")).gameObject;
		pivoteluz6 = ((Component)luces6.transform.FindChild("pivoteluz6/botonlampara6")).gameObject;
		pivluz6 = pivoteluz6.GetComponent<AudioSource>();
		luzon7 = ((Component)luces7.transform.FindChild("lamparaon1")).gameObject;
		luzoff7 = ((Component)luces7.transform.FindChild("lamparaoff1")).gameObject;
		luzon72 = ((Component)luces7.transform.FindChild("lamparaon2")).gameObject;
		luzoff72 = ((Component)luces7.transform.FindChild("lamparaoff2")).gameObject;
		pivoteluz7 = ((Component)luces7.transform.FindChild("pivoteluz7/botonlampara7")).gameObject;
		pivluz7 = pivoteluz7.GetComponent<AudioSource>();
		luzon81 = ((Component)luces8.transform.FindChild("lamparaon1")).gameObject;
		luzoff81 = ((Component)luces8.transform.FindChild("lamparaoff1")).gameObject;
		luzon82 = ((Component)luces8.transform.FindChild("lamparaon2")).gameObject;
		luzoff82 = ((Component)luces8.transform.FindChild("lamparaoff2")).gameObject;
		pivoteluz8 = ((Component)luces8.transform.FindChild("pivoteluz8/botonlampara8")).gameObject;
		pivluz8 = pivoteluz8.GetComponent<AudioSource>();
		luzon91 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa1/fluorescenteon1")).gameObject;
		luzoff91 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa1/fluorescenteoff1")).gameObject;
		luzon92 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa2/fluorescenteon2")).gameObject;
		luzoff92 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa2/fluorescenteoff2")).gameObject;
		luzon93 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa3/fluorescenteon3")).gameObject;
		luzoff93 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa3/fluorescenteoff3")).gameObject;
		luzon94 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa4/fluorescenteon4")).gameObject;
		luzoff94 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa4/fluorescenteoff4")).gameObject;
		luzon95 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa5/fluorescenteon5")).gameObject;
		luzoff95 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa5/fluorescenteoff5")).gameObject;
		luzon96 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa6/fluorescenteon6")).gameObject;
		luzoff96 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/lampa6/fluorescenteoff6")).gameObject;
		pivoteluz9 = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/pivoteluz9/botonlampara9")).gameObject;
		pivluz9 = pivoteluz9.GetComponent<AudioSource>();
		luzon11 = ((Component)((Component)this).transform.FindChild("lampara11/lamparaon1")).gameObject;
		luzoff11 = ((Component)((Component)this).transform.FindChild("lampara11/lamparaoff1")).gameObject;
		pivoteluz11 = ((Component)((Component)this).transform.FindChild("lampara11/pivoteluz11/botonlampara11")).gameObject;
		pivluz11 = pivoteluz11.GetComponent<AudioSource>();
		pivoteluz1cerrado = ((Component)luces1.transform.FindChild("pivoteluz/botonlamparaabajo")).transform;
		pivoteluz1abierto = ((Component)luces1.transform.FindChild("pivoteluz/botonlamparaarriba")).transform;
		pivoteluz2cerrado = ((Component)luces2.transform.FindChild("pivoteluz2/botonlamparaabajo2")).transform;
		pivoteluz2abierto = ((Component)luces2.transform.FindChild("pivoteluz2/botonlamparaarriba2")).transform;
		pivoteluz3cerrado = ((Component)luces3.transform.FindChild("pivoteluz3/botonlamparaabajo3")).transform;
		pivoteluz3abierto = ((Component)luces3.transform.FindChild("pivoteluz3/botonlamparaarriba3")).transform;
		pivoteluz4cerrado = ((Component)luces4.transform.FindChild("pivoteluz4/botonlamparaabajo4")).transform;
		pivoteluz4abierto = ((Component)luces4.transform.FindChild("pivoteluz4/botonlamparaarriba4")).transform;
		pivoteluz5cerrado = ((Component)luces5.transform.FindChild("pivoteluz5/botonlamparaabajo5")).transform;
		pivoteluz5abierto = ((Component)luces5.transform.FindChild("pivoteluz5/botonlamparaarriba5")).transform;
		pivoteluz6cerrado = ((Component)luces6.transform.FindChild("pivoteluz6/botonlamparaabajo6")).transform;
		pivoteluz6abierto = ((Component)luces6.transform.FindChild("pivoteluz6/botonlamparaarriba6")).transform;
		pivoteluz7cerrado = ((Component)luces7.transform.FindChild("pivoteluz7/botonlamparaabajo7")).transform;
		pivoteluz7abierto = ((Component)luces7.transform.FindChild("pivoteluz7/botonlamparaarriba7")).transform;
		pivoteluz8cerrado = ((Component)luces8.transform.FindChild("pivoteluz8/botonlamparaabajo8")).transform;
		pivoteluz8abierto = ((Component)luces8.transform.FindChild("pivoteluz8/botonlamparaarriba8")).transform;
		pivoteluz9cerrado = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/pivoteluz9/botonlamparaabajo9")).transform;
		pivoteluz9abierto = ((Component)((Component)root).transform.FindChild("utiles/parkingcamion/luzcamion/pivoteluz9/botonlamparaarriba9")).transform;
		pivoteluz11cerrado = ((Component)((Component)this).transform.FindChild("lampara11/pivoteluz11/botonlamparaabajo11")).transform;
		pivoteluz11abierto = ((Component)((Component)this).transform.FindChild("lampara11/pivoteluz11/botonlamparaarriba11")).transform;
		luz1 = pivoteluz1.GetComponent<Collider>();
		luz2 = pivoteluz2.GetComponent<Collider>();
		luz3 = pivoteluz3.GetComponent<Collider>();
		luz4 = pivoteluz4.GetComponent<Collider>();
		luz5 = pivoteluz5.GetComponent<Collider>();
		luz6 = pivoteluz6.GetComponent<Collider>();
		luz7 = pivoteluz7.GetComponent<Collider>();
		luz8 = pivoteluz8.GetComponent<Collider>();
		luz9 = pivoteluz9.GetComponent<Collider>();
		luz11 = pivoteluz11.GetComponent<Collider>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		luzon101 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighon1")).gameObject;
		luzoff101 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighoff1")).gameObject;
		luzon102 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighon2")).gameObject;
		luzoff102 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighoff2")).gameObject;
		luzon103 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighon3")).gameObject;
		luzoff103 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighoff3")).gameObject;
		luzon104 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighon4")).gameObject;
		luzoff104 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/porch_lighoff4")).gameObject;
		pivoteluz10 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/pivoteluz10/botonlampara10")).gameObject;
		pivluz10 = pivoteluz10.GetComponent<AudioSource>();
		luz10 = pivoteluz10.GetComponent<Collider>();
		pivoteluz10cerrado = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/pivoteluz10/botonlamparaabajo10")).transform;
		pivoteluz10abierto = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1/pivoteluz10/botonlamparaarriba10")).transform;
		luzpiscina1 = ((Component)((Component)root).transform.FindChild("utiles/luzpiscina1")).gameObject;
		Load();
	}

	private void Update()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null) || ((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>()._playerInMenu.Value)
		{
			return;
		}
		if (root.piscinacomprada)
		{
			luzpiscina1.SetActive(true);
		}
		if (!root.piscinacomprada)
		{
			luzpiscina1.SetActive(false);
		}
		if (Vector3.Distance(((Component)GameObject.Find("PLAYER")).transform.position, transform.root.position) <= 60f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		foreach (RaycastHit hit in array)
		{
			if (root.vendido)
			{
				Rayluces(hit);
				if (root.piscinacomprada)
				{
					RaylucesPiscina(hit);
				}
			}
		}
		}
		if (root.vendido)
		{
			SetupLuces();
			if (root.piscinacomprada)
			{
				SetupLucesPiscina();
			}
		}
	}

	public void Save()
	{
		if (root.vendido)
		{
			SaveData saveData = new SaveData();
			SaveDataList item = new SaveDataList
			{
				luz1 = luzz1,
				luz2 = luzz2,
				luz3 = luzz3,
				luz4 = luzz4,
				luz5 = luzz5,
				luz6 = luzz6,
				luz7 = luzz7,
				luz8 = luzz8,
				luz9 = luzz9,
				luz10 = luzz10,
				luz11 = luzz11,
				intensidad = intensidad
			};
			saveData.save.Add(item);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-lights.save");
		}
	}

	private void Load()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-lights.save");
		if (saveData != null)
		{
			luzz1 = saveData.save[0].luz1;
			luzz2 = saveData.save[0].luz2;
			luzz3 = saveData.save[0].luz3;
			luzz4 = saveData.save[0].luz4;
			luzz5 = saveData.save[0].luz5;
			luzz6 = saveData.save[0].luz6;
			luzz7 = saveData.save[0].luz7;
			luzz8 = saveData.save[0].luz8;
			luzz9 = saveData.save[0].luz9;
			luzz10 = saveData.save[0].luz10;
			luzz11 = saveData.save[0].luz11;
			intensidad = saveData.save[0].intensidad;
		}
	}

	private void SetupLucesPiscina()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (luzz10 && root.piscinacomprada)
		{
			pivoteluz10.transform.rotation = pivoteluz10abierto.rotation;
			luzon101.SetActive(true);
			luzoff101.SetActive(false);
			luzon102.SetActive(true);
			luzoff102.SetActive(false);
			luzon103.SetActive(true);
			luzoff103.SetActive(false);
			luzon104.SetActive(true);
			luzoff104.SetActive(false);
		}
		if (!luzz10 && root.piscinacomprada)
		{
			pivoteluz10.transform.rotation = pivoteluz10cerrado.rotation;
			luzon101.SetActive(false);
			luzoff101.SetActive(true);
			luzon102.SetActive(false);
			luzoff102.SetActive(true);
			luzon103.SetActive(false);
			luzoff103.SetActive(true);
			luzon104.SetActive(false);
			luzoff104.SetActive(true);
		}
	}

	private void SetupLuces()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		if (luzz1)
		{
			pivoteluz1.transform.rotation = pivoteluz1abierto.rotation;
			luzon1.SetActive(true);
			luzoff1.SetActive(false);
		}
		if (!luzz1)
		{
			pivoteluz1.transform.rotation = pivoteluz1cerrado.rotation;
			luzon1.SetActive(false);
			luzoff1.SetActive(true);
		}
		if (luzz2)
		{
			pivoteluz2.transform.rotation = pivoteluz2abierto.rotation;
			luzon21.SetActive(true);
			luzoff21.SetActive(false);
			luzon22.SetActive(true);
			luzoff22.SetActive(false);
		}
		if (!luzz2)
		{
			pivoteluz2.transform.rotation = pivoteluz2cerrado.rotation;
			luzon21.SetActive(false);
			luzoff21.SetActive(true);
			luzon22.SetActive(false);
			luzoff22.SetActive(true);
		}
		if (luzz3)
		{
			pivoteluz3.transform.rotation = pivoteluz3abierto.rotation;
			luzon3.SetActive(true);
			luzoff3.SetActive(false);
		}
		if (!luzz3)
		{
			pivoteluz3.transform.rotation = pivoteluz3cerrado.rotation;
			luzon3.SetActive(false);
			luzoff3.SetActive(true);
		}
		if (luzz4)
		{
			pivoteluz4.transform.rotation = pivoteluz4abierto.rotation;
			luzon4.SetActive(true);
			luzoff4.SetActive(false);
		}
		if (!luzz4)
		{
			pivoteluz4.transform.rotation = pivoteluz4cerrado.rotation;
			luzon4.SetActive(false);
			luzoff4.SetActive(true);
		}
		if (luzz5)
		{
			pivoteluz5.transform.rotation = pivoteluz5abierto.rotation;
			luzon5.SetActive(true);
			luzoff5.SetActive(false);
		}
		if (!luzz5)
		{
			pivoteluz5.transform.rotation = pivoteluz5cerrado.rotation;
			luzon5.SetActive(false);
			luzoff5.SetActive(true);
		}
		if (luzz6)
		{
			pivoteluz6.transform.rotation = pivoteluz6abierto.rotation;
			luzon6.SetActive(true);
			luzoff6.SetActive(false);
		}
		if (!luzz6)
		{
			pivoteluz6.transform.rotation = pivoteluz6cerrado.rotation;
			luzon6.SetActive(false);
			luzoff6.SetActive(true);
		}
		if (luzz7)
		{
			pivoteluz7.transform.rotation = pivoteluz7abierto.rotation;
			luzon7.SetActive(true);
			luzoff7.SetActive(false);
			luzon72.SetActive(true);
			luzoff72.SetActive(false);
		}
		if (!luzz7)
		{
			pivoteluz7.transform.rotation = pivoteluz7cerrado.rotation;
			luzon7.SetActive(false);
			luzoff7.SetActive(true);
			luzon72.SetActive(false);
			luzoff72.SetActive(true);
		}
		if (luzz8)
		{
			pivoteluz8.transform.rotation = pivoteluz8abierto.rotation;
			luzon81.SetActive(true);
			luzoff81.SetActive(false);
			luzon82.SetActive(true);
			luzoff82.SetActive(false);
		}
		if (!luzz8)
		{
			pivoteluz8.transform.rotation = pivoteluz8cerrado.rotation;
			luzon81.SetActive(false);
			luzoff81.SetActive(true);
			luzon82.SetActive(false);
			luzoff82.SetActive(true);
		}
		if (luzz9)
		{
			pivoteluz9.transform.rotation = pivoteluz9abierto.rotation;
			luzon91.SetActive(true);
			luzoff91.SetActive(false);
			luzon92.SetActive(true);
			luzoff92.SetActive(false);
			luzon93.SetActive(true);
			luzoff93.SetActive(false);
			luzon94.SetActive(true);
			luzoff94.SetActive(false);
			luzon95.SetActive(true);
			luzoff95.SetActive(false);
			luzon96.SetActive(true);
			luzoff96.SetActive(false);
		}
		if (!luzz9)
		{
			pivoteluz9.transform.rotation = pivoteluz9cerrado.rotation;
			luzon91.SetActive(false);
			luzoff91.SetActive(true);
			luzon92.SetActive(false);
			luzoff92.SetActive(true);
			luzon93.SetActive(false);
			luzoff93.SetActive(true);
			luzon94.SetActive(false);
			luzoff94.SetActive(true);
			luzon95.SetActive(false);
			luzoff95.SetActive(true);
			luzon96.SetActive(false);
			luzoff96.SetActive(true);
		}
		if (luzz11)
		{
			pivoteluz11.transform.rotation = pivoteluz11abierto.rotation;
			luzon11.SetActive(true);
			luzoff11.SetActive(false);
		}
		if (!luzz11)
		{
			pivoteluz11.transform.rotation = pivoteluz11cerrado.rotation;
			luzon11.SetActive(false);
			luzoff11.SetActive(true);
		}
	}

	private void RaylucesPiscina(RaycastHit hit)
	{
		if (!((Object)(object)hit.collider == (Object)(object)luz10))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
		{
			luzz10 = !luzz10;
			pivluz10.Play();
			if (luzz10)
			{
				intensidad++;
			}
			if (!luzz10)
			{
				intensidad--;
			}
		}
	}

	private void Rayluces(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)luz1)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz1 = !luzz1;
				pivluz1.Play();
				if (luzz1)
				{
					intensidad++;
				}
				if (!luzz1)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz2)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz2 = !luzz2;
				pivluz2.Play();
				if (luzz2)
				{
					intensidad++;
				}
				if (!luzz2)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz3)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz3 = !luzz3;
				pivluz3.Play();
				if (luzz3)
				{
					intensidad++;
				}
				if (!luzz3)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz4)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz4 = !luzz4;
				pivluz4.Play();
				if (luzz4)
				{
					intensidad++;
				}
				if (!luzz4)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz5)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz5 = !luzz5;
				pivluz5.Play();
				if (luzz5)
				{
					intensidad++;
				}
				if (!luzz5)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz6)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz6 = !luzz6;
				pivluz6.Play();
				if (luzz6)
				{
					intensidad++;
				}
				if (!luzz6)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz7)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz7 = !luzz7;
				pivluz7.Play();
				if (luzz7)
				{
					intensidad++;
				}
				if (!luzz7)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz8)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz8 = !luzz8;
				pivluz8.Play();
				if (luzz8)
				{
					intensidad++;
				}
				if (!luzz8)
				{
					intensidad--;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)luz9)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				luzz9 = !luzz9;
				pivluz9.Play();
				if (luzz9)
				{
					intensidad++;
				}
				if (!luzz9)
				{
					intensidad--;
				}
			}
		}
		if (!((Object)(object)hit.collider == (Object)(object)luz11))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
		{
			luzz11 = !luzz11;
			pivluz11.Play();
			if (luzz11)
			{
				intensidad++;
			}
			if (!luzz11)
			{
				intensidad--;
			}
		}
	}
}
