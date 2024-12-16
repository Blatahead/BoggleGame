# BoggleGame

### L'ex�cutable se trouve dans `Projet\BoggleGameWinForm\bin\Debug\net8.0-windows`

## Description
Ce projet est une version du jeu de mots "Boggle" en C#. 
Les joueurs d�couvrent des mots en formant des cha�nes de lettres adjacentes sur un plateau de d�s. 
Chaque joueur a un temps limit� pour trouver un maximum de mots valides en utilisant un dictionnaire de r�f�rence.

## Fonctionnalit�s principales
1. **G�n�ration de plateau** : Un plateau carr� (4x4 par d�faut) avec des d�s � six faces contenant des lettres.
2. **Tour de jeu** : Les joueurs jouent chacun � tour de r�le, trouvant des mots � partir des lettres visibles sur le plateau.
3. **Calcul des scores** : Les mots trouv�s attribuent des points en fonction de leur longueur et de la raret� des lettres.
4. **Nuage de mots** : Un nuage de mots est g�n�r� pour chaque joueur en fin de partie, illustrant leurs mots.

## Installation

1. Cloner le projet :
    ```bash
    git clone <url-du-depot>
    cd <nom-du-dossier>
    ```

2. Ouvrir le projet dans Visual Studio.

3. Compiler et ex�cuter le projet pour commencer le jeu.

## Pr�requis

- .NET 5.0 ou sup�rieur
- Visual Studio (ou autre environnement compatible C#)
- Fichiers n�cessaires : `Lettres.txt` (configuration des lettres et pond�rations), `MOTS_FRANCAIS.txt` ou `MOTS_ENGLISH.txt` (dictionnaires de mots).

## Instructions de jeu

1. **Mise en place** :
   - Choisissez la langue (fran�ais ou anglais) et la taille du plateau.
   - Entrez les pseudonymes des joueurs.

2. **D�roulement** :
   - Chaque joueur a un temps limit� pour trouver des mots dans le plateau.
   - Les mots doivent �tre d�au moins deux lettres et ne pas utiliser le m�me d� plus d'une fois.
   - � la fin de chaque tour, les scores sont mis � jour si les mots sont valides et pr�sents dans le dictionnaire.

3. **Fin de partie** :
   - Le jeu se termine une fois le temps imparti �coul�. Les scores sont affich�s, et un nuage de mots est g�n�r� pour chaque joueur.

## Diagramme UML
Un diagramme de classes UML est fourni dans le projet pour illustrer la relation entre les classes et les principales m�thodes.

## Bonus
Le projet inclut un appel d'IA, qui, en mode "Joueur IA", explore toutes les combinaisons de lettres pour maximiser les points. 
Elle utilise une optimisation de recherche pour ignorer rapidement les combinaisons impossibles.

## Contributeurs
Projet r�alis� en bin�me par `Mathieu` et `Antonin`.