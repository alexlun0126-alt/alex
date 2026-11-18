using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class PapelilloBehaviour : MonoBehaviour
{
	private GameObject deltele;

	private GameObject delradio;

	private GameObject delpiscina;

	private GameObject deljacuzzi;

	private GameObject delmudanza;

	private GameObject delbarbacoa;

	private Collider imatele;

	private Collider imaradio;

	private Collider imapiscina;

	private Collider imajacuzzi;

	private Collider imamudanza;

	private Collider imaexit;

	private Collider imaexit2;

	private Collider imabarbacoa;

	private Collider imanext;

	private FsmBool m_guiUseBool;

	public bool tele;

	public bool radio;

	public bool piscina;

	public bool jacuzzi;

	public bool barbacoa;

	public bool muevepartes;

	public bool cobradotele;

	public bool cobradoradio;

	public bool cobradopiscina;

	public bool cobradosauna;

	public bool cobradobarbacoa;

	private TodoItemBehaviour partes;

	private CasaBehaviour general;

	public float precioradio = 895f;

	public float preciotele = 1295f;

	public float preciopiscina = 12375f;

	public float preciojacuzzi = 7895f;

	public float preciomudanza = 500f;

	public float preciobarbacoa = 5250f;

	public float total;

	public float total2;

	private TextMesh texto1;

	private TextMesh texto2;

	private TextMesh texto3;

	private TextMesh texto4;

	private TextMesh texto5;

	private TextMesh texto6;

	private TextMesh texto7;

	private TextMesh texto8;

	private TextMesh texto10;

	private TextMesh texto11;

	private TextMesh texto12;

	private TextMesh texto13;

	private GameObject serviciokunedo2;

	private GameObject serviciokunedo3;

	private GameObject serviciokunedo4;

	private Collider imamesa;

	private Collider imasofa;

	private Collider imapouf;

	private Collider imasilla;

	private Collider imaalfombra;

	private Collider imaexit4;

	private Collider imaexit42;

	private Collider imanext4;

	private GameObject delmesa;

	private GameObject delsofa;

	private GameObject delpouf;

	private GameObject delsilla;

	private GameObject delalfombra;

	public bool mesa;

	public bool sofa;

	public bool pouf;

	public bool silla;

	public bool alfombra;

	public float preciomesa = 95f;

	public float preciosofa = 895f;

	public float preciopouf = 175f;

	public float preciosilla = 95f;

	public float precioalfombra = 40f;

	private Collider imamesa2;

	private Collider imasilla2;

	private Collider imanightstand;

	private GameObject delmesa2;

	private GameObject delsilla2;

	private GameObject delnightstand;

	public bool mesa2;

	public bool silla2;

	public bool nightstand;

	public float preciomesa2 = 145f;

	public float preciosilla2 = 95f;

	public float precionightstand = 65f;

	private TextMesh textomesa2;

	private TextMesh textosilla2;

	private TextMesh textonightstand;

	public bool sacacarta;

	private void Start()
	{
		serviciokunedo4 = ((Component)((Component)this).transform.FindChild("ServicioKunedo4")).gameObject;
		serviciokunedo4.SetActive(false);
		serviciokunedo3 = ((Component)((Component)this).transform.FindChild("ServicioKunedo3")).gameObject;
		serviciokunedo2 = ((Component)((Component)this).transform.FindChild("ServicioKunedo2")).gameObject;
		deltele = ((Component)serviciokunedo2.transform.FindChild("deltele")).gameObject;
		delradio = ((Component)serviciokunedo2.transform.FindChild("delradio")).gameObject;
		delpiscina = ((Component)serviciokunedo2.transform.FindChild("delpiscina")).gameObject;
		deljacuzzi = ((Component)serviciokunedo2.transform.FindChild("deljacuzzi")).gameObject;
		delmudanza = ((Component)serviciokunedo2.transform.FindChild("delmudanza")).gameObject;
		delbarbacoa = ((Component)serviciokunedo2.transform.FindChild("delbarbacoa")).gameObject;
		imatele = ((Component)serviciokunedo2.transform.FindChild("imatele")).GetComponent<Collider>();
		imaradio = ((Component)serviciokunedo2.transform.FindChild("imaradio")).GetComponent<Collider>();
		imapiscina = ((Component)serviciokunedo2.transform.FindChild("imapiscina")).GetComponent<Collider>();
		imajacuzzi = ((Component)serviciokunedo2.transform.FindChild("imajacuzzi")).GetComponent<Collider>();
		imamudanza = ((Component)serviciokunedo2.transform.FindChild("imamudanza")).GetComponent<Collider>();
		imaexit = ((Component)serviciokunedo2.transform.FindChild("imaexit")).GetComponent<Collider>();
		imanext = ((Component)serviciokunedo2.transform.FindChild("imanext")).GetComponent<Collider>();
		imaexit2 = ((Component)serviciokunedo2.transform.FindChild("imaexit2")).GetComponent<Collider>();
		imabarbacoa = ((Component)serviciokunedo2.transform.FindChild("imabarbacoa")).GetComponent<Collider>();
		texto1 = ((Component)serviciokunedo3.transform.FindChild("textoo1")).GetComponent<TextMesh>();
		texto2 = ((Component)serviciokunedo3.transform.FindChild("textoo2")).GetComponent<TextMesh>();
		texto3 = ((Component)serviciokunedo3.transform.FindChild("textoo3")).GetComponent<TextMesh>();
		texto4 = ((Component)serviciokunedo3.transform.FindChild("textoo4")).GetComponent<TextMesh>();
		texto5 = ((Component)serviciokunedo3.transform.FindChild("textoo5")).GetComponent<TextMesh>();
		texto6 = ((Component)serviciokunedo3.transform.FindChild("textoo6")).GetComponent<TextMesh>();
		texto7 = ((Component)serviciokunedo3.transform.FindChild("textoo7")).GetComponent<TextMesh>();
		texto8 = ((Component)serviciokunedo3.transform.FindChild("textoo8")).GetComponent<TextMesh>();
		texto10 = ((Component)serviciokunedo3.transform.FindChild("textoo10")).GetComponent<TextMesh>();
		texto11 = ((Component)serviciokunedo3.transform.FindChild("textoo11")).GetComponent<TextMesh>();
		texto12 = ((Component)serviciokunedo3.transform.FindChild("textoo12")).GetComponent<TextMesh>();
		texto13 = ((Component)serviciokunedo3.transform.FindChild("textoo13")).GetComponent<TextMesh>();
		textomesa2 = ((Component)serviciokunedo3.transform.FindChild("textoomesa2")).GetComponent<TextMesh>();
		textosilla2 = ((Component)serviciokunedo3.transform.FindChild("textoosilla2")).GetComponent<TextMesh>();
		textonightstand = ((Component)serviciokunedo3.transform.FindChild("textoonightstand")).GetComponent<TextMesh>();
		delmesa = ((Component)serviciokunedo4.transform.FindChild("delmesa")).gameObject;
		delmesa2 = ((Component)serviciokunedo4.transform.FindChild("delmesa2")).gameObject;
		delsofa = ((Component)serviciokunedo4.transform.FindChild("delsofa")).gameObject;
		delpouf = ((Component)serviciokunedo4.transform.FindChild("delpouf")).gameObject;
		delsilla = ((Component)serviciokunedo4.transform.FindChild("delsilla")).gameObject;
		delsilla2 = ((Component)serviciokunedo4.transform.FindChild("delsilla2")).gameObject;
		delalfombra = ((Component)serviciokunedo4.transform.FindChild("delalfombra")).gameObject;
		delnightstand = ((Component)serviciokunedo4.transform.FindChild("delnightstand")).gameObject;
		imamesa = ((Component)serviciokunedo4.transform.FindChild("imamesa")).GetComponent<Collider>();
		imamesa2 = ((Component)serviciokunedo4.transform.FindChild("imamesa2")).GetComponent<Collider>();
		imasofa = ((Component)serviciokunedo4.transform.FindChild("imasofa")).GetComponent<Collider>();
		imapouf = ((Component)serviciokunedo4.transform.FindChild("imapouf")).GetComponent<Collider>();
		imasilla = ((Component)serviciokunedo4.transform.FindChild("imasilla")).GetComponent<Collider>();
		imasilla2 = ((Component)serviciokunedo4.transform.FindChild("imasilla2")).GetComponent<Collider>();
		imaalfombra = ((Component)serviciokunedo4.transform.FindChild("imaalfombra")).GetComponent<Collider>();
		imanightstand = ((Component)serviciokunedo4.transform.FindChild("imanightstand")).GetComponent<Collider>();
		imaexit4 = ((Component)serviciokunedo4.transform.FindChild("imaexit")).GetComponent<Collider>();
		imanext4 = ((Component)serviciokunedo4.transform.FindChild("imanext")).GetComponent<Collider>();
		imaexit42 = ((Component)serviciokunedo4.transform.FindChild("imaexit2")).GetComponent<Collider>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		partes = Object.FindObjectOfType<TodoItemBehaviour>();
		general = Object.FindObjectOfType<CasaBehaviour>();
		if (general.telecomprada)
		{
			tele = true;
			cobradotele = true;
		}
		if (general.radiocomprada)
		{
			radio = true;
			cobradoradio = true;
		}
		if (general.piscinacomprada)
		{
			piscina = true;
			cobradopiscina = true;
		}
		if (general.saunacomprada)
		{
			jacuzzi = true;
			cobradosauna = true;
		}
		if (general.barbacoacomprada)
		{
			barbacoa = true;
			cobradobarbacoa = true;
		}
	}

	private void Objetos()
	{
		if (tele)
		{
			deltele.SetActive(true);
		}
		if (!tele)
		{
			deltele.SetActive(false);
			general.telecomprada = false;
		}
		if (radio)
		{
			delradio.SetActive(true);
		}
		if (!radio)
		{
			delradio.SetActive(false);
			general.radiocomprada = false;
		}
		if (piscina)
		{
			delpiscina.SetActive(true);
		}
		if (!piscina)
		{
			delpiscina.SetActive(false);
			general.piscinacomprada = false;
		}
		if (jacuzzi)
		{
			deljacuzzi.SetActive(true);
		}
		if (!jacuzzi)
		{
			deljacuzzi.SetActive(false);
			general.saunacomprada = false;
		}
		if (barbacoa)
		{
			delbarbacoa.SetActive(true);
		}
		if (!barbacoa)
		{
			delbarbacoa.SetActive(false);
			general.barbacoacomprada = false;
		}
		if (muevepartes && !partes.movido)
		{
			delmudanza.SetActive(true);
		}
		if (partes.movido)
		{
			delmudanza.SetActive(true);
		}
		if (!muevepartes && !partes.movido)
		{
			delmudanza.SetActive(false);
		}
	}

	private void Objetos2()
	{
		if (mesa)
		{
			delmesa.SetActive(true);
		}
		if (!mesa)
		{
			delmesa.SetActive(false);
		}
		if (sofa)
		{
			delsofa.SetActive(true);
		}
		if (!sofa)
		{
			delsofa.SetActive(false);
		}
		if (pouf)
		{
			delpouf.SetActive(true);
		}
		if (!pouf)
		{
			delpouf.SetActive(false);
		}
		if (silla)
		{
			delsilla.SetActive(true);
		}
		if (!silla)
		{
			delsilla.SetActive(false);
		}
		if (alfombra)
		{
			delalfombra.SetActive(true);
		}
		if (!alfombra)
		{
			delalfombra.SetActive(false);
		}
		if (mesa2)
		{
			delmesa2.SetActive(true);
		}
		if (!mesa2)
		{
			delmesa2.SetActive(false);
		}
		if (silla2)
		{
			delsilla2.SetActive(true);
		}
		if (!silla2)
		{
			delsilla2.SetActive(false);
		}
		if (nightstand)
		{
			delnightstand.SetActive(true);
		}
		if (!nightstand)
		{
			delnightstand.SetActive(false);
		}
	}

	private void Textos()
	{
		texto7.text = "Price Total = " + total + ".-MK";
		if (cobradotele)
		{
			texto1.text = "TV (Purchased)";
		}
		if (!cobradotele)
		{
			if (tele)
			{
				texto1.text = "TV";
			}
			if (!tele)
			{
				texto1.text = "";
			}
		}
		if (cobradoradio)
		{
			texto2.text = "RADIO (Purchased)";
		}
		if (!cobradoradio)
		{
			if (radio)
			{
				texto2.text = "RADIO";
			}
			if (!radio)
			{
				texto2.text = "";
			}
		}
		if (cobradopiscina)
		{
			texto3.text = "POOL (Purchased)";
		}
		if (!cobradopiscina)
		{
			if (piscina)
			{
				texto3.text = "POOL";
			}
			if (!piscina)
			{
				texto3.text = "";
			}
		}
		if (cobradosauna)
		{
			texto4.text = "JACUZZI (Purchased)";
		}
		if (!cobradosauna)
		{
			if (jacuzzi)
			{
				texto4.text = "JACUZZI";
			}
			if (!jacuzzi)
			{
				texto4.text = "";
			}
		}
		if (cobradobarbacoa)
		{
			texto5.text = "BARBECUE (Purchased)";
		}
		if (!cobradobarbacoa)
		{
			if (barbacoa)
			{
				texto5.text = "BARBECUE";
			}
			if (!barbacoa)
			{
				texto5.text = "";
			}
		}
		if (muevepartes && !partes.movido)
		{
			texto6.text = "TRANSPORT PARTS CAR";
		}
		if (partes.movido)
		{
			texto6.text = "UNAVAILABLE SERVICE";
		}
		if (!muevepartes && !partes.movido)
		{
			texto6.text = "";
		}
	}

	private void Textos2()
	{
		if (mesa)
		{
			texto8.text = "TABLE";
		}
		if (!mesa)
		{
			texto8.text = "";
		}
		if (sofa)
		{
			texto10.text = "COUCH";
		}
		if (!sofa)
		{
			texto10.text = "";
		}
		if (pouf)
		{
			texto11.text = "POUF";
		}
		if (!pouf)
		{
			texto11.text = "";
		}
		if (silla)
		{
			texto12.text = "DESK CHAIR";
		}
		if (!silla)
		{
			texto12.text = "";
		}
		if (alfombra)
		{
			texto13.text = "CARPET";
		}
		if (!alfombra)
		{
			texto13.text = "";
		}
		if (silla2)
		{
			textosilla2.text = "CHAIR";
		}
		if (!silla2)
		{
			textosilla2.text = "";
		}
		if (mesa2)
		{
			textomesa2.text = "TABLE";
		}
		if (!mesa2)
		{
			textomesa2.text = "";
		}
		if (nightstand)
		{
			textonightstand.text = "NIGHTSTAND";
		}
		if (!nightstand)
		{
			textonightstand.text = "";
		}
	}

	private void Rayservicio2(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imatele && !cobradotele)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= total + preciotele)
			{
				tele = !tele;
				if (tele)
				{
					total += preciotele;
				}
				if (!tele)
				{
					total -= preciotele;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaradio && !cobradoradio)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= total + precioradio)
			{
				radio = !radio;
				if (radio)
				{
					total += precioradio;
				}
				if (!radio)
				{
					total -= precioradio;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imapiscina && !cobradopiscina)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= total + preciopiscina)
			{
				piscina = !piscina;
				if (piscina)
				{
					total += preciopiscina;
				}
				if (!piscina)
				{
					total -= preciopiscina;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imajacuzzi && !cobradosauna)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= total + preciojacuzzi)
			{
				jacuzzi = !jacuzzi;
				if (jacuzzi)
				{
					total += preciojacuzzi;
				}
				if (!jacuzzi)
				{
					total -= preciojacuzzi;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imabarbacoa && !cobradobarbacoa)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= total + preciobarbacoa)
			{
				barbacoa = !barbacoa;
				if (barbacoa)
				{
					total += preciobarbacoa;
				}
				if (!barbacoa)
				{
					total -= preciobarbacoa;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imamudanza && !partes.movido)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0) && FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= total + preciomudanza)
			{
				muevepartes = !muevepartes;
				if (muevepartes)
				{
					total += preciomudanza;
				}
				if (!muevepartes)
				{
					total -= preciomudanza;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				Purchase();
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit2)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				total = 0f;
				muevepartes = false;
				((Component)partes).GetComponent<CasaBehaviour>()._playerInMenu.Value = false;
				FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
				((Component)partes).GetComponent<CasaBehaviour>().mirandopapel = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imanext)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				serviciokunedo2.SetActive(false);
				serviciokunedo4.SetActive(true);
			}
		}
	}

	private void Rayservicio4(RaycastHit hit)
	{
		if ((Object)(object)hit.collider == (Object)(object)imamesa)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				mesa = !mesa;
				if (mesa)
				{
					total += preciomesa;
				}
				if (!mesa)
				{
					total -= preciomesa;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imamesa2)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				mesa2 = !mesa2;
				if (mesa2)
				{
					total += preciomesa2;
				}
				if (!mesa2)
				{
					total -= preciomesa2;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imasofa)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				sofa = !sofa;
				if (sofa)
				{
					total += preciosofa;
				}
				if (!sofa)
				{
					total -= preciosofa;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imapouf)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				pouf = !pouf;
				if (pouf)
				{
					total += preciopouf;
				}
				if (!pouf)
				{
					total -= preciopouf;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imasilla)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				silla = !silla;
				if (silla)
				{
					total += preciosilla;
				}
				if (!silla)
				{
					total -= preciosilla;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imasilla2)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				silla2 = !silla2;
				if (silla2)
				{
					total += preciosilla2;
				}
				if (!silla2)
				{
					total -= preciosilla2;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaalfombra)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				alfombra = !alfombra;
				if (alfombra)
				{
					total += precioalfombra;
				}
				if (!alfombra)
				{
					total -= precioalfombra;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imanightstand)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				nightstand = !nightstand;
				if (nightstand)
				{
					total += precionightstand;
				}
				if (!nightstand)
				{
					total -= precionightstand;
				}
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit4)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				Purchase();
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imaexit42)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				total = 0f;
				muevepartes = false;
				((Component)partes).GetComponent<CasaBehaviour>()._playerInMenu.Value = false;
				FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
				((Component)partes).GetComponent<CasaBehaviour>().mirandopapel = false;
			}
		}
		if ((Object)(object)hit.collider == (Object)(object)imanext4)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				serviciokunedo2.SetActive(true);
				serviciokunedo4.SetActive(false);
			}
		}
	}

	private void Purchase()
	{
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Object.FindObjectOfType<PedidoBehaviour>() != (Object)null)
		{
			Object.Destroy((Object)(object)((Component)Object.FindObjectOfType<PedidoBehaviour>()).gameObject);
		}
		if ((Object)(object)Object.FindObjectOfType<PedidoBehaviour>() == (Object)null)
		{
			if (mesa)
			{
				total2 += preciomesa;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaMesa();
				mesa = false;
			}
			if (mesa2)
			{
				total2 += preciomesa2;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaMesa2();
				mesa2 = false;
			}
			if (sofa)
			{
				total2 += preciosofa;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaSofa();
				sofa = false;
			}
			if (pouf)
			{
				total2 += preciopouf;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaPouf();
				pouf = false;
			}
			if (silla)
			{
				total2 += preciosilla;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaSilla();
				silla = false;
			}
			if (silla2)
			{
				total2 += preciosilla2;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaSilla2();
				silla2 = false;
			}
			if (alfombra)
			{
				total2 += precioalfombra;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaAlfombra();
				alfombra = false;
			}
			if (nightstand)
			{
				total2 += precionightstand;
				((Component)partes).GetComponent<CompraObjetosBehaviour>().PedidoCajaNightStand();
				nightstand = false;
			}
		}
		if (tele)
		{
			general.telecomprada = true;
			if (!cobradotele)
			{
				FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
				val.Value -= preciotele;
			}
			cobradotele = true;
		}
		if (radio)
		{
			general.radiocomprada = true;
			if (!cobradoradio)
			{
				FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
				val2.Value -= precioradio;
			}
			cobradoradio = true;
		}
		if (piscina)
		{
			general.piscinacomprada = true;
			if (!cobradopiscina)
			{
				FsmFloat val3 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
				val3.Value -= preciopiscina;
			}
			cobradopiscina = true;
		}
		if (jacuzzi)
		{
			general.saunacomprada = true;
			if (!cobradosauna)
			{
				FsmFloat val4 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
				val4.Value -= preciojacuzzi;
			}
			cobradosauna = true;
		}
		if (barbacoa)
		{
			general.barbacoacomprada = true;
			if (!cobradobarbacoa)
			{
				FsmFloat val5 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
				val5.Value -= preciobarbacoa;
			}
			cobradobarbacoa = true;
		}
		if (muevepartes)
		{
			FsmFloat val6 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
			val6.Value -= preciomudanza;
			partes.Muevepartes();
		}
		total = 0f;
		if (total2 != 0f && (Object)(object)Object.FindObjectOfType<PedidoBehaviour>() == (Object)null)
		{
			((Component)partes).GetComponent<CompraObjetosBehaviour>().SacarPedido(((Component)this).transform.position, total2);
		}
		total2 = 0f;
		muevepartes = false;
		((Component)partes).GetComponent<CasaBehaviour>()._playerInMenu.Value = false;
		FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = false;
		((Component)partes).GetComponent<CasaBehaviour>().mirandopapel = false;
	}

	private void Update()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameObject.Find("PLAYER") != (Object)null)
		{
			Objetos();
			Objetos2();
			Textos();
			Textos2();
			if (cobradotele)
			{
				tele = true;
			}
			if (cobradoradio)
			{
				radio = true;
			}
			if (cobradopiscina)
			{
				piscina = true;
			}
			if (cobradosauna)
			{
				jacuzzi = true;
			}
			if (cobradobarbacoa)
			{
				barbacoa = true;
			}
			if (Vector3.Distance(((Component)GameObject.Find("PLAYER")).transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
			foreach (RaycastHit hit in array)
			{
				Rayservicio2(hit);
				Rayservicio4(hit);
			}
		}
		}
	}
}
