using System.Collections.Generic;
using UnityEngine;

namespace NewHouse;

public class TodoItemBehaviour : MonoBehaviour
{
	private GameObject xmas;

	private GameObject dices;

	private GameObject wishbonel;

	private GameObject spindlel;

	private GameObject strutl;

	private List<GameObject> brakefront = new List<GameObject>(2);

	private GameObject wishboner;

	private GameObject spindler;

	private GameObject strutr;

	private GameObject traill;

	private List<GameObject> coil = new List<GameObject>(2);

	private List<GameObject> shock = new List<GameObject>(2);

	private List<GameObject> brakerear = new List<GameObject>(2);

	private GameObject trailr;

	private GameObject muffler;

	private GameObject pipe;

	private GameObject fueltank;

	private GameObject pipe2;

	private GameObject bumperf;

	private GameObject bumperr;

	private GameObject fenderl;

	private GameObject fenderr;

	private GameObject doorl;

	private GameObject doorr;

	private GameObject maletero;

	private GameObject capo;

	private GameObject lightrl;

	private GameObject lightrr;

	private GameObject grille;

	private List<GameObject> lightfront = new List<GameObject>(2);

	private GameObject hubcabfl;

	private GameObject hubcabfr;

	private GameObject hubcabrl;

	private GameObject hubcabrr;

	private GameObject bearing1;

	private GameObject bearing2;

	private GameObject bearing3;

	private GameObject block;

	private GameObject cranck;

	private GameObject piston1;

	private GameObject piston2;

	private GameObject piston3;

	private GameObject piston4;

	private GameObject camshaft;

	private GameObject camshaftgear;

	private GameObject timingcover;

	private GameObject timingchain;

	private GameObject waterpump;

	private GameObject waterpumppull;

	private GameObject flywheel;

	private GameObject clutchcover;

	private GameObject clutchdisc;

	private GameObject clutchpressure;

	private GameObject engineplate;

	private GameObject gearbox;

	private GameObject cranckpulley;

	private GameObject drivegear;

	private GameObject oilpan;

	private GameObject alternator;

	private GameObject starter;

	private GameObject gasket;

	private GameObject cylindro;

	private GameObject rockershaft;

	private GameObject rockercover;

	private GameObject distributor;

	private GameObject filter;

	private GameObject fuelpump;

	private GameObject bujia1;

	private GameObject bujia2;

	private GameObject bujia3;

	private GameObject bujia4;

	private GameObject headers;

	private GameObject carburator;

	private GameObject airfilter;

	private GameObject subframe;

	private GameObject steeringrack;

	private GameObject steeringcolumn;

	private GameObject rodl;

	private GameObject rodr;

	private GameObject radiator;

	private GameObject hose1;

	private GameObject hose2;

	private GameObject hose3;

	private GameObject batery;

	private GameObject electrics;

	private GameObject brakelining;

	private GameObject clutchlining;

	private GameObject brakemaster;

	private GameObject clutchmaster;

	private GameObject fuelstrainer;

	private GameObject gearlink;

	private List<GameObject> halfshaft = new List<GameObject>(2);

	private GameObject rpmgauge;

	private GameObject clockgauge;

	private GameObject dashboardmeter;

	private GameObject dashboard;

	private GameObject seatd;

	private GameObject seatp;

	private GameObject seatr;

	private GameObject steeringwheel;

	private GameObject gearstick;

	private GameObject handbrake;

	private GameObject radio;

	private GameObject backpanel;

	private GameObject woferpanel;

	private GameObject wire;

	private GameObject inspectioncover;

	private GameObject gbarros1;

	private GameObject gbarros2;

	private GameObject gbarros3;

	private GameObject gbarros4;

	private Rigidbody[] objetos;

	private Vector3 posi = new Vector3(-1732.2f, 7.343648f, -169.5f);

	public bool movido;

