#TODO List

- [ ] MENU DE CONFIGURATIONS
	- [ ] Langue
		- [ ] Français (Défaut)
		- [ ] Set anglais si choisi
	- [ ] Taille de plateau
		- [ ] 4x4 (Défaut)
		- [ ] Set nouvelle valeur
	- [ ] Temps de partie totale par joueur 
		- [ ] 3 minutes (défaut)
		- [ ] Set nouvelle valeur
	- [ ] Temps de plateau par joueur
		- [ ] 1 minute (défaut)
		- [ ] Set nouvelle valeur (Conseiller et/ou vérfier que ce soit un diviseur cohérent avec le temps de partie)

- [ ] PLATEAU
	- [ ] Créer le plateau **(A chaque changement de joueur (tour))**

- [ ] DE
	- [ ] Créer un Dé *Constructeur*
		- [ ] Créer une face
		- [ ] Ajouter une lettre sur cette face **(différente des lettres précédentes)**
		- [ ] Multiplier cette face par 6 **(Sans avoir une lettre 2 fois sur le même dé)**
	- [ ] Lancer un Dé *Méthode*
		- [ ] Tirage aléatoire d'une face parmi les 6
		- [ ] Répéter pour tous les Dés
	- [ ] Compte à rebours de 6 minutes (3 min de jeu / joueur) *Méthode*
	- [ ] Stopper le jeu à la fin du compte à rebours (ne pas inclure dans ) *Méthode*

- [ ] JOUEUR
	- [ ] Tour de joueur *Méthode*
		- [ ] Lancement compte à rebours **Joueur**
		- [ ] Saisie et stockage des mots dans l'attribut Mots
		- [ ] Changement de joueur
	- [ ] Attributs
		- [ ] Mots string[][] : sous tableaux par tour (simplification pour vérifier les mots)

- [ ] DEROULE DE PARTIE
	- [ ] Menu de configurations
	- [ ] Règles expliquées rapidement (demander à ne plus afficher si on a le temps)
	- [ ] Lancement Compte à rebours **Partie**
	- [ ] Tour de joueur (à répéter)
	- [ ] Fin de compte à rebours
	- [ ] Vérification des mots
		- [ ] Dans le dictionnaire
		- [ ] Longueur >= 2
		- [ ] Si mot répété lors d'un même tour : compter que 1 occurence