//Maya ASCII 2018 scene
//Name: Prototype 3 structure.ma
//Last modified: Wed, Mar 06, 2019 12:45:57 AM
//Codeset: 936
requires maya "2018";
requires "stereoCamera" "10.0";
currentUnit -l meter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2018";
fileInfo "version" "2018";
fileInfo "cutIdentifier" "201706261615-f9658c4cfc";
fileInfo "osv" "Microsoft Windows 8 Enterprise Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -s -n "persp";
	rename -uid "0248D08B-449B-2D11-0F22-B08BDCDD9A4F";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 3.5571109398158449 6.9104965644921519 -0.87491454491226239 ;
	setAttr ".r" -type "double3" -36.938352742307977 5086.1999999990585 -4.595226539075202e-15 ;
	setAttr ".rp" -type "double3" -3.5527136788005011e-16 2.8421709430404008e-16 1.1368683772161603e-15 ;
	setAttr ".rpt" -type "double3" -4.6626893167029264e-16 1.9128134687582858e-15 -4.8407534895701487e-16 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "72AEC792-4619-467D-60BB-41873EA99DF7";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.107008971590213;
	setAttr ".ow" 0.1;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" -120.1733229477508 89.140463380459551 -444.35440159153575 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
	setAttr ".ai_translator" -type "string" "perspective";
createNode transform -s -n "top";
	rename -uid "96E61708-4C3C-6F68-D145-7389DAD4DB30";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0.20770535557025718 10.001000000000003 -7.0203625986415457 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "F54B113E-4214-9301-D909-34981D264189";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.001000000000001;
	setAttr ".ow" 1.0510268419079523;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "2E84A902-497C-77FA-219E-6490488A8A93";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -3.0797469517884046 0.987475529742744 10.001000000000001 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "557D30E2-4EAF-BE87-28BB-36838AD059AC";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.001000000000001;
	setAttr ".ow" 1.9517779423239265;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "CA4BF497-447A-104C-5547-D89BAE06E500";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 10.001000000000003 1.1680760633614677 -7.1280945444335275 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "7CD12AF4-4767-CB57-DB2F-33B0BC391922";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".ncp" 0.001;
	setAttr ".fcp" 100;
	setAttr ".fd" 0.05;
	setAttr ".coi" 10.001000000000001;
	setAttr ".ow" 1.5262976890709683;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "no_door";
	rename -uid "2EEEBA55-4612-3A82-A247-F0B4D6EB44F1";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0.075792232853498342 0 -3.4784428447012541 ;
	setAttr ".s" -type "double3" 91.350690177888609 91.350690177888609 91.350690177888609 ;
createNode transform -n "pCube2" -p "no_door";
	rename -uid "315FBE5E-4BD0-CAA7-1B5A-ACB771972581";
	setAttr ".t" -type "double3" 0 0.00979850528688808 -0.0051949671701471316 ;
	setAttr ".r" -type "double3" 90 0 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape2" -p "|no_door|pCube2";
	rename -uid "941387FF-4515-02E8-463E-119C3731A18D";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.625 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -0.00037034217 5.551115e-19 
		-3.4874677e-06 0 5.551115e-19 -3.4874677e-06 -0.00037034217 -7.6763034e-05 -3.4874677e-06 
		0 -7.6763034e-05 -3.4874677e-06 -0.00037034217 -7.6763034e-05 -0.00043876425 0 -7.6763034e-05 
		-0.00043876425 -0.00037034217 0 -0.00043876425 0 0 -0.00043876425;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube3" -p "no_door";
	rename -uid "021078F0-48F2-AA7E-AA14-56AC79BA27E5";
	setAttr ".t" -type "double3" -0.0051723359931077819 0.0097954899616662303 -1.8651117265899853e-05 ;
	setAttr ".r" -type "double3" 90 90 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape3" -p "pCube3";
	rename -uid "D6B86057-4E4D-13DB-8C07-E481B23E1101";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.625 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  0 0 -6.5028294e-06 -1.8651188e-05 
		0 -6.5028294e-06 0 -0.00064822286 -6.5028294e-06 -1.8651188e-05 -0.00064822286 -6.5028294e-06 
		0 -0.00064822286 -0.00044177947 -1.8651188e-05 -0.00064822286 -0.00044177947 0 2.220446e-18 
		-0.00044177947 -1.8651188e-05 2.220446e-18 -0.00044177947;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube1" -p "no_door";
	rename -uid "7878D792-4AEB-1E5C-A8AB-70A9C223B1D3";
	setAttr ".t" -type "double3" 0 0.005 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape1" -p "|no_door|pCube1";
	rename -uid "6F11AB55-479B-1BA7-906A-16BC3858DB63";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "left_door";
	rename -uid "8F522F6E-4605-6069-0FA5-3C8A0D0C94E5";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0.010420073796035182 0 1.6260903298120426 ;
	setAttr ".s" -type "double3" 91.350690177888609 91.350690177888609 91.350690177888609 ;
