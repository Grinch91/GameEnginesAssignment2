using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace BGE.Scenarios
{
	public class BattleScene : Scenario {

		public GameObject hleader;
		public GameObject hfLeader;
		public GameObject ofLeader;
		public GameObject gLeader;
		public GameObject aLeader;
		public GameObject stargate;
		public GameObject camera;
		public GameObject target;
		public float timer = 0.0f;
		public Path path1;

		private bool sceneEnd = false;

		public override string Description()
		{
			return "Battle Scene script";
		}

		public Vector3 initialPos = Vector3.zero;
		// Use this for initialization
		public override void Start () {
		
			//Allied fleet creates
			Params.Load("MyBattle.txt");
			stargate = CreateBoid(new Vector3(10,10,10),stargatePrefab);
			hleader = CreateBoid(new Vector3(0,30,200),humanleaderPrefab);
			hleader = CreateBoid(new Vector3(-15,30,210),humanleaderPrefab);

			gLeader = CreateBoid(new Vector3(0,10,200),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(30,10,200),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(30,30,190),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(0,40,190),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(-25,20,200),goauldleaderPrefab);

			aLeader = CreateBoid(new Vector3(10,25,200),asgardPrefab);

			//Reinforcement fleet creates
			gLeader = CreateBoid(new Vector3(-85,400,-315),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(-70,400,-310),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(-60,400,-320),goauldleaderPrefab);
			gLeader = CreateBoid(new Vector3(-70,400,-300),goauldleaderPrefab);

			//Ori fleet creates
			/*oLeader = CreateBoid(new Vector3(-2,20,-30),orileaderPrefab);
			oLeader = CreateBoid(new Vector3(-2,20,-60),orileaderPrefab);
			oLeader = CreateBoid(new Vector3(-2,20,0),orileaderPrefab);*/

			camera = GameObject.Find("sceneCamera");
			camera.transform.position = new Vector3 (110,25,180);
			//camera = CreateBoid(new Vector3(110,25,180), camFighter);
			
			//camera = GameObject.FindGameObjectWithTag("sceneCamera");
			//camera.renderer.enabled = false;
			if(initialPos == Vector3.zero)
			{
				initialPos = camera.transform.position;
			}
			path1 = camera.GetComponent<SteeringBehaviours>().path;
			camera.GetComponent<SteeringBehaviours>().path.Waypoints.Add (initialPos);
			path1.Waypoints.Add(initialPos - new Vector3(70,0,20));
			path1.Waypoints.Add(initialPos - new Vector3(90,-5,30));
			path1.Waypoints.Add(initialPos - new Vector3(140,-5,0));
			path1.Waypoints.Add(initialPos - new Vector3(110,-5,-40));
			path1.Waypoints.Add(initialPos - new Vector3(110,-8,-20));
			path1.Looped=false;
			path1.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			camera.GetComponent<SteeringBehaviours>().TurnOffAll();
			camera.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			//CreateCamFollower(camera,new Vector3(120,25,180));
			
			//Put in components you want each thing to have, so seekTargetPosition, etc.
			//hleader.GetComponent<SteeringBehaviours>();
		}

		public void Update()
		{
			timer = timer + Time.deltaTime;
			Debug.Log (timer);
			if(timer == 35.0f)
			{

			}
			
			if(timer == 35.01f)
			{
				camera.transform.position = new Vector3(-20,25,12);
				timer = timer + Time.deltaTime;
			}

		}

	}
}
