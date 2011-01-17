module IDHT {
	struct range {
		int min;
		int max;
	};
	
	struct keyvaluepair {
		string key;
		string value;
	};

	sequence<keyvaluepair> values;

	sequence<range> ranges;
	
	struct nodeConf {
		string nodeId;
		string parentNode;
		int min;
		int max;
		values elems;
	};
	
	sequence<nodeConf> confs;

	interface DHTNode {
		// ktos o id connectiongId sie podlacza pod wybrany node majac juz swoj zakres 
		// np A -> B -> C. 
		// B znika i C podlacza sie do A z zakresem swoim
//		string connected(string id, range currentRange);

		// podlacza i dostaje swoj klucz
		nodeConf newConnected(string id);

		// wezel znika i zglasza to do swojego rodzica
		void slaveDisconnected(string id);

		// wezel zglasza do swoich potomkow
		// i kaze im sie polaczyc do swojego mastera
		void masterDisconnected(string id, string connectTo, ranges newRanges, confs childRanges);

		// przeszukuje - sprawdza u siebie i ewentualnie sasiadow
		string seatchDHT(string key);

		// wklada badz przekazuje sprawe do swoich sasiadow
		void insertDHT(string key, string val);
	};
};