createNode transform -n "left_foor_pCube3" -p "left_door";
	rename -uid "BD5224B2-42CB-8455-1086-BA83C262CA67";
	setAttr ".t" -type "double3" -0.010420073796035182 0 -0.015043726729912475 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube3Shape" -p "|left_door|left_foor_pCube3";
	rename -uid "796717C6-4F2C-19B9-4B33-2EB89AEC94E9";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube2" -p "left_door";
	rename -uid "A1AC784E-4427-25B7-BAF5-58A2C3E31EC0";
	setAttr ".t" -type "double3" 0 0.00979850528688808 -0.0051949671701471316 ;
	setAttr ".r" -type "double3" 90 0 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape2" -p "|left_door|pCube2";
	rename -uid "0AAFBE3E-47E2-EDE3-B1D1-108E7D35DC0A";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.625 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -0.00037034217 5.551115e-19 
		-3.4874677e-06 0 5.551115e-19 -3.4874677e-06 -0.00037034217 -7.6763034e-05 -3.4874677e-06 
		0 -7.6763034e-05 -3.4874677e-06 -0.00037034217 -7.6763034e-05 -0.00043876425 0 -7.6763034e-05 
		-0.00043876425 -0.00037034217 0 -0.00043876425 0 0 -0.00043876425;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube1" -p "left_door";
	rename -uid "40EBCED1-4DB2-6CF8-8B7B-27895FCBC5CF";
	setAttr ".t" -type "double3" 0 0.005 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape1" -p "|left_door|pCube1";
	rename -uid "C54EA020-4A3E-DAB6-3DD9-3A9E454F693A";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "right_door";
	rename -uid "0802F1EB-496B-1461-6F6F-2DA45945F96D";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.0018800494867178363 0 -1.7537657144652792 ;
	setAttr ".r" -type "double3" 0 90 0 ;
	setAttr ".s" -type "double3" 91.350690177888609 91.350690177888609 91.350690177888609 ;
createNode transform -n "pCube1" -p "right_door";
	rename -uid "C0057FCF-4600-C5D9-750D-B3B39B928CA0";
	setAttr ".t" -type "double3" 0 0.005 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape1" -p "|right_door|pCube1";
	rename -uid "E2757834-42AA-499E-77B0-F99DDC4AB70E";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "group1" -p "right_door";
	rename -uid "E2063ADC-4BCB-EF90-1F94-DD86A92CDA39";
	setAttr ".s" -type "double3" -1 1 1 ;
createNode transform -n "left_foor_pCube3" -p "|right_door|group1";
	rename -uid "FFB5945F-4827-B33A-54C9-9CBED65EC2FC";
	setAttr ".t" -type "double3" -0.010420073796035182 0 -0.015043726729912475 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube3Shape" -p "|right_door|group1|left_foor_pCube3";
	rename -uid "04DB3BC8-4D4A-3374-92EF-D6B986CCB6C8";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.125 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube2" -p "|right_door|group1";
	rename -uid "FBC40668-40FF-CF53-2C43-ECAD790CFDD6";
	setAttr ".t" -type "double3" 0 0.00979850528688808 -0.0051949671701471316 ;
	setAttr ".r" -type "double3" 89.999999999999986 0 0 ;
	setAttr ".s" -type "double3" 1 0.039601414832774982 1 ;
createNode mesh -n "pCubeShape2" -p "|right_door|group1|pCube2";
	rename -uid "78F3CA42-44D7-3F31-D127-59B487884A20";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.625 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -0.00037034217 5.551115e-19 
		-3.4874677e-06 0 5.551115e-19 -3.4874677e-06 -0.00037034217 -7.6763034e-05 -3.4874677e-06 
		0 -7.6763034e-05 -3.4874677e-06 -0.00037034217 -7.6763034e-05 -0.00043876425 0 -7.6763034e-05 
		-0.00043876425 -0.00037034217 0 -0.00043876425 0 0 -0.00043876425;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "both_door";
	rename -uid "A269A263-45F4-4F11-B067-87A475AA7658";
	setAttr ".t" -type "double3" -3.8452288337435556 0 -2.8339943651100028 ;
	setAttr ".r" -type "double3" 0 90 0 ;
	setAttr ".s" -type "double3" 91.350690177888609 91.350690177888609 91.350690177888609 ;
createNode transform -n "pCube1" -p "both_door";
	rename -uid "CB567E97-4DB7-E3AC-3692-FD9F15382A04";
	setAttr ".t" -type "double3" 0 0.005 0 ;
	setAttr ".s" -type "double3" 1.2 0.039601414832774982 1.2 ;
createNode mesh -n "pCubeShape1" -p "|both_door|pCube1";
	rename -uid "E0A2C74A-49C8-300E-9A2A-6680635EF5E3";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "group1" -p "both_door";
	rename -uid "4A8C0C8F-4AAF-7056-4C7B-94AABD5369E6";
	setAttr ".s" -type "double3" -1 1 1 ;
