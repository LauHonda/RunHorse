﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetststr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string str="[[340.56,330,336.36,330,331,335.16,333,330,331,335],[351.12,334,346.72,336,335,343.32,340,337,340,342],[361.68,337,358.08,341,340,352.48,343,345,343,351],[372.24,344,369.44,349,344,361.64,347,353,348,357],[382.8,352,378.8,357,352,370.8,354,358,357,364],[393.36,355,388.16,362,355,378.96,358,365,362,369],[403.92,360,397.52,370,359,387.12,361,373,368,376],[415.48,364,406.88,378,362,395.28,368,381,372,380],[429.04,369,418.24,384,367,406.44,376,389,381,389],[440.6,374,427.6,389,375,415.6,383,396,385,398],[451.16,378,436.96,392,379,426.76,388,404,394,406],[461.72,385,446.32,400,387,434.92,391,412,401,412],[472.28,389,455.68,407,391,446.08,396,421,406,419],[485.84,393,465.04,410,397,454.24,401,430,413,425],[497.4,396,474.4,415,402,462.4,404,434,418,428],[507.96,403,483.76,420,405,470.56,407,440,425,434],[518.52,408,494.12,429,409,481.72,411,444,428,438],[531.08,412,503.48,437,418,491.88,414,453,432,445],[541.64,421,512.84,441,421,502.04,422,457,440,451],[552.2,424,525.2,444,429,510.2,427,464,447,458]]";
		str = str.Replace("[[", string.Empty).Replace("],[","*");

		string[] Posstr=str.Split(new char[1]{'*'});
		foreach(string child in Posstr)
		{
			Debug.Log(child);
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