	private void Start()
	{
		xmas = GameObject.Find("xmas lights(Clone)").gameObject;
		dices = GameObject.Find("fur dices(Clone)").gameObject;
		wishbonel = GameObject.Find("wishbone fl(Clone)").gameObject;
		spindlel = GameObject.Find("spindle fl(Clone)").gameObject;
		strutl = GameObject.Find("strut fl(Clone)").gameObject;
		objetos = Object.FindObjectsOfType<Rigidbody>();
		for (int i = 0; i < objetos.Length; i++)
		{
			if (((Object)((Component)objetos[i]).gameObject).name == "disc brake(Clone)")
			{
				brakefront.Add(((Component)objetos[i]).gameObject);
			}
			if (((Object)((Component)objetos[i]).gameObject).name == "coil spring(Clone)")
			{
				coil.Add(((Component)objetos[i]).gameObject);
			}
			if (((Object)((Component)objetos[i]).gameObject).name == "shock absorber(Clone)")
			{
				shock.Add(((Component)objetos[i]).gameObject);
			}
			if (((Object)((Component)objetos[i]).gameObject).name == "drum brake(Clone)")
			{
				brakerear.Add(((Component)objetos[i]).gameObject);
			}
			if (((Object)((Component)objetos[i]).gameObject).name == "headlight(Clone)")
			{
				lightfront.Add(((Component)objetos[i]).gameObject);
			}
			if (((Object)((Component)objetos[i]).gameObject).name == "halfshaft(Clone)")
			{
				halfshaft.Add(((Component)objetos[i]).gameObject);
			}
		}
		wishboner = GameObject.Find("wishbone fr(Clone)").gameObject;
		spindler = GameObject.Find("spindle fr(Clone)").gameObject;
		strutr = GameObject.Find("strut fr(Clone)").gameObject;
		traill = GameObject.Find("trail arm rl(Clone)").gameObject;
		trailr = GameObject.Find("trail arm rr(Clone)").gameObject;
		muffler = GameObject.Find("exhaust muffler(Clone)").gameObject;
		pipe = GameObject.Find("exhaust pipe(Clone)").gameObject;
		fueltank = GameObject.Find("fuel tank(Clone)").gameObject;
		pipe2 = GameObject.Find("fuel tank pipe(Clone)").gameObject;
		bumperf = GameObject.Find("bumper front(Clone)").gameObject;
		bumperr = GameObject.Find("bumper rear(Clone)").gameObject;
		fenderl = GameObject.Find("fender left(Clone)").gameObject;
		fenderr = GameObject.Find("fender right(Clone)").gameObject;
		doorl = GameObject.Find("door left(Clone)").gameObject;
		doorr = GameObject.Find("door right(Clone)").gameObject;
		maletero = GameObject.Find("bootlid(Clone)").gameObject;
		capo = GameObject.Find("hood(Clone)").gameObject;
		lightrl = GameObject.Find("rear light left(Clone)").gameObject;
		lightrr = GameObject.Find("rear light right(Clone)").gameObject;
		grille = GameObject.Find("grille(Clone)").gameObject;
		hubcabfl = GameObject.Find("hubcap fl(Clone)").gameObject;
		hubcabfr = GameObject.Find("hubcap fr(Clone)").gameObject;
		hubcabrl = GameObject.Find("hubcap rl(Clone)").gameObject;
		hubcabrr = GameObject.Find("hubcap rr(Clone)").gameObject;
		bearing1 = GameObject.Find("main bearing1(Clone)").gameObject;
		bearing2 = GameObject.Find("main bearing2(Clone)").gameObject;
		bearing3 = GameObject.Find("main bearing3(Clone)").gameObject;
		block = GameObject.Find("block(Clone)").gameObject;
		cranck = GameObject.Find("crankshaft(Clone)").gameObject;
		piston1 = GameObject.Find("piston1(Clone)").gameObject;
		piston2 = GameObject.Find("piston2(Clone)").gameObject;
		piston3 = GameObject.Find("piston3(Clone)").gameObject;
		piston4 = GameObject.Find("piston4(Clone)").gameObject;
		camshaft = GameObject.Find("camshaft(Clone)").gameObject;
		camshaftgear = GameObject.Find("camshaft gear(Clone)").gameObject;
		timingcover = GameObject.Find("timing cover(Clone)").gameObject;
		timingchain = GameObject.Find("timing chain(Clone)").gameObject;
		waterpump = GameObject.Find("water pump(Clone)").gameObject;
		waterpumppull = GameObject.Find("water pump pulley(Clone)").gameObject;
		flywheel = GameObject.Find("flywheel(Clone)").gameObject;
		clutchcover = GameObject.Find("clutch cover plate(Clone)").gameObject;
		clutchdisc = GameObject.Find("clutch disc(Clone)").gameObject;
		clutchpressure = GameObject.Find("clutch pressure plate(Clone)").gameObject;
		engineplate = GameObject.Find("engine plate(Clone)").gameObject;
		gearbox = GameObject.Find("gearbox(Clone)").gameObject;
		cranckpulley = GameObject.Find("crankshaft pulley(Clone)").gameObject;
		drivegear = GameObject.Find("drive gear(Clone)").gameObject;
		oilpan = GameObject.Find("oilpan(Clone)").gameObject;
		alternator = GameObject.Find("alternator(Clone)").gameObject;
		starter = GameObject.Find("starter(Clone)").gameObject;
		gasket = GameObject.Find("head gasket(Clone)").gameObject;
		cylindro = GameObject.Find("cylinder head(Clone)").gameObject;
		rockershaft = GameObject.Find("rocker shaft(Clone)").gameObject;
		rockercover = GameObject.Find("rocker cover(Clone)").gameObject;
		distributor = GameObject.Find("distributor(Clone)").gameObject;
		filter = GameObject.Find("oil filter(Clone)").gameObject;
		fuelpump = GameObject.Find("fuel pump(Clone)").gameObject;
		if ((Object)(object)GameObject.Find("spark plug 1(Clone)") != (Object)null)
		{
			bujia1 = GameObject.Find("spark plug 1(Clone)").gameObject;
			bujia2 = GameObject.Find("spark plug 2(Clone)").gameObject;
			bujia3 = GameObject.Find("spark plug 3(Clone)").gameObject;
			bujia4 = GameObject.Find("spark plug 4(Clone)").gameObject;
		}
		if ((Object)(object)GameObject.Find("wiring mess(itemx)") != (Object)null)
		{
			wire = GameObject.Find("wiring mess(itemx)").gameObject;
		}
		headers = GameObject.Find("headers(Clone)").gameObject;
		carburator = GameObject.Find("carburator(Clone)").gameObject;
		airfilter = GameObject.Find("airfilter(Clone)").gameObject;
		subframe = GameObject.Find("sub frame(Clone)").gameObject;
		steeringrack = GameObject.Find("steering rack(Clone)").gameObject;
		steeringcolumn = GameObject.Find("steering column(Clone)").gameObject;
		rodl = GameObject.Find("steering rod fl(Clone)").gameObject;
		rodr = GameObject.Find("steering rod fr(Clone)").gameObject;
		radiator = GameObject.Find("radiator(Clone)").gameObject;
		hose1 = GameObject.Find("radiator hose1(Clone)").gameObject;
		hose2 = GameObject.Find("radiator hose2(Clone)").gameObject;
		hose3 = GameObject.Find("radiator hose3(Clone)").gameObject;
		batery = GameObject.Find("battery(Clone)").gameObject;
		electrics = GameObject.Find("electrics(Clone)").gameObject;
		brakelining = GameObject.Find("brake lining(Clone)").gameObject;
		clutchlining = GameObject.Find("clutch lining(Clone)").gameObject;
		brakemaster = GameObject.Find("brake master cylinder(Clone)").gameObject;
		clutchmaster = GameObject.Find("clutch master cylinder(Clone)").gameObject;
		fuelstrainer = GameObject.Find("fuel strainer(Clone)").gameObject;
		gearlink = GameObject.Find("gear linkage(Clone)").gameObject;
		rpmgauge = GameObject.Find("rpm gauge(Clone)").gameObject;
		clockgauge = GameObject.Find("clock gauge(Clone)").gameObject;
		dashboardmeter = GameObject.Find("dashboard meters(Clone)").gameObject;
		dashboard = GameObject.Find("dashboard(Clone)").gameObject;
		seatd = GameObject.Find("seat driver(Clone)").gameObject;
		seatp = GameObject.Find("seat passenger(Clone)").gameObject;
		seatr = GameObject.Find("seat rear(Clone)").gameObject;
		steeringwheel = GameObject.Find("stock steering wheel(Clone)").gameObject;
		gearstick = GameObject.Find("gear stick(Clone)").gameObject;
		handbrake = GameObject.Find("handbrake(Clone)").gameObject;
		radio = GameObject.Find("radio(Clone)").gameObject;
		backpanel = GameObject.Find("back panel(Clone)").gameObject;
		woferpanel = GameObject.Find("subwoofer panel(Clone)").gameObject;
		inspectioncover = GameObject.Find("inspection cover(Clone)").gameObject;
		gbarros1 = GameObject.Find("mudflap rr(Clone)").gameObject;
		gbarros2 = GameObject.Find("mudflap rl(Clone)").gameObject;
		gbarros3 = GameObject.Find("mudflap fr(Clone)").gameObject;
		gbarros4 = GameObject.Find("mudflap fl(Clone)").gameObject;
	}