createNode transform -n "left_foor_pCube3" -p "|both_door|group1";
	rename -uid "A090B8E4-4606-D83B-0BC5-999B035C3C66";
	setAttr ".t" -type "double3" -0.011041840026364822 0.00037854223511354706 -0.014054152319039457 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube3Shape" -p "|both_door|group1|left_foor_pCube3";
	rename -uid "EFCAF47D-4230-704A-CD82-03B2E0AF6A79";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.46677987277507782 0.54965412616729736 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".pt[0:15]" -type "float3"  -7.8907233e-06 1.7472104e-05 
		0 -7.8907233e-06 1.7472134e-05 -0.0016376388 0 1.7472104e-05 -0.0016376388 0 1.7472104e-05 
		0 -7.8907233e-06 0.00019140795 -0.0016376388 -1.110223e-18 0.00019140793 -0.0016376388 
		-7.8907233e-06 -0.00064363069 0 -4.7683715e-09 -0.00064363069 0 -7.8907233e-06 1.7472104e-05 
		0 -7.8907233e-06 1.7472104e-05 0 0 1.7472104e-05 0 0 1.7472104e-05 0 -4.7683715e-09 
		-0.00064363069 0 -7.8907233e-06 -0.00064363069 0 -7.8907233e-06 0.00019140793 0 -1.110223e-18 
		0.00019140793 0;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "left_foor_pCube4" -p "|both_door|group1";
	rename -uid "1CF20F98-48BF-6B6C-1525-79BCB4316992";
	setAttr ".t" -type "double3" -0.0085856429863365603 0.00056994954134766595 -0.019971371943931584 ;
	setAttr ".r" -type "double3" 0 90 0 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube4Shape" -p "|both_door|group1|left_foor_pCube4";
	rename -uid "6EC62540-4550-C956-AF51-5EAE6699576D";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.46677987277507782 0.54965412616729736 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".pt[0:15]" -type "float3"  2.1075606e-05 -0.00017393529 
		0.0051733241 2.1075606e-05 -0.00017393529 0.0032166054 2.6678667e-06 -0.00017393529 
		0.0032166054 2.6678667e-06 -0.00017393529 0.0051733241 2.1075606e-05 0 0.0032166054 
		2.6678667e-06 0 0.0032166054 2.1075606e-05 -0.00083503441 0.0051733241 2.6678667e-06 
		-0.00083503441 0.0051733241 2.1075606e-05 -0.00017393529 0.0052352552 2.1075606e-05 
		-0.00017393529 0.0051733241 2.6678667e-06 -0.00017393529 0.0051733241 2.6678667e-06 
		-0.00017393529 0.0052352552 2.6678667e-06 -0.00083503441 0.0051733241 2.1075606e-05 
		-0.00083503441 0.0051733241 2.1075606e-05 0 0.0052352552 2.6678667e-06 0 0.0052352552;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "upper_large_room";
	rename -uid "32B98AFE-4B91-9DFA-840F-9A94B13278F8";
	setAttr ".t" -type "double3" -2.5859604454162146 0 -5.2881007370937141 ;
	setAttr ".r" -type "double3" 0 90 0 ;
	setAttr ".s" -type "double3" 91.350690177888609 91.350690177888609 91.350690177888609 ;
createNode transform -n "group1" -p "upper_large_room";
	rename -uid "F228969C-4D62-6E90-1229-3AB349A46754";
	setAttr ".s" -type "double3" -1 1 1 ;
createNode transform -n "left_foor_pCube3" -p "|upper_large_room|group1";
	rename -uid "6E35AF5E-4017-9F31-AF82-BE88A004612D";
	setAttr ".t" -type "double3" -0.011042116844144099 0.00037854223511354706 -0.0020205068836865411 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube3Shape" -p "|upper_large_room|group1|left_foor_pCube3";
	rename -uid "043D7054-4631-D74F-0DC7-DEA7830A2E8C";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr -s 2 ".ciog[0].cog";
	setAttr ".pv" -type "double2" 0.75 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".pt[0:15]" -type "float3"  -7.8907233e-06 1.7472104e-05 
		0 -7.8907233e-06 1.7472134e-05 -0.0020169646 0 1.7472104e-05 -0.0020169646 0 1.7472104e-05 
		0 -7.8907233e-06 0.00019140795 -0.0020169646 -1.110223e-18 0.00019140793 -0.0020169646 
		-7.8907233e-06 -0.00064363069 0 -4.7683715e-09 -0.00064363069 0 -7.8907233e-06 1.7472104e-05 
		0 -7.8907233e-06 1.7472104e-05 0 0 1.7472104e-05 0 0 1.7472104e-05 0 -4.7683715e-09 
		-0.00064363069 0 -7.8907233e-06 -0.00064363069 0 -7.8907233e-06 0.00019140793 0 -1.110223e-18 
		0.00019140793 0;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "left_foor_pCube4" -p "|upper_large_room|group1";
	rename -uid "ED6240AE-4092-D85C-51EF-AA9ADD81F894";
	setAttr ".t" -type "double3" 0.0034202625280806351 0.00056994954134765977 -0.019966810340061491 ;
	setAttr ".r" -type "double3" 0 90 0 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube4Shape" -p "|upper_large_room|group1|left_foor_pCube4";
	rename -uid "F49BB7B0-42DC-9BA1-2A03-83908C0AEAA5";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr -s 2 ".ciog[0].cog";
	setAttr ".pv" -type "double2" 0.46677987277507782 0.54965412616729736 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".pt[0:15]" -type "float3"  2.1075606e-05 -0.00017393529 
		0.0051733241 2.1075606e-05 -0.00017393529 0.0032166054 2.6678667e-06 -0.00017393529 
		0.0032166054 2.6678667e-06 -0.00017393529 0.0051733241 2.1075606e-05 0 0.0032166054 
		2.6678667e-06 0 0.0032166054 2.1075606e-05 -0.00083503441 0.0051733241 2.6678667e-06 
		-0.00083503441 0.0051733241 2.1075606e-05 -0.00017393529 0.0052352552 2.1075606e-05 
		-0.00017393529 0.0051733241 2.6678667e-06 -0.00017393529 0.0051733241 2.6678667e-06 
		-0.00017393529 0.0052352552 2.6678667e-06 -0.00083503441 0.0051733241 2.1075606e-05 
		-0.00083503441 0.0051733241 2.1075606e-05 0 0.0052352552 2.6678667e-06 0 0.0052352552;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube7" -p "upper_large_room";
	rename -uid "832D1132-4D16-9295-D3B8-519136C46ED5";
	setAttr ".t" -type "double3" -0.057887912251085485 0 0.028308055914854441 ;
	setAttr ".r" -type "double3" 0 -89.999999999999986 0 ;
	setAttr ".s" -type "double3" 0.010946824791938458 0.010946824791938458 0.010946824791938458 ;
	setAttr ".rp" -type "double3" -0.022302239350347603 0.0050000002228529541 -0.051887849193893061 ;
	setAttr ".rpt" -type "double3" 0.074190088544241806 0 0.029585609843545361 ;
	setAttr ".sp" -type "double3" -2.0373249571667196 0.4567534712472141 -4.739990835708384 ;
	setAttr ".spt" -type "double3" 2.0150227178163722 -0.4517534710243612 4.6881029865144903 ;
