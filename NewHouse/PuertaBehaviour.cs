using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class PuertaBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public bool puerta1;

		public bool puerta2;

		public bool puerta3;

		public bool puerta4;

		public bool puerta5;

		public bool puerta6;

		public bool puerta7;

		public bool puerta8;

		public bool puerta9;

		public bool puerta10;

		public bool puertaparking;

		public bool puertainterior1;

		public bool puertainterior2;

		public bool puertainterior3;

		public bool puertainterior4;

		public bool puertainterior5;

		public bool puertainterior6;

		public bool puertavallaopen;

		public bool puertavallaparkingopen;

		public int intensidad;
	}

	private GameObject pivote1;

	private GameObject pivote2;

	private GameObject pivote3;

	private GameObject pivote4;

	private GameObject pivote5;

	private GameObject pivote6;

	private GameObject pivote7;

	private GameObject pivote8;

	private GameObject pivote9;

	private GameObject pivote10;

	private GameObject pivoteparking;

	private Animator pivoteparkinganim;

	private Transform pivoteparkingbotoncerrado1;

	private Transform pivoteparkingbotonabierto1;

	private Transform pivoteparkingbotoncerrado2;

	private Transform pivoteparkingbotonabierto2;

	private Animator pivote1anim;

	private Animator pivote2anim;

	private Animator pivote3anim;

	private Animator pivote4anim;

	private Animator pivote5anim;

	private Animator pivote6anim;

	private Animator pivote7anim;

	private Animator pivote8anim;

	private Animator pivote9anim;

	private Animator pivote10anim;

	private Collider botonparking1;

	private Collider botonparking2;

	private Collider puerta1;

	private Collider puerta2;

	private Collider puerta3;

	private Collider puerta4;

	private Collider puerta5;

	private Collider puerta6;

	private Collider puerta7;

	private Collider puerta8;

	private Collider puerta9;

	private Collider puerta10;

	private FsmBool m_guiUseBool;

	public bool abiertaparking;

	private bool abierta1;

	private bool abierta2;

	private bool abierta3;

	private bool abierta4;

	private bool abierta5;

	private bool abierta6;

	private bool abierta7;

	private bool abierta8;

	private bool abierta9;

	private bool abierta10;

	private AudioSource pivpuertavallagarage;

	private AudioSource pivpuertavalla;

	private AudioSource pivabierto1;

	private AudioSource pivabierto2;

	private AudioSource pivabierto3;

	private AudioSource pivabierto4;

	private AudioSource pivabierto5;

	private AudioSource pivcerrado1;

	private AudioSource pivcerrado2;

	private AudioSource pivcerrado3;

	private AudioSource pivcerrado4;

	private AudioSource pivcerrado5;

	private AudioSource pivboton1;

	private AudioSource pivboton2;

	private AudioSource sonidoparking;

	private GameObject pivoteinterior1;

	private Collider puertainterior1;

	private Animator pivoteinterior1anim;

	private bool interiorabierta1;

	private AudioSource interiorpivabierto1;

	private AudioSource interiorpivcerrado1;

	private GameObject pivoteinterior2;

	private Collider puertainterior2;

	private Animator pivoteinterior2anim;

	private bool interiorabierta2;

	private AudioSource interiorpivabierto2;

	private AudioSource interiorpivcerrado2;

	private GameObject pivoteinterior3;

	private Collider puertainterior3;

	private Animator pivoteinterior3anim;

	private bool interiorabierta3;

	private AudioSource interiorpivabierto3;

	private AudioSource interiorpivcerrado3;

	private GameObject pivoteinterior4;

	private Collider puertainterior4;

	private Animator pivoteinterior4anim;

	private bool interiorabierta4;

	private AudioSource interiorpivabierto4;

	private AudioSource interiorpivcerrado4;

	private GameObject pivoteinterior5;

	private Animator pivoteinterior5anim;

	private Collider puertainterior5;

	private bool interiorabierta5;

	private AudioSource interiorpivabierto5;

	private AudioSource interiorpivcerrado5;

	private GameObject pivoteinterior6;

	private Animator pivoteinterior6anim;

	private Collider puertainterior6;

	private bool interiorabierta6;

	private AudioSource interiorpivabierto6;

	private AudioSource interiorpivcerrado6;

	private GameObject puertagarage;

	private GameObject pulsador;

	private Animator pivotpuertavallaanim;

	private Transform pivotpuertavalla;

	private Collider puertavalla;

	private Animator pivotpuertavallagarageanim;

	private Transform pivotpuertavallagarage;

	private Collider puertavallagarage;

	private bool puertavallaopen;

	public bool puertavallagarageopen;

	private CasaBehaviour root;

	public int intensidad;

	public bool loaded;

	private bool loading;

	private void Start()
	{
		pivotpuertavalla = ((Component)((Component)this).transform.FindChild("valla/puertavallacompleta/pivotpuertavalla")).transform;
		puertavalla = ((Component)((Component)pivotpuertavalla).transform.FindChild("puertavalla")).GetComponent<Collider>();
		pivpuertavalla = ((Component)puertavalla).GetComponent<AudioSource>();
		pivotpuertavallaanim = ((Component)puertavalla).GetComponent<Animator>();
		pivotpuertavallagarage = ((Component)((Component)this).transform.FindChild("valla/puertavallagaragecompleta/pivotpuertavallagarage")).transform;
		puertavallagarage = ((Component)((Component)pivotpuertavallagarage).transform.FindChild("puertavallagarage")).GetComponent<Collider>();
		pivpuertavallagarage = ((Component)puertavallagarage).GetComponent<AudioSource>();
		pivotpuertavallagarageanim = ((Component)puertavallagarage).GetComponent<Animator>();
		puertagarage = ((Component)((Component)this).transform.FindChild("puertagarage")).gameObject;
		pulsador = ((Component)((Component)this).transform.FindChild("pulsador/palo/panel")).gameObject;
		pivoteparking = ((Component)puertagarage.transform.FindChild("pivotegarage")).gameObject;
		sonidoparking = pivoteparking.GetComponent<AudioSource>();
		pivoteparkinganim = pivoteparking.GetComponent<Animator>();
		pivoteparkingbotonabierto1 = ((Component)pulsador.transform.FindChild("pivoteparkingboton1/pivoteparkingbotonarriba1")).transform;
		pivoteparkingbotonabierto2 = ((Component)pulsador.transform.FindChild("pivoteparkingboton2/pivoteparkingbotonarriba2")).transform;
		pivoteparkingbotoncerrado1 = ((Component)pulsador.transform.FindChild("pivoteparkingboton1/pivoteparkingbotonabajo1")).transform;
		pivoteparkingbotoncerrado2 = ((Component)pulsador.transform.FindChild("pivoteparkingboton2/pivoteparkingbotonabajo2")).transform;
		botonparking1 = ((Component)pulsador.transform.FindChild("pivoteparkingboton1/botonparking1")).GetComponent<Collider>();
		botonparking2 = ((Component)pulsador.transform.FindChild("pivoteparkingboton2/botonparking2")).GetComponent<Collider>();
		pivboton1 = ((Component)botonparking1).GetComponent<AudioSource>();
		pivboton2 = ((Component)botonparking2).GetComponent<AudioSource>();
		pivote1 = ((Component)((Component)this).transform.FindChild("puertas/puerta1/pivotepuertainterior")).gameObject;
		puerta1 = ((Component)pivote1.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote2 = ((Component)((Component)this).transform.FindChild("puertas/puerta2/pivotepuertainterior")).gameObject;
		puerta2 = ((Component)pivote2.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote3 = ((Component)((Component)this).transform.FindChild("puertas 1/puerta1/pivotepuertainterior")).gameObject;
		puerta3 = ((Component)pivote3.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote4 = ((Component)((Component)this).transform.FindChild("puertas 1/puerta2/pivotepuertainterior")).gameObject;
		puerta4 = ((Component)pivote4.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote5 = ((Component)((Component)this).transform.FindChild("puertas 2/puerta1/pivotepuertainterior")).gameObject;
		puerta5 = ((Component)pivote5.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote6 = ((Component)((Component)this).transform.FindChild("puertas 2/puerta2/pivotepuertainterior")).gameObject;
		puerta6 = ((Component)pivote6.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote7 = ((Component)((Component)this).transform.FindChild("puertas 3/puerta1/pivotepuertainterior")).gameObject;
		puerta7 = ((Component)pivote7.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote8 = ((Component)((Component)this).transform.FindChild("puertas 3/puerta2/pivotepuertainterior")).gameObject;
		puerta8 = ((Component)pivote8.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote9 = ((Component)((Component)this).transform.FindChild("puertas 4/puerta1/pivotepuertainterior")).gameObject;
		puerta9 = ((Component)pivote9.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivote10 = ((Component)((Component)this).transform.FindChild("puertas 4/puerta2/pivotepuertainterior")).gameObject;
		puerta10 = ((Component)pivote10.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivabierto1 = pivote1.GetComponent<AudioSource>();
		pivabierto2 = pivote3.GetComponent<AudioSource>();
		pivabierto3 = pivote5.GetComponent<AudioSource>();
		pivabierto4 = pivote7.GetComponent<AudioSource>();
		pivabierto5 = pivote9.GetComponent<AudioSource>();
		pivcerrado1 = pivote2.GetComponent<AudioSource>();
		pivcerrado2 = ((Component)puerta3).GetComponent<AudioSource>();
		pivcerrado3 = ((Component)puerta5).GetComponent<AudioSource>();
		pivcerrado4 = ((Component)puerta7).GetComponent<AudioSource>();
		pivcerrado5 = ((Component)puerta9).GetComponent<AudioSource>();
		pivote1anim = pivote1.GetComponent<Animator>();
		pivote2anim = pivote2.GetComponent<Animator>();
		pivote3anim = pivote3.GetComponent<Animator>();
		pivote4anim = pivote4.GetComponent<Animator>();
		pivote5anim = pivote5.GetComponent<Animator>();
		pivote6anim = pivote6.GetComponent<Animator>();
		pivote7anim = pivote7.GetComponent<Animator>();
		pivote8anim = pivote8.GetComponent<Animator>();
		pivote9anim = pivote9.GetComponent<Animator>();
		pivote10anim = pivote10.GetComponent<Animator>();
		pivoteinterior1 = ((Component)((Component)this).transform.FindChild("puertas 5/pivotepuertainterior")).gameObject;
		puertainterior1 = ((Component)pivoteinterior1.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivoteinterior1anim = pivoteinterior1.GetComponent<Animator>();
		interiorpivabierto1 = pivoteinterior1.GetComponent<AudioSource>();
		interiorpivcerrado1 = ((Component)puertainterior1).GetComponent<AudioSource>();
		pivoteinterior2 = ((Component)((Component)this).transform.FindChild("puertas 6/pivotepuertainterior")).gameObject;
		puertainterior2 = ((Component)pivoteinterior2.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivoteinterior2anim = pivoteinterior2.GetComponent<Animator>();
		interiorpivabierto2 = pivoteinterior2.GetComponent<AudioSource>();
		interiorpivcerrado2 = ((Component)puertainterior2).GetComponent<AudioSource>();
		pivoteinterior3 = ((Component)((Component)this).transform.FindChild("puertas 7/pivotepuertainterior")).gameObject;
		puertainterior3 = ((Component)pivoteinterior3.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivoteinterior3anim = pivoteinterior3.GetComponent<Animator>();
		interiorpivabierto3 = pivoteinterior3.GetComponent<AudioSource>();
		interiorpivcerrado3 = ((Component)puertainterior3).GetComponent<AudioSource>();
		pivoteinterior4 = ((Component)((Component)this).transform.FindChild("puertas 8/pivotepuertainterior")).gameObject;
		puertainterior4 = ((Component)pivoteinterior4.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivoteinterior4anim = pivoteinterior4.GetComponent<Animator>();
		interiorpivabierto4 = pivoteinterior4.GetComponent<AudioSource>();
		interiorpivcerrado4 = ((Component)puertainterior4).GetComponent<AudioSource>();
		pivoteinterior5 = ((Component)((Component)this).transform.FindChild("puertas 9/pivotepuertainterior")).gameObject;
		pivoteinterior5anim = pivoteinterior5.GetComponent<Animator>();
		puertainterior5 = ((Component)pivoteinterior5.transform.FindChild("puertainterior")).GetComponent<Collider>();
		interiorpivabierto5 = pivoteinterior5.GetComponent<AudioSource>();
		interiorpivcerrado5 = ((Component)puertainterior5).GetComponent<AudioSource>();
		pivoteinterior6 = ((Component)((Component)this).transform.FindChild("puertas 10/pivotepuertainterior")).gameObject;
		puertainterior6 = ((Component)pivoteinterior6.transform.FindChild("puertainterior")).GetComponent<Collider>();
		pivoteinterior6anim = pivoteinterior6.GetComponent<Animator>();
		interiorpivabierto6 = pivoteinterior6.GetComponent<AudioSource>();
		interiorpivcerrado6 = ((Component)puertainterior6).GetComponent<AudioSource>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		root = ((Component)((Component)this).transform.root).GetComponent<CasaBehaviour>();
	}

	private IEnumerator Espera()
	{
		abierta1 = false;
		abierta2 = false;
		abierta3 = false;
		abierta4 = false;
		abierta5 = false;
		abierta6 = false;
		abierta7 = false;
		abierta8 = false;
		abierta9 = false;
		abierta10 = false;
		abiertaparking = false;
		interiorabierta1 = false;
		interiorabierta2 = false;
		interiorabierta3 = false;
		interiorabierta4 = false;
		interiorabierta5 = false;
		interiorabierta6 = false;
		puertavallaopen = false;
		puertavallagarageopen = false;
		yield return (object)new WaitForSeconds(4f);
		Load();
		loading = false;
	}

	private void Update()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (!loaded && !loading)
		{
			loading = true;
			((MonoBehaviour)this).StartCoroutine(Espera());
		}
		if (Vector3.Distance(GameObject.Find("PLAYER").transform.position, transform.root.position) <= 60f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		foreach (RaycastHit hit in array)
		{
			if (root.vendido)
			{
				Raypuertas(hit);
				Raypuertasinteriores(hit);
			}
		}
		}
		if (root.vendido)
		{
			SetupPuertasgarage();
			PuertaInterior1();
			PuertaInterior2();
			PuertaInterior3();
			PuertaInterior4();
			PuertaInterior5();
			PuertaInterior6();
			Puertaexterior1();
			Puertaexterior2();
			Puertaexterior3();
			Puertaexterior4();
			Puertaexterior5();
			Puertaexterior6();
			Puertaexterior7();
			Puertaexterior8();
			Puertaexterior9();
			Puertaexterior10();
			ParkingExterior();
			ParkingInterior();
		}
	}

	private void SetupPuertasgarage()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (abiertaparking)
		{
			((Component)botonparking1).transform.rotation = pivoteparkingbotonabierto1.rotation;
			((Component)botonparking2).transform.rotation = pivoteparkingbotonabierto2.rotation;
			pivoteparkinganim.CrossFade("close", 0.5f);
		}
		if (!abiertaparking)
		{
			((Component)botonparking1).transform.rotation = pivoteparkingbotoncerrado1.rotation;
			((Component)botonparking2).transform.rotation = pivoteparkingbotoncerrado2.rotation;
			pivoteparkinganim.CrossFade("open", 0.5f);
		}
	}

	private void PuertaInterior1()
	{
		if (interiorabierta1)
		{
			pivoteinterior1anim.CrossFade("open", 0f);
		}
		if (!interiorabierta1)
		{
			pivoteinterior1anim.CrossFade("close", 0f);
		}
	}

	private void PuertaInterior2()
	{
		if (interiorabierta2)
		{
			pivoteinterior2anim.CrossFade("open", 0f);
		}
		if (!interiorabierta2)
		{
			pivoteinterior2anim.CrossFade("close", 0f);
		}
	}

	private void PuertaInterior3()
	{
		if (interiorabierta3)
		{
			pivoteinterior3anim.CrossFade("open", 0f);
		}
		if (!interiorabierta3)
		{
			pivoteinterior3anim.CrossFade("close", 0f);
		}
	}

	private void PuertaInterior4()
	{
		if (interiorabierta4)
		{
			pivoteinterior4anim.CrossFade("open", 0f);
		}
		if (!interiorabierta4)
		{
			pivoteinterior4anim.CrossFade("close", 0f);
		}
	}

	private void PuertaInterior5()
	{
		if (interiorabierta5)
		{
			pivoteinterior5anim.CrossFade("open", 0f);
		}
		if (!interiorabierta5)
		{
			pivoteinterior5anim.CrossFade("close", 0f);
		}
	}

	private void PuertaInterior6()
	{
		if (interiorabierta6)
		{
			pivoteinterior6anim.CrossFade("open", 0f);
		}
		if (!interiorabierta6)
		{
			pivoteinterior6anim.CrossFade("close", 0f);
		}
	}

	private void Puertaexterior1()
	{
		if (abierta1)
		{
			pivote1anim.CrossFade("openinverted", 0f);
		}
		if (!abierta1)
		{
			pivote1anim.CrossFade("closeinverted", 0f);
		}
	}

	private void Puertaexterior2()
	{
		if (abierta2)
		{
			pivote2anim.CrossFade("open", 0f);
		}
		if (!abierta2)
		{
			pivote2anim.CrossFade("close", 0f);
		}
	}

	private void Puertaexterior3()
	{
		if (abierta3)
		{
			pivote3anim.CrossFade("openinverted", 0f);
		}
		if (!abierta3)
		{
			pivote3anim.CrossFade("closeinverted", 0f);
		}
	}

	private void Puertaexterior4()
	{
		if (abierta4)
		{
			pivote4anim.CrossFade("open", 0f);
		}
		if (!abierta4)
		{
			pivote4anim.CrossFade("close", 0f);
		}
	}

	private void Puertaexterior5()
	{
		if (abierta5)
		{
			pivote5anim.CrossFade("open", 0f);
		}
		if (!abierta5)
		{
			pivote5anim.CrossFade("close", 0f);
		}
	}

	private void Puertaexterior6()
	{
		if (abierta6)
		{
			pivote6anim.CrossFade("openinverted", 0f);
		}
		if (!abierta6)
		{
			pivote6anim.CrossFade("closeinverted", 0f);
		}
	}

	private void Puertaexterior7()
	{
		if (abierta7)
		{
			pivote7anim.CrossFade("openinverted", 0f);
		}
		if (!abierta7)
		{
			pivote7anim.CrossFade("closeinverted", 0f);
		}
	}

	private void Puertaexterior8()
	{
		if (abierta8)
		{
			pivote8anim.CrossFade("open", 0f);
		}
		if (!abierta8)
		{
			pivote8anim.CrossFade("close", 0f);
		}
	}

	private void Puertaexterior9()
	{
		if (abierta9)
		{
			pivote9anim.CrossFade("openinverted", 0f);
		}
		if (!abierta9)
		{
			pivote9anim.CrossFade("closeinverted", 0f);
		}
	}

	private void Puertaexterior10()
	{
		if (abierta10)
		{
			pivote10anim.CrossFade("open", 0f);
		}
		if (!abierta10)
		{
			pivote10anim.CrossFade("close", 0f);
		}
	}

	private void ParkingExterior()
	{
		if (puertavallagarageopen)
		{
			pivotpuertavallagarageanim.CrossFade("close", 3f);
		}
		if (!puertavallagarageopen)
		{
			pivotpuertavallagarageanim.CrossFade("open", 3f);
		}
	}

	private void ParkingInterior()
	{
		if (puertavallaopen)
		{
			pivotpuertavallaanim.CrossFade("open2", 0f);
		}
		if (!puertavallaopen)
		{
			pivotpuertavallaanim.CrossFade("close2", 0f);
		}
	}

	private void Raypuertas(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)puerta1)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta1 = !abierta1;
				if (abierta1)
				{
					pivabierto1.Play();
				}
				if (!abierta1)
				{
					pivcerrado1.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta2)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta2 = !abierta2;
				if (abierta2)
				{
					pivabierto1.Play();
				}
				if (!abierta2)
				{
					pivcerrado1.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta3)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta3 = !abierta3;
				if (abierta3)
				{
					pivabierto2.Play();
				}
				if (!abierta3)
				{
					pivcerrado2.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta4)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta4 = !abierta4;
				if (abierta4)
				{
					pivabierto2.Play();
				}
				if (!abierta4)
				{
					pivcerrado2.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta5)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta5 = !abierta5;
				if (abierta5)
				{
					pivabierto3.Play();
				}
				if (!abierta5)
				{
					pivcerrado3.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta6)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta6 = !abierta6;
				if (abierta6)
				{
					pivabierto3.Play();
				}
				if (!abierta6)
				{
					pivcerrado3.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta7)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta7 = !abierta7;
				if (abierta7)
				{
					pivabierto4.Play();
				}
				if (!abierta7)
				{
					pivcerrado4.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta8)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta8 = !abierta8;
				if (abierta8)
				{
					pivabierto4.Play();
				}
				if (!abierta8)
				{
					pivcerrado4.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta9)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta9 = !abierta9;
				if (abierta9)
				{
					pivabierto5.Play();
				}
				if (!abierta9)
				{
					pivcerrado5.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puerta10)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				abierta10 = !abierta10;
				if (abierta10)
				{
					pivabierto5.Play();
				}
				if (!abierta10)
				{
					pivcerrado5.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)botonparking1)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
			{
				abiertaparking = !abiertaparking;
				intensidad++;
				pivboton1.Play();
				((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>().reusado = false;
				if (sonidoparking.isPlaying)
				{
					sonidoparking.Stop();
				}
				if (!sonidoparking.isPlaying)
				{
					sonidoparking.Play();
				}
			}
		}
		if (!((Object)(object)hit.collider == (Object)(object)botonparking2))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0) && ((Component)root).GetComponent<ElectricidadBehaviour>().electricidadon)
		{
			abiertaparking = !abiertaparking;
			intensidad++;
			pivboton2.Play();
			((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>().reusado = false;
			if (sonidoparking.isPlaying)
			{
				sonidoparking.Stop();
			}
			if (!sonidoparking.isPlaying)
			{
				sonidoparking.Play();
			}
		}
	}

	private void Raypuertasinteriores(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)puertavalla)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				puertavallaopen = !puertavallaopen;
				if (!pivpuertavalla.isPlaying)
				{
					pivpuertavalla.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puertainterior1)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				interiorabierta1 = !interiorabierta1;
				if (interiorabierta1)
				{
					interiorpivabierto1.Play();
				}
				if (!interiorabierta1)
				{
					interiorpivcerrado1.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puertainterior2)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				interiorabierta2 = !interiorabierta2;
				if (interiorabierta2)
				{
					interiorpivabierto2.Play();
				}
				if (!interiorabierta2)
				{
					interiorpivcerrado2.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puertainterior3)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				interiorabierta3 = !interiorabierta3;
				if (interiorabierta3)
				{
					interiorpivabierto3.Play();
				}
				if (!interiorabierta3)
				{
					interiorpivcerrado3.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puertainterior4)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				interiorabierta4 = !interiorabierta4;
				if (interiorabierta4)
				{
					interiorpivabierto4.Play();
				}
				if (!interiorabierta4)
				{
					interiorpivcerrado4.Play();
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)puertainterior5)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				interiorabierta5 = !interiorabierta5;
				if (interiorabierta5)
				{
					interiorpivabierto5.Play();
				}
				if (!interiorabierta5)
				{
					interiorpivcerrado5.Play();
				}
			}
		}
		if (!((Object)(object)hit.collider == (Object)(object)puertainterior6))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0))
		{
			interiorabierta6 = !interiorabierta6;
			if (interiorabierta6)
			{
				interiorpivabierto6.Play();
			}
			if (!interiorabierta6)
			{
				interiorpivcerrado6.Play();
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
				puerta1 = abierta1,
				puerta2 = abierta2,
				puerta3 = abierta3,
				puerta4 = abierta4,
				puerta5 = abierta5,
				puerta6 = abierta6,
				puerta7 = abierta7,
				puerta8 = abierta8,
				puerta9 = abierta9,
				puerta10 = abierta10,
				puertainterior1 = interiorabierta1,
				puertainterior2 = interiorabierta2,
				puertainterior3 = interiorabierta3,
				puertainterior4 = interiorabierta4,
				puertainterior5 = interiorabierta5,
				puertainterior6 = interiorabierta6,
				puertavallaopen = puertavallaopen,
				puertaparking = abiertaparking,
				puertavallaparkingopen = puertavallagarageopen,
				intensidad = intensidad
			};
			saveData.save.Add(item);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-doors.save");
		}
	}

	private void Load()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-doors.save");
		abierta1 = false;
		abierta2 = false;
		abierta3 = false;
		abierta4 = false;
		abierta5 = false;
		abierta6 = false;
		abierta7 = false;
		abierta8 = false;
		abierta9 = false;
		abierta10 = false;
		abiertaparking = false;
		interiorabierta1 = false;
		interiorabierta2 = false;
		interiorabierta3 = false;
		interiorabierta4 = false;
		interiorabierta5 = false;
		interiorabierta6 = false;
		puertavallaopen = false;
		puertavallagarageopen = false;
		intensidad = 0;
		if (saveData != null)
		{
			abierta1 = saveData.save[0].puerta1;
			abierta2 = saveData.save[0].puerta2;
			abierta3 = saveData.save[0].puerta3;
			abierta4 = saveData.save[0].puerta4;
			abierta5 = saveData.save[0].puerta5;
			abierta6 = saveData.save[0].puerta6;
			abierta7 = saveData.save[0].puerta7;
			abierta8 = saveData.save[0].puerta8;
			abierta9 = saveData.save[0].puerta9;
			abierta10 = saveData.save[0].puerta10;
			abiertaparking = saveData.save[0].puertaparking;
			interiorabierta1 = saveData.save[0].puertainterior1;
			interiorabierta2 = saveData.save[0].puertainterior2;
			interiorabierta3 = saveData.save[0].puertainterior3;
			interiorabierta4 = saveData.save[0].puertainterior4;
			interiorabierta5 = saveData.save[0].puertainterior5;
			interiorabierta6 = saveData.save[0].puertainterior6;
			puertavallaopen = saveData.save[0].puertavallaopen;
			puertavallagarageopen = saveData.save[0].puertavallaparkingopen;
			intensidad = saveData.save[0].intensidad;
		}
		loaded = true;
	}

	public void Operapuerta(bool abierto)
	{
		if (abierto)
		{
			puertavallagarageopen = true;
			((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>().reusado2 = false;
			if (!pivpuertavallagarage.isPlaying)
			{
				pivpuertavallagarage.Play();
			}
		}
		if (!abierto)
		{
			puertavallagarageopen = false;
			((Component)((Component)this).transform.root).GetComponent<ElectricidadBehaviour>().reusado2 = false;
			if (!pivpuertavallagarage.isPlaying)
			{
				pivpuertavallagarage.Play();
			}
		}
	}
}
