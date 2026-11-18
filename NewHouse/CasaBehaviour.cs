using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class CasaBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public bool enchufetelf;

		public bool teleon;

		public bool vendido;

		public bool telecomprada;

		public bool radiocomprada;

		public bool saunacomprado;

		public bool piscinacomprado;

		public bool barbacoacomprado;

		public int intensidad;

		public bool pagado;

		public bool cortinablanca;

		public bool cortinaverde;

		public bool cortinaazul;

		public bool cortinarara;

		public bool cortinablanca2;

		public bool cortinaverde2;

		public bool cortinaazul2;

		public bool cortinarara2;

		public bool cortinablancalav;

		public bool cortinaverdelav;

		public bool cortinaazullav;

		public bool cortinararalav;

		public bool cortinablancacoc;

		public bool cortinaverdecoc;

		public bool cortinaazulcoc;

		public bool cortinararacoc;

		public bool cortinablancatel;

		public bool cortinaverdetel;

		public bool cortinaazultel;

		public bool cortinararatel;

		public bool cortinablancahab1;

		public bool cortinaverdehab1;

		public bool cortinaazulhab1;

		public bool cortinararahab1;

		public bool cortinablancahab2;

		public bool cortinaverdehab2;

		public bool cortinaazulhab2;

		public bool cortinararahab2;
	}

	private FsmBool m_guiUseBool;

	private PlayMakerFSM sunFsm;

	private float nextHouseMaintenance;

	private GameObject cajatonta;

	private bool drinkRunning;

	private bool drink2Running;

	private GameObject botonteleluz;

	private GameObject botontele;

	private GameObject botonteleon;

	private GameObject botonteleoff;

	private GameObject pantalla;

	private GameObject pantallaon;

	private GameObject pantallaoff;

	private GameObject pantallacarta;

	private Texture peliculaoff;

	private Texture peliculacarta;

	private MovieTexture peliculadia;

	private AudioSource pelitop;

	private AudioSource marjatta;

	private GameObject cama;

	private GameObject camaorig;

	private GameObject camainst;

	private GameObject camsleep;

	public bool teleencendida;

	public GameObject Player;

	private GameObject Coliderkeo;

	private GameObject Coliderkeo2;

	private GameObject Coliderkeo3;

	private GameObject Coliderkeo4;

	private GameObject cartel;

	private GameObject poster;

	public bool vendido;

	private float precio = 75000f;

	private FsmString m_guiInteractString;

	private GameObject triggerpiscina;

	private GameObject nevera;

	private GameObject pivotnevera;

	private Transform puertaneveraabierta;

	private Transform puertaneveracerrada;

	public bool neveraabierta;

	private GameObject correo;

	private GameObject correoorig;

	private GameObject correo2;

	private GameObject congelador;

	private GameObject pivotcongelador;

	private Transform puertacongeladorabierta;

	private Transform puertacongeladorcerrada;

	private bool congeladorabierta;

	private AudioSource neveraopen;

	private AudioSource neveraclose;

	private GameObject relojpared;

	private Collider posguardar;

	public bool playerspawn;

	private GameObject ducha;

	private GameObject grifococina2;

	private GameObject grifococina3;

	private GameObject grifosauna;

	private GameObject puertas;

	private GameObject luces;

	private GameObject chimenea;

	private GameObject chimeneaclone;

	private GameObject troncos;

	private GameObject troncosclone;

	public bool pagado;

	private TextMesh lecturanewhouse;

	private float speeddisc = 1f;

	private Transform axedisc;

	public float consumidodisc;

	private GameObject boton;

	private Transform botona;

	private Transform botonb;

	private AudioSource audi2;

	private bool activado;

	private Renderer estado;

	public int intensidad = 1;

	public bool storeradio;

	public bool storetele;

	private GameObject satsuma;

	private GameObject posisatsu;

	public FsmBool _playerInMenu;

	public bool showGUI;

	private readonly Rect _guiBox = new Rect((float)(Screen.width / 2 - 190), (float)(Screen.height / 2 - 200), 280f, 290f);

	public bool muevepiezas;

	public bool muevesatsu;

	public bool muevejonn;

	public bool confirmado;

	public bool confirmado2;

	public bool confirmado3;

	public bool checkeao;

	public bool checkeao2;

	public bool checkeao3;

	public bool nomoney;

	public float precioañadido;

	public float preciototal;

	private GameObject jonn;

	private TodoItemBehaviour partes;

	private GameObject papelillo;

	private GameObject papelillovisual;

	private GameObject papelillovisual2;

	private GameObject saunamadera;

	public bool radiocomprada;

	public bool telecomprada;

	public bool saunacomprada;

	public bool piscinacomprada;

	public bool barbacoacomprada;

	public bool mirandopapel;

	public bool mirandopapel2;

	private GameObject piscina;

	private GameObject radiopepino;

	private GameObject bistecc;

	private GameObject pelota;

	private GameObject pelotaclone;

	public bool moroso;

	public bool checkmoroso;

	public int semanassinpagar;

	private GameObject cortinablanca;

	private GameObject cortinaverde;

	private GameObject cortinaazul;

	private GameObject cortinarara;

	private GameObject cortinablanca2;

	private GameObject cortinaverde2;

	private GameObject cortinaazul2;

	private GameObject cortinarara2;

	private GameObject cortinablanca3;

	private GameObject cortinaverde3;

	private GameObject cortinaazul3;

	private GameObject cortinarara3;

	private GameObject cortinablanca4;

	private GameObject cortinaverde4;

	private GameObject cortinaazul4;

	private GameObject cortinarara4;

	private GameObject cortinablancalav;

	private GameObject cortinaverdelav;

	private GameObject cortinaazullav;

	private GameObject cortinararalav;

	private GameObject cortinablancalav2;

	private GameObject cortinaverdelav2;

	private GameObject cortinaazullav2;

	private GameObject cortinararalav2;

	private GameObject cortinablancacoc;

	private GameObject cortinaverdecoc;

	private GameObject cortinaazulcoc;

	private GameObject cortinararacoc;

	private GameObject cortinablancacoc2;

	private GameObject cortinaverdecoc2;

	private GameObject cortinaazulcoc2;

	private GameObject cortinararacoc2;

	private GameObject cortinablancacoc3;

	private GameObject cortinaverdecoc3;

	private GameObject cortinaazulcoc3;

	private GameObject cortinararacoc3;

	private GameObject cortinablancacoc4;

	private GameObject cortinaverdecoc4;

	private GameObject cortinaazulcoc4;

	private GameObject cortinararacoc4;

	private GameObject cortinablancatel;

	private GameObject cortinaverdetel;

	private GameObject cortinaazultel;

	private GameObject cortinararatel;

	private GameObject cortinablancahab1;

	private GameObject cortinaverdehab1;

	private GameObject cortinaazulhab1;

	private GameObject cortinararahab1;

	private GameObject cortinablancahab2;

	private GameObject cortinaverdehab2;

	private GameObject cortinaazulhab2;

	private GameObject cortinararahab2;

	public GameObject posirevista;

	public bool modoedicion;

	public bool modoedicionblanco;

	public bool modoedicionverde;

	public bool modoedicionazul;

	public bool modoedicionraro;

	public bool modoedicionblanco3;

	public bool modoedicionverde3;

	public bool modoedicionazul3;

	public bool modoedicionraro3;

	private GameObject guard;

	private GameObject guarda;

	private GameObject store;

	private GameObject storelod;

	private GameObject cojin;

	private Texture guiedi;

	private ElectricidadBehaviour electricidad;

	private void Start()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected Obj, but got Unknown
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_1360: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Unknown result type (might be due to invalid IL or missing references)
		//IL_149b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = new Vector3(-1736f, 6.79f, -175f);
		((Component)this).transform.eulerAngles = new Vector3(0f, 267f, 0f);
		((Component)((Component)this).transform.FindChild("estructura/Cube 18")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("estructura/Cube 18")).gameObject.tag = "Concrete";
		((Component)((Component)this).transform.FindChild("estructura/Cube 19")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("estructura/Cube 19")).gameObject.tag = "Concrete";
		((Component)((Component)this).transform.FindChild("estructura/Cube 21")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("estructura/Cube 21")).gameObject.tag = "Concrete";
		((Component)((Component)this).transform.FindChild("estructura/Cube 22")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("estructura/Cube 22")).gameObject.tag = "Concrete";
		((Component)((Component)this).transform.FindChild("estructura/Cube 24")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("estructura/Cube 24")).gameObject.tag = "Concrete";
		((Component)((Component)this).transform.FindChild("estructura/Cube 25")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("estructura/Cube 25")).gameObject.tag = "Concrete";
		((Component)((Component)this).transform.FindChild("utiles/parkingcamion/interiors/_Interior/parkingcamion_Interior:suelo")).gameObject.layer = LayerMask.NameToLayer("Terrain");
		((Component)((Component)this).transform.FindChild("utiles/parkingcamion/interiors/_Interior/parkingcamion_Interior:suelo")).gameObject.tag = "Concrete";
		cortinablanca = ((Component)((Component)this).transform.FindChild("salon/setcortina1/cortinablanca")).gameObject;
		cortinaverde = ((Component)((Component)this).transform.FindChild("salon/setcortina1/cortinaverde")).gameObject;
		cortinaazul = ((Component)((Component)this).transform.FindChild("salon/setcortina1/cortinaazul")).gameObject;
		cortinarara = ((Component)((Component)this).transform.FindChild("salon/setcortina1/cortinarara")).gameObject;
		cortinablanca2 = ((Component)((Component)this).transform.FindChild("salon/setcortina2/cortinablanca")).gameObject;
		cortinaverde2 = ((Component)((Component)this).transform.FindChild("salon/setcortina2/cortinaverde")).gameObject;
		cortinaazul2 = ((Component)((Component)this).transform.FindChild("salon/setcortina2/cortinaazul")).gameObject;
		cortinarara2 = ((Component)((Component)this).transform.FindChild("salon/setcortina2/cortinarara")).gameObject;
		cortinablanca3 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas1/cortinablanca")).gameObject;
		cortinaverde3 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas1/cortinaverde")).gameObject;
		cortinaazul3 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas1/cortinaazul")).gameObject;
		cortinarara3 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas1/cortinarara")).gameObject;
		cortinablanca4 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas2/cortinablanca")).gameObject;
		cortinaverde4 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas2/cortinaverde")).gameObject;
		cortinaazul4 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas2/cortinaazul")).gameObject;
		cortinarara4 = ((Component)((Component)this).transform.FindChild("salonradio/setcortinas2/cortinarara")).gameObject;
		cortinablancalav = ((Component)((Component)this).transform.FindChild("lavabo/setcortina1/cortinablanca")).gameObject;
		cortinaverdelav = ((Component)((Component)this).transform.FindChild("lavabo/setcortina1/cortinaverde")).gameObject;
		cortinaazullav = ((Component)((Component)this).transform.FindChild("lavabo/setcortina1/cortinaazul")).gameObject;
		cortinararalav = ((Component)((Component)this).transform.FindChild("lavabo/setcortina1/cortinarara")).gameObject;
		cortinablancalav2 = ((Component)((Component)this).transform.FindChild("lavabo/setcortina2/cortinablanca")).gameObject;
		cortinaverdelav2 = ((Component)((Component)this).transform.FindChild("lavabo/setcortina2/cortinaverde")).gameObject;
		cortinaazullav2 = ((Component)((Component)this).transform.FindChild("lavabo/setcortina2/cortinaazul")).gameObject;
		cortinararalav2 = ((Component)((Component)this).transform.FindChild("lavabo/setcortina2/cortinarara")).gameObject;
		cortinablancacoc = ((Component)((Component)this).transform.FindChild("cocina/setcortina1/cortinablanca")).gameObject;
		cortinaverdecoc = ((Component)((Component)this).transform.FindChild("cocina/setcortina1/cortinaverde")).gameObject;
		cortinaazulcoc = ((Component)((Component)this).transform.FindChild("cocina/setcortina1/cortinaazul")).gameObject;
		cortinararacoc = ((Component)((Component)this).transform.FindChild("cocina/setcortina1/cortinarara")).gameObject;
		cortinablancacoc2 = ((Component)((Component)this).transform.FindChild("cocina/setcortina2/cortinablanca")).gameObject;
		cortinaverdecoc2 = ((Component)((Component)this).transform.FindChild("cocina/setcortina2/cortinaverde")).gameObject;
		cortinaazulcoc2 = ((Component)((Component)this).transform.FindChild("cocina/setcortina2/cortinaazul")).gameObject;
		cortinararacoc2 = ((Component)((Component)this).transform.FindChild("cocina/setcortina2/cortinarara")).gameObject;
		cortinablancacoc3 = ((Component)((Component)this).transform.FindChild("cocina/setcortina3/cortinablanca")).gameObject;
		cortinaverdecoc3 = ((Component)((Component)this).transform.FindChild("cocina/setcortina3/cortinaverde")).gameObject;
		cortinaazulcoc3 = ((Component)((Component)this).transform.FindChild("cocina/setcortina3/cortinaazul")).gameObject;
		cortinararacoc3 = ((Component)((Component)this).transform.FindChild("cocina/setcortina3/cortinarara")).gameObject;
		cortinablancacoc4 = ((Component)((Component)this).transform.FindChild("cocina/setcortina4/cortinablanca")).gameObject;
		cortinaverdecoc4 = ((Component)((Component)this).transform.FindChild("cocina/setcortina4/cortinaverde")).gameObject;
		cortinaazulcoc4 = ((Component)((Component)this).transform.FindChild("cocina/setcortina4/cortinaazul")).gameObject;
		cortinararacoc4 = ((Component)((Component)this).transform.FindChild("cocina/setcortina4/cortinarara")).gameObject;
		cortinablancatel = ((Component)((Component)this).transform.FindChild("salatelefono/setcortina1/cortinablanca")).gameObject;
		cortinaverdetel = ((Component)((Component)this).transform.FindChild("salatelefono/setcortina1/cortinaverde")).gameObject;
		cortinaazultel = ((Component)((Component)this).transform.FindChild("salatelefono/setcortina1/cortinaazul")).gameObject;
		cortinararatel = ((Component)((Component)this).transform.FindChild("salatelefono/setcortina1/cortinarara")).gameObject;
		cortinablancahab1 = ((Component)((Component)this).transform.FindChild("habitacion1/setcortina1/cortinablanca")).gameObject;
		cortinaverdehab1 = ((Component)((Component)this).transform.FindChild("habitacion1/setcortina1/cortinaverde")).gameObject;
		cortinaazulhab1 = ((Component)((Component)this).transform.FindChild("habitacion1/setcortina1/cortinaazul")).gameObject;
		cortinararahab1 = ((Component)((Component)this).transform.FindChild("habitacion1/setcortina1/cortinarara")).gameObject;
		cortinablancahab2 = ((Component)((Component)this).transform.FindChild("habitacion2/setcortina1/cortinablanca")).gameObject;
		cortinaverdehab2 = ((Component)((Component)this).transform.FindChild("habitacion2/setcortina1/cortinaverde")).gameObject;
		cortinaazulhab2 = ((Component)((Component)this).transform.FindChild("habitacion2/setcortina1/cortinaazul")).gameObject;
		cortinararahab2 = ((Component)((Component)this).transform.FindChild("habitacion2/setcortina1/cortinararo")).gameObject;
		Coliderkeo = ((Component)((Component)this).transform.FindChild("utiles/lluviacasa")).gameObject;
		Coliderkeo.layer = LayerMask.NameToLayer("NoRain");
		Coliderkeo2 = ((Component)((Component)this).transform.FindChild("utiles/lluviacasa2")).gameObject;
		Coliderkeo2.layer = LayerMask.NameToLayer("NoRain");
		Coliderkeo3 = ((Component)((Component)this).transform.FindChild("utiles/lluviacasa3")).gameObject;
		Coliderkeo3.layer = LayerMask.NameToLayer("NoRain");
		Coliderkeo4 = ((Component)((Component)this).transform.FindChild("utiles/lluviacasa4")).gameObject;
		Coliderkeo4.layer = LayerMask.NameToLayer("NoRain");
		poster = ((Component)((Component)this).transform.FindChild("utiles/poster")).gameObject;
		cartel = ((Component)poster.transform.FindChild("cartel")).gameObject;
		m_guiInteractString = PlayMakerGlobals.Instance.Variables.FindFsmString("GUIinteraction");
		pivotnevera = ((Component)((Component)this).transform.FindChild("utiles/neverilla/pivotpuertanevera")).gameObject;
		nevera = ((Component)pivotnevera.transform.FindChild("puertanevera")).gameObject;
		puertaneveracerrada = ((Component)((Component)this).transform.FindChild("utiles/neverilla/pivotpuertaneveracerrada")).transform;
		puertaneveraabierta = ((Component)((Component)this).transform.FindChild("utiles/neverilla/pivotpuertaneveraabierta")).transform;
		pivotcongelador = ((Component)((Component)this).transform.FindChild("utiles/neverilla/pivotpuertacongelador")).gameObject;
		congelador = ((Component)pivotcongelador.transform.FindChild("puertacongelador")).gameObject;
		puertacongeladorcerrada = ((Component)((Component)this).transform.FindChild("utiles/neverilla/pivotpuertacongeladorcerrada")).transform;
		puertacongeladorabierta = ((Component)((Component)this).transform.FindChild("utiles/neverilla/pivotpuertacongeladorabierta")).transform;
		neveraopen = nevera.GetComponent<AudioSource>();
		neveraclose = congelador.GetComponent<AudioSource>();
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		lecturanewhouse = ((Component)((Component)this).transform.FindChild("Contadorluznewhouse/Lecturanewhouse")).GetComponent<TextMesh>();
		axedisc = ((Component)((Component)this).transform.FindChild("Contadorluznewhouse/kwh_meternuevo/pivotdiscnewhouse")).transform;
		audi2 = ((Component)((Component)this).transform.FindChild("Contadorluznewhouse/Ejebotonnewhouse")).GetComponent<AudioSource>();
		boton = ((Component)((Component)audi2).transform.FindChild("Botonnewhouse")).gameObject;
		botona = ((Component)((Component)this).transform.FindChild("Contadorluznewhouse/posicionarribanewhouse")).transform;
		botonb = ((Component)((Component)this).transform.FindChild("Contadorluznewhouse/posicionabajonewhouse")).transform;
		estado = ((Component)((Component)this).transform.FindChild("Contadorluznewhouse/luzestadonewhouse")).gameObject.GetComponent<Renderer>();
		cojin = ((Component)((Component)this).transform.FindChild("cojin")).gameObject;
		((Object)cojin).name = "Cushion";
		cojin.layer = LayerMask.NameToLayer("Parts");
		cojin.tag = "ITEM";
		_playerInMenu = PlayMakerGlobals.Instance.Variables.GetFsmBool("PlayerInMenu");
		guiedi = Object.Instantiate<Texture>(ModBehaviour.m_bundle.LoadAsset<Texture>("edit"));
		posguardar = ((Component)((Component)this).transform.FindChild("utiles/Toilet/guardarpartidapos")).GetComponent<Collider>();
		saunamadera = ((Component)((Component)this).transform.FindChild("utiles/saunamadera")).gameObject;
		cajatonta = ((Component)((Component)this).transform.FindChild("utiles/television")).gameObject;
		botonteleluz = ((Component)cajatonta.transform.FindChild("modelotele/teleluz")).gameObject;
		botonteleluz.GetComponent<Renderer>().material.color = Color.red;
		botontele = ((Component)cajatonta.transform.FindChild("botontele")).gameObject;
		marjatta = botontele.GetComponent<AudioSource>();
		botonteleon = ((Component)cajatonta.transform.FindChild("botonteleon")).gameObject;
		botonteleoff = ((Component)cajatonta.transform.FindChild("botonteleoff")).gameObject;
		pantalla = ((Component)cajatonta.transform.FindChild("modelotele/pantalla")).gameObject;
		pantalla.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
		pelitop = pantalla.GetComponent<AudioSource>();
		pantallaoff = ((Component)cajatonta.transform.FindChild("modelotele/pantallaoff")).gameObject;
		pantallacarta = ((Component)cajatonta.transform.FindChild("modelotele/pantallacarta")).gameObject;
		pantallaon = ((Component)cajatonta.transform.FindChild("modelotele/pantallaon")).gameObject;
		peliculadia = (MovieTexture)pantallaon.GetComponent<Renderer>().material.mainTexture;
		peliculaoff = pantallaoff.GetComponent<Renderer>().material.mainTexture;
		peliculacarta = pantallacarta.GetComponent<Renderer>().material.mainTexture;
		pantallaoff.SetActive(false);
		pantallaon.SetActive(false);
		pantallacarta.SetActive(false);
		pantalla.GetComponent<Renderer>().material.mainTexture = pantallaoff.GetComponent<Renderer>().material.mainTexture;
		piscina = ((Component)((Component)this).transform.FindChild("utiles/piscina")).gameObject;
		triggerpiscina = ((Component)piscina.transform.FindChild("triggerpiscina")).gameObject;
		TriggerCallback triggerCallback = triggerpiscina.AddComponent<TriggerCallback>();
		triggerCallback.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerStay, new Action<Collider>(OnBagTriggerStay2));
		((Component)this).gameObject.AddComponent<CompraObjetosBehaviour>();
		ducha = ((Component)((Component)this).transform.FindChild("utiles/sitio ducha/ducha")).gameObject;
		ducha.AddComponent<DuchaBehaviour>();
		ducha.SetActive(false);
		GameObject val = Object.Instantiate<GameObject>(GameObject.Find("YARD/Building/BATHROOM").gameObject);
		((Component)val.transform.FindChild("DoorBathroom")).gameObject.SetActive(false);
		val.transform.position = new Vector3(-1720.32f, 7.9204f, -185.7f);
		val.transform.eulerAngles = new Vector3(270f, 220f, 0f);
		if (GameObject.Find("YARD/Building/KITCHEN/KitchenWaterTap") != null)
		{
			grifococina2 = GameObject.Find("YARD/Building/KITCHEN/KitchenWaterTap").gameObject;
			grifococina3 = Object.Instantiate<GameObject>(grifococina2);
			grifococina3.transform.position = new Vector3(-1744.006f, 10.76f, -159.856f);
			grifococina3.transform.eulerAngles = new Vector3(270f, 120f, 0f);
		}
		else
		{
			ModConsole.Error("No found Kitchenwatertap");
			grifococina2 = null;
			grifococina3 = null;
		}
		grifosauna = ((Component)((Component)this).transform.FindChild("utiles/saunamadera")).gameObject;
		grifosauna.AddComponent<GrifoSaunaBehaviour>();
		puertas = ((Component)((Component)this).transform.FindChild("utiles/puertas")).gameObject;
		puertas.AddComponent<PuertaBehaviour>();
		luces = ((Component)((Component)this).transform.FindChild("utiles/luces")).gameObject;
		luces.AddComponent<LucesBehaviour>();
		electricidad = ((Component)this).gameObject.AddComponent<ElectricidadBehaviour>();
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("mandopuerta")).AddComponent<MandoBehaviour>()).transform.SetParent(((Component)this).transform);
		((Component)this).gameObject.AddComponent<CosasGarageBehaviour>();
		((Component)this).gameObject.AddComponent<TexturasBehaviour>();
		radiopepino = ((Component)((Component)this).transform.FindChild("utiles/radiopepino")).gameObject;
		radiopepino.AddComponent<RadiooBehaviour>();
		bistecc = ((Component)((Component)this).transform.FindChild("utiles/barbacoa")).gameObject;
		bistecc.AddComponent<BistecBehaviour>();
		((Component)this).gameObject.AddComponent<VendedorBistecBehaviour>();
		partes = ((Component)this).gameObject.AddComponent<TodoItemBehaviour>();
		if (GameObject.Find("MAP/MESH/FOLIAGE/BUSHES6") != null)
		{
			GameObject.Find("MAP/MESH/FOLIAGE/BUSHES6").gameObject.SetActive(false);
		}
		if (GameObject.Find("YARD/Building/Dynamics/SuomiClock/Clock") != null)
		{
			GameObject gameObject = GameObject.Find("YARD/Building/Dynamics/SuomiClock/Clock").gameObject;
			GameObject gameObject2 = ((Component)((Component)this).transform.FindChild("utiles/posireloj")).gameObject;
			relojpared = Object.Instantiate<GameObject>(gameObject);
			relojpared.transform.SetParent(gameObject2.transform);
			relojpared.transform.localPosition = new Vector3(0f, 0f, -0.01069f);
			relojpared.transform.localRotation = Quaternion.Euler(0f, 270f, 90f);
			relojpared.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
		}
		else
		{
			ModConsole.Error("No found Clock");
			relojpared = null;
		}
		chimenea = ((Component)((Component)this).transform.FindChild("utiles/sitiochimenea")).gameObject;
		GameObject gameObject3 = GameObject.Find("COTTAGE/Fireplace").gameObject;
		chimeneaclone = Object.Instantiate<GameObject>(gameObject3);
		chimeneaclone.transform.SetParent(chimenea.transform);
		chimeneaclone.transform.localPosition = new Vector3(0f, -0.25f, -0.182f);
		chimeneaclone.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		troncos = ((Component)((Component)this).transform.FindChild("utiles/sitiotroncos")).gameObject;
		GameObject gameObject4 = GameObject.Find("COTTAGE/Logging").gameObject;
		troncosclone = Object.Instantiate<GameObject>(gameObject4);
		troncosclone.transform.SetParent(troncos.transform);
		troncosclone.transform.localPosition = new Vector3(0f, 0f, 0f);
		troncosclone.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		Transform val2 = troncos.transform.FindChild("sitiopila");
		Transform val3 = troncosclone.transform.FindChild("Logwall");
		((Component)val3).transform.SetParent(((Component)val2).transform);
		((Component)val3).transform.localPosition = new Vector3(0f, 0f, 0f);
		((Component)val3).transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		Transform val4 = troncos.transform.FindChild("sitiovirgen");
		Transform val5 = troncosclone.transform.FindChild("Pölkky");
		((Component)val5).transform.SetParent(((Component)val4).transform);
		((Component)val5).transform.localPosition = new Vector3(0f, 0.55f, 0f);
		((Component)val5).transform.localRotation = Quaternion.Euler(270f, 0f, 0f);
		GameObject val6 = Object.Instantiate<GameObject>(GameObject.Find("ax(itemx)").gameObject);
		((Object)val6).name = "ax(itemx)";
		val6.layer = LayerMask.NameToLayer("Parts");
		val6.tag = "ITEM";
		val6.transform.SetParent(troncos.transform);
		val6.transform.localPosition = new Vector3(0f, 0f, 0f);
		val6.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		pelota = GameObject.Find("ITEMS/basketball(Clone)").gameObject;
		pelotaclone = Object.Instantiate<GameObject>(pelota);
		((Object)pelotaclone).name = "BasketBall(Clone)";
		posirevista = GameObject.Find("sitiorevista").gameObject;
		pelotaclone.transform.SetParent(posirevista.transform);
		pelotaclone.transform.localPosition = new Vector3(0f, 0.2f, 0f);
		pelotaclone.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		if (GameObject.Find("YARD/PlayerMailBox") != null)
		{
			GameObject gameObject5 = GameObject.Find("YARD/PlayerMailBox").gameObject;
			correo = Object.Instantiate<GameObject>(gameObject5);
			correo.transform.SetParent(((Component)this).transform);
			correo.transform.localPosition = new Vector3(3.79f, 0.8f, -20.722f);
			correoorig = ((Component)correo.transform.FindChild("EnvelopeElectricityBill")).gameObject;
			Object.Destroy((Object)(object)((Component)correo.transform.FindChild("EnvelopePhoneBill")).gameObject);
			Object.Destroy((Object)(object)((Component)correo.transform.FindChild("AdComputer")).gameObject);
			Object.Destroy((Object)(object)((Component)correo.transform.FindChild("LetterProcyon")).gameObject);
			Object.Destroy((Object)(object)((Component)correo.transform.FindChild("EnvelopeCrimeEnvironment")).gameObject);
			correo2 = Object.Instantiate<GameObject>(((Component)correo.transform.FindChild("EnvelopeElectricityBill")).gameObject);
			correo2.AddComponent<CartaBehaviour>();
			Object.Destroy((Object)(object)correo2.GetComponent<PlayMakerFSM>());
			correo2.transform.SetParent(correo.transform);
			correo2.transform.localPosition = correoorig.transform.localPosition;
			correo2.transform.localRotation = correoorig.transform.localRotation;
			correo2.gameObject.SetActive(false);
			Object.Destroy((Object)(object)correoorig.gameObject);
		}
		else
		{
			ModConsole.Error("No found mailbox");
			correo = null;
			correoorig = null;
			correo2 = null;
		}
		((MonoBehaviour)this).StartCoroutine(SetupMod());
	}

	private IEnumerator SetupMod()
	{
		while ((Object)(object)GameObject.Find("PLAYER") == (Object)null)
		{
			yield return null;
		}
		((Component)this).gameObject.AddComponent<TelefonoBehaviour>();
		papelillo = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("ServicioKunedo")).gameObject;
		papelillo.transform.parent = null;
		papelillo.transform.position = new Vector3(-1730.1102f, 7.7022f, -176.7189f);
		papelillo.transform.eulerAngles = new Vector3(0f, 87f, 0f);
		papelillovisual = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("ServicioKunedo2")).gameObject;
		papelillovisual.transform.SetParent(((Component)Camera.main).transform);
		papelillovisual.transform.localPosition = new Vector3(0f, 0f, 0.5f);
		papelillovisual.transform.localEulerAngles = new Vector3(90f, 180f, 0f);
		papelillovisual.AddComponent<PapelilloBehaviour>();
		papelillovisual.SetActive(false);
		papelillovisual2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("ServicioKunedo4")).gameObject;
		papelillovisual2.transform.SetParent(((Component)Camera.main).transform);
		papelillovisual2.transform.localPosition = new Vector3(0f, 0f, 0.5f);
		papelillovisual2.transform.localEulerAngles = new Vector3(90f, 180f, 0f);
		papelillovisual2.AddComponent<Papelillo2Behaviour>();
		papelillovisual2.SetActive(false);
		cama = ((Component)((Component)this).transform.FindChild("utiles/cama")).gameObject;
		camaorig = GameObject.Find("CARPARTS/PartsCar/seat rear(Clone)/Sleep").gameObject;
		camainst = Object.Instantiate<GameObject>(camaorig);
		camainst.transform.SetParent(cama.transform);
		camainst.transform.localPosition = new Vector3(0.2f, 0f, 0.7f);
		camainst.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		camsleep = ((Component)camainst.transform.FindChild("SleepTrigger")).gameObject;
		camsleep.transform.localPosition = new Vector3(0f, 0f, 0f);
		camsleep.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		camsleep.transform.localScale = new Vector3(3f, 3f, 3f);
		Player = GameObject.Find("PLAYER").gameObject;
		sunFsm = GameObject.Find("MAP/SUN/Pivot/SUN").GetComponent<PlayMakerFSM>();
		store = GameObject.Find("STORE").gameObject;
		storelod = ((Component)store.transform.FindChild("LOD")).gameObject;
		storelod.SetActive(true);
		guard = ((Component)storelod.transform.FindChild("SHITHOUSE/SavePivot/SAVEGAME")).gameObject;
		guarda = Object.Instantiate<GameObject>(guard);
		guarda.transform.SetParent(((Component)posguardar).transform);
		guarda.transform.localPosition = new Vector3(0f, 0f, 0f);
		guarda.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		Load();
		Load2(papelillovisual2.GetComponent<Papelillo2Behaviour>());
		modoedicion = false;
		MesaBehaviour[] array = Object.FindObjectsOfType<MesaBehaviour>();
		if (array != null)
		{
			MesaBehaviour[] array2 = array;
			foreach (MesaBehaviour mesaBehaviour in array2)
			{
				QuitaRigid(((Component)mesaBehaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)mesaBehaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)mesaBehaviour).gameObject);
			}
		}
		Mesa2Behaviour[] array3 = Object.FindObjectsOfType<Mesa2Behaviour>();
		if (array3 != null)
		{
			Mesa2Behaviour[] array4 = array3;
			foreach (Mesa2Behaviour mesa2Behaviour in array4)
			{
				QuitaRigid(((Component)mesa2Behaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)mesa2Behaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)mesa2Behaviour).gameObject);
			}
		}
		PoufBehaviour[] array5 = Object.FindObjectsOfType<PoufBehaviour>();
		if (array5 != null)
		{
			PoufBehaviour[] array6 = array5;
			foreach (PoufBehaviour poufBehaviour in array6)
			{
				QuitaRigid(((Component)poufBehaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)poufBehaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)poufBehaviour).gameObject);
			}
		}
		SofaBehaviour[] array7 = Object.FindObjectsOfType<SofaBehaviour>();
		if (array7 != null)
		{
			SofaBehaviour[] array8 = array7;
			foreach (SofaBehaviour sofaBehaviour in array8)
			{
				QuitaRigid(((Component)sofaBehaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)sofaBehaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)sofaBehaviour).gameObject);
			}
		}
		SillaBehaviour[] array9 = Object.FindObjectsOfType<SillaBehaviour>();
		if (array9 != null)
		{
			SillaBehaviour[] array10 = array9;
			foreach (SillaBehaviour sillaBehaviour in array10)
			{
				QuitaRigid(((Component)sillaBehaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)sillaBehaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)sillaBehaviour).gameObject);
			}
		}
		Silla2Behaviour[] array11 = Object.FindObjectsOfType<Silla2Behaviour>();
		if (array11 != null)
		{
			Silla2Behaviour[] array12 = array11;
			foreach (Silla2Behaviour silla2Behaviour in array12)
			{
				QuitaRigid(((Component)silla2Behaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)silla2Behaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)silla2Behaviour).gameObject);
			}
		}
		AlfombraBehaviour[] array13 = Object.FindObjectsOfType<AlfombraBehaviour>();
		if (array13 != null)
		{
			AlfombraBehaviour[] array14 = array13;
			foreach (AlfombraBehaviour alfombraBehaviour in array14)
			{
				QuitaRigid(((Component)alfombraBehaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)alfombraBehaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)alfombraBehaviour).gameObject);
			}
		}
		NightStandBehaviour[] array15 = Object.FindObjectsOfType<NightStandBehaviour>();
		if (array15 != null)
		{
			NightStandBehaviour[] array16 = array15;
			foreach (NightStandBehaviour nightStandBehaviour in array16)
			{
				QuitaRigid(((Component)nightStandBehaviour).GetComponent<Rigidbody>());
				Disablecol(((Component)nightStandBehaviour).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)nightStandBehaviour).gameObject);
			}
		}
		playerspawn = true;
	}

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
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		GUIStyle val = new GUIStyle
		{
			alignment = (TextAnchor)1
		};
		val.normal.textColor = Color.red;
		val.fontSize = 20;
		if (showGUI)
		{
			GUI.ModalWindow(949, _guiBox, (WindowFunction)GuiSettingsWindow, "Purchase Home Options");
		}
		if (modoedicion)
		{
			GUI.DrawTexture(new Rect((float)(Screen.width - 70), 20f, 50f, 30f), guiedi);
		}
	}

	private void GuiSettingsWindow(int windowId)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.GetStyle("Label").alignment = (TextAnchor)1;
		if (GUI.Button(new Rect(150f, 210f, 100f, 30f), "Purchase"))
		{
			if (FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney").Value >= preciototal)
			{
				FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
				val.Value -= preciototal;
				vendido = true;
				_playerInMenu.Value = false;
				nomoney = false;
				showGUI = false;
			}
			else
			{
				nomoney = true;
			}
			if (nomoney)
			{
				GUI.Label(new Rect(150f, 240f, 100f, 30f), "Not enough money");
			}
		}
		if (GUI.Button(new Rect(30f, 210f, 100f, 30f), "Exit"))
		{
			_playerInMenu.Value = false;
			nomoney = false;
			showGUI = false;
		}
		if ((muevepiezas = GUI.Toggle(new Rect(10f, 30f, 350f, 30f), muevepiezas, "Move parts of the car to new house. 500MK")) && !checkeao)
		{
			precioañadido += 500f;
			checkeao = true;
		}
		if ((muevesatsu = GUI.Toggle(new Rect(10f, 60f, 300f, 30f), muevesatsu, "Move satsuma to the new house. 800MK")) && !checkeao2)
		{
			precioañadido += 800f;
			checkeao2 = true;
		}
		if ((muevejonn = GUI.Toggle(new Rect(10f, 90f, 300f, 30f), muevejonn, "Move Jonnez to the new house. 400MK")) && !checkeao3)
		{
			precioañadido += 400f;
			checkeao3 = true;
		}
		GUI.Label(new Rect(70f, 120f, 150f, 30f), "House price = " + precio);
		GUI.Label(new Rect(70f, 150f, 150f, 30f), "Accessories price = " + precioañadido);
		GUI.Label(new Rect(70f, 180f, 150f, 30f), "Total price = " + preciototal);
	}

	private void Setupmudanza()
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		preciototal = precio + precioañadido;
		if (muevepiezas && !confirmado && vendido)
		{
			partes.Muevepartes();
			confirmado = true;
		}
		if (muevesatsu && !confirmado2 && vendido)
		{
			satsuma = GameObject.Find("SATSUMA(557kg, 248)").gameObject;
			posisatsu = ((Component)((Component)this).transform.FindChild("posisatsu")).gameObject;
			satsuma.transform.position = posisatsu.transform.position;
			confirmado2 = true;
		}
		if (muevejonn && !confirmado3 && vendido)
		{
			jonn = GameObject.Find("JONNEZ ES(Clone)").gameObject;
			GameObject gameObject = ((Component)((Component)this).transform.FindChild("posijonnez")).gameObject;
			jonn.transform.position = gameObject.transform.position;
			confirmado3 = true;
		}
		if (!muevepiezas && checkeao)
		{
			precioañadido -= 500f;
			checkeao = false;
		}
		if (!muevesatsu && checkeao2)
		{
			precioañadido -= 800f;
			checkeao2 = false;
		}
		if (!muevejonn && checkeao3)
		{
			precioañadido -= 400f;
			checkeao3 = false;
		}
	}

	public void Save()
	{
		if (vendido)
		{
			SaveData saveData = new SaveData();
			SaveDataList item = new SaveDataList
			{
				teleon = teleencendida,
				vendido = vendido,
				telecomprada = telecomprada,
				radiocomprada = radiocomprada,
				saunacomprado = saunacomprada,
				barbacoacomprado = barbacoacomprada,
				piscinacomprado = piscinacomprada,
				intensidad = intensidad,
				pagado = pagado
			};
			saveData.save.Add(item);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-general.save");
			Papelillo2Behaviour component = papelillovisual2.GetComponent<Papelillo2Behaviour>();
			SaveData saveData2 = new SaveData();
			SaveDataList item2 = new SaveDataList
			{
				cortinablanca = component.blanco2,
				cortinaverde = component.verde2,
				cortinaazul = component.azul2,
				cortinarara = component.raro2,
				cortinablanca2 = component.blanco4,
				cortinaverde2 = component.verde4,
				cortinaazul2 = component.azul4,
				cortinarara2 = component.raro4,
				cortinablancalav = component.blancolav,
				cortinaverdelav = component.verdelav,
				cortinaazullav = component.azullav,
				cortinararalav = component.rarolav,
				cortinablancacoc = component.blancococ,
				cortinaverdecoc = component.verdecoc,
				cortinaazulcoc = component.azulcoc,
				cortinararacoc = component.rarococ,
				cortinablancatel = component.blancotel,
				cortinaverdetel = component.verdetel,
				cortinaazultel = component.azultel,
				cortinararatel = component.rarotel,
				cortinablancahab1 = component.blancohab1,
				cortinaverdehab1 = component.verdehab1,
				cortinaazulhab1 = component.azulhab1,
				cortinararahab1 = component.rarohab1,
				cortinablancahab2 = component.blancohab2,
				cortinaverdehab2 = component.verdehab2,
				cortinaazulhab2 = component.azulhab2,
				cortinararahab2 = component.rarohab2
			};
			saveData2.save.Add(item2);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData2, "NewHouse-decoration.save");
		}
	}

	private void Load()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-general.save");
		if (saveData != null)
		{
			teleencendida = saveData.save[0].teleon;
			vendido = saveData.save[0].vendido;
			telecomprada = saveData.save[0].telecomprada;
			radiocomprada = saveData.save[0].radiocomprada;
			saunacomprada = saveData.save[0].saunacomprado;
			piscinacomprada = saveData.save[0].piscinacomprado;
			barbacoacomprada = saveData.save[0].barbacoacomprado;
			intensidad = saveData.save[0].intensidad;
			pagado = saveData.save[0].pagado;
		}
	}

	private void Load2(Papelillo2Behaviour papel)
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-decoration.save");
		if (saveData != null)
		{
			cortinablanca.SetActive(saveData.save[0].cortinablanca);
			papel.blanco2 = saveData.save[0].cortinablanca;
			cortinablanca2.SetActive(saveData.save[0].cortinablanca);
			cortinaverde.SetActive(saveData.save[0].cortinaverde);
			papel.verde2 = saveData.save[0].cortinaverde;
			cortinaverde2.SetActive(saveData.save[0].cortinaverde);
			cortinaazul.SetActive(saveData.save[0].cortinaazul);
			papel.azul2 = saveData.save[0].cortinaazul;
			cortinaazul2.SetActive(saveData.save[0].cortinaazul);
			cortinarara.SetActive(saveData.save[0].cortinarara);
			papel.raro2 = saveData.save[0].cortinarara;
			cortinarara2.SetActive(saveData.save[0].cortinarara);
			cortinablanca3.SetActive(saveData.save[0].cortinablanca2);
			papel.blanco4 = saveData.save[0].cortinablanca2;
			cortinablanca4.SetActive(saveData.save[0].cortinablanca2);
			cortinaverde3.SetActive(saveData.save[0].cortinaverde2);
			papel.verde4 = saveData.save[0].cortinaverde2;
			cortinaverde4.SetActive(saveData.save[0].cortinaverde2);
			cortinaazul3.SetActive(saveData.save[0].cortinaazul2);
			papel.azul4 = saveData.save[0].cortinaazul2;
			cortinaazul4.SetActive(saveData.save[0].cortinaazul2);
			cortinarara3.SetActive(saveData.save[0].cortinarara2);
			papel.raro4 = saveData.save[0].cortinarara2;
			cortinarara4.SetActive(saveData.save[0].cortinarara2);
			cortinablancalav.SetActive(saveData.save[0].cortinablancalav);
			papel.blancolav = saveData.save[0].cortinablancalav;
			cortinablancalav2.SetActive(saveData.save[0].cortinablancalav);
			cortinaverdelav.SetActive(saveData.save[0].cortinaverdelav);
			papel.verdelav = saveData.save[0].cortinaverdelav;
			cortinaverdelav2.SetActive(saveData.save[0].cortinaverdelav);
			cortinaazullav.SetActive(saveData.save[0].cortinaazullav);
			papel.azullav = saveData.save[0].cortinaazullav;
			cortinaazullav2.SetActive(saveData.save[0].cortinaazullav);
			cortinararalav.SetActive(saveData.save[0].cortinararalav);
			papel.rarolav = saveData.save[0].cortinararalav;
			cortinararalav2.SetActive(saveData.save[0].cortinararalav);
			cortinablancacoc.SetActive(saveData.save[0].cortinablancacoc);
			papel.blancococ = saveData.save[0].cortinablancacoc;
			cortinablancacoc2.SetActive(saveData.save[0].cortinablancacoc);
			cortinablancacoc3.SetActive(saveData.save[0].cortinablancacoc);
			cortinablancacoc4.SetActive(saveData.save[0].cortinablancacoc);
			cortinaverdecoc.SetActive(saveData.save[0].cortinaverdecoc);
			papel.verdecoc = saveData.save[0].cortinaverdecoc;
			cortinaverdecoc2.SetActive(saveData.save[0].cortinaverdecoc);
			cortinaverdecoc3.SetActive(saveData.save[0].cortinaverdecoc);
			cortinaverdecoc4.SetActive(saveData.save[0].cortinaverdecoc);
			cortinaazulcoc.SetActive(saveData.save[0].cortinaazulcoc);
			papel.azulcoc = saveData.save[0].cortinaazulcoc;
			cortinaazulcoc2.SetActive(saveData.save[0].cortinaazulcoc);
			cortinaazulcoc3.SetActive(saveData.save[0].cortinaazulcoc);
			cortinaazulcoc4.SetActive(saveData.save[0].cortinaazulcoc);
			cortinararacoc.SetActive(saveData.save[0].cortinararacoc);
			papel.rarococ = saveData.save[0].cortinararacoc;
			cortinararacoc2.SetActive(saveData.save[0].cortinararacoc);
			cortinararacoc3.SetActive(saveData.save[0].cortinararacoc);
			cortinararacoc4.SetActive(saveData.save[0].cortinararacoc);
			cortinablancatel.SetActive(saveData.save[0].cortinablancatel);
			papel.blancotel = saveData.save[0].cortinablancatel;
			cortinaverdetel.SetActive(saveData.save[0].cortinaverdetel);
			papel.verdetel = saveData.save[0].cortinaverdetel;
			cortinaazultel.SetActive(saveData.save[0].cortinaazultel);
			papel.azultel = saveData.save[0].cortinaazultel;
			cortinararatel.SetActive(saveData.save[0].cortinararatel);
			papel.rarotel = saveData.save[0].cortinararatel;
			cortinablancahab1.SetActive(saveData.save[0].cortinablancahab1);
			papel.blancohab1 = saveData.save[0].cortinablancahab1;
			cortinaverdehab1.SetActive(saveData.save[0].cortinaverdehab1);
			papel.verdehab1 = saveData.save[0].cortinaverdehab1;
			cortinaazulhab1.SetActive(saveData.save[0].cortinaazulhab1);
			papel.azulhab1 = saveData.save[0].cortinaazulhab1;
			cortinararahab1.SetActive(saveData.save[0].cortinararahab1);
			papel.rarohab1 = saveData.save[0].cortinararahab1;
			cortinablancahab2.SetActive(saveData.save[0].cortinablancahab2);
			papel.blancohab2 = saveData.save[0].cortinablancahab2;
			cortinaverdehab2.SetActive(saveData.save[0].cortinaverdehab2);
			papel.verdehab2 = saveData.save[0].cortinaverdehab2;
			cortinaazulhab2.SetActive(saveData.save[0].cortinaazulhab2);
			papel.azulhab2 = saveData.save[0].cortinaazulhab2;
			cortinararahab2.SetActive(saveData.save[0].cortinararahab2);
			papel.rarohab2 = saveData.save[0].cortinararahab2;
		}
		else
		{
			papel.blanco2 = true;
			papel.verde2 = false;
			papel.azul2 = false;
			papel.raro2 = false;
			papel.blanco4 = true;
			papel.verde4 = false;
			papel.azul4 = false;
			papel.raro4 = false;
			papel.blancococ = true;
			papel.verdecoc = false;
			papel.azulcoc = false;
			papel.rarococ = false;
			papel.blancohab1 = true;
			papel.verdehab1 = false;
			papel.azulhab1 = false;
			papel.rarohab1 = false;
			papel.blancohab2 = true;
			papel.verdehab2 = false;
			papel.azulhab2 = false;
			papel.rarohab2 = false;
			papel.blancotel = true;
			papel.verdetel = false;
			papel.azultel = false;
			papel.rarotel = false;
			papel.blancolav = true;
			papel.verdelav = false;
			papel.azullav = false;
			papel.rarolav = false;
		}
	}

	private void OnBagTriggerStay2(Collider collider)
	{
		if (((Object)collider).name == ((Object)Player).name && !drink2Running)
		{
			drink2Running = true;
			((MonoBehaviour)this).StartCoroutine(Drink2());
		}
	}

	private void SetupRadio()
	{
		if (radiocomprada)
		{
			radiopepino.SetActive(true);
		}
		if (!radiocomprada)
		{
			radiopepino.SetActive(false);
		}
	}

	private void SetupSauna()
	{
		if (saunacomprada)
		{
			saunamadera.SetActive(true);
		}
		if (!saunacomprada)
		{
			saunamadera.SetActive(false);
		}
	}

	private void SetupBarbacoa()
	{
		if (barbacoacomprada)
		{
			bistecc.SetActive(true);
		}
		if (!barbacoacomprada)
		{
			bistecc.SetActive(false);
		}
	}

	private void SetupTelevision()
	{
		if (telecomprada)
		{
			cajatonta.SetActive(true);
		}
		if (!telecomprada)
		{
			cajatonta.SetActive(false);
		}
	}

	private void SetupPiscina()
	{
		if (piscinacomprada)
		{
			piscina.SetActive(true);
		}
		if (!piscinacomprada)
		{
			piscina.SetActive(false);
		}
	}

	private void SetupPapel()
	{
		if (mirandopapel2)
		{
			papelillovisual2.SetActive(true);
			papelillovisual.SetActive(false);
			papelillo.SetActive(false);
			_playerInMenu.Value = true;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = true;
		}
		if (!mirandopapel2 && !mirandopapel)
		{
			papelillovisual2.SetActive(false);
			papelillovisual.SetActive(false);
			papelillo.SetActive(true);
		}
		if (mirandopapel)
		{
			papelillovisual.SetActive(true);
			papelillovisual2.SetActive(false);
			papelillo.SetActive(false);
			_playerInMenu.Value = true;
			FsmVariables.GlobalVariables.FindFsmBool("PlayerStop").Value = true;
		}
	}

	private void SetupTele()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		float num = Vector3.Distance(cajatonta.transform.position, Player.transform.position);
		if (electricidad.electricidadon)
		{
			if (teleencendida && num < 5f && !drinkRunning)
			{
				drinkRunning = true;
				((MonoBehaviour)this).StartCoroutine(Drink());
			}
			if (teleencendida)
			{
				botonteleon.SetActive(true);
				botonteleoff.SetActive(false);
				botonteleluz.GetComponent<Renderer>().material.color = Color.green;
				if (sunFsm.FsmVariables.FindFsmBool("Night").Value)
				{
					if (!marjatta.isPlaying)
					{
						marjatta.Play();
					}
					if (pelitop.isPlaying)
					{
						pelitop.Stop();
					}
					if (peliculadia.isPlaying)
					{
						peliculadia.Stop();
					}
					if ((Object)(object)pantalla.GetComponent<Renderer>().material.mainTexture != (Object)(object)peliculacarta)
					{
						pantalla.GetComponent<Renderer>().material.mainTexture = peliculacarta;
					}
				}
				if (!sunFsm.FsmVariables.FindFsmBool("Night").Value)
				{
					if (!peliculadia.isPlaying)
					{
						peliculadia.loop = true;
						peliculadia.Play();
					}
					if (!pelitop.isPlaying)
					{
						pelitop.Play();
					}
					if (marjatta.isPlaying)
					{
						marjatta.Stop();
					}
					if ((Object)(object)pantalla.GetComponent<Renderer>().material.mainTexture != (Object)(object)peliculadia)
					{
						pantalla.GetComponent<Renderer>().material.mainTexture = (Texture)(object)peliculadia;
					}
				}
			}
			if (!teleencendida)
			{
				botonteleluz.GetComponent<Renderer>().material.color = Color.red;
				botonteleon.SetActive(false);
				botonteleoff.SetActive(true);
				if (peliculadia.isPlaying)
				{
					peliculadia.Stop();
				}
				if (pelitop.isPlaying)
				{
					pelitop.Stop();
				}
				if (marjatta.isPlaying)
				{
					marjatta.Stop();
				}
				if ((Object)(object)pantalla.GetComponent<Renderer>().material.mainTexture != (Object)(object)peliculaoff)
				{
					pantalla.GetComponent<Renderer>().material.mainTexture = peliculaoff;
				}
			}
		}
		if (!electricidad.electricidadon)
		{
			botonteleluz.GetComponent<Renderer>().material.color = Color.red;
			botonteleon.SetActive(false);
			botonteleoff.SetActive(true);
			if (peliculadia.isPlaying)
			{
				peliculadia.Stop();
			}
			if (pelitop.isPlaying)
			{
				pelitop.Stop();
			}
			if (marjatta.isPlaying)
			{
				marjatta.Stop();
			}
			if ((Object)(object)pantalla.GetComponent<Renderer>().material.mainTexture != (Object)(object)peliculaoff)
			{
				pantalla.GetComponent<Renderer>().material.mainTexture = peliculaoff;
			}
		}
	}

	private void SetupNevera()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		if (neveraabierta)
		{
			Quaternion val = Quaternion.Euler(puertaneveraabierta.eulerAngles.x, puertaneveraabierta.eulerAngles.y, puertaneveraabierta.eulerAngles.z);
			pivotnevera.transform.rotation = Quaternion.Lerp(pivotnevera.transform.rotation, val, Time.deltaTime * 3f);
		}
		if (!neveraabierta)
		{
			Quaternion val2 = Quaternion.Euler(puertaneveracerrada.eulerAngles.x, puertaneveracerrada.eulerAngles.y, puertaneveracerrada.eulerAngles.z);
			pivotnevera.transform.rotation = Quaternion.Lerp(pivotnevera.transform.rotation, val2, Time.deltaTime * 3f);
		}
		if (congeladorabierta)
		{
			Quaternion val3 = Quaternion.Euler(puertacongeladorabierta.eulerAngles.x, puertacongeladorabierta.eulerAngles.y, puertacongeladorabierta.eulerAngles.z);
			pivotcongelador.transform.rotation = Quaternion.Lerp(pivotcongelador.transform.rotation, val3, Time.deltaTime * 3f);
		}
		if (!congeladorabierta)
		{
			Quaternion val4 = Quaternion.Euler(puertacongeladorcerrada.eulerAngles.x, puertacongeladorcerrada.eulerAngles.y, puertacongeladorcerrada.eulerAngles.z);
			pivotcongelador.transform.rotation = Quaternion.Lerp(pivotcongelador.transform.rotation, val4, Time.deltaTime * 3f);
		}
	}

	private void RayTele(RaycastHit hit)
	{
		if (!((Object)(object)((Component)hit.collider).gameObject == (Object)(object)botontele) || !Object.FindObjectOfType<ElectricidadBehaviour>().electricidadon)
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0))
		{
			teleencendida = !teleencendida;
			if (teleencendida)
			{
				intensidad++;
			}
			if (!teleencendida)
			{
				intensidad--;
			}
		}
	}

	private IEnumerator Drink()
	{
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerFatigue");
		val.Value += 0.01f;
		drinkRunning = false;
	}

	private IEnumerator Drink2()
	{
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerStress");
		val.Value -= 0.05f;
		FsmFloat val2 = FsmVariables.GlobalVariables.FindFsmFloat("PlayerDirtiness");
		val2.Value -= 0.09f;
		drink2Running = false;
	}

	private IEnumerator Drink3()
	{
		yield return (object)new WaitForSeconds(0.5f);
		FsmFloat val = FsmVariables.GlobalVariables.FindFsmFloat("PlayerStress");
		val.Value -= 0.05f;
	}

	private void RayCartel(RaycastHit hit)
	{
		if ((Object)(object)((Component)hit.collider).gameObject == (Object)(object)cartel)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				showGUI = true;
			}
		}
	}

	private void RayNevera(RaycastHit hit)
	{
		if ((Object)(object)((Component)hit.collider).gameObject == (Object)(object)nevera)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				neveraabierta = !neveraabierta;
				if (neveraabierta && !neveraopen.isPlaying)
				{
					neveraopen.Play();
				}
				if (!neveraabierta && !neveraclose.isPlaying)
				{
					neveraclose.Play();
				}
			}
		}
		if (!((Object)(object)((Component)hit.collider).gameObject == (Object)(object)congelador))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (Input.GetMouseButtonDown(0))
		{
			congeladorabierta = !congeladorabierta;
			if (congeladorabierta && !neveraopen.isPlaying)
			{
				neveraopen.Play();
			}
			if (!congeladorabierta && !neveraclose.isPlaying)
			{
				neveraclose.Play();
			}
		}
	}

	private void SetupEdicion()
	{
		if (Input.GetKeyDown((KeyCode)51))
		{
			modoedicion = true;
			MesaBehaviour[] array = Object.FindObjectsOfType<MesaBehaviour>();
			if (array != null)
			{
				MesaBehaviour[] array2 = array;
				foreach (MesaBehaviour mesaBehaviour in array2)
				{
					AñadeRigid(((Component)mesaBehaviour).gameObject);
					Enablecol(((Component)mesaBehaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)mesaBehaviour).gameObject);
				}
			}
			Mesa2Behaviour[] array3 = Object.FindObjectsOfType<Mesa2Behaviour>();
			if (array3 != null)
			{
				Mesa2Behaviour[] array4 = array3;
				foreach (Mesa2Behaviour mesa2Behaviour in array4)
				{
					AñadeRigid(((Component)mesa2Behaviour).gameObject);
					Enablecol(((Component)mesa2Behaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)mesa2Behaviour).gameObject);
				}
			}
			PoufBehaviour[] array5 = Object.FindObjectsOfType<PoufBehaviour>();
			if (array5 != null)
			{
				PoufBehaviour[] array6 = array5;
				foreach (PoufBehaviour poufBehaviour in array6)
				{
					AñadeRigid(((Component)poufBehaviour).gameObject);
					Enablecol(((Component)poufBehaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)poufBehaviour).gameObject);
				}
			}
			SofaBehaviour[] array7 = Object.FindObjectsOfType<SofaBehaviour>();
			if (array7 != null)
			{
				SofaBehaviour[] array8 = array7;
				foreach (SofaBehaviour sofaBehaviour in array8)
				{
					AñadeRigid(((Component)sofaBehaviour).gameObject);
					Enablecol(((Component)sofaBehaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)sofaBehaviour).gameObject);
				}
			}
			SillaBehaviour[] array9 = Object.FindObjectsOfType<SillaBehaviour>();
			if (array9 != null)
			{
				SillaBehaviour[] array10 = array9;
				foreach (SillaBehaviour sillaBehaviour in array10)
				{
					AñadeRigid(((Component)sillaBehaviour).gameObject);
					Enablecol(((Component)sillaBehaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)sillaBehaviour).gameObject);
				}
			}
			Silla2Behaviour[] array11 = Object.FindObjectsOfType<Silla2Behaviour>();
			if (array11 != null)
			{
				Silla2Behaviour[] array12 = array11;
				foreach (Silla2Behaviour silla2Behaviour in array12)
				{
					AñadeRigid(((Component)silla2Behaviour).gameObject);
					Enablecol(((Component)silla2Behaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)silla2Behaviour).gameObject);
				}
			}
			AlfombraBehaviour[] array13 = Object.FindObjectsOfType<AlfombraBehaviour>();
			if (array13 != null)
			{
				AlfombraBehaviour[] array14 = array13;
				foreach (AlfombraBehaviour alfombraBehaviour in array14)
				{
					AñadeRigid(((Component)alfombraBehaviour).gameObject);
					Enablecol(((Component)alfombraBehaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)alfombraBehaviour).gameObject);
				}
			}
			NightStandBehaviour[] array15 = Object.FindObjectsOfType<NightStandBehaviour>();
			if (array15 != null)
			{
				NightStandBehaviour[] array16 = array15;
				foreach (NightStandBehaviour nightStandBehaviour in array16)
				{
					AñadeRigid(((Component)nightStandBehaviour).gameObject);
					Enablecol(((Component)nightStandBehaviour).GetComponent<BoxCollider>());
					CambiaLayeritem(((Component)nightStandBehaviour).gameObject);
				}
			}
		}
		if (Input.GetKeyDown((KeyCode)49))
		{
			modoedicion = false;
			MesaBehaviour[] array17 = Object.FindObjectsOfType<MesaBehaviour>();
			if (array17 != null)
			{
				MesaBehaviour[] array2 = array17;
				foreach (MesaBehaviour mesaBehaviour2 in array2)
				{
					QuitaRigid(((Component)mesaBehaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)mesaBehaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)mesaBehaviour2).gameObject);
				}
			}
			Mesa2Behaviour[] array18 = Object.FindObjectsOfType<Mesa2Behaviour>();
			if (array18 != null)
			{
				Mesa2Behaviour[] array4 = array18;
				foreach (Mesa2Behaviour mesa2Behaviour2 in array4)
				{
					QuitaRigid(((Component)mesa2Behaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)mesa2Behaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)mesa2Behaviour2).gameObject);
				}
			}
			PoufBehaviour[] array19 = Object.FindObjectsOfType<PoufBehaviour>();
			if (array19 != null)
			{
				PoufBehaviour[] array6 = array19;
				foreach (PoufBehaviour poufBehaviour2 in array6)
				{
					QuitaRigid(((Component)poufBehaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)poufBehaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)poufBehaviour2).gameObject);
				}
			}
			SofaBehaviour[] array20 = Object.FindObjectsOfType<SofaBehaviour>();
			if (array20 != null)
			{
				SofaBehaviour[] array8 = array20;
				foreach (SofaBehaviour sofaBehaviour2 in array8)
				{
					QuitaRigid(((Component)sofaBehaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)sofaBehaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)sofaBehaviour2).gameObject);
				}
			}
			SillaBehaviour[] array21 = Object.FindObjectsOfType<SillaBehaviour>();
			if (array21 != null)
			{
				SillaBehaviour[] array10 = array21;
				foreach (SillaBehaviour sillaBehaviour2 in array10)
				{
					QuitaRigid(((Component)sillaBehaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)sillaBehaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)sillaBehaviour2).gameObject);
				}
			}
			Silla2Behaviour[] array22 = Object.FindObjectsOfType<Silla2Behaviour>();
			if (array22 != null)
			{
				Silla2Behaviour[] array12 = array22;
				foreach (Silla2Behaviour silla2Behaviour2 in array12)
				{
					QuitaRigid(((Component)silla2Behaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)silla2Behaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)silla2Behaviour2).gameObject);
				}
			}
			AlfombraBehaviour[] array23 = Object.FindObjectsOfType<AlfombraBehaviour>();
			if (array23 != null)
			{
				AlfombraBehaviour[] array14 = array23;
				foreach (AlfombraBehaviour alfombraBehaviour2 in array14)
				{
					QuitaRigid(((Component)alfombraBehaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)alfombraBehaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)alfombraBehaviour2).gameObject);
				}
			}
			NightStandBehaviour[] array24 = Object.FindObjectsOfType<NightStandBehaviour>();
			if (array24 != null)
			{
				NightStandBehaviour[] array16 = array24;
				foreach (NightStandBehaviour nightStandBehaviour2 in array16)
				{
					QuitaRigid(((Component)nightStandBehaviour2).GetComponent<Rigidbody>());
					Disablecol(((Component)nightStandBehaviour2).GetComponent<BoxCollider>());
					CambiaLayernoitem(((Component)nightStandBehaviour2).gameObject);
				}
			}
		}
		if (!Input.GetKeyDown((KeyCode)50))
		{
			return;
		}
		modoedicion = false;
		MesaBehaviour[] array25 = Object.FindObjectsOfType<MesaBehaviour>();
		if (array25 != null)
		{
			MesaBehaviour[] array2 = array25;
			foreach (MesaBehaviour mesaBehaviour3 in array2)
			{
				QuitaRigid(((Component)mesaBehaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)mesaBehaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)mesaBehaviour3).gameObject);
			}
		}
		Mesa2Behaviour[] array26 = Object.FindObjectsOfType<Mesa2Behaviour>();
		if (array26 != null)
		{
			Mesa2Behaviour[] array4 = array26;
			foreach (Mesa2Behaviour mesa2Behaviour3 in array4)
			{
				QuitaRigid(((Component)mesa2Behaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)mesa2Behaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)mesa2Behaviour3).gameObject);
			}
		}
		PoufBehaviour[] array27 = Object.FindObjectsOfType<PoufBehaviour>();
		if (array27 != null)
		{
			PoufBehaviour[] array6 = array27;
			foreach (PoufBehaviour poufBehaviour3 in array6)
			{
				QuitaRigid(((Component)poufBehaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)poufBehaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)poufBehaviour3).gameObject);
			}
		}
		SofaBehaviour[] array28 = Object.FindObjectsOfType<SofaBehaviour>();
		if (array28 != null)
		{
			SofaBehaviour[] array8 = array28;
			foreach (SofaBehaviour sofaBehaviour3 in array8)
			{
				QuitaRigid(((Component)sofaBehaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)sofaBehaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)sofaBehaviour3).gameObject);
			}
		}
		SillaBehaviour[] array29 = Object.FindObjectsOfType<SillaBehaviour>();
		if (array29 != null)
		{
			SillaBehaviour[] array10 = array29;
			foreach (SillaBehaviour sillaBehaviour3 in array10)
			{
				QuitaRigid(((Component)sillaBehaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)sillaBehaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)sillaBehaviour3).gameObject);
			}
		}
		Silla2Behaviour[] array30 = Object.FindObjectsOfType<Silla2Behaviour>();
		if (array30 != null)
		{
			Silla2Behaviour[] array12 = array30;
			foreach (Silla2Behaviour silla2Behaviour3 in array12)
			{
				QuitaRigid(((Component)silla2Behaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)silla2Behaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)silla2Behaviour3).gameObject);
			}
		}
		AlfombraBehaviour[] array31 = Object.FindObjectsOfType<AlfombraBehaviour>();
		if (array31 != null)
		{
			AlfombraBehaviour[] array14 = array31;
			foreach (AlfombraBehaviour alfombraBehaviour3 in array14)
			{
				QuitaRigid(((Component)alfombraBehaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)alfombraBehaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)alfombraBehaviour3).gameObject);
			}
		}
		NightStandBehaviour[] array32 = Object.FindObjectsOfType<NightStandBehaviour>();
		if (array32 != null)
		{
			NightStandBehaviour[] array16 = array32;
			foreach (NightStandBehaviour nightStandBehaviour3 in array16)
			{
				QuitaRigid(((Component)nightStandBehaviour3).GetComponent<Rigidbody>());
				Disablecol(((Component)nightStandBehaviour3).GetComponent<BoxCollider>());
				CambiaLayernoitem(((Component)nightStandBehaviour3).gameObject);
			}
		}
	}

	private void LateUpdate()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Player == (Object)null)
		{
			return;
		}
		try
		{
			if (playerspawn)
			{
				Color targetColor = activado ? Color.red : Color.green;
				if (estado.material.color != targetColor)
				{
					estado.material.color = targetColor;
				}
				if (electricidad != null)
				{
					electricidad.electricidadon = !activado;
				}
			}
		}
		catch (Exception ex)
		{
			ModConsole.Error(ex.ToString());
		}
	}

	private void Update()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Player == (Object)null || !playerspawn)
		{
			return;
		}
		if (showGUI)
		{
			_playerInMenu.Value = true;
		}
		if (activado)
		{
			((Component)audi2).transform.rotation = botona.rotation;
		}
		if (!activado)
		{
			((Component)audi2).transform.rotation = botonb.rotation;
		}
		if (vendido)
		{
			if (FsmVariables.GlobalVariables.FindFsmInt("GlobalDay").Value == 1 && !pagado && ((Component)this).GetComponent<ElectricidadBehaviour>().consumor >= 1f)
			{
				correo2.SetActive(true);
			}
			if (FsmVariables.GlobalVariables.FindFsmInt("GlobalDay").Value == 7 && pagado)
			{
				pagado = false;
			}
			else if (FsmVariables.GlobalVariables.FindFsmInt("GlobalDay").Value == 7 && !pagado && !moroso)
			{
				semanassinpagar++;
				moroso = true;
			}
			if (semanassinpagar >= 3)
			{
				checkmoroso = true;
			}
			if (semanassinpagar < 3)
			{
				checkmoroso = false;
			}
			if (checkmoroso)
			{
				((Component)this).GetComponent<ElectricidadBehaviour>().electricidadon = false;
			}
		}
		else
		{
			((Component)this).GetComponent<ElectricidadBehaviour>().electricidadon = false;
			((Component)this).GetComponent<ElectricidadBehaviour>().consumor = 0f;
		}
		if (Vector3.Distance(Player.transform.position, transform.root.position) <= 60f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit hit = array[i];
			if (vendido)
			{
				if (telecomprada)
				{
					RayTele(hit);
				}
				RayNevera(hit);
				if (((Object)hit.collider).name == ((Object)boton).name)
				{
					m_guiUseBool.Value = true;
					if (cInput.GetButtonDown("Use") || Input.GetMouseButtonDown(0))
					{
						activado = !activado;
						audi2.Play();
					}
				}
				if ((Object)(object)hit.collider == (Object)(object)papelillo.GetComponent<Collider>())
				{
					if (!modoedicion)
					{
						m_guiUseBool.Value = true;
						if (cInput.GetButtonDown("Use") || Input.GetMouseButtonDown(0))
						{
							mirandopapel2 = true;
							mirandopapel = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().compras = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().opcion = true;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().living = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortina = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().living2 = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortina2 = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().bath = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortinalav = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().kitc = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortinacoc = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().telf = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortinatel = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().habita1 = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortinahab1 = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().habita2 = false;
							papelillovisual2.GetComponent<Papelillo2Behaviour>().customcortinahab2 = false;
						}
					}
					if (modoedicion && (cInput.GetButtonDown("Use") || Input.GetMouseButtonDown(0)))
					{
						ModConsole.Print("Press 1 to desactive mode edit , look magazine need mode edit off.");
					}
				}
			}
			RayCartel(hit);
		}
		}
		float num = (float)Math.Round(((Component)this).GetComponent<ElectricidadBehaviour>().consumor, 1);
		consumidodisc = num;
		lecturanewhouse.text = consumidodisc.ToString();
		speeddisc = ((Component)this).GetComponent<ElectricidadBehaviour>().intensidad;
		if (!activado)
		{
			((Component)axedisc).transform.Rotate(new Vector3(0f, 0f, 1f), speeddisc * 2f * Time.smoothDeltaTime);
		}
		if (vendido)
		{
			SetupNevera();
		}
		if (Time.time >= nextHouseMaintenance)
		{
			nextHouseMaintenance = Time.time + 0.1f;
			if (vendido)
			{
				poster.SetActive(false);
				correo.SetActive(true);
				SetupPapel();
				if (telecomprada)
				{
					SetupTele();
				}
			}
			else
			{
				poster.SetActive(true);
				correo.SetActive(false);
			}
			Setupmudanza();
			SetupPiscina();
			SetupRadio();
			SetupTelevision();
			SetupSauna();
			SetupBarbacoa();
		}
		SetupEdicion();
	}

	private void CambiaLayernoitem(GameObject gob)
	{
		gob.layer = LayerMask.NameToLayer("Default");
	}

	private void CambiaLayeritem(GameObject gob)
	{
		gob.layer = LayerMask.NameToLayer("Parts");
	}

	private void AñadeRigid(GameObject go)
	{
		if ((Object)(object)go.GetComponent<Rigidbody>() == (Object)null)
		{
			go.AddComponent<Rigidbody>();
		}
	}

	private void QuitaRigid(Rigidbody rigid)
	{
		Object.Destroy((Object)(object)rigid);
	}

	private void Enablecol(BoxCollider col)
	{
		((Collider)col).enabled = true;
	}

	private void Disablecol(BoxCollider col)
	{
		((Collider)col).enabled = false;
	}

	public CasaBehaviour()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
	}
}