createNode mesh -n "pCube7Shape" -p "|upper_large_room|pCube7";
	rename -uid "F2715BB5-4310-E77B-8E0A-639EB5FF15EF";
	setAttr -k off ".v";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:8]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.75 0.25 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 29 ".uvst[0].uvsp[0:28]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.75 0.375 1 0.625 1 0.875 0 0.875 0.25 0.125 0 0.125
		 0.25 0.625 0.25 0.375 0.5 0.375 0.75 0.625 1 0.125 0 0.375 0 0.625 0 0.625 0.25 0.375
		 0.25 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[4:10]" -type "float3"  0 -9.536743e-09 0 0 3.8146972e-08 
		0 0 0 0 0 -1.9073486e-08 0 0 -3.8146972e-08 0 0 -7.6293944e-08 0 -2.3841858e-08 0 
		0;
	setAttr -s 14 ".vt[0:13]"  -0.94107664 0.43866539 -4.73999643 -0.94107664 0.43866539 -5.83620501
		 -0.94107664 0.47484154 -4.73999643 -0.94107664 0.47484154 -5.83620501 -2.037311792 0.47484154 -4.73999262
		 -2.037284851 0.47484156 -5.83620501 -2.037311792 0.43866539 -4.73999262 -2.037284851 0.43866539 -5.83620501
		 -3.13357329 0.47484151 -4.73998499 -3.13357329 0.4386653 -4.73998499 -2.03736496 0.43866539 -3.64377666
		 -2.03736496 0.47484154 -3.64377666 -3.13357329 0.47484154 -3.64377666 -3.13357329 0.43866539 -3.64377666;
	setAttr -s 21 ".ed[0:20]"  0 1 0 2 3 0 0 2 0 1 3 0 2 4 0 3 5 0 4 6 0
		 5 7 0 6 0 0 7 1 0 8 9 0 5 8 0 7 9 0 10 6 0 11 4 0 12 8 0 13 9 0 10 11 0 11 12 0 12 13 0
		 13 10 0;
	setAttr -s 9 -ch 42 ".fc[0:8]" -type "polyFaces" 
		f 4 0 3 -2 -3
		mu 0 4 0 1 3 2
		f 4 -10 -8 -6 -4
		mu 0 4 1 8 9 3
		f 4 8 2 4 6
		mu 0 4 10 0 2 11
		f 4 -11 -12 7 12
		mu 0 4 16 13 12 15
		f 4 13 -7 -15 -18
		mu 0 4 17 18 19 20
		f 7 -16 -19 14 -5 1 5 11
		mu 0 7 21 22 20 4 2 3 12
		f 4 15 10 -17 -20
		mu 0 4 22 21 23 24
		f 7 -14 -21 16 -13 9 -1 -9
		mu 0 7 25 26 24 14 5 7 6
		f 4 20 17 18 19
		mu 0 4 27 17 20 28;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube6" -p "upper_large_room";
	rename -uid "63B21176-4C5D-A4C6-923D-2A8606D2C540";
	setAttr ".t" -type "double3" 0.0044777501729478756 0.0091952575962032535 -0.0048205469131954717 ;
	setAttr ".r" -type "double3" 89.999999999999986 -45 0 ;
	setAttr ".s" -type "double3" 1.2 0.039601414832774982 1.2 ;
createNode mesh -n "pCubeShape6" -p "pCube6";
	rename -uid "AAC97814-4678-C03C-DCDA-74B6D683D68F";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.375 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -0.0018698662 0.17121349 
		-0.0016689579 0.0022769142 0.17113331 -0.0016689581 -0.0016624857 0.16749755 -0.0016689579 
		0.0020540371 0.16788693 -0.0016689579 -0.0016624862 0.16749752 -0.00050996838 0.0020540371 
		0.16788693 -0.00050996919 -0.0018698657 0.17121349 -0.00050996779 0.0022769137 0.17113332 
		-0.0005099696;
	setAttr -s 8 ".vt[0:7]"  -0.0049999999 -0.0049999999 0.0049999999
		 0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999 0.0049999999
		 -0.0049999999 0.0049999999 -0.0049999999 0.0049999999 0.0049999999 -0.0049999999
		 -0.0049999999 -0.0049999999 -0.0049999999 0.0049999999 -0.0049999999 -0.0049999999;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "lower_large_room1";
	rename -uid "30D37A16-424B-18FB-F6C7-92831F1F2C21";
	setAttr ".t" -type "double3" 0.86412508635685059 0 -6.6557459472287883 ;
	setAttr ".r" -type "double3" 0 -90 0 ;
	setAttr ".s" -type "double3" 91.350690177888609 91.350690177888609 91.350690177888609 ;
