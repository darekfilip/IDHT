module IDHT {
	struct range {
		string node;
		int min;
		int max;
	};

	interface DHTNode {
		// ktos o id connectiongId sie podlacza pod wybrany node majac juz swoj zakres 
		// np A -> B -> C. 
		// B znika i C podlacza sie do A z zakresem swoim
		struct range connected(string id, struct range);

		// podlacza i dostaje swoj klucz
		struct range connected(string id);

		// wezel znika i zglasza to do swojego rodzica
		void disconnected(string id);

		// wezel zglasza do swoich potomkow
		// i kaze im sie polaczyc do swojego mastera
		void disconnected(string id, string connectTo);

		// przeszukuje - sprawdza u siebie i ewentualnie sasiadow
		string seatchDHT(int key);

		// wklada badz przekazuje sprawe do swoich sasiadow
		void insertDHT(int key, int val);

		// dodaje pare klucz->wartosc do drzewa
		int insertDHT(string val);
	};

	interface DHTMaster {
		struct range getUniqId(); 
	};
};
