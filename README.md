# BoggleGame

### L'exécutable se trouve dans `Projet\BoggleGameWinForm\bin\Debug\net8.0-windows`

## Description
Ce projet est une version du jeu de mots "Boggle" en C#. 
Les joueurs découvrent des mots en formant des chaînes de lettres adjacentes sur un plateau de dés. 
Chaque joueur a un temps limité pour trouver un maximum de mots valides en utilisant un dictionnaire de référence.

## Fonctionnalités principales
1. **Génération de plateau** : Un plateau carré (4x4 par défaut) avec des dés à six faces contenant des lettres.
2. **Tour de jeu** : Les joueurs jouent chacun à tour de rôle, trouvant des mots à partir des lettres visibles sur le plateau.
3. **Calcul des scores** : Les mots trouvés attribuent des points en fonction de leur longueur et de la rareté des lettres.
4. **Nuage de mots** : Un nuage de mots est généré pour chaque joueur en fin de partie, illustrant leurs mots.

## Installation

1. Cloner le projet :
    ```bash
    git clone <url-du-depot>
    cd <nom-du-dossier>
    ```

2. Ouvrir le projet dans Visual Studio.

3. Compiler et exécuter le projet pour commencer le jeu.

## Prérequis

- .NET 5.0 ou supérieur
- Visual Studio (ou autre environnement compatible C#)
- Fichiers nécessaires : `Lettres.txt` (configuration des lettres et pondérations), `MOTS_FRANCAIS.txt` ou `MOTS_ENGLISH.txt` (dictionnaires de mots).

## Instructions de jeu

1. **Mise en place** :
   - Choisissez la langue (français ou anglais) et la taille du plateau.
   - Entrez les pseudonymes des joueurs.

2. **Déroulement** :
   - Chaque joueur a un temps limité pour trouver des mots dans le plateau.
   - Les mots doivent être d’au moins deux lettres et ne pas utiliser le même dé plus d'une fois.
   - À la fin de chaque tour, les scores sont mis à jour si les mots sont valides et présents dans le dictionnaire.

3. **Fin de partie** :
   - Le jeu se termine une fois le temps imparti écoulé. Les scores sont affichés, et un nuage de mots est généré pour chaque joueur.

## Diagramme UML
Un diagramme de classes UML est fourni dans le projet pour illustrer la relation entre les classes et les principales méthodes.

## Bonus
Le projet inclut un appel d'IA, qui, en mode "Joueur IA", explore toutes les combinaisons de lettres pour maximiser les points. 
Elle utilise une optimisation de recherche pour ignorer rapidement les combinaisons impossibles.

## Contributeurs
Projet réalisé en binôme par `Mathieu` et `Antonin`.