createNode transform -n "group1" -p "lower_large_room1";
	rename -uid "D36C9E0F-4548-72ED-8A4C-A585B2DF34FD";
	setAttr ".s" -type "double3" -1 1 1 ;
createNode transform -n "left_foor_pCube3" -p "|lower_large_room1|group1";
	rename -uid "C128F9E6-48BA-6398-60E7-58860D6C0324";
	setAttr ".t" -type "double3" -0.0053700060306008492 0.00037854223511354706 0.0019119032333547656 ;
	setAttr ".r" -type "double3" 0 -90 0 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube3Shape" -p "|lower_large_room1|group1|left_foor_pCube3";
	rename -uid "A48BEA41-455C-2AF8-8D89-248D214FF309";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr -s 2 ".ciog[0].cog";
	setAttr ".pv" -type "double2" 0.5 0.3609125018119812 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".pt[0:15]" -type "float3"  -7.8907233e-06 1.7472104e-05 
		0 -7.8907233e-06 1.7472134e-05 -0.0020169646 0 1.7472104e-05 -0.0020169646 0 1.7472104e-05 
		0 -7.8907233e-06 0.00019140795 -0.0020169646 -1.110223e-18 0.00019140793 -0.0020169646 
		-7.8907233e-06 -0.00064363069 0 -4.7683715e-09 -0.00064363069 0 -7.8907233e-06 1.7472104e-05 
		0 -7.8907233e-06 1.7472104e-05 0 0 1.7472104e-05 0 0 1.7472104e-05 0 -4.7683715e-09 
		-0.00064363069 0 -7.8907233e-06 -0.00064363069 0 -7.8907233e-06 0.00019140793 0 -1.110223e-18 
		0.00019140793 0;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "left_foor_pCube4" -p "|lower_large_room1|group1";
	rename -uid "9C728CA4-46D3-4154-8E0C-6E805C5A4F7C";
	setAttr ".t" -type "double3" 0.01434976998005197 0.00056994954134765815 -0.01080552752553041 ;
	setAttr ".r" -type "double3" 0 180 0 ;
	setAttr ".rp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
	setAttr ".sp" -type "double3" 0.0043597124516963964 0.0096201676130294803 0.015034402012825012 ;
createNode mesh -n "left_foor_pCube4Shape" -p "|lower_large_room1|group1|left_foor_pCube4";
	rename -uid "516AB806-41CD-F144-6A65-C9B1029E5309";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr -s 2 ".ciog[0].cog";
	setAttr ".pv" -type "double2" 0.46677987277507782 0.54965412616729736 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.46748561 0 0.625
		 0 0.625 0.25 0.46748561 0.25 0.875 0 0.875 0.25 0.52365607 0.5 0.52365607 0.72182494
		 0.53635269 0.721825 0.53635269 0.5 0.375 0 0.39720705 0 0.39720705 0.25 0.375 0.25
		 0.53635269 0.25 0.53635269 0.028175011 0.52365607 0.028175011 0.52365607 0.25 0.125
		 0 0.125 0.25 0.375 0.5 0.625 0.5 0.625 0.75 0.375 0.75 0.625 1 0.46748561 1 0.46748561
		 0.84930825 0.39720705 0.84930825 0.39720705 1 0.375 1 0.39720705 0.40069175 0.46748561
		 0.40069175;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 16 ".pt[0:15]" -type "float3"  2.1075606e-05 -0.00017393529 
		0.0051733241 2.1075606e-05 -0.00017393529 0.0032166054 2.6678667e-06 -0.00017393529 
		0.0032166054 2.6678667e-06 -0.00017393529 0.0051733241 2.1075606e-05 0 0.0032166054 
		2.6678667e-06 0 0.0032166054 2.1075606e-05 -0.00083503441 0.0051733241 2.6678667e-06 
		-0.00083503441 0.0051733241 2.1075606e-05 -0.00017393529 0.0052352552 2.1075606e-05 
		-0.00017393529 0.0051733241 2.6678667e-06 -0.00017393529 0.0051733241 2.6678667e-06 
		-0.00017393529 0.0052352552 2.6678667e-06 -0.00083503441 0.0051733241 2.1075606e-05 
		-0.00083503441 0.0051733241 2.1075606e-05 0 0.0052352552 2.6678667e-06 0 0.0052352552;
	setAttr -s 16 ".vt[0:15]"  0.0050497307 0.0048019928 0.016332552 0.0050497307 0.0048019928 0.010043727
		 0.0054200743 0.0048019928 0.010043727 0.0054200743 0.0048019928 0.016332552 0.0050497307 0.015237269 0.010043727
		 0.0054200743 0.015237269 0.010043727 0.0050497307 0.011092033 0.016332552 0.0054200743 0.011092033 0.016332552
		 0.0050497307 0.0048019928 0.020025076 0.0050497307 0.0048019928 0.019138452 0.0054200743 0.0048019928 0.019138452
		 0.0054200743 0.0048019928 0.020025076 0.0054200743 0.011092033 0.019138452 0.0050497307 0.011092033 0.019138452
		 0.0050497307 0.015237269 0.020025076 0.0054200743 0.015237269 0.020025076;
	setAttr -s 24 ".ed[0:23]"  0 1 0 1 2 0 2 3 0 3 0 0 1 4 0 4 5 0 5 2 0
		 6 0 0 3 7 0 7 6 0 8 9 0 9 10 0 10 11 0 11 8 0 12 10 0 9 13 0 13 12 0 13 6 0 7 12 0
		 14 8 0 11 15 0 15 14 0 15 5 0 4 14 0;
	setAttr -s 10 -ch 48 ".fc[0:9]" -type "polyFaces" 
		f 4 0 1 2 3
		mu 0 4 0 1 2 3
		f 4 4 5 6 -2
		mu 0 4 1 4 5 2
		f 4 7 -4 8 9
		mu 0 4 6 7 8 9
		f 4 10 11 12 13
		mu 0 4 10 11 12 13
		f 4 14 -12 15 16
		mu 0 4 14 15 16 17
		f 4 17 -10 18 -17
		mu 0 4 17 6 9 14
		f 4 19 -14 20 21
		mu 0 4 18 10 13 19
		f 4 22 -6 23 -22
		mu 0 4 20 21 22 23
		f 8 -24 -5 -1 -8 -18 -16 -11 -20
		mu 0 8 23 22 24 25 26 27 28 29
		f 8 -13 -15 -19 -9 -3 -7 -23 -21
		mu 0 8 13 12 30 31 3 2 21 20;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".dr" 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube10" -p "lower_large_room1";
	rename -uid "53C9D9AF-4782-62B4-881F-CC8C719522A9";
	setAttr ".t" -type "double3" -0.089291295962150713 0 0.0035062238223475899 ;
	setAttr ".r" -type "double3" 0 -89.999999999999986 0 ;
	setAttr ".s" -type "double3" 0.010946824791938458 0.010946824791938458 0.010946824791938458 ;
	setAttr ".rp" -type "double3" 0.0081218216339938674 0.010502613924483184 -0.077657308388728391 ;
	setAttr ".rpt" -type "double3" 0.069535486754735656 0 0.085779130022722833 ;
	setAttr ".sp" -type "double3" 0.74193401176704687 0.95942103067345519 -7.0940487186674765 ;
	setAttr ".spt" -type "double3" -0.73381219013305299 -0.94891841674897193 7.0163914102787475 ;