	private void Update()
	{
		if ((Object)(object)GameObject.Find("PLAYER") != (Object)null)
		{
			if ((Object)(object)block != (Object)null)
			{
				movido = false;
			}
			if ((Object)(object)block == (Object)null)
			{
				movido = true;
			}
		}
	}

	public void Muevepartes()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_129d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1309: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1375: Unknown result type (might be due to invalid IL or missing references)
		//IL_1399: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Unknown result type (might be due to invalid IL or missing references)
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Unknown result type (might be due to invalid IL or missing references)
		//IL_1536: Unknown result type (might be due to invalid IL or missing references)
		//IL_155a: Unknown result type (might be due to invalid IL or missing references)
		//IL_157e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Unknown result type (might be due to invalid IL or missing references)
		//IL_1688: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Unknown result type (might be due to invalid IL or missing references)
		//IL_173c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1760: Unknown result type (might be due to invalid IL or missing references)
		//IL_1784: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1814: Unknown result type (might be due to invalid IL or missing references)
		//IL_1838: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1880: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1910: Unknown result type (might be due to invalid IL or missing references)
		//IL_1934: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Unknown result type (might be due to invalid IL or missing references)
		//IL_197c: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_200c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2030: Unknown result type (might be due to invalid IL or missing references)
		//IL_2054: Unknown result type (might be due to invalid IL or missing references)
		//IL_2078: Unknown result type (might be due to invalid IL or missing references)
		//IL_209c: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2108: Unknown result type (might be due to invalid IL or missing references)
		//IL_212c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2150: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1640: Unknown result type (might be due to invalid IL or missing references)
		if (!movido)
		{
			xmas.transform.position = new Vector3(-1745.786f, 9.178814f, -169.0245f);
			xmas.transform.eulerAngles = new Vector3(90f, 0f, 0f);
			dices.transform.position = new Vector3(-1744.521f, 8.030682f, -172.2615f);
			dices.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			wishbonel.transform.position = new Vector3(-1739.627f, 6.818208f, -172.0768f);
			wishbonel.transform.eulerAngles = new Vector3(281.2497f, 182.2614f, 90f);
			spindlel.transform.position = new Vector3(-1740.05f, 6.8865f, -172.0297f);
			spindlel.transform.eulerAngles = new Vector3(358.813f, 224.731f, 287.4484f);
			strutl.transform.position = new Vector3(-1739.202f, 6.853555f, -172.3447f);
			strutl.transform.eulerAngles = new Vector3(0f, 181.97f, 270.0052f);
			brakefront[0].transform.position = new Vector3(-1738.83f, 6.758f, -171.9461f);
			brakefront[0].transform.eulerAngles = new Vector3(0f, 147.78f, 90.00056f);
			brakefront[1].transform.position = new Vector3(-1738.824f, 6.758f, -172.3011f);
			brakefront[1].transform.eulerAngles = new Vector3(0f, 147.78f, 90.00056f);
			wishboner.transform.position = new Vector3(-1739.585f, 6.82f, -172.1541f);
			wishboner.transform.eulerAngles = new Vector3(81.8726f, 0f, 90f);
			spindler.transform.position = new Vector3(-1740.05f, 6.88652f, -172.4624f);
			spindler.transform.eulerAngles = new Vector3(0f, 74.6988f, 72.5539f);
			strutr.transform.position = new Vector3(-1739.01f, 6.850445f, -171.9926f);
			strutr.transform.eulerAngles = new Vector3(0f, 0f, 270.0054f);
			traill.transform.position = new Vector3(-1738.534f, 6.82966f, -171.9533f);
			traill.transform.eulerAngles = new Vector3(281.415f, 179.504f, 179.958f);
			coil[0].transform.position = new Vector3(-1738.059f, 6.83697f, -171.6939f);
			coil[0].transform.eulerAngles = new Vector3(0f, 0f, 0f);
			coil[1].transform.position = new Vector3(-1738.031f, 6.83697f, -172.0581f);
			coil[1].transform.eulerAngles = new Vector3(0f, 0f, 0f);
			shock[0].transform.position = new Vector3(-1738.192f, 6.816997f, -171.8744f);
			shock[0].transform.eulerAngles = new Vector3(0f, 0f, 270.0214f);
			shock[1].transform.position = new Vector3(-1738.104f, 6.83697f, -172.2036f);
			shock[1].transform.eulerAngles = new Vector3(0f, 0f, 90f);
			brakerear[0].transform.position = new Vector3(-1737.796f, 6.83697f, -171.8182f);
			brakerear[0].transform.eulerAngles = new Vector3(0f, 270f, 90f);
			brakerear[1].transform.position = new Vector3(-1737.759f, 6.83697f, -172.1324f);
			brakerear[1].transform.eulerAngles = new Vector3(0f, 270f, 90f);
			muffler.transform.position = new Vector3(-1735.883f, 6.846948f, -168.4322f);
			muffler.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			trailr.transform.position = new Vector3(-1738.391f, 6.83697f, -172.0165f);
			trailr.transform.eulerAngles = new Vector3(72.69643f, 136.111f, 151.67f);
			pipe.transform.position = new Vector3(-1735.67f, 6.824451f, -170.3956f);
			pipe.transform.eulerAngles = new Vector3(283.98f, 262.46f, 270.0005f);
			fueltank.transform.position = new Vector3(-1736.187f, 6.946144f, -170.7863f);
			fueltank.transform.eulerAngles = new Vector3(270f, 11.2874f, 0f);
			pipe2.transform.position = new Vector3(-1736.252f, 6.87747f, -170.1238f);
			pipe2.transform.eulerAngles = new Vector3(351.61f, 258.83f, 143.2725f);
			bumperf.transform.position = new Vector3(-1736.035f, 6.83688f, -169.3895f);
			bumperf.transform.eulerAngles = new Vector3(346.321f, 268.43f, 179.991f);
			bumperr.transform.position = new Vector3(-1736.203f, 6.83716f, -169.3705f);
			bumperr.transform.eulerAngles = new Vector3(90f, 90f, 0f);
			fenderl.transform.position = new Vector3(-1737.345f, 7.04768f, -172.2972f);
			fenderl.transform.eulerAngles = new Vector3(297.4703f, 145.739f, 106.0065f);
			fenderr.transform.position = new Vector3(-1736.194f, 7.02667f, -172.3f);
			fenderr.transform.eulerAngles = new Vector3(312.569f, 180.684f, 263.133f);
			doorl.transform.position = new Vector3(-1735.988f, 7.1425f, -160.9836f);
			doorl.transform.eulerAngles = new Vector3(299.651f, 82.3803f, 90.039f);
			doorr.transform.position = new Vector3(-1735.904f, 7.1482f, -160.89f);
			doorr.transform.eulerAngles = new Vector3(296.001f, 86.95f, 270f);
			maletero.transform.position = new Vector3(-1736.456f, 6.8738f, -159.3987f);
			maletero.transform.eulerAngles = new Vector3(62.7857f, 355.9402f, 355.21f);
			capo.transform.position = new Vector3(-1737.618f, 6.86623f, -159.985f);
			capo.transform.eulerAngles = new Vector3(303.4569f, 175.746f, 181.095f);
			lightrl.transform.position = new Vector3(-1742.748f, 6.85202f, -172.7643f);
			lightrl.transform.eulerAngles = new Vector3(0f, 180.207f, 180.207f);
			lightrr.transform.position = new Vector3(-1742.74f, 6.85195f, -172.5058f);
			lightrr.transform.eulerAngles = new Vector3(0f, 0f, 180f);
			grille.transform.position = new Vector3(-1737.618f, 6.86623f, -159.985f);
			grille.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			lightfront[0].transform.position = new Vector3(-1742.751f, 6.86623f, -172.2558f);
			lightfront[0].transform.eulerAngles = new Vector3(0f, 141.81f, 0f);
			lightfront[1].transform.position = new Vector3(-1742.786f, 6.86623f, -172.0638f);
			lightfront[1].transform.eulerAngles = new Vector3(0f, 140.016f, 0f);
			hubcabfl.transform.position = new Vector3(-1743.056f, 6.86623f, -172.0872f);
			hubcabfl.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			hubcabfr.transform.position = new Vector3(-1743.062f, 6.86623f, -172.3167f);
			hubcabfr.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			hubcabrl.transform.position = new Vector3(-1743.073f, 6.86623f, -172.5112f);
			hubcabrl.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			hubcabrr.transform.position = new Vector3(-1743.077f, 6.86623f, -172.7759f);
			hubcabrr.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			bearing1.transform.position = new Vector3(-1745.892f, 7.95876f, -166.9269f);
			bearing1.transform.eulerAngles = new Vector3(90f, 90f, 0f);
			bearing2.transform.position = new Vector3(-1745.883f, 7.95876f, -166.9832f);
			bearing2.transform.eulerAngles = new Vector3(90f, 90f, 0f);
			bearing3.transform.position = new Vector3(-1745.88f, 7.958771f, -167.0377f);
			bearing3.transform.eulerAngles = new Vector3(90f, 90f, 0f);
			block.transform.position = new Vector3(-1745.993f, 6.867f, -168.4697f);
			block.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			cranck.transform.position = new Vector3(-1746.087f, 7.36135f, -168.4661f);
			cranck.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			piston1.transform.position = new Vector3(-1745.942f, 7.360644f, -166.7395f);
			piston1.transform.eulerAngles = new Vector3(0f, 250f, 180f);
			piston2.transform.position = new Vector3(-1745.934f, 7.360644f, -166.6645f);
			piston2.transform.eulerAngles = new Vector3(0f, 25f, 180f);
			piston3.transform.position = new Vector3(-1745.954f, 7.360644f, -166.5846f);
			piston3.transform.eulerAngles = new Vector3(0f, 250f, 180f);
			piston4.transform.position = new Vector3(-1745.947f, 7.360644f, -166.5082f);
			piston4.transform.eulerAngles = new Vector3(0f, 250f, 180f);
			camshaft.transform.position = new Vector3(-1746.002f, 7.343592f, -168.6825f);
			camshaft.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			camshaftgear.transform.position = new Vector3(-1745.739f, 7.34421f, -168.7353f);
			camshaftgear.transform.eulerAngles = new Vector3(0f, 90f, 90f);
			timingcover.transform.position = new Vector3(-1746.048f, 7.955256f, -166.055f);
			timingcover.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			timingchain.transform.position = new Vector3(-1745.983f, 7.334076f, -167.903f);
			timingchain.transform.eulerAngles = new Vector3(0f, 0f, 270f);
			waterpump.transform.position = new Vector3(-1745.768f, 7.975504f, -168.2651f);
			waterpump.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			waterpumppull.transform.position = new Vector3(-1745.897f, 7.988266f, -168.1179f);
			waterpumppull.transform.eulerAngles = new Vector3(90f, 288f, 0f);
			flywheel.transform.position = new Vector3(-1745.978f, 7.340743f, -169.0582f);
			flywheel.transform.eulerAngles = new Vector3(0f, 180f, 270f);
			clutchcover.transform.position = new Vector3(-1745.878f, 7.318644f, -168.8412f);
			clutchcover.transform.eulerAngles = new Vector3(0f, 180f, 270f);
			clutchdisc.transform.position = new Vector3(-1745.861f, 7.344934f, -168.6545f);
			clutchdisc.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			clutchpressure.transform.position = new Vector3(-1745.855f, 7.342987f, -168.4784f);
			clutchpressure.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			engineplate.transform.position = new Vector3(-1745.926f, 7.332136f, -168.2128f);
			engineplate.transform.eulerAngles = new Vector3(0f, 180f, 270f);
			gearbox.transform.position = new Vector3(-1746.006f, 6.932f, -167.0539f);
			gearbox.transform.eulerAngles = new Vector3(270f, 85f, 0f);
			cranckpulley.transform.position = new Vector3(-1745.754f, 7.347612f, -169.0353f);
			cranckpulley.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			drivegear.transform.position = new Vector3(-1745.876f, 7.34565f, -166.3616f);
			drivegear.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			oilpan.transform.position = new Vector3(-1745.942f, 6.90496f, -167.96f);
			oilpan.transform.eulerAngles = new Vector3(294.083f, 187.0783f, 90f);
			alternator.transform.position = new Vector3(-1745.824f, 7.9833f, -167.6556f);
			alternator.transform.eulerAngles = new Vector3(55f, 270f, 180f);
			starter.transform.position = new Vector3(-1746.069f, 7.973267f, -165.8068f);
			starter.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			gasket.transform.position = new Vector3(-1745.983f, 7.99677f, -168.7346f);
			gasket.transform.eulerAngles = new Vector3(74f, 183f, 270f);
			cylindro.transform.position = new Vector3(-1746.07f, 7.973269f, -167.094f);
			cylindro.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			rockershaft.transform.position = new Vector3(-1745.738f, 7.959727f, -168.9644f);
			rockershaft.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			rockercover.transform.position = new Vector3(-1745.996f, 7.983267f, -168.9946f);
			rockercover.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			distributor.transform.position = new Vector3(-1746.014f, 7.96055f, -168.3318f);
			distributor.transform.eulerAngles = new Vector3(0f, 30f, 80f);
			filter.transform.position = new Vector3(-1745.812f, 7.99955f, -168.433f);
			filter.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			fuelpump.transform.position = new Vector3(-1745.828f, 7.305645f, -167.8416f);
			fuelpump.transform.eulerAngles = new Vector3(270f, 296f, 0f);
			if ((Object)(object)bujia1 != (Object)null)
			{
				bujia1.transform.position = new Vector3(-1745.867f, 7.343144f, -167.0692f);
				bujia1.transform.eulerAngles = new Vector3(6f, 73f, 0f);
				bujia2.transform.position = new Vector3(-1745.882f, 7.343144f, -167.0191f);
				bujia2.transform.eulerAngles = new Vector3(6f, 73f, 0f);
				bujia3.transform.position = new Vector3(-1745.884f, 7.343144f, -166.9768f);
				bujia3.transform.eulerAngles = new Vector3(6f, 73f, 0f);
				bujia4.transform.position = new Vector3(-1745.891f, 7.343144f, -166.937f);
				bujia4.transform.eulerAngles = new Vector3(6f, 73f, 0f);
			}
			if ((Object)(object)wire != (Object)null)
			{
				wire.transform.position = new Vector3(-1745.963f, 7.978766f, -167.4201f);
				wire.transform.eulerAngles = new Vector3(90f, 0f, 0f);
			}
			headers.transform.position = new Vector3(-1745.871f, 7.99542f, -166.4559f);
			headers.transform.eulerAngles = new Vector3(0f, 120f, 180f);
			carburator.transform.position = new Vector3(-1745.812f, 8.58692f, -169.0311f);
			carburator.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			airfilter.transform.position = new Vector3(-1746.013f, 8.55986f, -168.994f);
			airfilter.transform.eulerAngles = new Vector3(270f, 0f, 0f);
			subframe.transform.position = new Vector3(-1735.624f, 6.86384f, -172.11f);
			subframe.transform.eulerAngles = new Vector3(90f, 0f, 0f);
			steeringrack.transform.position = new Vector3(-1739.535f, 6.8275f, -172.5822f);
			steeringrack.transform.eulerAngles = new Vector3(90f, 180f, 0f);
			steeringcolumn.transform.position = new Vector3(-1738.317f, 6.89351f, -172.5595f);
			steeringcolumn.transform.eulerAngles = new Vector3(60f, 170f, 85f);
			rodl.transform.position = new Vector3(-1739.821f, 6.821813f, -172.0531f);
			rodl.transform.eulerAngles = new Vector3(270f, 90f, 0f);
			rodr.transform.position = new Vector3(-1739.874f, 6.822059f, -172.3452f);
			rodr.transform.eulerAngles = new Vector3(0f, 270f, 0f);
			radiator.transform.position = new Vector3(-1746.198f, 6.95778f, -165.8848f);
			radiator.transform.eulerAngles = new Vector3(287f, 266f, 180f);
			hose1.transform.position = new Vector3(-1745.894f, 6.83073f, -165.9888f);
			hose1.transform.eulerAngles = new Vector3(292f, 156f, 226f);
			hose2.transform.position = new Vector3(-1746.087f, 6.82377f, -165.7103f);
			hose2.transform.eulerAngles = new Vector3(322f, 287f, 90f);
			hose3.transform.position = new Vector3(-1745.844f, 6.81424f, -165.8541f);
			hose3.transform.eulerAngles = new Vector3(39f, 88f, 277f);
			batery.transform.position = new Vector3(-1745.979f, 7.399796f, -166.0671f);
			batery.transform.eulerAngles = new Vector3(270f, 0f, 0f);
			electrics.transform.position = new Vector3(-1746.083f, 7.36329f, -167.4354f);
			electrics.transform.eulerAngles = new Vector3(290f, 75f, 180f);
			brakelining.transform.position = new Vector3(-1745.851f, 8.53991f, -166.6241f);
			brakelining.transform.eulerAngles = new Vector3(0f, 90f, 180f);
			clutchlining.transform.position = new Vector3(-1746.01f, 8.664768f, -166.1235f);
			clutchlining.transform.eulerAngles = new Vector3(90f, 264f, 0f);
			brakemaster.transform.position = new Vector3(-1745.789f, 8.56086f, -167.8749f);
			brakemaster.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			clutchmaster.transform.position = new Vector3(-1745.744f, 8.55798f, -167.697f);
			clutchmaster.transform.eulerAngles = new Vector3(0f, 0f, 270f);
			fuelstrainer.transform.position = new Vector3(-1745.849f, 8.571925f, -167.4334f);
			fuelstrainer.transform.eulerAngles = new Vector3(270f, 180f, 0f);
			gearlink.transform.position = new Vector3(-1745.817f, 6.802f, -168.7794f);
			gearlink.transform.eulerAngles = new Vector3(270f, 0f, 0f);
			halfshaft[0].transform.position = new Vector3(-1737.965f, 6.830926f, -172.0272f);
			halfshaft[0].transform.eulerAngles = new Vector3(0f, 270f, 0f);
			halfshaft[1].transform.position = new Vector3(-1737.916f, 6.82986f, -172.2132f);
			halfshaft[1].transform.eulerAngles = new Vector3(270f, 270f, 0f);
			clockgauge.transform.position = new Vector3(-1745.786f, 8.57745f, -168.2355f);
			clockgauge.transform.eulerAngles = new Vector3(270f, 264f, 180f);
			dashboardmeter.transform.position = new Vector3(-1745.453f, 6.903888f, -172.6134f);
			dashboardmeter.transform.eulerAngles = new Vector3(0f, 180f, 180f);
			dashboard.transform.position = new Vector3(-1744.448f, 6.92114f, -172.5101f);
			dashboard.transform.eulerAngles = new Vector3(270f, 0f, 0f);
			seatd.transform.position = new Vector3(-1746.071f, 6.89119f, -162.2536f);
			seatd.transform.eulerAngles = new Vector3(270f, 90f, 180f);
			seatp.transform.position = new Vector3(-1746.05f, 6.86669f, -161.7898f);
			seatp.transform.eulerAngles = new Vector3(270f, 270f, 0f);
			seatr.transform.position = new Vector3(-1746.138f, 6.89598f, -160.6543f);
			seatr.transform.eulerAngles = new Vector3(270f, 90f, 180f);
			steeringwheel.transform.position = new Vector3(-1745.439f, 8.01196f, -172.3372f);
			steeringwheel.transform.eulerAngles = new Vector3(270f, 0f, 0f);
			gearstick.transform.position = new Vector3(-1745.948f, 6.837006f, -167.2377f);
			gearstick.transform.eulerAngles = new Vector3(0f, 180f, 270f);
			handbrake.transform.position = new Vector3(-1746.114f, 6.825025f, -163.5207f);
			handbrake.transform.eulerAngles = new Vector3(0f, 90f, 270f);
			radio.transform.position = new Vector3(-1745.058f, 8.0137f, -172.3271f);
			radio.transform.eulerAngles = new Vector3(270f, 0f, 0f);
			backpanel.transform.position = new Vector3(-1744.428f, 7.40465f, -159.9755f);
			backpanel.transform.eulerAngles = new Vector3(344.514f, 168f, 271.2409f);
			woferpanel.transform.position = new Vector3(-1743.982f, 7.41468f, -159.906f);
			woferpanel.transform.eulerAngles = new Vector3(348.628f, 170f, 270.878f);
			inspectioncover.transform.position = new Vector3(-1745.926f, 7.349169f, -167.0937f);
			inspectioncover.transform.eulerAngles = new Vector3(0f, 272f, 270f);
			gbarros1.transform.position = new Vector3(-1741.982f, 7.41468f, -159.906f);
			gbarros1.transform.eulerAngles = new Vector3(348.628f, 170f, 270.878f);
			gbarros2.transform.position = new Vector3(-1741.982f, 7.41468f, -159.906f);
			gbarros2.transform.eulerAngles = new Vector3(348.628f, 170f, 270.878f);
			gbarros3.transform.position = new Vector3(-1741.982f, 7.41468f, -159.906f);
			gbarros3.transform.eulerAngles = new Vector3(348.628f, 170f, 270.878f);
			gbarros4.transform.position = new Vector3(-1741.982f, 7.41468f, -159.906f);
			gbarros4.transform.eulerAngles = new Vector3(348.628f, 170f, 270.878f);
		}
	}

	public TodoItemBehaviour()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
	}
}
