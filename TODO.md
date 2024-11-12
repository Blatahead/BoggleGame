﻿#TODO List
- [ ] Cahier des charges (graphique UML)

- [ ] INTERFACE GRAPHIQUE

- [ ] MENU DE CONFIGURATIONS
	- [ ] Afficher si Dictionnaire.txt trié ou pas
	- [ ] Langue
		- [ ] Français (Défaut)
		- [ ] Set anglais si choisi
	- [ ] Taille de plateau
		- [ ] 4x4 (Défaut)
		- [ ] Set nouvelle valeur
	- [ ] Pseudo des joueurs (2 min)
	- [ ] Temps de partie totale par joueur
		- [ ] 3 minutes (défaut)
		- [ ] Set nouvelle valeur
	- [ ] Temps de plateau par joueur
		- [ ] 1 minute (défaut)
		- [ ] Set nouvelle valeur (Conseiller et/ou vérfier que ce soit un diviseur cohérent avec le temps de partie)
	- [ ] (Supplément) Activer ou désactiver les couronnes de points (lettre sur l'extérieur vaut plus)

- [ ] PLATEAU
	- [ ] Créer le plateau **(A chaque changement de joueur (tour))**

- [ ] DE
	- [ ] Créer un Dé *Constructeur*
		- [ ] Créer une face
		- [ ] Ajouter une lettre sur cette face **(différente des lettres précédentes)** avec new Random()
		- [ ] Multiplier cette face par 6 **(Sans avoir une lettre 2 fois sur le même dé)***
		- [ ] Connaître les coordonnées de la face
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

- [ ] CALCUL DES POINTS
	- [ ] juste après que le joueur est rentré un mot (valider par ESPACE ou ENTRER)
		- [ ] Mot bon : 
			- [ ] longueur de mot
			- [ ] poids des lettres (edit le fichier pour ça)
			- [ ] stocker le mot dans un dictionnaire
			- [ ] Compteur de mots bons
		- [ ] Mot mauvais :
			- [ ] stocker le mot dans un dictionnaire
			- [ ] Compteur de mots mauvais
- [ ] DEROULE DE PARTIE
	- [ ] Menu de configurations
	- [ ] Règles expliquées rapidement (demander à ne plus afficher si on a le temps)
	- [ ] Lancement Compte à rebours **Partie** (StopWaztch depuis System.Diagnostics)
	- [ ] Tour de joueur (à répéter)
	- [ ] Vérification des mots (à chaque mot entré)
		- [ ] Faisable avec les lettres du plateau
		- [ ] Dans le dictionnaire
			- [ ] Algo de tri (3 solutions)
			- [ ] Algo de recherche
		- [ ] Longueur >= 2
		- [ ] Si mot répété lors d'un même tour : compter que 1 occurence
	- [ ] Fin du compte à rebours de jeu
	- [ ] Affichage des nuages de mots