createNode mesh -n "pCube10Shape" -p "pCube10";
	rename -uid "B0B4976B-49F2-A78E-1F6B-EB80500BF82A";
	setAttr -k off ".v";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:11]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.625 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.48814827
		 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 0.76185167 0.86314827 0.25 0.86314833
		 0 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.625 1 0.375 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 6 ".pt";
	setAttr ".pt[0]" -type "float3" -5.7220458e-08 0 -2.6702881e-07 ;
	setAttr ".pt[1]" -type "float3" 1.9073486e-08 0 -1.9073486e-08 ;
	setAttr ".pt[2]" -type "float3" 1.9073486e-08 0 -2.6702881e-07 ;
	setAttr -s 14 ".vt[0:13]"  0.2283527 0.47484162 -7.643291 0.22835273 0.47484162 -7.6087389
		 0.22835281 1.4440006 -7.643291 0.22835267 1.4440006 -7.6087389 1.29007351 1.4440006 -7.643291
		 1.29007351 1.4440006 -7.6087389 1.29007351 0.47484156 -7.64329147 1.29007351 0.47484156 -7.6087389
		 0.19379464 0.47484156 -6.544806 0.22834678 0.47484156 -6.544806 0.19379471 1.44400036 -6.544806
		 0.22834671 1.44400036 -6.544806 0.19379471 1.44400036 -7.643291 0.19379447 0.47484156 -7.643291;
	setAttr -s 23 ".ed[0:22]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 8 9 0 10 11 0 12 2 0 13 0 0 8 10 0 9 11 0 11 3 0 12 13 0
		 13 8 0 10 12 0 1 9 0;
	setAttr -s 12 -ch 50 ".fc[0:11]" -type "polyFaces" 
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13
		f 4 12 17 -14 -17
		mu 0 4 14 15 16 17
		f 5 -2 -15 -22 13 18
		mu 0 5 18 19 20 17 16
		f 4 14 -5 -16 -20
		mu 0 4 20 19 21 22
		f 5 -21 15 0 22 -13
		mu 0 5 31 22 21 23 30
		f 4 -6 -1 4 1
		mu 0 4 24 25 26 27
		f 4 21 19 20 16
		mu 0 4 17 29 28 14
		f 4 -23 5 -19 -18
		mu 0 4 15 25 24 16;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube7" -p "lower_large_room1";
	rename -uid "185D62CD-4248-2473-A5DF-208FE598FFB5";
	setAttr ".t" -type "double3" -0.057887912251085485 0 0.028308055914854441 ;
	setAttr ".r" -type "double3" 0 -89.999999999999986 0 ;
	setAttr ".s" -type "double3" 0.010946824791938458 0.010946824791938458 0.010946824791938458 ;
	setAttr ".rp" -type "double3" -0.022302239350347603 0.0050000002228529541 -0.051887849193893061 ;
	setAttr ".rpt" -type "double3" 0.074190088544241806 0 0.029585609843545361 ;
	setAttr ".sp" -type "double3" -2.0373249571667196 0.4567534712472141 -4.739990835708384 ;
	setAttr ".spt" -type "double3" 2.0150227178163722 -0.4517534710243612 4.6881029865144903 ;
createNode mesh -n "pCube7Shape" -p "|lower_large_room1|pCube7";
	rename -uid "45F98B29-4A30-9BE0-1A67-BAAFF3FB2FCC";
	setAttr -k off ".v";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:8]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.375 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 29 ".uvst[0].uvsp[0:28]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.75 0.375 1 0.625 1 0.875 0 0.875 0.25 0.125 0 0.125
		 0.25 0.625 0.25 0.375 0.5 0.375 0.75 0.625 1 0.125 0 0.375 0 0.625 0 0.625 0.25 0.375
		 0.25 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[4:10]" -type "float3"  0 -9.536743e-09 0 0 3.8146972e-08 
		0 0 0 0 0 -1.9073486e-08 0 0 -3.8146972e-08 0 0 -7.6293944e-08 0 -2.3841858e-08 0 
		0;
	setAttr -s 14 ".vt[0:13]"  -0.94107664 0.43866539 -4.73999643 -0.94107664 0.43866539 -5.83620501
		 -0.94107664 0.47484154 -4.73999643 -0.94107664 0.47484154 -5.83620501 -2.037311792 0.47484154 -4.73999262
		 -2.037284851 0.47484156 -5.83620501 -2.037311792 0.43866539 -4.73999262 -2.037284851 0.43866539 -5.83620501
		 -3.13357329 0.47484151 -4.73998499 -3.13357329 0.4386653 -4.73998499 -2.03736496 0.43866539 -3.64377666
		 -2.03736496 0.47484154 -3.64377666 -3.13357329 0.47484154 -3.64377666 -3.13357329 0.43866539 -3.64377666;
	setAttr -s 21 ".ed[0:20]"  0 1 0 2 3 0 0 2 0 1 3 0 2 4 0 3 5 0 4 6 0
		 5 7 0 6 0 0 7 1 0 8 9 0 5 8 0 7 9 0 10 6 0 11 4 0 12 8 0 13 9 0 10 11 0 11 12 0 12 13 0
		 13 10 0;
	setAttr -s 9 -ch 42 ".fc[0:8]" -type "polyFaces" 
		f 4 0 3 -2 -3
		mu 0 4 0 1 3 2
		f 4 -10 -8 -6 -4
		mu 0 4 1 8 9 3
		f 4 8 2 4 6
		mu 0 4 10 0 2 11
		f 4 -11 -12 7 12
		mu 0 4 16 13 12 15
		f 4 13 -7 -15 -18
		mu 0 4 17 18 19 20
		f 7 -16 -19 14 -5 1 5 11
		mu 0 7 21 22 20 4 2 3 12
		f 4 15 10 -17 -20
		mu 0 4 22 21 23 24
		f 7 -14 -21 16 -13 9 -1 -9
		mu 0 7 25 26 24 14 5 7 6
		f 4 20 17 18 19
		mu 0 4 27 17 20 28;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "6E4338CA-42BF-2BAD-3B8B-70977B5665C4";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "0190E17A-4D3F-EEA5-0DEC-7896B43520A0";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "1EF05BCC-4418-61B7-FAEF-1BB58F9EBAC6";
createNode displayLayerManager -n "layerManager";
	rename -uid "BCCEA523-41EC-D402-07E4-0886579CBFAC";
createNode displayLayer -n "defaultLayer";
	rename -uid "530A73A7-41D1-9F9F-C2AF-B0AD9854EAA3";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "99BEE121-4256-224A-BA1E-4CBD806179D2";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "C9A88235-4F7D-A6C9-7BB2-73843E1042F7";
	setAttr ".g" yes;
createNode script -n "uiConfigurationScriptNode";
	rename -uid "A6A7C296-48CA-137B-F385-FDADA88CE830";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"wireframe\" \n            -activeOnly 0\n"
		+ "            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 1\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n"
		+ "            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n"
		+ "            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 664\n            -height 349\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 663\n            -height 348\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n"
		+ "            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n"
		+ "            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 664\n            -height 348\n"
		+ "            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n"
		+ "            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n"
		+ "            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n"
		+ "            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1334\n            -height 741\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -docTag \"isolOutln_fromSeln\" \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n"
		+ "            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n"
		+ "            -isSet 0\n            -isSetMember 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n            -expandAttribute 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n"
		+ "\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n"
		+ "            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n"
		+ "                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n"
		+ "                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 1\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n"
		+ "                -showCurveNames 0\n                -showActiveCurveNames 0\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                -valueLinesToggle 1\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n"
		+ "                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n"
		+ "                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n"
		+ "                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n"
		+ "                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n"
		+ "                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n"
		+ "\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -highlightConnections 0\n                -copyConnectionsOnPaste 0\n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n"
		+ "                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -activeTab -1\n                -editorMode \"default\" \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"Stereo\" (localizedPanelLabel(\"Stereo\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Stereo\")) -mbv $menusOkayInPanels  $panelName;\nstring $editorName = ($panelName+\"Editor\");\n            stereoCameraView -e \n                -camera \"persp\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"wireframe\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n"
		+ "                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 1\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 32768\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 4 4 \n                -bumpResolution 4 4 \n"
		+ "                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 0\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -controllers 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n"
		+ "                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 0\n                -height 0\n                -sceneRenderFilter 0\n                -displayMode \"centerEye\" \n                -viewColor 0 0 0 1 \n                -useCustomBackground 1\n                $editorName;\n            stereoCameraView -e -viewSelected 0 $editorName;\n            stereoCameraView -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n"
		+ "                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"vacantCell.xP:/\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1334\\n    -height 741\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1334\\n    -height 741\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "A3454077-4A7F-0893-2C1B-77BE7F49C9B1";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
createNode groupId -n "groupId5";
	rename -uid "141F677F-4A74-F0E7-BB89-88B7CADD2E7D";
	setAttr ".ihi" 0;
createNode groupId -n "groupId6";
	rename -uid "BCF49A34-4992-2C60-2216-95989F8AEA02";
	setAttr ".ihi" 0;
createNode groupId -n "groupId7";
	rename -uid "FF3F2937-447D-FBE9-D116-AD919813E67A";
	setAttr ".ihi" 0;
createNode groupId -n "groupId8";
	rename -uid "5410A523-454A-30C6-E921-A79C5D1929BE";
	setAttr ".ihi" 0;
createNode groupId -n "groupId9";
	rename -uid "699F217E-4D3D-F06D-418A-1881C117BE8B";
	setAttr ".ihi" 0;
createNode groupId -n "groupId10";
	rename -uid "178C1AEF-4218-992A-6B72-D387CAA68A01";
	setAttr ".ihi" 0;
createNode groupId -n "groupId11";
	rename -uid "34618CC6-4622-0DFE-939E-2B88288AAD12";
	setAttr ".ihi" 0;
createNode groupId -n "groupId12";
	rename -uid "65B4CFD0-4AD9-867F-4F29-3288D4353159";
	setAttr ".ihi" 0;
createNode groupId -n "groupId13";
	rename -uid "1C428ED7-4DA8-D745-35AE-1EAF87E4FF55";
	setAttr ".ihi" 0;
createNode groupId -n "groupId14";
	rename -uid "A513D8CD-4258-B1A2-34C1-C08A194FE43B";
	setAttr ".ihi" 0;
createNode groupId -n "groupId15";
	rename -uid "08833043-4F94-5B07-C13E-C29D7BB2492D";
	setAttr ".ihi" 0;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 28 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 10 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "groupId5.id" "|left_door|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[0].cgid"
		;
connectAttr "groupId6.id" "|right_door|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[1].cgid"
		;
connectAttr "groupId7.id" "|both_door|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[2].cgid"
		;
connectAttr "groupId8.id" "|both_door|group1|left_foor_pCube4|left_foor_pCube4Shape.ciog.cog[3].cgid"
		;
connectAttr "groupId9.id" "|upper_large_room|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[3].cgid"
		;
connectAttr "groupId10.id" "|upper_large_room|group1|left_foor_pCube4|left_foor_pCube4Shape.ciog.cog[4].cgid"
		;
connectAttr "groupId11.id" "|upper_large_room|pCube7|pCube7Shape.iog.og[0].gid";
connectAttr ":initialShadingGroup.mwc" "|upper_large_room|pCube7|pCube7Shape.iog.og[0].gco"
		;
connectAttr "groupId12.id" "|lower_large_room1|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[3].cgid"
		;
connectAttr "groupId13.id" "|lower_large_room1|group1|left_foor_pCube4|left_foor_pCube4Shape.ciog.cog[4].cgid"
		;
connectAttr "groupId15.id" "pCube10Shape.iog.og[0].gid";
connectAttr ":initialShadingGroup.mwc" "pCube10Shape.iog.og[0].gco";
connectAttr "groupId14.id" "|lower_large_room1|pCube7|pCube7Shape.iog.og[0].gid"
		;
connectAttr ":initialShadingGroup.mwc" "|lower_large_room1|pCube7|pCube7Shape.iog.og[0].gco"
		;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "|no_door|pCube2|pCubeShape2.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape3.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|no_door|pCube1|pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|left_door|pCube2|pCubeShape2.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|left_door|pCube1|pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|left_door|left_foor_pCube3|left_foor_pCube3Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|left_door|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[0]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|right_door|group1|left_foor_pCube3|left_foor_pCube3Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|right_door|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[1]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|right_door|group1|pCube2|pCubeShape2.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|right_door|pCube1|pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|both_door|pCube1|pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|both_door|group1|left_foor_pCube3|left_foor_pCube3Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|both_door|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[2]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|both_door|group1|left_foor_pCube4|left_foor_pCube4Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|both_door|group1|left_foor_pCube4|left_foor_pCube4Shape.ciog.cog[3]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|upper_large_room|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[3]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|upper_large_room|group1|left_foor_pCube3|left_foor_pCube3Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|upper_large_room|group1|left_foor_pCube4|left_foor_pCube4Shape.ciog.cog[4]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|upper_large_room|group1|left_foor_pCube4|left_foor_pCube4Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "pCubeShape6.iog" ":initialShadingGroup.dsm" -na;
connectAttr "|upper_large_room|pCube7|pCube7Shape.iog.og[0]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|lower_large_room1|group1|left_foor_pCube3|left_foor_pCube3Shape.ciog.cog[3]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|lower_large_room1|group1|left_foor_pCube3|left_foor_pCube3Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|lower_large_room1|group1|left_foor_pCube4|left_foor_pCube4Shape.ciog.cog[4]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|lower_large_room1|group1|left_foor_pCube4|left_foor_pCube4Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|lower_large_room1|pCube7|pCube7Shape.iog.og[0]" ":initialShadingGroup.dsm"
		 -na;
connectAttr "pCube10Shape.iog.og[0]" ":initialShadingGroup.dsm" -na;
connectAttr "groupId6.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId7.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId8.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId9.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId10.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId11.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId12.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId13.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId14.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId15.msg" ":initialShadingGroup.gn" -na;
// End of Prototype 3 structure.ma
